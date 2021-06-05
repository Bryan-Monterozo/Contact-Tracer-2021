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
        string date_Str = "";
        //string status = "";
        XmlSerializer xs;           //read/write xml file
        List<user_Reg_Data> lsURD;  // list containing user registration data

        public reg_Form()
        {
            InitializeComponent();

            lsURD = new List<user_Reg_Data>();
            xs = new XmlSerializer(typeof(List<user_Reg_Data>));

        }
        public void modify_Data(user_Reg_Data obj) //modifier
        {
            //FileStream fsRead = new FileStream(".\\Urd.Xml", FileMode.Open, FileAccess.Read);
            //FileStream fsMod = new FileStream(".\\Urd.Xml", FileMode.Open, FileAccess.Write);
            
            List<user_Reg_Data> lsURD = null;

            try
            {
                using (Stream s = File.OpenRead(".\\Urd.xml"))
                {
                    lsURD = xs.Deserialize(s) as List<user_Reg_Data>;
                }
            }
            catch
            {
                lsURD = new List<user_Reg_Data>();
            }
            lsURD.Add(obj);
            //fsRead.Close();

            using (Stream s = File.OpenWrite(".\\Urd.xml"))
            {
                xs.Serialize(s, lsURD);
                //fsMod.Close();
            }
            //fsMod.Close();
        }

        private void button_RegisterNow_Click(object sender, EventArgs e)
        {
            byte i;
            string status = "";
            for (i = 0; i <= (status_ChkBox.Items.Count - 1); i++)
            {
                if (status_ChkBox.GetItemChecked(i))
                {
                    status = status + status_ChkBox.Items[i].ToString() + " ";
                }
            }

            DialogResult yesno_Result = MessageBox.Show("Your inputed details will be stored and can be viewed by others. Do You Still Wish To Continue?", "Contact Tracer 2021",MessageBoxButtons.YesNo);
            if (yesno_Result == DialogResult.Yes)
            {
                try
                {
                    if (File.Exists(".\\Urd.xml"))//for modifying .Xml file database
                    {
                        user_Reg_Data urd = new user_Reg_Data();

                        urd.FIRSTNAME = textbox_Fname.Text;
                        urd.LASTNAME = textbox_Lname.Text;
                        urd.BIRTHDATE = date_Str;
                        urd.AGE = textbox_Age.Text;
                        urd.ADDRESS = textbox_Address.Text;
                        urd.PHONE_NO = textbox_Pnum.Text;
                        urd.SEX = dropdown_Sex.Text;
                        urd.EMAIL = textbox_Email.Text;
                        urd.HSTATUS = status;
                        urd.CUR_DATE_TIME = label_CurDate.Text + " " + label_CurTime.Text;

                        modify_Data(urd);
                    }
                    else
                    {
                        FileStream fsNew = new FileStream(".\\Urd.Xml", FileMode.Create, FileAccess.Write);   //for creating.Xml file database
                        user_Reg_Data urd = new user_Reg_Data();
                        urd.FIRSTNAME = textbox_Fname.Text;
                        urd.LASTNAME = textbox_Lname.Text;
                        urd.BIRTHDATE = date_Str;
                        urd.AGE = textbox_Age.Text;
                        urd.ADDRESS = textbox_Address.Text;
                        urd.PHONE_NO = textbox_Pnum.Text;
                        urd.SEX = dropdown_Sex.Text;
                        urd.EMAIL = textbox_Email.Text;
                        urd.HSTATUS = status;
                        urd.CUR_DATE_TIME = label_CurDate.Text + " " + label_CurTime.Text;

                        lsURD.Add(urd);
                        xs.Serialize(fsNew, lsURD);
                        fsNew.Close();
                    }

                    main_Menu form = new main_Menu();
                    form.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_BackRegister_Click(object sender, EventArgs e)
        {
            main_Menu form = new main_Menu();
            form.Show();
            this.Hide();
        }

        private void reg_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void reg_Form_Load(object sender, EventArgs e)
        {
            timer_Ticker.Start();
            label_CurTime.Text = DateTime.Now.ToLongTimeString();
            label_CurDate.Text = DateTime.Now.ToLongDateString();

            dtpicker_Birthdate.Value = DateTime.Today;
        }

        private void timer_Ticker_Tick(object sender, EventArgs e) //time ticker
        {
            label_CurTime.Text = DateTime.Now.ToLongTimeString();
            timer_Ticker.Start();
        }

        private void dtpicker_Birthdate_ValueChanged(object sender, EventArgs e) //only show/convert date to string
        {
            date_Str = dtpicker_Birthdate.Value.ToString("yyyy-MM-dd");
        }

        /*private void status_ChkBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var checkedListBox = (CheckedListBox)sender;
            status = checkedListBox.Items[e.Index].ToString();
        }*/
    }
}
