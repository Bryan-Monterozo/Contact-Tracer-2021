
namespace Contact_Tracer_2021
{
    partial class profile
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
            this.profile_User_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // profile_User_Title
            // 
            this.profile_User_Title.AutoSize = true;
            this.profile_User_Title.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_User_Title.ForeColor = System.Drawing.Color.White;
            this.profile_User_Title.Location = new System.Drawing.Point(12, 23);
            this.profile_User_Title.Name = "profile_User_Title";
            this.profile_User_Title.Size = new System.Drawing.Size(390, 44);
            this.profile_User_Title.TabIndex = 1;
            this.profile_User_Title.Text = "Welcome, User Name";
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(804, 589);
            this.Controls.Add(this.profile_User_Title);
            this.MaximizeBox = false;
            this.Name = "profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracer 2021";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profile_User_Title;
    }
}