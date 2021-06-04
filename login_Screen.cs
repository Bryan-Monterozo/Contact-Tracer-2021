using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Contact_Tracer_2021
{
    public partial class login_Screen : Form
    {
        //byte auth_Token = 0;


        public login_Screen()
        {
            InitializeComponent();
        }

        //XmlNodeList userList = 
        // XmlDocument userList = new XmlDocument();
        // XmlTextReader checker = new XmlTextReader(".\\Urd.xml");

        private void button_BackLogin_Click(object sender, System.EventArgs e)
        {
            main_Menu form = new main_Menu();
            form.Show();
            this.Hide();
        }

        private void button_TryLogin_Click(object sender, System.EventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();
            string fileName = @".\Urd.xml";
            xdoc.Load(fileName);

            //XmlNodeList userlist = xdoc.SelectNodes(".//user_Reg_Data")
            //private bool auth_Token = false;

            var Username = "";
            var Password = "";

            foreach (XmlElement node in xdoc.SelectNodes("user_Reg_Data"))
            {
                Username = node.SelectSingleNode(".//username").InnerText;
                Password = node.SelectSingleNode(".//password").InnerText;

                if (Username.Equals(textbox_Login_Username.Text) && Password.Equals(textbox_Login_Password.Text))
                {
                    profile form = new profile();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("something is wrong");
                }
            }
            //var path = Application.ExecutablePath + "Urd.xml";
            //FileStream fs = new FileStream(".\\Urd.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            //string fileName = Path.Combine(Application.StartupPath, @"\\Urd.xml");
            //string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "\\Urd.xml");
            //string fileName = @"C:\Users\LenovoUser\Desktop\C#\Contact Tracer 2021\Contact Tracer 2021\bin\Debug\Urd.xml";
            //string startingdir = Path.GetDirectoryName(Application.ExecutablePath);
            //string fileName = Path.Combine(startingdir, @"\Urd.xml");
            /*xdoc.Load(fileName);

            var Username = "";
            var Password = "";
            
            foreach (XmlNode node in xdoc.SelectNodes("user_Reg_Data"))
            {
                Username = node.SelectSingleNode(".//username").InnerText;
                Password = node.SelectSingleNode(".//password").InnerText;

                if (Username.Equals(textbox_Login_Username.Text) && Password.Equals(textbox_Login_Password.Text))
                {
                    profile form = new profile();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("something is wrong");
                }
            }

                {   /*XmlSerializer xs = new XmlSerializer(typeof(List<user_Reg_Data>));
                user_Reg_Data users = new user_Reg_Data();
                FileStream fs = new FileStream(".\\Urd.xml", FileMode.Open, FileAccess.Read);
                try
                {
                    using (fs)
                    {
                        users = (user_Reg_Data)xs.Deserialize(fs);
                        var tryUsername = users.username;
                        var tryPassword = users.password;
                        if (tryUsername == textbox_Login_Username.Text && tryPassword == textbox_Login_Password.Text)
                        {
                            profile form = new profile();
                            form.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("LOL", "Contact Tracer 2021", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Error", "Contact Tracer 2021", MessageBoxButtons.OK);
                }*/
            //var auth = tryUsername.Zip(tryPassword, (u, p) new => { n, p});
        }
    }
}
