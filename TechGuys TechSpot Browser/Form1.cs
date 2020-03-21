using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TechGuys_TechSpot_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radMenuItem7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(radTextBox1.Text);
        }
    }
}
