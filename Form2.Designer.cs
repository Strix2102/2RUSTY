namespace _2RUSTY
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            managebtn = new Button();
            searchbtn = new Button();
            settingsbtn = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // managebtn
            // 
            managebtn.BackColor = Color.FromArgb(222, 134, 27);
            managebtn.BackgroundImageLayout = ImageLayout.Zoom;
            managebtn.FlatStyle = FlatStyle.Popup;
            managebtn.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            managebtn.Location = new Point(276, 237);
            managebtn.Name = "managebtn";
            managebtn.Size = new Size(241, 46);
            managebtn.TabIndex = 0;
            managebtn.Text = "MANAGE SERVER";
            toolTip1.SetToolTip(managebtn, "Manage your localhost server");
            managebtn.UseVisualStyleBackColor = false;
            managebtn.Click += managebtn_Click;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.FromArgb(222, 134, 27);
            searchbtn.BackgroundImageLayout = ImageLayout.Zoom;
            searchbtn.FlatStyle = FlatStyle.Popup;
            searchbtn.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            searchbtn.Location = new Point(276, 308);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(241, 46);
            searchbtn.TabIndex = 1;
            searchbtn.Text = "JOIN LOCAL SERVER";
            toolTip1.SetToolTip(searchbtn, "Join a server from the local network");
            searchbtn.UseVisualStyleBackColor = false;
            searchbtn.Click += searchbtn_Click;
            // 
            // settingsbtn
            // 
            settingsbtn.BackColor = Color.FromArgb(222, 134, 27);
            settingsbtn.BackgroundImage = Properties.Resources.settingsico;
            settingsbtn.BackgroundImageLayout = ImageLayout.Zoom;
            settingsbtn.FlatStyle = FlatStyle.Popup;
            settingsbtn.Location = new Point(12, 385);
            settingsbtn.Name = "settingsbtn";
            settingsbtn.Size = new Size(54, 53);
            settingsbtn.TabIndex = 2;
            toolTip1.SetToolTip(settingsbtn, "Settings");
            settingsbtn.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundmenu;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(settingsbtn);
            Controls.Add(searchbtn);
            Controls.Add(managebtn);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            Text = "2RUSTY - Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button managebtn;
        private Button searchbtn;
        private Button settingsbtn;
        private ToolTip toolTip1;
    }
}