using System;
using System.Windows.Forms;

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

        private void main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
