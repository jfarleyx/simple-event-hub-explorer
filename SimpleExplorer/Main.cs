using System;
using System.Configuration;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.EventHubs;
using Microsoft.Azure.EventHubs.Processor;

namespace SimpleExplorer
{
    public partial class Main : Form
    {
        #region Fields
        private bool _senderEnabled = false;
        private bool _readerEnabled = false;
        private string _eventHubConnString;
        private string _eventHubEntityPath;
        private string _storageContainerName;
        private string _storageAccountName;
        private string _storageAccountKey;
        #endregion

        #region Properties
        private EventProcessorHost ProcessorHost { get; set; }
        private EventProcessorOptions ProcessorOptions { get; set; }
        private ProcessorTraceListener EventHubTrace { get; set; }
        private EventHubClient EventHub { get; set; }
        private bool SenderEnabled
        {
            get { return _senderEnabled; }
            set
            {
                _senderEnabled = value;
                OnPropertyChanged("SenderEnabled");
            }
        }
        private bool ReaderEnabled
        {
            get { return _readerEnabled; }
            set
            {
                _readerEnabled = value;
                OnPropertyChanged("ReaderEnabled");
            }
        }
        private string EventHubConnectionString
        {
            get { return _eventHubConnString; }
            set { _eventHubConnString = value.Trim(); }
        }
        private string EventHubEntityPath
        {
            get { return _eventHubEntityPath; }
            set { _eventHubEntityPath = value.Trim(); }
        }
        private string StorageContainerName
        {
            get { return _storageContainerName;  }
            set { _storageContainerName = value.Trim();  }
        }
        private string StorageAccountName
        {
            get { return _storageAccountName;  }
            set { _storageAccountName = value.Trim(); }
        }
        private string StorageAccountKey
        {
            get { return _storageAccountKey;  }   
            set { _storageAccountKey = value.Trim();  }
        }
        private string StorageConnectionString => $"DefaultEndpointsProtocol=https;AccountName={StorageAccountName};AccountKey={StorageAccountKey}";
        #endregion

        #region Constructors
        public Main()
        {
            InitializeComponent();

            //set default button states 
            ReaderEnabled = false;
            SenderEnabled = false;
            btnConnect.Enabled = false;

            //enable trace listener for showing event hub mesages in textbox
            EventHubTrace = new ProcessorTraceListener(tbEhOutput);
            Trace.Listeners.Add(EventHubTrace);

            //if user has added azure settings to app.config, read them and place in form
            LoadConfigSettings();
        }
        #endregion

        #region Events
        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                // disable button to prevent multiple connection attempts until first request finishes. 
                btnConnect.Enabled = false;

                try
                {
                    if (SenderEnabled)
                    {
                        OutputStatus("Create sender...");
                        CreateEventHubSender();
                        OutputStatus("Sender created.");
                    }

                    if (ReaderEnabled)
                    {
                        OutputStatus("Create reader...");
                        CreateProcessorHostConnection();
                        await ReadHub();
                        btnRead.Enabled = false;
                        OutputStatus("Reader created and now reading messages.");
                    }
                }
                catch (Exception ex)
                {
                    OutputStatus($"ERROR! {ex.Message}");
                    SenderEnabled = false;
                    ReaderEnabled = false;
                }
            }
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            await ReadHub();
        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                btnStop.Enabled = false;
                OutputStatus("Event Hub reader stopping...");
                await ProcessorHost.UnregisterEventProcessorAsync();
            }
            catch (Exception ex)
            {
                OutputStatus($"ERROR! {ex.Message}");
            }
            finally
            {
                btnStop.Enabled = false;
                btnRead.Enabled = true;
            }
        }

        private async void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                btnDisconnect.Enabled = false;
                OutputStatus("Disconnecting...");

                if (ReaderEnabled)
                {
                    await ProcessorHost.UnregisterEventProcessorAsync();
                    ReaderEnabled = false;
                }

                if (SenderEnabled)
                {
                    await EventHub.CloseAsync();
                    SenderEnabled = false;
                }

                OutputStatus("Disconnected.");
            }
            catch (Exception ex)
            {
                OutputStatus($"ERROR! {ex.Message}");
            }
            finally
            {
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbEhInput.Clear();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            OutputStatus("Sending message...");
            try
            {
                await EventHub.SendAsync(new EventData(Encoding.UTF8.GetBytes(tbEhInput.Text.Trim())));
                OutputStatus("Message sent.");
            }
            catch (Exception ex)
            {
                OutputStatus($"ERROR! {ex.Message}");
            }
            finally
            {
                btnSend.Enabled = true;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ReaderEnabled)
            {
                try
                {
                    Task.Run(() => ProcessorHost.UnregisterEventProcessorAsync());
                }
                catch
                {
                    // suppress error and close app
                }
            }

            if (SenderEnabled)
            {
                try
                {
                    Task.Run(() => EventHub.CloseAsync());
                }
                catch 
                {
                    // suppress error and close app
                }
            }

            try
            {
                Trace.Listeners.Remove(EventHubTrace);
            }
            catch
            {
                // suppress error and close app
            }
        }

        private void btnClearRead_Click(object sender, EventArgs e)
        {
            tbEhOutput.Clear();
        }
        #endregion

        #region Methods
        private void OnPropertyChanged(string name)
        {
            if (name == "SenderEnabled")
            {
                if (SenderEnabled)
                {
                    btnSend.Enabled = true;
                    btnClear.Enabled = true;
                }
                else
                {
                    btnSend.Enabled = false;
                }
            }
            else if (name == "ReaderEnabled")
            {
                if (ReaderEnabled)
                {
                    btnRead.Enabled = true;
                    btnStop.Enabled = true;
                }
                else
                {
                    btnRead.Enabled = false;
                    btnStop.Enabled = false;
                }
            }
        }

        private bool IsValidInput()
        {
            EventHubConnectionString = tbEventHubConnectionString.Text;
            EventHubEntityPath = tbEventHubEntityPath.Text;
            StorageContainerName = tbStorageContainerName.Text;
            StorageAccountName = tbStorageAccountName.Text;
            StorageAccountKey = tbStorageAccountKey.Text;

            if (string.IsNullOrWhiteSpace(EventHubConnectionString))
            {
                OutputStatus("Please provide Event Hub Connection String!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(EventHubEntityPath))
            {
                OutputStatus("Please provide Event Hub Entity Path!");
                return false;
            }
            SenderEnabled = true;

            // storage account settings are required only if user wants to read from a hub. 
            // if any storage settings were provided, make sure all storage settings were provided. 
            if (string.IsNullOrWhiteSpace(StorageContainerName) == false ||
                string.IsNullOrWhiteSpace(StorageAccountName) == false ||
                string.IsNullOrWhiteSpace(StorageAccountKey) == false)
            {
                if (string.IsNullOrWhiteSpace(StorageContainerName))
                {
                    OutputStatus("Please provide Storage Container Name!");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(StorageAccountName))
                {
                    OutputStatus("Please provide Storage Account Name!");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(StorageAccountKey))
                {
                    OutputStatus("Please provide Storage Account Key!");
                    return false;
                }
                ReaderEnabled = true;
            }
            else
            {
                OutputStatus("No storage account settings provided. Send Message enabled. Read Message disabled.");
                ReaderEnabled = false;
            }

            return true;
        }

        private void CreateProcessorHostConnection()
        {
            ProcessorHost = new EventProcessorHost(
                EventHubEntityPath,
                PartitionReceiver.DefaultConsumerGroupName,
                EventHubConnectionString,
                StorageConnectionString,
                StorageContainerName
            );

            ProcessorOptions = new EventProcessorOptions();
            ProcessorOptions.SetExceptionHandler(LogProcessorErrors);
        }

        private void CreateEventHubSender()
        {
            var connStringBuilder = new EventHubsConnectionStringBuilder(EventHubConnectionString)
            {
                EntityPath = EventHubEntityPath
            };
            EventHub = EventHubClient.CreateFromConnectionString(connStringBuilder.ToString());
        }

        private static void LogProcessorErrors(ExceptionReceivedEventArgs obj)
        {
            Trace.TraceError(obj.Exception.Message);
        }

        private void OutputStatus(string message)
        {
            tbAppStatus.AppendText(message + Environment.NewLine);
        }

        private async Task ReadHub()
        {
            try
            {
                btnRead.Enabled = false;
                await ProcessorHost.RegisterEventProcessorAsync<Processor>(ProcessorOptions);
                OutputStatus("Reading event hub data.");
                btnStop.Enabled = true;
            }
            catch (Exception ex)
            {
                OutputStatus($"ERROR! {ex.Message}");
                btnRead.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        private void LoadConfigSettings()
        {
            EventHubConnectionString = ConfigurationManager.AppSettings["EventHubConnectionString"];
            EventHubEntityPath = ConfigurationManager.AppSettings["EventHubEntityPath"];
            StorageAccountName = ConfigurationManager.AppSettings["StorageAccountName"];
            StorageContainerName = ConfigurationManager.AppSettings["StorageContainerName"];
            StorageAccountKey = ConfigurationManager.AppSettings["StorageAccountKey"];

            tbEventHubConnectionString.Text = EventHubConnectionString;
            tbEventHubEntityPath.Text = EventHubEntityPath;
            tbStorageAccountName.Text = StorageAccountName;
            tbStorageContainerName.Text = StorageContainerName;
            tbStorageAccountKey.Text = StorageAccountKey;

            btnConnect.Enabled = true;
        }
        #endregion
    }
}
