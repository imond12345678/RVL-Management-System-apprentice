namespace RVL_Management_System.Forms
{
    partial class SocialMediaAdd
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
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_apn = new MetroFramework.Controls.MetroTextBox();
            this.txt_current = new MetroFramework.Controls.MetroTextBox();
            this.txt_updatePrice = new MetroFramework.Controls.MetroTextBox();
            this.txt_title = new MetroFramework.Controls.MetroTextBox();
            this.txt_socialmedia = new MetroFramework.Controls.MetroTextBox();
            this.txt_hashtags = new MetroFramework.Controls.MetroTextBox();
            this.txt_schedule = new MetroFramework.Controls.MetroTextBox();
            this.cBoxPreApproved = new MetroFramework.Controls.MetroComboBox();
            this.cBoxStatus = new MetroFramework.Controls.MetroComboBox();
            this.txt_addiotnalNotes = new MetroFramework.Controls.MetroTextBox();
            this.GridView = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new MetroFramework.Controls.MetroTile();
            this.btn_save = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(345, 45);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(94, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Pre-Approved";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(472, 45);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(43, 19);
            this.metroLabel9.TabIndex = 8;
            this.metroLabel9.Text = "Status";
            // 
            // txt_apn
            // 
            // 
            // 
            // 
            this.txt_apn.CustomButton.Image = null;
            this.txt_apn.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txt_apn.CustomButton.Name = "";
            this.txt_apn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_apn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_apn.CustomButton.TabIndex = 1;
            this.txt_apn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_apn.CustomButton.UseSelectable = true;
            this.txt_apn.CustomButton.Visible = false;
            this.txt_apn.Lines = new string[0];
            this.txt_apn.Location = new System.Drawing.Point(6, 19);
            this.txt_apn.MaxLength = 32767;
            this.txt_apn.Name = "txt_apn";
            this.txt_apn.PasswordChar = '\0';
            this.txt_apn.PromptText = "APN ID";
            this.txt_apn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_apn.SelectedText = "";
            this.txt_apn.SelectionLength = 0;
            this.txt_apn.SelectionStart = 0;
            this.txt_apn.ShortcutsEnabled = true;
            this.txt_apn.Size = new System.Drawing.Size(163, 23);
            this.txt_apn.TabIndex = 10;
            this.txt_apn.UseSelectable = true;
            this.txt_apn.WaterMark = "APN ID";
            this.txt_apn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_apn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_apn.Click += new System.EventHandler(this.txt_apn_Click);
            this.txt_apn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apn_KeyPress);
            // 
            // txt_current
            // 
            // 
            // 
            // 
            this.txt_current.CustomButton.Image = null;
            this.txt_current.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txt_current.CustomButton.Name = "";
            this.txt_current.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_current.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_current.CustomButton.TabIndex = 1;
            this.txt_current.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_current.CustomButton.UseSelectable = true;
            this.txt_current.CustomButton.Visible = false;
            this.txt_current.Lines = new string[0];
            this.txt_current.Location = new System.Drawing.Point(184, 19);
            this.txt_current.MaxLength = 32767;
            this.txt_current.Name = "txt_current";
            this.txt_current.PasswordChar = '\0';
            this.txt_current.PromptText = "Current Market Value";
            this.txt_current.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_current.SelectedText = "";
            this.txt_current.SelectionLength = 0;
            this.txt_current.SelectionStart = 0;
            this.txt_current.ShortcutsEnabled = true;
            this.txt_current.Size = new System.Drawing.Size(132, 23);
            this.txt_current.TabIndex = 11;
            this.txt_current.UseSelectable = true;
            this.txt_current.WaterMark = "Current Market Value";
            this.txt_current.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_current.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_updatePrice
            // 
            // 
            // 
            // 
            this.txt_updatePrice.CustomButton.Image = null;
            this.txt_updatePrice.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txt_updatePrice.CustomButton.Name = "";
            this.txt_updatePrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_updatePrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_updatePrice.CustomButton.TabIndex = 1;
            this.txt_updatePrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_updatePrice.CustomButton.UseSelectable = true;
            this.txt_updatePrice.CustomButton.Visible = false;
            this.txt_updatePrice.Lines = new string[0];
            this.txt_updatePrice.Location = new System.Drawing.Point(322, 19);
            this.txt_updatePrice.MaxLength = 32767;
            this.txt_updatePrice.Name = "txt_updatePrice";
            this.txt_updatePrice.PasswordChar = '\0';
            this.txt_updatePrice.PromptText = "Update Price";
            this.txt_updatePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_updatePrice.SelectedText = "";
            this.txt_updatePrice.SelectionLength = 0;
            this.txt_updatePrice.SelectionStart = 0;
            this.txt_updatePrice.ShortcutsEnabled = true;
            this.txt_updatePrice.Size = new System.Drawing.Size(132, 23);
            this.txt_updatePrice.TabIndex = 12;
            this.txt_updatePrice.UseSelectable = true;
            this.txt_updatePrice.WaterMark = "Update Price";
            this.txt_updatePrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_updatePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_title
            // 
            // 
            // 
            // 
            this.txt_title.CustomButton.Image = null;
            this.txt_title.CustomButton.Location = new System.Drawing.Point(304, 1);
            this.txt_title.CustomButton.Name = "";
            this.txt_title.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_title.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_title.CustomButton.TabIndex = 1;
            this.txt_title.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_title.CustomButton.UseSelectable = true;
            this.txt_title.CustomButton.Visible = false;
            this.txt_title.Lines = new string[0];
            this.txt_title.Location = new System.Drawing.Point(460, 19);
            this.txt_title.MaxLength = 32767;
            this.txt_title.Name = "txt_title";
            this.txt_title.PasswordChar = '\0';
            this.txt_title.PromptText = "Title";
            this.txt_title.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_title.SelectedText = "";
            this.txt_title.SelectionLength = 0;
            this.txt_title.SelectionStart = 0;
            this.txt_title.ShortcutsEnabled = true;
            this.txt_title.Size = new System.Drawing.Size(326, 23);
            this.txt_title.TabIndex = 13;
            this.txt_title.UseSelectable = true;
            this.txt_title.WaterMark = "Title";
            this.txt_title.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_title.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_socialmedia
            // 
            // 
            // 
            // 
            this.txt_socialmedia.CustomButton.Image = null;
            this.txt_socialmedia.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txt_socialmedia.CustomButton.Name = "";
            this.txt_socialmedia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_socialmedia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_socialmedia.CustomButton.TabIndex = 1;
            this.txt_socialmedia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_socialmedia.CustomButton.UseSelectable = true;
            this.txt_socialmedia.CustomButton.Visible = false;
            this.txt_socialmedia.Lines = new string[0];
            this.txt_socialmedia.Location = new System.Drawing.Point(792, 19);
            this.txt_socialmedia.MaxLength = 32767;
            this.txt_socialmedia.Name = "txt_socialmedia";
            this.txt_socialmedia.PasswordChar = '\0';
            this.txt_socialmedia.PromptText = "Social Media Notes";
            this.txt_socialmedia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_socialmedia.SelectedText = "";
            this.txt_socialmedia.SelectionLength = 0;
            this.txt_socialmedia.SelectionStart = 0;
            this.txt_socialmedia.ShortcutsEnabled = true;
            this.txt_socialmedia.Size = new System.Drawing.Size(163, 23);
            this.txt_socialmedia.TabIndex = 14;
            this.txt_socialmedia.UseSelectable = true;
            this.txt_socialmedia.WaterMark = "Social Media Notes";
            this.txt_socialmedia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_socialmedia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_hashtags
            // 
            // 
            // 
            // 
            this.txt_hashtags.CustomButton.Image = null;
            this.txt_hashtags.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txt_hashtags.CustomButton.Name = "";
            this.txt_hashtags.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_hashtags.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_hashtags.CustomButton.TabIndex = 1;
            this.txt_hashtags.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_hashtags.CustomButton.UseSelectable = true;
            this.txt_hashtags.CustomButton.Visible = false;
            this.txt_hashtags.Lines = new string[0];
            this.txt_hashtags.Location = new System.Drawing.Point(6, 67);
            this.txt_hashtags.MaxLength = 32767;
            this.txt_hashtags.Name = "txt_hashtags";
            this.txt_hashtags.PasswordChar = '\0';
            this.txt_hashtags.PromptText = "Hashtags to use";
            this.txt_hashtags.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_hashtags.SelectedText = "";
            this.txt_hashtags.SelectionLength = 0;
            this.txt_hashtags.SelectionStart = 0;
            this.txt_hashtags.ShortcutsEnabled = true;
            this.txt_hashtags.Size = new System.Drawing.Size(163, 23);
            this.txt_hashtags.TabIndex = 15;
            this.txt_hashtags.UseSelectable = true;
            this.txt_hashtags.WaterMark = "Hashtags to use";
            this.txt_hashtags.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_hashtags.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_schedule
            // 
            // 
            // 
            // 
            this.txt_schedule.CustomButton.Image = null;
            this.txt_schedule.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txt_schedule.CustomButton.Name = "";
            this.txt_schedule.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_schedule.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_schedule.CustomButton.TabIndex = 1;
            this.txt_schedule.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_schedule.CustomButton.UseSelectable = true;
            this.txt_schedule.CustomButton.Visible = false;
            this.txt_schedule.Lines = new string[0];
            this.txt_schedule.Location = new System.Drawing.Point(184, 67);
            this.txt_schedule.MaxLength = 32767;
            this.txt_schedule.Name = "txt_schedule";
            this.txt_schedule.PasswordChar = '\0';
            this.txt_schedule.PromptText = "Schedule to be posted";
            this.txt_schedule.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_schedule.SelectedText = "";
            this.txt_schedule.SelectionLength = 0;
            this.txt_schedule.SelectionStart = 0;
            this.txt_schedule.ShortcutsEnabled = true;
            this.txt_schedule.Size = new System.Drawing.Size(155, 23);
            this.txt_schedule.TabIndex = 16;
            this.txt_schedule.UseSelectable = true;
            this.txt_schedule.WaterMark = "Schedule to be posted";
            this.txt_schedule.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_schedule.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cBoxPreApproved
            // 
            this.cBoxPreApproved.FormattingEnabled = true;
            this.cBoxPreApproved.ItemHeight = 23;
            this.cBoxPreApproved.Items.AddRange(new object[] {
            "Gil",
            "Luke"});
            this.cBoxPreApproved.Location = new System.Drawing.Point(345, 67);
            this.cBoxPreApproved.Name = "cBoxPreApproved";
            this.cBoxPreApproved.Size = new System.Drawing.Size(121, 29);
            this.cBoxPreApproved.TabIndex = 17;
            this.cBoxPreApproved.UseSelectable = true;
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.ItemHeight = 23;
            this.cBoxStatus.Items.AddRange(new object[] {
            "Complete",
            "Incomplete",
            "Changes has to be made"});
            this.cBoxStatus.Location = new System.Drawing.Point(472, 67);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(121, 29);
            this.cBoxStatus.TabIndex = 18;
            this.cBoxStatus.UseSelectable = true;
            // 
            // txt_addiotnalNotes
            // 
            // 
            // 
            // 
            this.txt_addiotnalNotes.CustomButton.Image = null;
            this.txt_addiotnalNotes.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txt_addiotnalNotes.CustomButton.Name = "";
            this.txt_addiotnalNotes.CustomButton.Size = new System.Drawing.Size(91, 91);
            this.txt_addiotnalNotes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_addiotnalNotes.CustomButton.TabIndex = 1;
            this.txt_addiotnalNotes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_addiotnalNotes.CustomButton.UseSelectable = true;
            this.txt_addiotnalNotes.CustomButton.Visible = false;
            this.txt_addiotnalNotes.Lines = new string[0];
            this.txt_addiotnalNotes.Location = new System.Drawing.Point(632, 45);
            this.txt_addiotnalNotes.MaxLength = 32767;
            this.txt_addiotnalNotes.Multiline = true;
            this.txt_addiotnalNotes.Name = "txt_addiotnalNotes";
            this.txt_addiotnalNotes.PasswordChar = '\0';
            this.txt_addiotnalNotes.PromptText = "Additional Notes";
            this.txt_addiotnalNotes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_addiotnalNotes.SelectedText = "";
            this.txt_addiotnalNotes.SelectionLength = 0;
            this.txt_addiotnalNotes.SelectionStart = 0;
            this.txt_addiotnalNotes.ShortcutsEnabled = true;
            this.txt_addiotnalNotes.Size = new System.Drawing.Size(323, 93);
            this.txt_addiotnalNotes.TabIndex = 19;
            this.txt_addiotnalNotes.UseSelectable = true;
            this.txt_addiotnalNotes.WaterMark = "Additional Notes";
            this.txt_addiotnalNotes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_addiotnalNotes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridView.Location = new System.Drawing.Point(23, 230);
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
            this.GridView.Size = new System.Drawing.Size(981, 194);
            this.GridView.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.txt_apn);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.txt_current);
            this.groupBox1.Controls.Add(this.txt_addiotnalNotes);
            this.groupBox1.Controls.Add(this.txt_updatePrice);
            this.groupBox1.Controls.Add(this.cBoxStatus);
            this.groupBox1.Controls.Add(this.txt_title);
            this.groupBox1.Controls.Add(this.cBoxPreApproved);
            this.groupBox1.Controls.Add(this.txt_socialmedia);
            this.groupBox1.Controls.Add(this.txt_schedule);
            this.groupBox1.Controls.Add(this.txt_hashtags);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 161);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.ActiveControl = null;
            this.btn_clear.Location = new System.Drawing.Point(6, 96);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(77, 58);
            this.btn_clear.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_clear.TabIndex = 21;
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
            this.btn_save.Location = new System.Drawing.Point(89, 96);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 58);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.TileImage = global::RVL_Management_System.Properties.Resources.plus_1;
            this.btn_save.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseSelectable = true;
            this.btn_save.UseTileImage = true;
            this.btn_save.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // SocialMediaAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SocialMediaAdd";
            this.Resizable = false;
            this.Text = "Add Social Media Infromation";
            this.Load += new System.EventHandler(this.Frm_SocialMediaAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_apn;
        private MetroFramework.Controls.MetroTextBox txt_current;
        private MetroFramework.Controls.MetroTextBox txt_updatePrice;
        private MetroFramework.Controls.MetroTextBox txt_title;
        private MetroFramework.Controls.MetroTextBox txt_socialmedia;
        private MetroFramework.Controls.MetroTextBox txt_hashtags;
        private MetroFramework.Controls.MetroTextBox txt_schedule;
        private MetroFramework.Controls.MetroComboBox cBoxPreApproved;
        private MetroFramework.Controls.MetroComboBox cBoxStatus;
        private MetroFramework.Controls.MetroTextBox txt_addiotnalNotes;
        private MetroFramework.Controls.MetroGrid GridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile btn_clear;
        private MetroFramework.Controls.MetroTile btn_save;
    }
}