using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracer_2021
{
    public partial class reg_Form : Form
    {
        XmlSerializer xs;           //easy read/write xml file
        List<user_Reg_Data> lsURD;  // list containing user registration data

        public reg_Form()
        {
            InitializeComponent();

            lsURD = new List<user_Reg_Data>();
            xs = new XmlSerializer(typeof(List<user_Reg_Data>));

        }

        private void button_RegisterNow_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(".\\Urd.Xml", FileMode.Create, FileAccess.Write);   //for creating/modifying .Xml file database
            user_Reg_Data urd = new user_Reg_Data();
            urd.fname = textbox_Fname.Text;
            urd.lname = textbox_Lname.Text;
            urd.birthdate = dtpicker_Birthdate.Value;
            urd.age = textbox_Age.Text;
            urd.address = textbox_Address.Text;
            urd.pnumber = textbox_Pnum.Text;
            urd.username = textbox_Username.Text;
            urd.password = textbox_Password.Text;

            lsURD.Add(urd);
            xs.Serialize(fs, lsURD);
            fs.Close();
        }
    }
}
