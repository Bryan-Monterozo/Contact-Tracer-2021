using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Contact_Tracer_2021
{
    public partial class main_Menu : Form
    {
        public main_Menu()
        {
            InitializeComponent();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            reg_Form form = new reg_Form();
            form.Show();
            this.Hide();
        }

        private void button_Contact_Log_Click(object sender, EventArgs e)
        {
            log_Form form = new log_Form();
            form.Show();
            this.Hide();
        }

        private void main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
