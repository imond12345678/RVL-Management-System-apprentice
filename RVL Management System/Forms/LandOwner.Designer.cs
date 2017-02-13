namespace RVL_Management_System.Forms
{
    partial class LandOwner
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
            this.txt_landowner = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txt_landowner
            // 
            // 
            // 
            // 
            this.txt_landowner.CustomButton.Image = null;
            this.txt_landowner.CustomButton.Location = new System.Drawing.Point(293, 1);
            this.txt_landowner.CustomButton.Name = "";
            this.txt_landowner.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_landowner.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_landowner.CustomButton.TabIndex = 1;
            this.txt_landowner.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_landowner.CustomButton.UseSelectable = true;
            this.txt_landowner.CustomButton.Visible = false;
            this.txt_landowner.Lines = new string[0];
            this.txt_landowner.Location = new System.Drawing.Point(133, 78);
            this.txt_landowner.MaxLength = 32767;
            this.txt_landowner.Name = "txt_landowner";
            this.txt_landowner.PasswordChar = '\0';
            this.txt_landowner.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_landowner.SelectedText = "";
            this.txt_landowner.SelectionLength = 0;
            this.txt_landowner.SelectionStart = 0;
            this.txt_landowner.ShortcutsEnabled = true;
            this.txt_landowner.Size = new System.Drawing.Size(315, 23);
            this.txt_landowner.TabIndex = 0;
            this.txt_landowner.UseSelectable = true;
            this.txt_landowner.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_landowner.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(46, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Land Owner:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(373, 120);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "&Save";
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // LandOwner
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 175);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_landowner);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LandOwner";
            this.Resizable = false;
            this.Text = "Add Information for Land Owner";
            this.Load += new System.EventHandler(this.Frm_LandOwner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_landowner;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_save;
    }
}