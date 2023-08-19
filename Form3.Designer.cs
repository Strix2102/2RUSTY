namespace _2RUSTY
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            resultsListBox = new ListBox();
            statusLabel = new Label();
            animationTimer = new System.Windows.Forms.Timer(components);
            localIpLabel = new Label();
            Scanbtn = new Button();
            menubtn = new Button();
            SuspendLayout();
            // 
            // resultsListBox
            // 
            resultsListBox.BackColor = Color.DimGray;
            resultsListBox.BorderStyle = BorderStyle.None;
            resultsListBox.FormattingEnabled = true;
            resultsListBox.ItemHeight = 15;
            resultsListBox.Location = new Point(242, 12);
            resultsListBox.Name = "resultsListBox";
            resultsListBox.Size = new Size(546, 420);
            resultsListBox.TabIndex = 1;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = Color.Transparent;
            statusLabel.ForeColor = Color.DarkOrange;
            statusLabel.Location = new Point(44, 95);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(151, 15);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "                                                ";
            // 
            // localIpLabel
            // 
            localIpLabel.AutoSize = true;
            localIpLabel.BackColor = Color.Transparent;
            localIpLabel.ForeColor = Color.DarkOrange;
            localIpLabel.Location = new Point(21, 354);
            localIpLabel.Name = "localIpLabel";
            localIpLabel.Size = new Size(38, 15);
            localIpLabel.TabIndex = 3;
            localIpLabel.Text = "label1";
            // 
            // Scanbtn
            // 
            Scanbtn.BackColor = Color.DarkOrange;
            Scanbtn.FlatStyle = FlatStyle.Popup;
            Scanbtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Scanbtn.Location = new Point(31, 68);
            Scanbtn.Name = "Scanbtn";
            Scanbtn.Size = new Size(176, 24);
            Scanbtn.TabIndex = 15;
            Scanbtn.Text = "Scan For Servers";
            Scanbtn.UseVisualStyleBackColor = false;
            // 
            // menubtn
            // 
            menubtn.BackColor = Color.DarkOrange;
            menubtn.FlatStyle = FlatStyle.Popup;
            menubtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menubtn.Location = new Point(31, 38);
            menubtn.Name = "menubtn";
            menubtn.Size = new Size(176, 24);
            menubtn.TabIndex = 16;
            menubtn.Text = "---Main Menu---";
            menubtn.UseVisualStyleBackColor = false;
            menubtn.Click += menubtn_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundother;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(menubtn);
            Controls.Add(Scanbtn);
            Controls.Add(localIpLabel);
            Controls.Add(statusLabel);
            Controls.Add(resultsListBox);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form3";
            Text = "2RUSTY - Join A Local Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox resultsListBox;
        private Label statusLabel;
        private System.Windows.Forms.Timer animationTimer;
        private Label localIpLabel;
        private Button Scanbtn;
        private Button menubtn;
    }
}