using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace _2RUSTY
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void managebtn_Click(object sender, EventArgs e)
        {
                Form1 Form1 = new Form1();
                Form1.Show();
                Form1.Location = this.Location;
                Hide();
        }

        private async void searchbtn_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            Form3.Location = this.Location;
            Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}