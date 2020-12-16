using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Diagnostics;

namespace Narzędzie_diagnostyczne_karty_sieciowej
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showInformation()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();

            textBox1.Text = ("Informacje o ustawieniach karty sieciowej dla urządzenia \"" + properties.HostName + "\"" + Environment.NewLine + Environment.NewLine);
            foreach (NetworkInterface adapter in networkInterfaces)
            {
                textBox1.Text += adapter.Description + Environment.NewLine;
                textBox1.Text += (String.Empty.PadLeft(adapter.Description.Length, '=')) + Environment.NewLine;

                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                GatewayIPAddressInformationCollection addressInformation = adapterProperties.GatewayAddresses;
                IPv4InterfaceProperties ip = adapterProperties.GetIPv4Properties();
                IPAddressCollection dnsServer = adapterProperties.DnsAddresses;
                IPAddressCollection dhcpServer = adapterProperties.DhcpServerAddresses;

                if (ip == null)
                    textBox1.Text += "Nie ma informacji na temat tej karty sieciowej";
                else
                {
                    // Typ interfejsu
                    textBox1.Text += ("Typ interfejsu ........... : " + adapter.NetworkInterfaceType + Environment.NewLine);

                    // Adres IPv4 i IPv6
                    foreach (UnicastIPAddressInformation ipaddress in adapterProperties.UnicastAddresses)
                    {
                        if (ipaddress.Address.AddressFamily == AddressFamily.InterNetworkV6)
                            textBox1.Text += ("Adres IPv6 ............... : " + ipaddress.Address + Environment.NewLine);

                        if (ipaddress.Address.AddressFamily == AddressFamily.InterNetwork)
                            textBox1.Text += ("Adres IPv4 ............... : " + ipaddress.Address + Environment.NewLine);
                    }

                    foreach (GatewayIPAddressInformation address in addressInformation)
                        textBox1.Text += ("Brama domyślna ........... : " + address.Address + Environment.NewLine);

                    textBox1.Text += ("Adres fizyczny (MAC) ..... : " + adapter.GetPhysicalAddress() + Environment.NewLine);

                    if(dhcpServer.Count > 0)
                    {
                        foreach (IPAddress dhcp in dhcpServer)
                            textBox1.Text += ("Serwer DHCP .............. : " + dhcp + Environment.NewLine);
                    }
                    else
                        textBox1.Text += ("Serwer DHCP .............. : wyłączony" + Environment.NewLine);

                    textBox1.Text += ("Serwery DNS .............. : " + Environment.NewLine);
                    foreach (IPAddress dns in dnsServer)
                        textBox1.Text += ("                             " + dns + Environment.NewLine);


                    textBox1.Text += Environment.NewLine;
                }
            }
        }

        private void onLoad(object sender, EventArgs e)
        {
            showInformation();
            textBox1.Font = Properties.Settings.Default.font;
            this.Size = Properties.Settings.Default.windowSize;
        }

        // NIE DOTYKAĆ, BO DZIAŁA
        private void generate(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Plik tekstowy (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextWriter txt = new StreamWriter(saveFileDialog1.FileName);
                txt.Write(textBox1.Text);
                txt.Close();
            }
        }

        private void refresh(object sender, EventArgs e)
        {
            showInformation();
        }

        // NIE DOTYKAĆ, BO DZIAŁA
        private void changeFont(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                Properties.Settings.Default.font = fontDialog1.Font;
                Properties.Settings.Default.Save();
                MessageBox.Show("Twoja nowa czcionka: " + fontDialog1.Font.Name + ", " + fontDialog1.Font.Size + "pt. Została zapisana", "Ustawienie");
            }
        }

        // NIE DOTYKAĆ, BO DZIAŁA
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.windowSize = this.Size;
            Properties.Settings.Default.Save();
        }

        private void stworzonePrzezKrzysiekSiemvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/KrzysiekSiemv");
        }
    }
}
