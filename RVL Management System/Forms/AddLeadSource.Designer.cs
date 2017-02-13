namespace RVL_Management_System.Forms
{
    partial class AddLeadSource
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new MetroFramework.Controls.MetroButton();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_leadDescription = new MetroFramework.Controls.MetroTextBox();
            this.txt_lid = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txt_leadDescription);
            this.groupBox1.Controls.Add(this.txt_lid);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lead Source Information";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(347, 103);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(266, 103);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 38);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Lead ID:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Lead Source:";
            // 
            // txt_leadDescription
            // 
            // 
            // 
            // 
            this.txt_leadDescription.CustomButton.Image = null;
            this.txt_leadDescription.CustomButton.Location = new System.Drawing.Point(285, 1);
            this.txt_leadDescription.CustomButton.Name = "";
            this.txt_leadDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_leadDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_leadDescription.CustomButton.TabIndex = 1;
            this.txt_leadDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_leadDescription.CustomButton.UseSelectable = true;
            this.txt_leadDescription.CustomButton.Visible = false;
            this.txt_leadDescription.Lines = new string[0];
            this.txt_leadDescription.Location = new System.Drawing.Point(115, 63);
            this.txt_leadDescription.MaxLength = 32767;
            this.txt_leadDescription.Name = "txt_leadDescription";
            this.txt_leadDescription.PasswordChar = '\0';
            this.txt_leadDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_leadDescription.SelectedText = "";
            this.txt_leadDescription.SelectionLength = 0;
            this.txt_leadDescription.SelectionStart = 0;
            this.txt_leadDescription.ShortcutsEnabled = true;
            this.txt_leadDescription.Size = new System.Drawing.Size(307, 23);
            this.txt_leadDescription.TabIndex = 1;
            this.txt_leadDescription.UseSelectable = true;
            this.txt_leadDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_leadDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_lid
            // 
            // 
            // 
            // 
            this.txt_lid.CustomButton.Image = null;
            this.txt_lid.CustomButton.Location = new System.Drawing.Point(285, 1);
            this.txt_lid.CustomButton.Name = "";
            this.txt_lid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_lid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_lid.CustomButton.TabIndex = 1;
            this.txt_lid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_lid.CustomButton.UseSelectable = true;
            this.txt_lid.CustomButton.Visible = false;
            this.txt_lid.Enabled = false;
            this.txt_lid.Lines = new string[0];
            this.txt_lid.Location = new System.Drawing.Point(115, 34);
            this.txt_lid.MaxLength = 32767;
            this.txt_lid.Name = "txt_lid";
            this.txt_lid.PasswordChar = '\0';
            this.txt_lid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_lid.SelectedText = "";
            this.txt_lid.SelectionLength = 0;
            this.txt_lid.SelectionStart = 0;
            this.txt_lid.ShortcutsEnabled = true;
            this.txt_lid.Size = new System.Drawing.Size(307, 23);
            this.txt_lid.TabIndex = 0;
            this.txt_lid.UseSelectable = true;
            this.txt_lid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_lid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Frm_AddLeadSource
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 277);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AddLeadSource";
            this.Resizable = false;
            this.Text = "Add Lead Source Information";
            this.Load += new System.EventHandler(this.Frm_AddLeadSource_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txt_lid;
        private MetroFramework.Controls.MetroTextBox txt_leadDescription;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btn_save;
        private MetroFramework.Controls.MetroButton btn_clear;
    }
}