
namespace Contact_Tracer_2021
{
    partial class main_Menu
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
            this.menu_Panel = new System.Windows.Forms.Panel();
            this.menu_Title = new System.Windows.Forms.Label();
            this.button_Register = new System.Windows.Forms.Button();
            this.button_Contact_Log = new System.Windows.Forms.Button();
            this.menu_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Panel
            // 
            this.menu_Panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menu_Panel.Controls.Add(this.menu_Title);
            this.menu_Panel.Location = new System.Drawing.Point(40, 31);
            this.menu_Panel.Name = "menu_Panel";
            this.menu_Panel.Size = new System.Drawing.Size(400, 70);
            this.menu_Panel.TabIndex = 1;
            // 
            // menu_Title
            // 
            this.menu_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu_Title.AutoSize = true;
            this.menu_Title.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Title.ForeColor = System.Drawing.Color.White;
            this.menu_Title.Location = new System.Drawing.Point(3, 10);
            this.menu_Title.Name = "menu_Title";
            this.menu_Title.Size = new System.Drawing.Size(392, 44);
            this.menu_Title.TabIndex = 0;
            this.menu_Title.Text = "Contact Tracer 2021";
            // 
            // button_Register
            // 
            this.button_Register.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Register.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.Location = new System.Drawing.Point(159, 212);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(150, 50);
            this.button_Register.TabIndex = 3;
            this.button_Register.Text = "REGISTER";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // button_Contact_Log
            // 
            this.button_Contact_Log.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Contact_Log.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Contact_Log.Location = new System.Drawing.Point(159, 280);
            this.button_Contact_Log.Name = "button_Contact_Log";
            this.button_Contact_Log.Size = new System.Drawing.Size(150, 50);
            this.button_Contact_Log.TabIndex = 4;
            this.button_Contact_Log.Text = "VIEW LOG";
            this.button_Contact_Log.UseVisualStyleBackColor = true;
            this.button_Contact_Log.Click += new System.EventHandler(this.button_Contact_Log_Click);
            // 
            // main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.button_Contact_Log);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.menu_Panel);
            this.MaximizeBox = false;
            this.Name = "main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracer 2021";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_Menu_FormClosed);
            this.menu_Panel.ResumeLayout(false);
            this.menu_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_Panel;
        private System.Windows.Forms.Label menu_Title;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Button button_Contact_Log;
    }
}