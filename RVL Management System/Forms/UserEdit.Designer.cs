namespace RVL_Management_System
{
    partial class Frm_UserEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxSearchBy = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cBoxRole = new MetroFramework.Controls.MetroComboBox();
            this.txt_lid = new MetroFramework.Controls.MetroTextBox();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.txt_uid = new MetroFramework.Controls.MetroTextBox();
            this.btn_clear = new MetroFramework.Controls.MetroTile();
            this.btn_update = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_level = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_confirmPw = new MetroFramework.Controls.MetroTextBox();
            this.txt_pw = new MetroFramework.Controls.MetroTextBox();
            this.txt_un = new MetroFramework.Controls.MetroTextBox();
            this.txt_search = new MetroFramework.Controls.MetroTextBox();
            this.txt_fName = new MetroFramework.Controls.MetroTextBox();
            this.GridView = new MetroFramework.Controls.MetroGrid();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cBoxSearchBy);
            this.GroupBox1.Controls.Add(this.metroLabel3);
            this.GroupBox1.Controls.Add(this.cBoxRole);
            this.GroupBox1.Controls.Add(this.txt_lid);
            this.GroupBox1.Controls.Add(this.txt_email);
            this.GroupBox1.Controls.Add(this.txt_uid);
            this.GroupBox1.Controls.Add(this.btn_clear);
            this.GroupBox1.Controls.Add(this.btn_update);
            this.GroupBox1.Controls.Add(this.metroLabel2);
            this.GroupBox1.Controls.Add(this.txt_level);
            this.GroupBox1.Controls.Add(this.metroLabel1);
            this.GroupBox1.Controls.Add(this.txt_confirmPw);
            this.GroupBox1.Controls.Add(this.txt_pw);
            this.GroupBox1.Controls.Add(this.txt_un);
            this.GroupBox1.Controls.Add(this.txt_search);
            this.GroupBox1.Controls.Add(this.txt_fName);
            this.GroupBox1.Controls.Add(this.GridView);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(21, 68);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(638, 412);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "User Information";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // cBoxSearchBy
            // 
            this.cBoxSearchBy.FormattingEnabled = true;
            this.cBoxSearchBy.ItemHeight = 23;
            this.cBoxSearchBy.Items.AddRange(new object[] {
            "User Id",
            "Full Name"});
            this.cBoxSearchBy.Location = new System.Drawing.Point(94, 34);
            this.cBoxSearchBy.Name = "cBoxSearchBy";
            this.cBoxSearchBy.Size = new System.Drawing.Size(164, 29);
            this.cBoxSearchBy.TabIndex = 46;
            this.cBoxSearchBy.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 37);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 45;
            this.metroLabel3.Text = "Search By:";
            // 
            // cBoxRole
            // 
            this.cBoxRole.FormattingEnabled = true;
            this.cBoxRole.ItemHeight = 23;
            this.cBoxRole.Location = new System.Drawing.Point(94, 71);
            this.cBoxRole.Name = "cBoxRole";
            this.cBoxRole.Size = new System.Drawing.Size(165, 29);
            this.cBoxRole.TabIndex = 44;
            this.cBoxRole.UseSelectable = true;
            this.cBoxRole.SelectedIndexChanged += new System.EventHandler(this.cBoxRole_SelectedIndexChanged_2);
            // 
            // txt_lid
            // 
            // 
            // 
            // 
            this.txt_lid.CustomButton.Image = null;
            this.txt_lid.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_lid.CustomButton.Name = "";
            this.txt_lid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_lid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_lid.CustomButton.TabIndex = 1;
            this.txt_lid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_lid.CustomButton.UseSelectable = true;
            this.txt_lid.CustomButton.Visible = false;
            this.txt_lid.Lines = new string[0];
            this.txt_lid.Location = new System.Drawing.Point(454, 72);
            this.txt_lid.MaxLength = 32767;
            this.txt_lid.Name = "txt_lid";
            this.txt_lid.PasswordChar = '\0';
            this.txt_lid.PromptText = "Login ID";
            this.txt_lid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_lid.SelectedText = "";
            this.txt_lid.SelectionLength = 0;
            this.txt_lid.SelectionStart = 0;
            this.txt_lid.ShortcutsEnabled = true;
            this.txt_lid.Size = new System.Drawing.Size(165, 23);
            this.txt_lid.TabIndex = 43;
            this.txt_lid.UseSelectable = true;
            this.txt_lid.WaterMark = "Login ID";
            this.txt_lid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_lid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_email
            // 
            // 
            // 
            // 
            this.txt_email.CustomButton.Image = null;
            this.txt_email.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_email.CustomButton.Name = "";
            this.txt_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_email.CustomButton.TabIndex = 1;
            this.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_email.CustomButton.UseSelectable = true;
            this.txt_email.CustomButton.Visible = false;
            this.txt_email.Lines = new string[0];
            this.txt_email.Location = new System.Drawing.Point(455, 109);
            this.txt_email.MaxLength = 32767;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PromptText = "Email";
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(165, 23);
            this.txt_email.TabIndex = 42;
            this.txt_email.UseSelectable = true;
            this.txt_email.WaterMark = "Email";
            this.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_uid
            // 
            // 
            // 
            // 
            this.txt_uid.CustomButton.Image = null;
            this.txt_uid.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_uid.CustomButton.Name = "";
            this.txt_uid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_uid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_uid.CustomButton.TabIndex = 1;
            this.txt_uid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_uid.CustomButton.UseSelectable = true;
            this.txt_uid.CustomButton.Visible = false;
            this.txt_uid.Lines = new string[0];
            this.txt_uid.Location = new System.Drawing.Point(453, 36);
            this.txt_uid.MaxLength = 32767;
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.PasswordChar = '\0';
            this.txt_uid.PromptText = "User ID";
            this.txt_uid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_uid.SelectedText = "";
            this.txt_uid.SelectionLength = 0;
            this.txt_uid.SelectionStart = 0;
            this.txt_uid.ShortcutsEnabled = true;
            this.txt_uid.Size = new System.Drawing.Size(165, 23);
            this.txt_uid.TabIndex = 41;
            this.txt_uid.UseSelectable = true;
            this.txt_uid.WaterMark = "User ID";
            this.txt_uid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_uid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_clear
            // 
            this.btn_clear.ActiveControl = null;
            this.btn_clear.Location = new System.Drawing.Point(459, 342);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(77, 58);
            this.btn_clear.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_clear.TabIndex = 40;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.TileImage = global::RVL_Management_System.Properties.Resources.cancel;
            this.btn_clear.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseSelectable = true;
            this.btn_clear.UseTileImage = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_update
            // 
            this.btn_update.ActiveControl = null;
            this.btn_update.Location = new System.Drawing.Point(542, 342);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(86, 58);
            this.btn_update.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_update.TabIndex = 39;
            this.btn_update.Text = "Update";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.TileImage = global::RVL_Management_System.Properties.Resources.edit_1;
            this.btn_update.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.UseSelectable = true;
            this.btn_update.UseTileImage = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(294, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Privilege level:";
            // 
            // txt_level
            // 
            // 
            // 
            // 
            this.txt_level.CustomButton.Image = null;
            this.txt_level.CustomButton.Location = new System.Drawing.Point(5, 1);
            this.txt_level.CustomButton.Name = "";
            this.txt_level.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_level.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_level.CustomButton.TabIndex = 1;
            this.txt_level.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_level.CustomButton.UseSelectable = true;
            this.txt_level.CustomButton.Visible = false;
            this.txt_level.Enabled = false;
            this.txt_level.Lines = new string[0];
            this.txt_level.Location = new System.Drawing.Point(390, 73);
            this.txt_level.MaxLength = 32767;
            this.txt_level.Name = "txt_level";
            this.txt_level.PasswordChar = '\0';
            this.txt_level.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_level.SelectedText = "";
            this.txt_level.SelectionLength = 0;
            this.txt_level.SelectionStart = 0;
            this.txt_level.ShortcutsEnabled = true;
            this.txt_level.Size = new System.Drawing.Size(25, 21);
            this.txt_level.TabIndex = 27;
            this.txt_level.UseSelectable = true;
            this.txt_level.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_level.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Role:";
            // 
            // txt_confirmPw
            // 
            // 
            // 
            // 
            this.txt_confirmPw.CustomButton.Image = null;
            this.txt_confirmPw.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_confirmPw.CustomButton.Name = "";
            this.txt_confirmPw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_confirmPw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_confirmPw.CustomButton.TabIndex = 1;
            this.txt_confirmPw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_confirmPw.CustomButton.UseSelectable = true;
            this.txt_confirmPw.CustomButton.Visible = false;
            this.txt_confirmPw.Lines = new string[0];
            this.txt_confirmPw.Location = new System.Drawing.Point(268, 142);
            this.txt_confirmPw.MaxLength = 32767;
            this.txt_confirmPw.Name = "txt_confirmPw";
            this.txt_confirmPw.PasswordChar = '*';
            this.txt_confirmPw.PromptText = "Confirm Password";
            this.txt_confirmPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_confirmPw.SelectedText = "";
            this.txt_confirmPw.SelectionLength = 0;
            this.txt_confirmPw.SelectionStart = 0;
            this.txt_confirmPw.ShortcutsEnabled = true;
            this.txt_confirmPw.Size = new System.Drawing.Size(165, 23);
            this.txt_confirmPw.TabIndex = 24;
            this.txt_confirmPw.UseSelectable = true;
            this.txt_confirmPw.WaterMark = "Confirm Password";
            this.txt_confirmPw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_confirmPw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_pw
            // 
            // 
            // 
            // 
            this.txt_pw.CustomButton.Image = null;
            this.txt_pw.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_pw.CustomButton.Name = "";
            this.txt_pw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_pw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pw.CustomButton.TabIndex = 1;
            this.txt_pw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pw.CustomButton.UseSelectable = true;
            this.txt_pw.CustomButton.Visible = false;
            this.txt_pw.Lines = new string[0];
            this.txt_pw.Location = new System.Drawing.Point(266, 110);
            this.txt_pw.MaxLength = 32767;
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.PromptText = "Password";
            this.txt_pw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pw.SelectedText = "";
            this.txt_pw.SelectionLength = 0;
            this.txt_pw.SelectionStart = 0;
            this.txt_pw.ShortcutsEnabled = true;
            this.txt_pw.Size = new System.Drawing.Size(165, 23);
            this.txt_pw.TabIndex = 23;
            this.txt_pw.UseSelectable = true;
            this.txt_pw.WaterMark = "Password";
            this.txt_pw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_pw.Click += new System.EventHandler(this.txt_pw_Click);
            // 
            // txt_un
            // 
            // 
            // 
            // 
            this.txt_un.CustomButton.Image = null;
            this.txt_un.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_un.CustomButton.Name = "";
            this.txt_un.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_un.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_un.CustomButton.TabIndex = 1;
            this.txt_un.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_un.CustomButton.UseSelectable = true;
            this.txt_un.CustomButton.Visible = false;
            this.txt_un.Lines = new string[0];
            this.txt_un.Location = new System.Drawing.Point(76, 142);
            this.txt_un.MaxLength = 32767;
            this.txt_un.Name = "txt_un";
            this.txt_un.PasswordChar = '\0';
            this.txt_un.PromptText = "Username";
            this.txt_un.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_un.SelectedText = "";
            this.txt_un.SelectionLength = 0;
            this.txt_un.SelectionStart = 0;
            this.txt_un.ShortcutsEnabled = true;
            this.txt_un.Size = new System.Drawing.Size(165, 23);
            this.txt_un.TabIndex = 22;
            this.txt_un.UseSelectable = true;
            this.txt_un.WaterMark = "Username";
            this.txt_un.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_un.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_un.Click += new System.EventHandler(this.txt_un_Click);
            // 
            // txt_search
            // 
            // 
            // 
            // 
            this.txt_search.CustomButton.BackgroundImage = global::RVL_Management_System.Properties.Resources.magnifier;
            this.txt_search.CustomButton.Image = global::RVL_Management_System.Properties.Resources.magnifier;
            this.txt_search.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_search.CustomButton.Name = "";
            this.txt_search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search.CustomButton.TabIndex = 1;
            this.txt_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search.CustomButton.UseSelectable = true;
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(277, 36);
            this.txt_search.MaxLength = 32767;
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PromptText = "Search";
            this.txt_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.ShortcutsEnabled = true;
            this.txt_search.ShowButton = true;
            this.txt_search.ShowClearButton = true;
            this.txt_search.Size = new System.Drawing.Size(165, 23);
            this.txt_search.TabIndex = 21;
            this.txt_search.UseSelectable = true;
            this.txt_search.WaterMark = "Search";
            this.txt_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_search.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.metroTextBox2_ButtonClick);
            this.txt_search.ClearClicked += new MetroFramework.Controls.MetroTextBox.LUClear(this.txt_search_ClearClicked);
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // txt_fName
            // 
            // 
            // 
            // 
            this.txt_fName.CustomButton.Image = null;
            this.txt_fName.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_fName.CustomButton.Name = "";
            this.txt_fName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_fName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_fName.CustomButton.TabIndex = 1;
            this.txt_fName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_fName.CustomButton.UseSelectable = true;
            this.txt_fName.CustomButton.Visible = false;
            this.txt_fName.Lines = new string[0];
            this.txt_fName.Location = new System.Drawing.Point(75, 111);
            this.txt_fName.MaxLength = 32767;
            this.txt_fName.Name = "txt_fName";
            this.txt_fName.PasswordChar = '\0';
            this.txt_fName.PromptText = "Full name";
            this.txt_fName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_fName.SelectedText = "";
            this.txt_fName.SelectionLength = 0;
            this.txt_fName.SelectionStart = 0;
            this.txt_fName.ShortcutsEnabled = true;
            this.txt_fName.Size = new System.Drawing.Size(165, 23);
            this.txt_fName.TabIndex = 20;
            this.txt_fName.UseSelectable = true;
            this.txt_fName.WaterMark = "Full name";
            this.txt_fName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_fName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_fName.Click += new System.EventHandler(this.txt_fName_Click);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridView.Location = new System.Drawing.Point(6, 176);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(625, 155);
            this.GridView.TabIndex = 13;
            this.GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellContentClick);
            this.GridView.SelectionChanged += new System.EventHandler(this.GridView_SelectionChanged);
            // 
            // Frm_UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 496);
            this.Controls.Add(this.GroupBox1);
            this.MaximizeBox = false;
            this.Name = "Frm_UserEdit";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Edit/Update user information";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Frm_UserEdit_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private MetroFramework.Controls.MetroGrid GridView;
        private MetroFramework.Controls.MetroTextBox txt_search;
        private MetroFramework.Controls.MetroTextBox txt_fName;
        private MetroFramework.Controls.MetroTextBox txt_confirmPw;
        private MetroFramework.Controls.MetroTextBox txt_pw;
        private MetroFramework.Controls.MetroTextBox txt_un;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_level;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btn_clear;
        private MetroFramework.Controls.MetroTile btn_update;
        private MetroFramework.Controls.MetroTextBox txt_uid;
        private MetroFramework.Controls.MetroTextBox txt_email;
        private MetroFramework.Controls.MetroTextBox txt_lid;
        private MetroFramework.Controls.MetroComboBox cBoxRole;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cBoxSearchBy;
    }
}