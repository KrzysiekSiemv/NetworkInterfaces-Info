using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace NetworkInterface_Info
{
    public partial class ping : Form
    {
        public ping()
        {
            InitializeComponent();
        }

        private void pingIt(object sender, EventArgs e)
        {
            Ping pingSender = new Ping();

            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            PingOptions options = new PingOptions(Int32.Parse(ttl.Value.ToString()), dontfragment.Checked);
            PingReply pingReply = pingSender.Send(server.Text, Int32.Parse(miliseconds.Value.ToString()), buffer, options);

            if (pingReply.Status == IPStatus.Success)
                textBox1.Text += pingReply.Buffer.Length + " bajtów od " + server.Text + " (" + pingReply.Address + "): ttl=" + pingReply.Options.Ttl + " czas=" + pingReply.RoundtripTime + " ms" + Environment.NewLine;
            else
            {
                textBox1.Text = "PING " + server.Text + " nie powiódł się. Status: " + pingReply.Status;
            }

            System.Threading.Thread.Sleep(1000);
        }

        private void startPing(object sender, EventArgs e)
        {
            textBox1.Text = "PING " + server.Text + Environment.NewLine;
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
        }

        private void stopPing(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void clearIt(object sender, EventArgs e)
        {
            textBox1.Text = "";
            button3.Enabled = false;
        }

        private void onLoad(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
        }
    }
}
