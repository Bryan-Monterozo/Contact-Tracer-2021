
namespace Contact_Tracer_2021
{
    partial class reg_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.login_Panel = new System.Windows.Forms.Panel();
            this.login_Title = new System.Windows.Forms.Label();
            this.textbox_Fname = new System.Windows.Forms.TextBox();
            this.textbox_Lname = new System.Windows.Forms.TextBox();
            this.textbox_Address = new System.Windows.Forms.TextBox();
            this.label_Fname = new System.Windows.Forms.Label();
            this.label_Lname = new System.Windows.Forms.Label();
            this.label_Birthdate = new System.Windows.Forms.Label();
            this.dtpicker_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.textbox_Age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Pnum = new System.Windows.Forms.Label();
            this.textbox_Pnum = new System.Windows.Forms.TextBox();
            this.button_RegisterNow = new System.Windows.Forms.Button();
            this.button_BackRegister = new System.Windows.Forms.Button();
            this.textbox_Email = new System.Windows.Forms.TextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Sex = new System.Windows.Forms.Label();
            this.dropdown_Sex = new System.Windows.Forms.ComboBox();
            this.status_ChkBox = new System.Windows.Forms.CheckedListBox();
            this.label_Status = new System.Windows.Forms.Label();
            this.label_Status2 = new System.Windows.Forms.Label();
            this.label_CurTime = new System.Windows.Forms.Label();
            this.label_CurDate = new System.Windows.Forms.Label();
            this.timer_Ticker = new System.Windows.Forms.Timer(this.components);
            this.login_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_Panel
            // 
            this.login_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.login_Panel.Controls.Add(this.login_Title);
            this.login_Panel.Location = new System.Drawing.Point(444, 42);
            this.login_Panel.Name = "login_Panel";
            this.login_Panel.Size = new System.Drawing.Size(400, 70);
            this.login_Panel.TabIndex = 1;
            // 
            // login_Title
            // 
            this.login_Title.AutoSize = true;
            this.login_Title.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Title.ForeColor = System.Drawing.Color.White;
            this.login_Title.Location = new System.Drawing.Point(3, 10);
            this.login_Title.Name = "login_Title";
            this.login_Title.Size = new System.Drawing.Size(392, 44);
            this.login_Title.TabIndex = 0;
            this.login_Title.Text = "Contact Tracer 2021";
            // 
            // textbox_Fname
            // 
            this.textbox_Fname.Location = new System.Drawing.Point(139, 168);
            this.textbox_Fname.Name = "textbox_Fname";
            this.textbox_Fname.Size = new System.Drawing.Size(491, 34);
            this.textbox_Fname.TabIndex = 2;
            // 
            // textbox_Lname
            // 
            this.textbox_Lname.Location = new System.Drawing.Point(750, 168);
            this.textbox_Lname.Name = "textbox_Lname";
            this.textbox_Lname.Size = new System.Drawing.Size(486, 34);
            this.textbox_Lname.TabIndex = 3;
            // 
            // textbox_Address
            // 
            this.textbox_Address.Location = new System.Drawing.Point(115, 276);
            this.textbox_Address.Multiline = true;
            this.textbox_Address.Name = "textbox_Address";
            this.textbox_Address.Size = new System.Drawing.Size(1121, 79);
            this.textbox_Address.TabIndex = 4;
            // 
            // label_Fname
            // 
            this.label_Fname.AutoSize = true;
            this.label_Fname.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Fname.ForeColor = System.Drawing.Color.White;
            this.label_Fname.Location = new System.Drawing.Point(21, 180);
            this.label_Fname.Name = "label_Fname";
            this.label_Fname.Size = new System.Drawing.Size(112, 22);
            this.label_Fname.TabIndex = 5;
            this.label_Fname.Text = "First Name:";
            // 
            // label_Lname
            // 
            this.label_Lname.AutoSize = true;
            this.label_Lname.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Lname.ForeColor = System.Drawing.Color.White;
            this.label_Lname.Location = new System.Drawing.Point(636, 180);
            this.label_Lname.Name = "label_Lname";
            this.label_Lname.Size = new System.Drawing.Size(108, 22);
            this.label_Lname.TabIndex = 6;
            this.label_Lname.Text = "Last Name:";
            // 
            // label_Birthdate
            // 
            this.label_Birthdate.AutoSize = true;
            this.label_Birthdate.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Birthdate.ForeColor = System.Drawing.Color.White;
            this.label_Birthdate.Location = new System.Drawing.Point(21, 232);
            this.label_Birthdate.Name = "label_Birthdate";
            this.label_Birthdate.Size = new System.Drawing.Size(130, 22);
            this.label_Birthdate.TabIndex = 9;
            this.label_Birthdate.Text = "Date of Birth:";
            // 
            // dtpicker_Birthdate
            // 
            this.dtpicker_Birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker_Birthdate.Location = new System.Drawing.Point(157, 220);
            this.dtpicker_Birthdate.MaxDate = new System.DateTime(3021, 12, 31, 0, 0, 0, 0);
            this.dtpicker_Birthdate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpicker_Birthdate.Name = "dtpicker_Birthdate";
            this.dtpicker_Birthdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpicker_Birthdate.Size = new System.Drawing.Size(142, 34);
            this.dtpicker_Birthdate.TabIndex = 10;
            this.dtpicker_Birthdate.Value = new System.DateTime(2021, 6, 4, 0, 0, 0, 0);
            this.dtpicker_Birthdate.ValueChanged += new System.EventHandler(this.dtpicker_Birthdate_ValueChanged);
            // 
            // textbox_Age
            // 
            this.textbox_Age.Location = new System.Drawing.Point(640, 220);
            this.textbox_Age.Name = "textbox_Age";
            this.textbox_Age.Size = new System.Drawing.Size(126, 34);
            this.textbox_Age.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(586, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Age:";
            // 
            // label_Pnum
            // 
            this.label_Pnum.AutoSize = true;
            this.label_Pnum.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pnum.ForeColor = System.Drawing.Color.White;
            this.label_Pnum.Location = new System.Drawing.Point(784, 232);
            this.label_Pnum.Name = "label_Pnum";
            this.label_Pnum.Size = new System.Drawing.Size(146, 22);
            this.label_Pnum.TabIndex = 13;
            this.label_Pnum.Text = "Phone Number:";
            // 
            // textbox_Pnum
            // 
            this.textbox_Pnum.Location = new System.Drawing.Point(936, 220);
            this.textbox_Pnum.Name = "textbox_Pnum";
            this.textbox_Pnum.Size = new System.Drawing.Size(300, 34);
            this.textbox_Pnum.TabIndex = 14;
            // 
            // button_RegisterNow
            // 
            this.button_RegisterNow.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RegisterNow.Location = new System.Drawing.Point(1010, 543);
            this.button_RegisterNow.Name = "button_RegisterNow";
            this.button_RegisterNow.Size = new System.Drawing.Size(180, 70);
            this.button_RegisterNow.TabIndex = 19;
            this.button_RegisterNow.Text = "REGISTER";
            this.button_RegisterNow.UseVisualStyleBackColor = true;
            this.button_RegisterNow.Click += new System.EventHandler(this.button_RegisterNow_Click);
            // 
            // button_BackRegister
            // 
            this.button_BackRegister.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BackRegister.Location = new System.Drawing.Point(1010, 628);
            this.button_BackRegister.Name = "button_BackRegister";
            this.button_BackRegister.Size = new System.Drawing.Size(180, 70);
            this.button_BackRegister.TabIndex = 20;
            this.button_BackRegister.Text = "BACK";
            this.button_BackRegister.UseVisualStyleBackColor = true;
            this.button_BackRegister.Click += new System.EventHandler(this.button_BackRegister_Click);
            // 
            // textbox_Email
            // 
            this.textbox_Email.Location = new System.Drawing.Point(170, 377);
            this.textbox_Email.Name = "textbox_Email";
            this.textbox_Email.Size = new System.Drawing.Size(1066, 34);
            this.textbox_Email.TabIndex = 21;
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Address.ForeColor = System.Drawing.Color.White;
            this.label_Address.Location = new System.Drawing.Point(21, 302);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(88, 22);
            this.label_Address.TabIndex = 7;
            this.label_Address.Text = "Address:";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.ForeColor = System.Drawing.Color.White;
            this.label_Email.Location = new System.Drawing.Point(21, 389);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(143, 22);
            this.label_Email.TabIndex = 22;
            this.label_Email.Text = "Email Address:";
            // 
            // label_Sex
            // 
            this.label_Sex.AutoSize = true;
            this.label_Sex.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sex.ForeColor = System.Drawing.Color.White;
            this.label_Sex.Location = new System.Drawing.Point(317, 232);
            this.label_Sex.Name = "label_Sex";
            this.label_Sex.Size = new System.Drawing.Size(46, 22);
            this.label_Sex.TabIndex = 24;
            this.label_Sex.Text = "Sex:";
            // 
            // dropdown_Sex
            // 
            this.dropdown_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown_Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_Sex.FormattingEnabled = true;
            this.dropdown_Sex.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.dropdown_Sex.Location = new System.Drawing.Point(369, 220);
            this.dropdown_Sex.Name = "dropdown_Sex";
            this.dropdown_Sex.Size = new System.Drawing.Size(196, 33);
            this.dropdown_Sex.TabIndex = 25;
            // 
            // status_ChkBox
            // 
            this.status_ChkBox.CheckOnClick = true;
            this.status_ChkBox.FormattingEnabled = true;
            this.status_ChkBox.Items.AddRange(new object[] {
            "Cold",
            "Cough",
            "Fever",
            "Nausea"});
            this.status_ChkBox.Location = new System.Drawing.Point(25, 504);
            this.status_ChkBox.Name = "status_ChkBox";
            this.status_ChkBox.Size = new System.Drawing.Size(120, 149);
            this.status_ChkBox.TabIndex = 26;
            //this.status_ChkBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.status_ChkBox_ItemCheck);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.ForeColor = System.Drawing.Color.White;
            this.label_Status.Location = new System.Drawing.Point(21, 434);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(269, 22);
            this.label_Status.TabIndex = 27;
            this.label_Status.Text = "Please check all that applies:";
            // 
            // label_Status2
            // 
            this.label_Status2.AutoSize = true;
            this.label_Status2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status2.ForeColor = System.Drawing.Color.White;
            this.label_Status2.Location = new System.Drawing.Point(21, 466);
            this.label_Status2.Name = "label_Status2";
            this.label_Status2.Size = new System.Drawing.Size(434, 22);
            this.label_Status2.TabIndex = 28;
            this.label_Status2.Text = "In the last 7 days have you felt these symptoms:";
            // 
            // label_CurTime
            // 
            this.label_CurTime.AutoSize = true;
            this.label_CurTime.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurTime.ForeColor = System.Drawing.Color.White;
            this.label_CurTime.Location = new System.Drawing.Point(528, 466);
            this.label_CurTime.Name = "label_CurTime";
            this.label_CurTime.Size = new System.Drawing.Size(48, 22);
            this.label_CurTime.TabIndex = 30;
            this.label_CurTime.Text = "time";
            // 
            // label_CurDate
            // 
            this.label_CurDate.AutoSize = true;
            this.label_CurDate.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurDate.ForeColor = System.Drawing.Color.White;
            this.label_CurDate.Location = new System.Drawing.Point(528, 504);
            this.label_CurDate.Name = "label_CurDate";
            this.label_CurDate.Size = new System.Drawing.Size(48, 22);
            this.label_CurDate.TabIndex = 31;
            this.label_CurDate.Text = "date";
            // 
            // timer_Ticker
            // 
            this.timer_Ticker.Enabled = true;
            this.timer_Ticker.Tick += new System.EventHandler(this.timer_Ticker_Tick);
            // 
            // reg_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1269, 720);
            this.Controls.Add(this.label_CurDate);
            this.Controls.Add(this.label_CurTime);
            this.Controls.Add(this.label_Status2);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.status_ChkBox);
            this.Controls.Add(this.dropdown_Sex);
            this.Controls.Add(this.label_Sex);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.textbox_Email);
            this.Controls.Add(this.button_BackRegister);
            this.Controls.Add(this.button_RegisterNow);
            this.Controls.Add(this.textbox_Pnum);
            this.Controls.Add(this.label_Pnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_Age);
            this.Controls.Add(this.dtpicker_Birthdate);
            this.Controls.Add(this.label_Birthdate);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_Lname);
            this.Controls.Add(this.label_Fname);
            this.Controls.Add(this.textbox_Address);
            this.Controls.Add(this.textbox_Lname);
            this.Controls.Add(this.textbox_Fname);
            this.Controls.Add(this.login_Panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "reg_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing 2021";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.reg_Form_FormClosed);
            this.Load += new System.EventHandler(this.reg_Form_Load);
            this.login_Panel.ResumeLayout(false);
            this.login_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel login_Panel;
        private System.Windows.Forms.Label login_Title;
        private System.Windows.Forms.TextBox textbox_Fname;
        private System.Windows.Forms.TextBox textbox_Lname;
        private System.Windows.Forms.TextBox textbox_Address;
        private System.Windows.Forms.Label label_Fname;
        private System.Windows.Forms.Label label_Lname;
        private System.Windows.Forms.Label label_Birthdate;
        private System.Windows.Forms.DateTimePicker dtpicker_Birthdate;
        private System.Windows.Forms.TextBox textbox_Age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Pnum;
        private System.Windows.Forms.TextBox textbox_Pnum;
        private System.Windows.Forms.Button button_RegisterNow;
        private System.Windows.Forms.Button button_BackRegister;
        private System.Windows.Forms.TextBox textbox_Email;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Sex;
        private System.Windows.Forms.ComboBox dropdown_Sex;
        private System.Windows.Forms.CheckedListBox status_ChkBox;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_Status2;
        private System.Windows.Forms.Label label_CurTime;
        private System.Windows.Forms.Label label_CurDate;
        private System.Windows.Forms.Timer timer_Ticker;
    }
}