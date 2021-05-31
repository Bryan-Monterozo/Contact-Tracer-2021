
namespace Contact_Tracer_2021
{
    partial class login_Screen
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
            this.login_Panel = new System.Windows.Forms.Panel();
            this.login_Title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.button_TryLogin = new System.Windows.Forms.Button();
            this.button_BackLogin = new System.Windows.Forms.Button();
            this.login_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_Panel
            // 
            this.login_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.login_Panel.Controls.Add(this.login_Title);
            this.login_Panel.Location = new System.Drawing.Point(40, 31);
            this.login_Panel.Name = "login_Panel";
            this.login_Panel.Size = new System.Drawing.Size(400, 70);
            this.login_Panel.TabIndex = 0;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.ForeColor = System.Drawing.Color.White;
            this.label_Username.Location = new System.Drawing.Point(86, 203);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(112, 22);
            this.label_Username.TabIndex = 2;
            this.label_Username.Text = "USERNAME:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 287);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(300, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.Color.White;
            this.label_Password.Location = new System.Drawing.Point(86, 262);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(116, 22);
            this.label_Password.TabIndex = 4;
            this.label_Password.Text = "PASSWORD:";
            // 
            // button_TryLogin
            // 
            this.button_TryLogin.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TryLogin.Location = new System.Drawing.Point(206, 361);
            this.button_TryLogin.Name = "button_TryLogin";
            this.button_TryLogin.Size = new System.Drawing.Size(75, 30);
            this.button_TryLogin.TabIndex = 5;
            this.button_TryLogin.Text = "LOGIN";
            this.button_TryLogin.UseVisualStyleBackColor = true;
            // 
            // button_BackLogin
            // 
            this.button_BackLogin.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BackLogin.Location = new System.Drawing.Point(206, 405);
            this.button_BackLogin.Name = "button_BackLogin";
            this.button_BackLogin.Size = new System.Drawing.Size(75, 30);
            this.button_BackLogin.TabIndex = 6;
            this.button_BackLogin.Text = "BACK";
            this.button_BackLogin.UseVisualStyleBackColor = true;
            this.button_BackLogin.Click += new System.EventHandler(this.button_BackLogin_Click);
            // 
            // login_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.button_BackLogin);
            this.Controls.Add(this.button_TryLogin);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.login_Panel);
            this.MaximizeBox = false;
            this.Name = "login_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracer 2021";
            this.login_Panel.ResumeLayout(false);
            this.login_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel login_Panel;
        private System.Windows.Forms.Label login_Title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button button_TryLogin;
        private System.Windows.Forms.Button button_BackLogin;
    }
}

