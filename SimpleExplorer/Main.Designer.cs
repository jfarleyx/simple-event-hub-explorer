namespace SimpleExplorer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbEhOutput = new System.Windows.Forms.TextBox();
            this.gbConnSettings = new System.Windows.Forms.GroupBox();
            this.lblExplain = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbStorageAccountKey = new System.Windows.Forms.TextBox();
            this.lblStorageAcctKey = new System.Windows.Forms.Label();
            this.tbStorageAccountName = new System.Windows.Forms.TextBox();
            this.lblStorageAcctName = new System.Windows.Forms.Label();
            this.tbStorageContainerName = new System.Windows.Forms.TextBox();
            this.lblStorageContainerName = new System.Windows.Forms.Label();
            this.tbEventHubEntityPath = new System.Windows.Forms.TextBox();
            this.lblEhEntityPath = new System.Windows.Forms.Label();
            this.tbEventHubConnectionString = new System.Windows.Forms.TextBox();
            this.lblEhConnString = new System.Windows.Forms.Label();
            this.tbAppStatus = new System.Windows.Forms.TextBox();
            this.gbSendMsg = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbEhInput = new System.Windows.Forms.TextBox();
            this.gbReadMsg = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClearRead = new System.Windows.Forms.Button();
            this.gbConnSettings.SuspendLayout();
            this.gbSendMsg.SuspendLayout();
            this.gbReadMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEhOutput
            // 
            this.tbEhOutput.Location = new System.Drawing.Point(6, 28);
            this.tbEhOutput.Multiline = true;
            this.tbEhOutput.Name = "tbEhOutput";
            this.tbEhOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEhOutput.Size = new System.Drawing.Size(687, 247);
            this.tbEhOutput.TabIndex = 10;
            // 
            // gbConnSettings
            // 
            this.gbConnSettings.Controls.Add(this.lblExplain);
            this.gbConnSettings.Controls.Add(this.label6);
            this.gbConnSettings.Controls.Add(this.btnDisconnect);
            this.gbConnSettings.Controls.Add(this.btnConnect);
            this.gbConnSettings.Controls.Add(this.tbStorageAccountKey);
            this.gbConnSettings.Controls.Add(this.lblStorageAcctKey);
            this.gbConnSettings.Controls.Add(this.tbStorageAccountName);
            this.gbConnSettings.Controls.Add(this.lblStorageAcctName);
            this.gbConnSettings.Controls.Add(this.tbStorageContainerName);
            this.gbConnSettings.Controls.Add(this.lblStorageContainerName);
            this.gbConnSettings.Controls.Add(this.tbEventHubEntityPath);
            this.gbConnSettings.Controls.Add(this.lblEhEntityPath);
            this.gbConnSettings.Controls.Add(this.tbEventHubConnectionString);
            this.gbConnSettings.Controls.Add(this.lblEhConnString);
            this.gbConnSettings.Location = new System.Drawing.Point(13, 13);
            this.gbConnSettings.Name = "gbConnSettings";
            this.gbConnSettings.Size = new System.Drawing.Size(315, 547);
            this.gbConnSettings.TabIndex = 1;
            this.gbConnSettings.TabStop = false;
            this.gbConnSettings.Text = "Connection Settings";
            // 
            // lblExplain
            // 
            this.lblExplain.Location = new System.Drawing.Point(10, 226);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(299, 45);
            this.lblExplain.TabIndex = 10;
            this.lblExplain.Text = "An Azure Storage Account is required to read data from an Azure Event Hub.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 9;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(83, 502);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(110, 33);
            this.btnDisconnect.TabIndex = 7;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(199, 502);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(110, 33);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbStorageAccountKey
            // 
            this.tbStorageAccountKey.Location = new System.Drawing.Point(10, 426);
            this.tbStorageAccountKey.Multiline = true;
            this.tbStorageAccountKey.Name = "tbStorageAccountKey";
            this.tbStorageAccountKey.Size = new System.Drawing.Size(299, 69);
            this.tbStorageAccountKey.TabIndex = 5;
            // 
            // lblStorageAcctKey
            // 
            this.lblStorageAcctKey.AutoSize = true;
            this.lblStorageAcctKey.Location = new System.Drawing.Point(7, 403);
            this.lblStorageAcctKey.Name = "lblStorageAcctKey";
            this.lblStorageAcctKey.Size = new System.Drawing.Size(159, 20);
            this.lblStorageAcctKey.TabIndex = 8;
            this.lblStorageAcctKey.Text = "Storage Account Key";
            // 
            // tbStorageAccountName
            // 
            this.tbStorageAccountName.Location = new System.Drawing.Point(10, 297);
            this.tbStorageAccountName.Name = "tbStorageAccountName";
            this.tbStorageAccountName.Size = new System.Drawing.Size(299, 26);
            this.tbStorageAccountName.TabIndex = 4;
            // 
            // lblStorageAcctName
            // 
            this.lblStorageAcctName.AutoSize = true;
            this.lblStorageAcctName.Location = new System.Drawing.Point(7, 276);
            this.lblStorageAcctName.Name = "lblStorageAcctName";
            this.lblStorageAcctName.Size = new System.Drawing.Size(179, 20);
            this.lblStorageAcctName.TabIndex = 6;
            this.lblStorageAcctName.Text = "Storage Account Name ";
            // 
            // tbStorageContainerName
            // 
            this.tbStorageContainerName.Location = new System.Drawing.Point(10, 358);
            this.tbStorageContainerName.Name = "tbStorageContainerName";
            this.tbStorageContainerName.Size = new System.Drawing.Size(299, 26);
            this.tbStorageContainerName.TabIndex = 3;
            // 
            // lblStorageContainerName
            // 
            this.lblStorageContainerName.AutoSize = true;
            this.lblStorageContainerName.Location = new System.Drawing.Point(7, 337);
            this.lblStorageContainerName.Name = "lblStorageContainerName";
            this.lblStorageContainerName.Size = new System.Drawing.Size(185, 20);
            this.lblStorageContainerName.TabIndex = 4;
            this.lblStorageContainerName.Text = "Storage Container Name";
            // 
            // tbEventHubEntityPath
            // 
            this.tbEventHubEntityPath.Location = new System.Drawing.Point(10, 175);
            this.tbEventHubEntityPath.Name = "tbEventHubEntityPath";
            this.tbEventHubEntityPath.Size = new System.Drawing.Size(299, 26);
            this.tbEventHubEntityPath.TabIndex = 2;
            // 
            // lblEhEntityPath
            // 
            this.lblEhEntityPath.AutoSize = true;
            this.lblEhEntityPath.Location = new System.Drawing.Point(7, 152);
            this.lblEhEntityPath.Name = "lblEhEntityPath";
            this.lblEhEntityPath.Size = new System.Drawing.Size(165, 20);
            this.lblEhEntityPath.TabIndex = 2;
            this.lblEhEntityPath.Text = "Event Hub Entity Path";
            // 
            // tbEventHubConnectionString
            // 
            this.tbEventHubConnectionString.Location = new System.Drawing.Point(10, 51);
            this.tbEventHubConnectionString.Multiline = true;
            this.tbEventHubConnectionString.Name = "tbEventHubConnectionString";
            this.tbEventHubConnectionString.Size = new System.Drawing.Size(299, 95);
            this.tbEventHubConnectionString.TabIndex = 1;
            // 
            // lblEhConnString
            // 
            this.lblEhConnString.AutoSize = true;
            this.lblEhConnString.Location = new System.Drawing.Point(7, 28);
            this.lblEhConnString.Name = "lblEhConnString";
            this.lblEhConnString.Size = new System.Drawing.Size(215, 20);
            this.lblEhConnString.TabIndex = 0;
            this.lblEhConnString.Text = "Event Hub Connection String";
            // 
            // tbAppStatus
            // 
            this.tbAppStatus.Location = new System.Drawing.Point(12, 581);
            this.tbAppStatus.Multiline = true;
            this.tbAppStatus.Name = "tbAppStatus";
            this.tbAppStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAppStatus.Size = new System.Drawing.Size(1022, 100);
            this.tbAppStatus.TabIndex = 11;
            // 
            // gbSendMsg
            // 
            this.gbSendMsg.Controls.Add(this.btnClear);
            this.gbSendMsg.Controls.Add(this.btnSend);
            this.gbSendMsg.Controls.Add(this.tbEhInput);
            this.gbSendMsg.Location = new System.Drawing.Point(335, 13);
            this.gbSendMsg.Name = "gbSendMsg";
            this.gbSendMsg.Size = new System.Drawing.Size(699, 211);
            this.gbSendMsg.TabIndex = 3;
            this.gbSendMsg.TabStop = false;
            this.gbSendMsg.Text = "Send Message";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(537, 163);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(618, 163);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 33);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbEhInput
            // 
            this.tbEhInput.Location = new System.Drawing.Point(7, 24);
            this.tbEhInput.Multiline = true;
            this.tbEhInput.Name = "tbEhInput";
            this.tbEhInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEhInput.Size = new System.Drawing.Size(686, 131);
            this.tbEhInput.TabIndex = 8;
            // 
            // gbReadMsg
            // 
            this.gbReadMsg.Controls.Add(this.btnClearRead);
            this.gbReadMsg.Controls.Add(this.btnStop);
            this.gbReadMsg.Controls.Add(this.btnRead);
            this.gbReadMsg.Controls.Add(this.tbEhOutput);
            this.gbReadMsg.Location = new System.Drawing.Point(335, 230);
            this.gbReadMsg.Name = "gbReadMsg";
            this.gbReadMsg.Size = new System.Drawing.Size(699, 330);
            this.gbReadMsg.TabIndex = 4;
            this.gbReadMsg.TabStop = false;
            this.gbReadMsg.Text = "Read Messages";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(537, 285);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 31);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRead
            // 
            this.btnRead.Enabled = false;
            this.btnRead.Location = new System.Drawing.Point(618, 285);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 31);
            this.btnRead.TabIndex = 11;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnClearRead
            // 
            this.btnClearRead.Location = new System.Drawing.Point(456, 285);
            this.btnClearRead.Name = "btnClearRead";
            this.btnClearRead.Size = new System.Drawing.Size(75, 31);
            this.btnClearRead.TabIndex = 13;
            this.btnClearRead.Text = "Clear";
            this.btnClearRead.UseVisualStyleBackColor = true;
            this.btnClearRead.Click += new System.EventHandler(this.btnClearRead_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(1046, 693);
            this.Controls.Add(this.gbReadMsg);
            this.Controls.Add(this.gbSendMsg);
            this.Controls.Add(this.gbConnSettings);
            this.Controls.Add(this.tbAppStatus);
            this.Name = "Main";
            this.Text = "Simple Explorer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.gbConnSettings.ResumeLayout(false);
            this.gbConnSettings.PerformLayout();
            this.gbSendMsg.ResumeLayout(false);
            this.gbSendMsg.PerformLayout();
            this.gbReadMsg.ResumeLayout(false);
            this.gbReadMsg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEhOutput;
        private System.Windows.Forms.GroupBox gbConnSettings;
        private System.Windows.Forms.Label lblStorageContainerName;
        private System.Windows.Forms.TextBox tbEventHubEntityPath;
        private System.Windows.Forms.Label lblEhEntityPath;
        private System.Windows.Forms.TextBox tbEventHubConnectionString;
        private System.Windows.Forms.Label lblEhConnString;
        private System.Windows.Forms.TextBox tbAppStatus;
        private System.Windows.Forms.GroupBox gbSendMsg;
        private System.Windows.Forms.GroupBox gbReadMsg;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbStorageAccountKey;
        private System.Windows.Forms.Label lblStorageAcctKey;
        private System.Windows.Forms.TextBox tbStorageAccountName;
        private System.Windows.Forms.Label lblStorageAcctName;
        private System.Windows.Forms.TextBox tbStorageContainerName;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbEhInput;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.Button btnClearRead;
    }
}

