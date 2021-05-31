using System.Windows.Forms;

namespace Contact_Tracer_2021
{
    public partial class login_Screen : Form
    {
        public login_Screen()
        {
            InitializeComponent();
        }

        private void button_BackLogin_Click(object sender, System.EventArgs e)
        {
            main_Menu form = new main_Menu();
            form.Show();
            this.Close();
        }
    }
}
