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
using System.Net.Sockets;

namespace _2RUSTY
{
    public partial class Form3 : Form
    {
        private int animationCounter = 0;
        public Form3()
        {
            InitializeComponent();
            animationTimer.Start();

            // Update local IP address label
            string localIpAddress = GetLocalIpAddress();
            if (!string.IsNullOrEmpty(localIpAddress))
            {
                localIpLabel.Text = $"Your Local IP Address: {localIpAddress}";
            }
            else
            {
                localIpLabel.Text = "Unable to retrieve local IP address.";
            }
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            animationCounter = (animationCounter + 1) % 4;
            string dots = new string('.', animationCounter);
            statusLabel.Text = $"Searching for servers on your local network{dots}";
        }

        private async void ScanButton_Click_1(object sender, EventArgs e)
        {
            animationTimer.Start(); // Start the animation

            resultsListBox.Items.Clear(); // Clear the ListBox before a new scan

            statusLabel.Text = "Searching for servers on your local network";
            await PerformNetworkScanAsync();

            if (resultsListBox.Items.Count == 0)
            {
                resultsListBox.Items.Add("No Rust servers found on the network.");
            }

            statusLabel.Text = "Finished";
            animationTimer.Stop(); // Stop the animation when the scan is done
        }

        private async Task PerformNetworkScanAsync()
        {
            await Task.Run(() =>
            {
                string localIpAddress = GetLocalIpAddress();
                if (!string.IsNullOrEmpty(localIpAddress))
                {
                    ScanNetworkForRustServers(localIpAddress);
                }
            });
        }

        private string GetLocalIpAddress()
        {
            string hostName = Dns.GetHostName();
            IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
            foreach (IPAddress ipAddress in hostEntry.AddressList)
            {
                if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ipAddress.ToString();
                }
            }
            return null;
        }

        private void ScanNetworkForRustServers(string localIpAddress)
        {
            string[] ipSegments = localIpAddress.Split('.');
            if (ipSegments.Length != 4)
            {
                resultsListBox.Items.Add("Invalid IP address format.");
                return;
            }

            string baseIpAddress = $"{ipSegments[0]}.{ipSegments[1]}.{ipSegments[2]}";

            for (int i = 1; i <= 255; i++)
            {
                string ipAddress = $"{baseIpAddress}.{i}";
                if (CheckPort(ipAddress, 28015))
                {
                    resultsListBox.Items.Add($"Server found: {ipAddress}:28015");
                }
            }
        }

        private bool CheckPort(string ipAddress, int port)
        {
            using (TcpClient tcpClient = new TcpClient())
            {
                try
                {
                    tcpClient.Connect(ipAddress, port);
                    return true; // Port is open
                }
                catch (SocketException)
                {
                    return false; // Port is closed
                }
            }
        }

        private void menubtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form2 Form2 = new Form2();
            Form2.Show();
            Form2.Location = this.Location;
            Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            animationTimer.Stop();  // Stop the timer
            animationTimer.Dispose(); // Dispose the timer
        }
    }
}