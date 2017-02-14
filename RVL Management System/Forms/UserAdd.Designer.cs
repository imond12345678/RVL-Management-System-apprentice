namespace RVL_Management_System
{
    partial class Frm_UserAdd
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_level = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cBoxRole = new MetroFramework.Controls.MetroComboBox();
            this.txt_confirmPw = new MetroFramework.Controls.MetroTextBox();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.txt_un = new MetroFramework.Controls.MetroTextBox();
            this.txt_fullname = new MetroFramework.Controls.MetroTextBox();
            this.txt_pw = new MetroFramework.Controls.MetroTextBox();
            this.txt_userID = new MetroFramework.Controls.MetroTextBox();
            this.btn_clear = new MetroFramework.Controls.MetroTile();
            this.btn_save = new MetroFramework.Controls.MetroTile();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.metroLabel3);
            this.GroupBox1.Controls.Add(this.metroLabel2);
            this.GroupBox1.Controls.Add(this.txt_level);
            this.GroupBox1.Controls.Add(this.metroLabel1);
            this.GroupBox1.Controls.Add(this.cBoxRole);
            this.GroupBox1.Controls.Add(this.txt_confirmPw);
            this.GroupBox1.Controls.Add(this.txt_email);
            this.GroupBox1.Controls.Add(this.txt_un);
            this.GroupBox1.Controls.Add(this.txt_fullname);
            this.GroupBox1.Controls.Add(this.txt_pw);
            this.GroupBox1.Controls.Add(this.txt_userID);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(23, 75);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(637, 115);
            this.GroupBox1.TabIndex = 13;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Staff Information";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(8, 21);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "User ID:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(430, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Privilege level:";
            // 
            // txt_level
            // 
            // 
            // 
            // 
            this.txt_level.CustomButton.Image = null;
            this.txt_level.CustomButton.Location = new System.Drawing.Point(1, 1);
            this.txt_level.CustomButton.Name = "";
            this.txt_level.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_level.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_level.CustomButton.TabIndex = 1;
            this.txt_level.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_level.CustomButton.UseSelectable = true;
            this.txt_level.CustomButton.Visible = false;
            this.txt_level.Enabled = false;
            this.txt_level.Lines = new string[0];
            this.txt_level.Location = new System.Drawing.Point(528, 67);
            this.txt_level.MaxLength = 32767;
            this.txt_level.Name = "txt_level";
            this.txt_level.PasswordChar = '\0';
            this.txt_level.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_level.SelectedText = "";
            this.txt_level.SelectionLength = 0;
            this.txt_level.SelectionStart = 0;
            this.txt_level.ShortcutsEnabled = true;
            this.txt_level.Size = new System.Drawing.Size(23, 23);
            this.txt_level.TabIndex = 21;
            this.txt_level.UseSelectable = true;
            this.txt_level.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_level.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(466, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Role:";
            // 
            // cBoxRole
            // 
            this.cBoxRole.FormattingEnabled = true;
            this.cBoxRole.ItemHeight = 23;
            this.cBoxRole.Location = new System.Drawing.Point(510, 21);
            this.cBoxRole.Name = "cBoxRole";
            this.cBoxRole.Size = new System.Drawing.Size(121, 29);
            this.cBoxRole.TabIndex = 19;
            this.cBoxRole.UseSelectable = true;
            this.cBoxRole.SelectedIndexChanged += new System.EventHandler(this.cBoxRole_SelectedIndexChanged_1);
            // 
            // txt_confirmPw
            // 
            // 
            // 
            // 
            this.txt_confirmPw.CustomButton.Image = null;
            this.txt_confirmPw.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txt_confirmPw.CustomButton.Name = "";
            this.txt_confirmPw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_confirmPw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_confirmPw.CustomButton.TabIndex = 1;
            this.txt_confirmPw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_confirmPw.CustomButton.UseSelectable = true;
            this.txt_confirmPw.CustomButton.Visible = false;
            this.txt_confirmPw.Lines = new string[0];
            this.txt_confirmPw.Location = new System.Drawing.Point(249, 75);
            this.txt_confirmPw.MaxLength = 32767;
            this.txt_confirmPw.Name = "txt_confirmPw";
            this.txt_confirmPw.PasswordChar = '*';
            this.txt_confirmPw.PromptText = "Confirm Password";
            this.txt_confirmPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_confirmPw.SelectedText = "";
            this.txt_confirmPw.SelectionLength = 0;
            this.txt_confirmPw.SelectionStart = 0;
            this.txt_confirmPw.ShortcutsEnabled = true;
            this.txt_confirmPw.Size = new System.Drawing.Size(175, 23);
            this.txt_confirmPw.TabIndex = 18;
            this.txt_confirmPw.UseSelectable = true;
            this.txt_confirmPw.WaterMark = "Confirm Password";
            this.txt_confirmPw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_confirmPw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_confirmPw.TextChanged += new System.EventHandler(this.txt_confirmPw_TextChanged_1);
            // 
            // txt_email
            // 
            // 
            // 
            // 
            this.txt_email.CustomButton.Image = null;
            this.txt_email.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txt_email.CustomButton.Name = "";
            this.txt_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_email.CustomButton.TabIndex = 1;
            this.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_email.CustomButton.UseSelectable = true;
            this.txt_email.CustomButton.Visible = false;
            this.txt_email.Lines = new string[0];
            this.txt_email.Location = new System.Drawing.Point(68, 75);
            this.txt_email.MaxLength = 32767;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PromptText = "Email";
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(175, 23);
            this.txt_email.TabIndex = 15;
            this.txt_email.UseSelectable = true;
            this.txt_email.WaterMark = "Email";
            this.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_un
            // 
            // 
            // 
            // 
            this.txt_un.CustomButton.Image = null;
            this.txt_un.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txt_un.CustomButton.Name = "";
            this.txt_un.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_un.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_un.CustomButton.TabIndex = 1;
            this.txt_un.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_un.CustomButton.UseSelectable = true;
            this.txt_un.CustomButton.Visible = false;
            this.txt_un.Lines = new string[0];
            this.txt_un.Location = new System.Drawing.Point(249, 17);
            this.txt_un.MaxLength = 32767;
            this.txt_un.Name = "txt_un";
            this.txt_un.PasswordChar = '\0';
            this.txt_un.PromptText = "Username";
            this.txt_un.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_un.SelectedText = "";
            this.txt_un.SelectionLength = 0;
            this.txt_un.SelectionStart = 0;
            this.txt_un.ShortcutsEnabled = true;
            this.txt_un.Size = new System.Drawing.Size(175, 23);
            this.txt_un.TabIndex = 16;
            this.txt_un.UseSelectable = true;
            this.txt_un.WaterMark = "Username";
            this.txt_un.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_un.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_fullname
            // 
            // 
            // 
            // 
            this.txt_fullname.CustomButton.Image = null;
            this.txt_fullname.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txt_fullname.CustomButton.Name = "";
            this.txt_fullname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_fullname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_fullname.CustomButton.TabIndex = 1;
            this.txt_fullname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_fullname.CustomButton.UseSelectable = true;
            this.txt_fullname.CustomButton.Visible = false;
            this.txt_fullname.Lines = new string[0];
            this.txt_fullname.Location = new System.Drawing.Point(68, 46);
            this.txt_fullname.MaxLength = 32767;
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.PasswordChar = '\0';
            this.txt_fullname.PromptText = "Full Name";
            this.txt_fullname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_fullname.SelectedText = "";
            this.txt_fullname.SelectionLength = 0;
            this.txt_fullname.SelectionStart = 0;
            this.txt_fullname.ShortcutsEnabled = true;
            this.txt_fullname.Size = new System.Drawing.Size(175, 23);
            this.txt_fullname.TabIndex = 14;
            this.txt_fullname.UseSelectable = true;
            this.txt_fullname.WaterMark = "Full Name";
            this.txt_fullname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_fullname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_pw
            // 
            // 
            // 
            // 
            this.txt_pw.CustomButton.Image = null;
            this.txt_pw.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txt_pw.CustomButton.Name = "";
            this.txt_pw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_pw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pw.CustomButton.TabIndex = 1;
            this.txt_pw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pw.CustomButton.UseSelectable = true;
            this.txt_pw.CustomButton.Visible = false;
            this.txt_pw.Lines = new string[0];
            this.txt_pw.Location = new System.Drawing.Point(249, 46);
            this.txt_pw.MaxLength = 32767;
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.PromptText = "Password";
            this.txt_pw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pw.SelectedText = "";
            this.txt_pw.SelectionLength = 0;
            this.txt_pw.SelectionStart = 0;
            this.txt_pw.ShortcutsEnabled = true;
            this.txt_pw.Size = new System.Drawing.Size(175, 23);
            this.txt_pw.TabIndex = 17;
            this.txt_pw.UseSelectable = true;
            this.txt_pw.WaterMark = "Password";
            this.txt_pw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_userID
            // 
            // 
            // 
            // 
            this.txt_userID.CustomButton.Image = null;
            this.txt_userID.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txt_userID.CustomButton.Name = "";
            this.txt_userID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_userID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_userID.CustomButton.TabIndex = 1;
            this.txt_userID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_userID.CustomButton.UseSelectable = true;
            this.txt_userID.CustomButton.Visible = false;
            this.txt_userID.Enabled = false;
            this.txt_userID.Lines = new string[0];
            this.txt_userID.Location = new System.Drawing.Point(68, 17);
            this.txt_userID.MaxLength = 32767;
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.PasswordChar = '\0';
            this.txt_userID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_userID.SelectedText = "";
            this.txt_userID.SelectionLength = 0;
            this.txt_userID.SelectionStart = 0;
            this.txt_userID.ShortcutsEnabled = true;
            this.txt_userID.Size = new System.Drawing.Size(175, 23);
            this.txt_userID.TabIndex = 13;
            this.txt_userID.UseSelectable = true;
            this.txt_userID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_userID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_clear
            // 
            this.btn_clear.ActiveControl = null;
            this.btn_clear.Location = new System.Drawing.Point(500, 196);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(77, 58);
            this.btn_clear.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_clear.TabIndex = 18;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.TileImage = global::RVL_Management_System.Properties.Resources.cancel;
            this.btn_clear.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseSelectable = true;
            this.btn_clear.UseTileImage = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.ActiveControl = null;
            this.btn_save.Location = new System.Drawing.Point(583, 196);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 58);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.TileImage = global::RVL_Management_System.Properties.Resources.plus_1;
            this.btn_save.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseSelectable = true;
            this.btn_save.UseTileImage = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Frm_UserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 267);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.GroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_UserAdd";
            this.Resizable = false;
            this.Text = "Add User Information";
            this.Load += new System.EventHandler(this.Frm_UserAdd_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.GroupBox GroupBox1;
        private MetroFramework.Controls.MetroTextBox txt_email;
        private MetroFramework.Controls.MetroTextBox txt_fullname;
        private MetroFramework.Controls.MetroTextBox txt_userID;
        private MetroFramework.Controls.MetroTextBox txt_confirmPw;
        private MetroFramework.Controls.MetroTextBox txt_un;
        private MetroFramework.Controls.MetroTextBox txt_pw;
        private MetroFramework.Controls.MetroComboBox cBoxRole;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_level;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btn_clear;
        private MetroFramework.Controls.MetroTile btn_save;
    }
}