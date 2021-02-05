using System;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace NetworkInterface_Info
{
    public partial class traceroute : Form
    {
        Thread thread;
        Process process;

        public traceroute() { InitializeComponent(); }
        private void startTracing(object sender, EventArgs e) { TraceIt(destination.Text, dontShowHostnames.Checked); }
        private void clearText_Click(object sender, EventArgs e) { outputText.Text = ""; }

        public void TraceIt(string url, bool dontShowHostnames)
        {
            outputText.Text = "";

            string arguments;
            if (!dontShowHostnames)
                arguments = "-h " + Convert.ToString(maxHops.Value) + " " + url;
            else
                arguments = "-d -h " + Convert.ToString(maxHops.Value) + " " + url;

            process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "TRACERT.exe",
                    Arguments = arguments,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                }
            };

            thread = new Thread(() => {
                process.Start();

                while (!process.StandardOutput.EndOfStream)
                {
                    string line = process.StandardOutput.ReadLine();
                    BeginInvoke(new Action(() => {
                        outputText.Text += line + Environment.NewLine;
                    }));
                }

                process.WaitForExit();
            });

            thread.Start();
        }

    }
}
