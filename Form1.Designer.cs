namespace _2RUSTY
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ConnectButton = new Button();
            SendButton = new Button();
            CommandTextBox = new TextBox();
            ConnectionStatusLabel = new Label();
            ResponseTextBox = new RichTextBox();
            Menubtn = new Button();
            Cfgbtn = new Button();
            Stopbtn = new Button();
            Startbtn = new Button();
            Joinbtn = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // ConnectButton
            // 
            ConnectButton.BackColor = Color.DarkOrange;
            ConnectButton.FlatStyle = FlatStyle.Popup;
            ConnectButton.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ConnectButton.Location = new Point(80, 121);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(82, 45);
            ConnectButton.TabIndex = 0;
            ConnectButton.Text = "Connect\r\nRCON";
            toolTip1.SetToolTip(ConnectButton, "Connect to the localhost RCON");
            ConnectButton.UseVisualStyleBackColor = false;
            ConnectButton.Click += ConnectButton_Click_1;
            // 
            // SendButton
            // 
            SendButton.BackColor = Color.DarkOrange;
            SendButton.FlatStyle = FlatStyle.Popup;
            SendButton.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SendButton.Location = new Point(713, 386);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(75, 33);
            SendButton.TabIndex = 1;
            SendButton.Text = "SEND";
            toolTip1.SetToolTip(SendButton, "Send the command to the server");
            SendButton.UseVisualStyleBackColor = false;
            SendButton.Click += SendButton_Click;
            // 
            // CommandTextBox
            // 
            CommandTextBox.BackColor = Color.LightGray;
            CommandTextBox.Location = new Point(243, 392);
            CommandTextBox.Name = "CommandTextBox";
            CommandTextBox.PlaceholderText = "Type your command here...";
            CommandTextBox.Size = new Size(464, 23);
            CommandTextBox.TabIndex = 2;
            toolTip1.SetToolTip(CommandTextBox, "Type a command to send to the server");
            // 
            // ConnectionStatusLabel
            // 
            ConnectionStatusLabel.AutoSize = true;
            ConnectionStatusLabel.BackColor = Color.Transparent;
            ConnectionStatusLabel.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ConnectionStatusLabel.ForeColor = Color.DarkOrange;
            ConnectionStatusLabel.Location = new Point(400, 367);
            ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            ConnectionStatusLabel.Size = new Size(203, 22);
            ConnectionStatusLabel.TabIndex = 4;
            ConnectionStatusLabel.Text = "RCON Status: Disconnected";
            // 
            // ResponseTextBox
            // 
            ResponseTextBox.BackColor = Color.Black;
            ResponseTextBox.BorderStyle = BorderStyle.None;
            ResponseTextBox.ForeColor = Color.White;
            ResponseTextBox.Location = new Point(243, 12);
            ResponseTextBox.Name = "ResponseTextBox";
            ResponseTextBox.ReadOnly = true;
            ResponseTextBox.Size = new Size(545, 351);
            ResponseTextBox.TabIndex = 5;
            ResponseTextBox.Text = "";
            // 
            // Menubtn
            // 
            Menubtn.BackColor = Color.DarkOrange;
            Menubtn.FlatStyle = FlatStyle.Popup;
            Menubtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Menubtn.Location = new Point(33, 30);
            Menubtn.Name = "Menubtn";
            Menubtn.Size = new Size(176, 24);
            Menubtn.TabIndex = 6;
            Menubtn.Text = "---Main Menu---";
            toolTip1.SetToolTip(Menubtn, "Back to main menu");
            Menubtn.UseVisualStyleBackColor = false;
            Menubtn.Click += Menubtn_Click;
            // 
            // Cfgbtn
            // 
            Cfgbtn.BackColor = Color.DarkOrange;
            Cfgbtn.FlatStyle = FlatStyle.Popup;
            Cfgbtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Cfgbtn.Location = new Point(33, 60);
            Cfgbtn.Name = "Cfgbtn";
            Cfgbtn.Size = new Size(176, 24);
            Cfgbtn.TabIndex = 7;
            Cfgbtn.Text = "Configure Server";
            toolTip1.SetToolTip(Cfgbtn, "Configure your localhost server");
            Cfgbtn.UseVisualStyleBackColor = false;
            // 
            // Stopbtn
            // 
            Stopbtn.BackColor = Color.IndianRed;
            Stopbtn.FlatStyle = FlatStyle.Popup;
            Stopbtn.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Stopbtn.Location = new Point(168, 128);
            Stopbtn.Name = "Stopbtn";
            Stopbtn.Size = new Size(41, 29);
            Stopbtn.TabIndex = 8;
            Stopbtn.Text = "✘";
            toolTip1.SetToolTip(Stopbtn, "Stop The Server");
            Stopbtn.UseVisualStyleBackColor = false;
            // 
            // Startbtn
            // 
            Startbtn.BackColor = Color.DarkSeaGreen;
            Startbtn.FlatStyle = FlatStyle.Popup;
            Startbtn.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Startbtn.Location = new Point(33, 128);
            Startbtn.Name = "Startbtn";
            Startbtn.Size = new Size(41, 29);
            Startbtn.TabIndex = 13;
            Startbtn.Text = "✔";
            toolTip1.SetToolTip(Startbtn, "Start The Server");
            Startbtn.UseVisualStyleBackColor = false;
            // 
            // Joinbtn
            // 
            Joinbtn.BackColor = Color.DarkOrange;
            Joinbtn.FlatStyle = FlatStyle.Popup;
            Joinbtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Joinbtn.Location = new Point(33, 90);
            Joinbtn.Name = "Joinbtn";
            Joinbtn.Size = new Size(176, 24);
            Joinbtn.TabIndex = 14;
            Joinbtn.Text = "Join Server Now";
            toolTip1.SetToolTip(Joinbtn, "Open rust and connect to your localhost server");
            Joinbtn.UseVisualStyleBackColor = false;
            Joinbtn.Click += Joinbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.backgroundother;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(Joinbtn);
            Controls.Add(Startbtn);
            Controls.Add(Stopbtn);
            Controls.Add(Cfgbtn);
            Controls.Add(Menubtn);
            Controls.Add(ResponseTextBox);
            Controls.Add(ConnectionStatusLabel);
            Controls.Add(CommandTextBox);
            Controls.Add(SendButton);
            Controls.Add(ConnectButton);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "2RUSTY - Manage Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConnectButton;
        private Button SendButton;
        private TextBox CommandTextBox;
        private Label ConnectionStatusLabel;
        private RichTextBox ResponseTextBox;
        private Button Menubtn;
        private Button Cfgbtn;
        private Button Stopbtn;
        private Button Startbtn;
        private Button Joinbtn;
        private ToolTip toolTip1;
    }
}