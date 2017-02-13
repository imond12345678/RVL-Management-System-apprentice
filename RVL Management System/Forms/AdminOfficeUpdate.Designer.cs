namespace RVL_Management_System.Forms
{
    partial class AdminOfficeUpdate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cBoxCategory = new MetroFramework.Controls.MetroComboBox();
            this.txt_county = new MetroFramework.Controls.MetroTextBox();
            this.txt_address = new MetroFramework.Controls.MetroTextBox();
            this.txt_phoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.txt_fullName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.GridView = new MetroFramework.Controls.MetroGrid();
            this.txt_search = new MetroFramework.Controls.MetroTextBox();
            this.cBoxSearchBy = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txt_acid = new MetroFramework.Controls.MetroTextBox();
            this.btn_update = new MetroFramework.Controls.MetroTile();
            this.btn_clear = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxCategory
            // 
            this.cBoxCategory.FormattingEnabled = true;
            this.cBoxCategory.ItemHeight = 23;
            this.cBoxCategory.Items.AddRange(new object[] {
            "Notary Public",
            "County Recorder",
            "County Treasurer"});
            this.cBoxCategory.Location = new System.Drawing.Point(502, 165);
            this.cBoxCategory.Name = "cBoxCategory";
            this.cBoxCategory.Size = new System.Drawing.Size(218, 29);
            this.cBoxCategory.TabIndex = 28;
            this.cBoxCategory.UseSelectable = true;
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
            this.txt_county.Location = new System.Drawing.Point(275, 146);
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
            this.txt_county.TabIndex = 25;
            this.txt_county.UseSelectable = true;
            this.txt_county.WaterMark = "County";
            this.txt_county.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_county.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txt_address.Location = new System.Drawing.Point(23, 146);
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
            this.txt_address.TabIndex = 24;
            this.txt_address.UseSelectable = true;
            this.txt_address.WaterMark = "Address";
            this.txt_address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txt_phoneNumber.Location = new System.Drawing.Point(502, 117);
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
            this.txt_phoneNumber.TabIndex = 23;
            this.txt_phoneNumber.UseSelectable = true;
            this.txt_phoneNumber.WaterMark = "Phone number";
            this.txt_phoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_phoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txt_email.Location = new System.Drawing.Point(275, 117);
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
            this.txt_email.TabIndex = 22;
            this.txt_email.UseSelectable = true;
            this.txt_email.WaterMark = "Email";
            this.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txt_fullName.Location = new System.Drawing.Point(23, 117);
            this.txt_fullName.MaxLength = 32767;
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.PasswordChar = '\0';
            this.txt_fullName.PromptText = "Full name";
            this.txt_fullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_fullName.SelectedText = "";
            this.txt_fullName.SelectionLength = 0;
            this.txt_fullName.SelectionStart = 0;
            this.txt_fullName.ShortcutsEnabled = true;
            this.txt_fullName.Size = new System.Drawing.Size(218, 23);
            this.txt_fullName.TabIndex = 21;
            this.txt_fullName.UseSelectable = true;
            this.txt_fullName.WaterMark = "Full name";
            this.txt_fullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_fullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(502, 143);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(64, 19);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Category";
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridView.GridColor = System.Drawing.Color.LightCyan;
            this.GridView.Location = new System.Drawing.Point(23, 284);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(697, 172);
            this.GridView.TabIndex = 29;
            this.GridView.SelectionChanged += new System.EventHandler(this.GridView_SelectionChanged);
            // 
            // txt_search
            // 
            // 
            // 
            // 
            this.txt_search.CustomButton.Image = null;
            this.txt_search.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txt_search.CustomButton.Name = "";
            this.txt_search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search.CustomButton.TabIndex = 1;
            this.txt_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search.CustomButton.UseSelectable = true;
            this.txt_search.CustomButton.Visible = false;
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(275, 82);
            this.txt_search.MaxLength = 32767;
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PromptText = "Search";
            this.txt_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.ShortcutsEnabled = true;
            this.txt_search.Size = new System.Drawing.Size(218, 23);
            this.txt_search.TabIndex = 31;
            this.txt_search.UseSelectable = true;
            this.txt_search.WaterMark = "Search";
            this.txt_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            // 
            // cBoxSearchBy
            // 
            this.cBoxSearchBy.FormattingEnabled = true;
            this.cBoxSearchBy.ItemHeight = 23;
            this.cBoxSearchBy.Items.AddRange(new object[] {
            "Admin Contact ID",
            "Full name"});
            this.cBoxSearchBy.Location = new System.Drawing.Point(23, 82);
            this.cBoxSearchBy.Name = "cBoxSearchBy";
            this.cBoxSearchBy.Size = new System.Drawing.Size(218, 29);
            this.cBoxSearchBy.TabIndex = 32;
            this.cBoxSearchBy.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 60);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(69, 19);
            this.metroLabel8.TabIndex = 33;
            this.metroLabel8.Text = "Search By:";
            // 
            // txt_acid
            // 
            // 
            // 
            // 
            this.txt_acid.CustomButton.Image = null;
            this.txt_acid.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txt_acid.CustomButton.Name = "";
            this.txt_acid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_acid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_acid.CustomButton.TabIndex = 1;
            this.txt_acid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_acid.CustomButton.UseSelectable = true;
            this.txt_acid.CustomButton.Visible = false;
            this.txt_acid.Enabled = false;
            this.txt_acid.Lines = new string[0];
            this.txt_acid.Location = new System.Drawing.Point(502, 82);
            this.txt_acid.MaxLength = 32767;
            this.txt_acid.Name = "txt_acid";
            this.txt_acid.PasswordChar = '\0';
            this.txt_acid.PromptText = "ACID";
            this.txt_acid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_acid.SelectedText = "";
            this.txt_acid.SelectionLength = 0;
            this.txt_acid.SelectionStart = 0;
            this.txt_acid.ShortcutsEnabled = true;
            this.txt_acid.Size = new System.Drawing.Size(218, 23);
            this.txt_acid.TabIndex = 35;
            this.txt_acid.UseSelectable = true;
            this.txt_acid.WaterMark = "ACID";
            this.txt_acid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_acid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_update
            // 
            this.btn_update.ActiveControl = null;
            this.btn_update.Location = new System.Drawing.Point(634, 213);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(86, 58);
            this.btn_update.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_update.TabIndex = 37;
            this.btn_update.Text = "Update";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.TileImage = global::RVL_Management_System.Properties.Resources.edit_1;
            this.btn_update.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.UseSelectable = true;
            this.btn_update.UseTileImage = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_clear
            // 
            this.btn_clear.ActiveControl = null;
            this.btn_clear.Location = new System.Drawing.Point(551, 213);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(77, 58);
            this.btn_clear.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_clear.TabIndex = 38;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.TileImage = global::RVL_Management_System.Properties.Resources.cancel;
            this.btn_clear.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseSelectable = true;
            this.btn_clear.UseTileImage = true;
            // 
            // AdminOfficeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 484);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_acid);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.cBoxSearchBy);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.cBoxCategory);
            this.Controls.Add(this.txt_county);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_fullName);
            this.Controls.Add(this.metroLabel6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminOfficeUpdate";
            this.Resizable = false;
            this.Text = "Admin Office Contact List Update";
            this.Load += new System.EventHandler(this.Frm_AdminOfficeUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cBoxCategory;
        private MetroFramework.Controls.MetroTextBox txt_county;
        private MetroFramework.Controls.MetroTextBox txt_address;
        private MetroFramework.Controls.MetroTextBox txt_phoneNumber;
        private MetroFramework.Controls.MetroTextBox txt_email;
        private MetroFramework.Controls.MetroTextBox txt_fullName;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroGrid GridView;
        private MetroFramework.Controls.MetroTextBox txt_search;
        private MetroFramework.Controls.MetroComboBox cBoxSearchBy;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txt_acid;
        private MetroFramework.Controls.MetroTile btn_update;
        private MetroFramework.Controls.MetroTile btn_clear;
    }
}