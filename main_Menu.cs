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

        private void button_Login_Click(object sender, EventArgs e)
        {
            login_Screen form = new login_Screen();
            form.Show();
            this.Hide();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            reg_Form form = new reg_Form();
            form.Show();
            this.Hide();
        }
    }
}
