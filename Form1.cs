using System;
using WebSocketSharp;
using Newtonsoft.Json;
using System.Net.WebSockets;
using System.Diagnostics;

namespace _2RUSTY
{
    public partial class Form1 : Form
    {
        private WebSocketSharp.WebSocket _websocket; //defines websocket
        private bool _isConnected = false; //sets status
        private int _messageIDCounter = 1; //sets JSON identifier to 1
        private string lastSentCommand = string.Empty; //something something
        private bool waitingForResponse = false; //sets response wait


        public Form1()
        {
            InitializeComponent();
            ConnectButton.Enabled = !_isConnected;
            CommandTextBox.KeyPress += CommandTextBox_KeyPress;
        }


        private string GetRustDedicatedPath()
        {
            string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string rustDedicatedPath = Path.Combine(userFolder, "2RUSTY", "server", "RustDedicated.exe");
            return rustDedicatedPath;
        }

        //rcon connect button
        private void ConnectButton_Click_1(object sender, EventArgs e)
        {
            if (!_isConnected)
            {
                _websocket = new WebSocketSharp.WebSocket("ws://127.0.0.1:28016/2RUSTY");
                _websocket.OnOpen += (s, evt) =>
                {
                    UpdateConnectionStatus("Connected");
                    _isConnected = true;
                    ConnectButton.Enabled = false; // Disable the button when connected
                };
                _websocket.OnClose += (s, evt) =>
                {
                    UpdateConnectionStatus("Disconnected");
                    _isConnected = false;
                    ConnectButton.Enabled = true; // Enable the button when disconnected
                };
            }

            //server response
            _websocket.OnMessage += (s, evt) =>
        {
            string response = evt.Data;

            // Parse the JSON response
            dynamic jsonResponse = JsonConvert.DeserializeObject(response);

            // Access the message part
            string message = jsonResponse.Message;

            // Display the response
            DisplayResponse(lastSentCommand, message);
        };

            _websocket.Connect();
        }

        private void CommandTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the "ding" sound
                SendButton.PerformClick(); // Trigger the "Send" button click
            }
        }

        //rcon send button
        private void SendButton_Click(object sender, EventArgs e)
        {
            if (_isConnected)
            {
                lastSentCommand = CommandTextBox.Text;
                waitingForResponse = true;
                DisplayResponse("Command: " + lastSentCommand, "");
                SendRconCommand();
            }
            else
            {
                DisplayResponse("Not connected to the server.", "");
            }
        }

        //rcon send JSON funtionality
        private void SendRconCommand()
        {
            try
            {
                var data = new
                {
                    Identifier = _messageIDCounter.ToString(),
                    Message = CommandTextBox.Text,
                    Stacktrace = "",
                    Type = 3
                };

                string jsonData = JsonConvert.SerializeObject(data);
                _websocket.Send(jsonData);

                // Increment the Identifier
                _messageIDCounter++;

                CommandTextBox.Text = "";
            }
            catch (Exception ex)
            {
                //catch exceptions
            }
        }

        //displaying responses from server
        private void DisplayResponse(string command, string response)
        {
            if (ResponseTextBox.InvokeRequired)
            {
                ResponseTextBox.Invoke(new Action(() => DisplayResponse(command, response)));
            }
            else
            {
                if (waitingForResponse)
                {
                    // Append new response with bold labels
                    ResponseTextBox.SelectionFont = new Font(ResponseTextBox.Font, FontStyle.Bold);
                    ResponseTextBox.AppendText(command + Environment.NewLine);

                    waitingForResponse = false; // Reset the waiting state
                }

                // Display the response
                ResponseTextBox.SelectionFont = new Font(ResponseTextBox.Font, FontStyle.Regular);
                ResponseTextBox.AppendText(response + Environment.NewLine);

                // Scroll to the end
                ResponseTextBox.SelectionStart = ResponseTextBox.Text.Length;
                ResponseTextBox.ScrollToCaret();
            }
        }

        private void Joinbtn_Click(object sender, EventArgs e)
        {
            string serverIpAddress = "127.0.0.1"; // server ip
            int serverPort = 28015; // server port

            string rustExecutablePath = "path/to/rust/executable"; // Provide the actual path
            string arguments = $"-connect {serverIpAddress}:{serverPort}";

            // Check if the game is running
            Process[] runningProcesses = Process.GetProcessesByName("RustClient");

            foreach (Process process in runningProcesses)
            {
                process.CloseMainWindow(); // Close the game
                process.WaitForExit(); // Wait for the process to exit
            }

            // Launch the game
            Process.Start(rustExecutablePath, arguments);
        }

        //connection status
        private void UpdateConnectionStatus(string status)
        {
            if (ConnectionStatusLabel.InvokeRequired)
            {
                ConnectionStatusLabel.Invoke(new Action(() => UpdateConnectionStatus(status)));
            }
            else
            {
                ConnectionStatusLabel.Text = "RCON Status: " + status;
            }
        }

        //close websocket when form closes
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _websocket?.Close();
        }

        private void Menubtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 Form2 = new Form2();
            Form2.Show();
            Form2.Location = this.Location;
            Hide();
        }
    }
}
