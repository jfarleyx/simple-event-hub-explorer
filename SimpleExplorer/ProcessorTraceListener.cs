using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SimpleExplorer
{
    public sealed class ProcessorTraceListener: TraceListener
    {
        private readonly TextBoxBase output;

        public ProcessorTraceListener(TextBoxBase output)
        {
            this.Name = "EventHubProcessorTrace";
            this.output = output;
        }

        public override void Write(string message)
        {
            Action append = delegate()
            {
                output.AppendText(message);
            };

            if (output.InvokeRequired)
            {
                output.BeginInvoke(append);
            }
            else
            {
                append();
            }
        }

        public override void WriteLine(string message)
        {
            Write(message + Environment.NewLine);
        }

        //override & edit TraceEvent method to control what is logged to textbox;
        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
        {
            WriteLine(message);
        }
    }
}
