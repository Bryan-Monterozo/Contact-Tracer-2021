using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Contact_Tracer_2021
{
    public partial class log_Form : Form
    {
        List<user_Reg_Data> lsURD;
        XmlSerializer xs;

        public log_Form()
        {
            InitializeComponent();

            lsURD = new List<user_Reg_Data>();
            xs = new XmlSerializer(typeof(List<user_Reg_Data>));
        }

        private void log_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fsShow = new FileStream(".\\Urd.Xml", FileMode.Open, FileAccess.Read);
                lsURD = (List<user_Reg_Data>)xs.Deserialize(fsShow);

                dataGrid_LogView.DataSource = lsURD;
                fsShow.Close();
            }
            catch (Exception)
            {
                DialogResult msg_R = MessageBox.Show("No contact registered yet, REGISTER NOW.", "Contact Tracer 2021", MessageBoxButtons.OK);
                if (msg_R == DialogResult.OK)
                {
                    reg_Form form = new reg_Form();
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void button_BackLog_Click(object sender, EventArgs e)
        {
            main_Menu form = new main_Menu();
            form.Show();
            this.Hide();
        }

        private void log_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGrid_LogView_DataSourceChanged(object sender, EventArgs e)
        {
            // datdagrid column sizes
            dataGrid_LogView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid_LogView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid_LogView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid_LogView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid_LogView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid_LogView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid_LogView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid_LogView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid_LogView.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid_LogView.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            for (int i = 0; i <= dataGrid_LogView.Columns.Count - 1; i++)
            {
                int colw = dataGrid_LogView.Columns[i].Width;
                dataGrid_LogView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGrid_LogView.Columns[i].Width = colw;
            }
        }
    }
}
