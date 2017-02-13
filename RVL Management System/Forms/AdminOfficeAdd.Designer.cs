namespace RVL_Management_System.Forms
{
    partial class AdminOfficeAdd
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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_fullName = new MetroFramework.Controls.MetroTextBox();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.txt_phoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.txt_address = new MetroFramework.Controls.MetroTextBox();
            this.txt_county = new MetroFramework.Controls.MetroTextBox();
            this.cBoxCategory = new MetroFramework.Controls.MetroComboBox();
            this.btn_save = new MetroFramework.Controls.MetroTile();
            this.btn_clear = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(502, 94);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(64, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Category";
            // 
            // txt_fullName
            // 
            // 
            // 
            // 
            this.txt_fullName.CustomButton.Image = null;
            this.txt_fullName.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txt_fullName.CustomButton.Name = "";
            this.txt_fullName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_fullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_fullName.CustomButton.TabIndex = 1;
            this.txt_fullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_fullName.CustomButton.UseSelectable = true;
            this.txt_fullName.CustomButton.Visible = false;
            this.txt_fullName.Lines = new string[0];
            this.txt_fullName.Location = new System.Drawing.Point(23, 63);
            this.txt_fullName.MaxLength = 32767;
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.PasswordChar = '\0';
#pragma warning disable CS0618 // Type or member is obsolete
            this.txt_fullName.PromptText = "Full name";
#pragma warning restore CS0618 // Type or member is obsolete
            this.txt_fullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_fullName.SelectedText = "";
            this.txt_fullName.SelectionLength = 0;
            this.txt_fullName.SelectionStart = 0;
            this.txt_fullName.ShortcutsEnabled = true;
            this.txt_fullName.Size = new System.Drawing.Size(218, 23);
            this.txt_fullName.TabIndex = 6;
            this.txt_fullName.UseSelectable = true;
            this.txt_fullName.WaterMark = "Full name";
            this.txt_fullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_fullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_email
            // 
            // 
            // 
            // 
            this.txt_email.CustomButton.Image = null;
            this.txt_email.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txt_email.CustomButton.Name = "";
            this.txt_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_email.CustomButton.TabIndex = 1;
            this.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_email.CustomButton.UseSelectable = true;
            this.txt_email.CustomButton.Visible = false;
            this.txt_email.Lines = new string[0];
            this.txt_email.Location = new System.Drawing.Point(275, 63);
            this.txt_email.MaxLength = 32767;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PromptText = "Email";
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(218, 23);
            this.txt_email.TabIndex = 7;
            this.txt_email.UseSelectable = true;
            this.txt_email.WaterMark = "Email";
            this.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_phoneNumber
            // 
            // 
            // 
            // 
            this.txt_phoneNumber.CustomButton.Image = null;
            this.txt_phoneNumber.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txt_phoneNumber.CustomButton.Name = "";
            this.txt_phoneNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_phoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_phoneNumber.CustomButton.TabIndex = 1;
            this.txt_phoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_phoneNumber.CustomButton.UseSelectable = true;
            this.txt_phoneNumber.CustomButton.Visible = false;
            this.txt_phoneNumber.Lines = new string[0];
            this.txt_phoneNumber.Location = new System.Drawing.Point(502, 63);
            this.txt_phoneNumber.MaxLength = 32767;
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.PasswordChar = '\0';
            this.txt_phoneNumber.PromptText = "Phone number";
            this.txt_phoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_phoneNumber.SelectedText = "";
            this.txt_phoneNumber.SelectionLength = 0;
            this.txt_phoneNumber.SelectionStart = 0;
            this.txt_phoneNumber.ShortcutsEnabled = true;
            this.txt_phoneNumber.Size = new System.Drawing.Size(218, 23);
            this.txt_phoneNumber.TabIndex = 8;
            this.txt_phoneNumber.UseSelectable = true;
            this.txt_phoneNumber.WaterMark = "Phone number";
            this.txt_phoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_phoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_address
            // 
            // 
            // 
            // 
            this.txt_address.CustomButton.Image = null;
            this.txt_address.CustomButton.Location = new System.Drawing.Point(140, 2);
            this.txt_address.CustomButton.Name = "";
            this.txt_address.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.txt_address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_address.CustomButton.TabIndex = 1;
            this.txt_address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_address.CustomButton.UseSelectable = true;
            this.txt_address.CustomButton.Visible = false;
            this.txt_address.Lines = new string[0];
            this.txt_address.Location = new System.Drawing.Point(23, 94);
            this.txt_address.MaxLength = 32767;
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.PromptText = "Address";
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_address.SelectedText = "";
            this.txt_address.SelectionLength = 0;
            this.txt_address.SelectionStart = 0;
            this.txt_address.ShortcutsEnabled = true;
            this.txt_address.Size = new System.Drawing.Size(218, 80);
            this.txt_address.TabIndex = 9;
            this.txt_address.UseSelectable = true;
            this.txt_address.WaterMark = "Address";
            this.txt_address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_county
            // 
            // 
            // 
            // 
            this.txt_county.CustomButton.Image = null;
            this.txt_county.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txt_county.CustomButton.Name = "";
            this.txt_county.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_county.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_county.CustomButton.TabIndex = 1;
            this.txt_county.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_county.CustomButton.UseSelectable = true;
            this.txt_county.CustomButton.Visible = false;
            this.txt_county.Lines = new string[0];
            this.txt_county.Location = new System.Drawing.Point(275, 94);
            this.txt_county.MaxLength = 32767;
            this.txt_county.Name = "txt_county";
            this.txt_county.PasswordChar = '\0';
            this.txt_county.PromptText = "County";
            this.txt_county.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_county.SelectedText = "";
            this.txt_county.SelectionLength = 0;
            this.txt_county.SelectionStart = 0;
            this.txt_county.ShortcutsEnabled = true;
            this.txt_county.Size = new System.Drawing.Size(218, 23);
            this.txt_county.TabIndex = 10;
            this.txt_county.UseSelectable = true;
            this.txt_county.WaterMark = "County";
            this.txt_county.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_county.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cBoxCategory
            // 
            this.cBoxCategory.FormattingEnabled = true;
            this.cBoxCategory.ItemHeight = 23;
            this.cBoxCategory.Items.AddRange(new object[] {
            "Notary Public",
            "County Recorder",
            "County Treasurer"});
            this.cBoxCategory.Location = new System.Drawing.Point(502, 116);
            this.cBoxCategory.Name = "cBoxCategory";
            this.cBoxCategory.Size = new System.Drawing.Size(218, 29);
            this.cBoxCategory.TabIndex = 14;
            this.cBoxCategory.UseSelectable = true;
            // 
            // btn_save
            // 
            this.btn_save.ActiveControl = null;
            this.btn_save.Location = new System.Drawing.Point(643, 151);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 58);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.TileImage = global::RVL_Management_System.Properties.Resources.plus_1;
            this.btn_save.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseSelectable = true;
            this.btn_save.UseTileImage = true;
            this.btn_save.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.ActiveControl = null;
            this.btn_clear.Location = new System.Drawing.Point(560, 151);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(77, 58);
            this.btn_clear.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.TileImage = global::RVL_Management_System.Properties.Resources.cancel;
            this.btn_clear.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseSelectable = true;
            this.btn_clear.UseTileImage = true;
            this.btn_clear.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // AdminOfficeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 227);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cBoxCategory);
            this.Controls.Add(this.txt_county);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_fullName);
            this.Controls.Add(this.metroLabel6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminOfficeAdd";
            this.Resizable = false;
            this.Text = "Admin Office Contact List";
            this.Load += new System.EventHandler(this.Frm_AdminOffice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txt_fullName;
        private MetroFramework.Controls.MetroTextBox txt_email;
        private MetroFramework.Controls.MetroTextBox txt_phoneNumber;
        private MetroFramework.Controls.MetroTextBox txt_address;
        private MetroFramework.Controls.MetroTextBox txt_county;
        private MetroFramework.Controls.MetroComboBox cBoxCategory;
        private MetroFramework.Controls.MetroTile btn_save;
        private MetroFramework.Controls.MetroTile btn_clear;
    }
}