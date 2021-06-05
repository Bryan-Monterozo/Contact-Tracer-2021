
namespace Contact_Tracer_2021
{
    partial class log_Form
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
            this.dataGrid_LogView = new System.Windows.Forms.DataGridView();
            this.button_BackLog = new System.Windows.Forms.Button();
            this.login_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_LogView)).BeginInit();
            this.SuspendLayout();
            // 
            // login_Panel
            // 
            this.login_Panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.login_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.login_Panel.Controls.Add(this.login_Title);
            this.login_Panel.Location = new System.Drawing.Point(485, 45);
            this.login_Panel.Name = "login_Panel";
            this.login_Panel.Size = new System.Drawing.Size(400, 70);
            this.login_Panel.TabIndex = 2;
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
            // dataGrid_LogView
            // 
            this.dataGrid_LogView.AllowUserToAddRows = false;
            this.dataGrid_LogView.AllowUserToDeleteRows = false;
            this.dataGrid_LogView.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_LogView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_LogView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid_LogView.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGrid_LogView.Location = new System.Drawing.Point(0, 339);
            this.dataGrid_LogView.Name = "dataGrid_LogView";
            this.dataGrid_LogView.ReadOnly = true;
            this.dataGrid_LogView.RowHeadersWidth = 51;
            this.dataGrid_LogView.RowTemplate.Height = 24;
            this.dataGrid_LogView.Size = new System.Drawing.Size(1330, 399);
            this.dataGrid_LogView.TabIndex = 3;
            this.dataGrid_LogView.DataSourceChanged += new System.EventHandler(this.dataGrid_LogView_DataSourceChanged);
            // 
            // button_BackLog
            // 
            this.button_BackLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_BackLog.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BackLog.Location = new System.Drawing.Point(588, 200);
            this.button_BackLog.Name = "button_BackLog";
            this.button_BackLog.Size = new System.Drawing.Size(180, 70);
            this.button_BackLog.TabIndex = 21;
            this.button_BackLog.Text = "BACK";
            this.button_BackLog.UseVisualStyleBackColor = true;
            this.button_BackLog.Click += new System.EventHandler(this.button_BackLog_Click);
            // 
            // log_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1330, 738);
            this.Controls.Add(this.button_BackLog);
            this.Controls.Add(this.dataGrid_LogView);
            this.Controls.Add(this.login_Panel);
            this.Name = "log_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracer 2021";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.log_Form_FormClosed);
            this.Load += new System.EventHandler(this.log_Load);
            this.login_Panel.ResumeLayout(false);
            this.login_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_LogView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel login_Panel;
        private System.Windows.Forms.Label login_Title;
        private System.Windows.Forms.DataGridView dataGrid_LogView;
        private System.Windows.Forms.Button button_BackLog;
    }
}