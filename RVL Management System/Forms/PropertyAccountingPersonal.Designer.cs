namespace RVL_Management_System.Forms
{
    partial class PropertyAccountingPersonal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_billedTo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_memo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.cBoxBilled = new MetroFramework.Controls.MetroComboBox();
            this.cBoxAccount = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtDateRecorded = new MetroFramework.Controls.MetroDateTime();
            this.lbl_total = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_notes = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_amount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.btn_save = new MetroFramework.Controls.MetroTile();
            this.btn_cancel = new MetroFramework.Controls.MetroTile();
            this.GridView = new MetroFramework.Controls.MetroGrid();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.lbl_amount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_billedTo);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txt_memo);
            this.groupBox1.Controls.Add(this.metroLabel25);
            this.groupBox1.Controls.Add(this.cBoxBilled);
            this.groupBox1.Controls.Add(this.cBoxAccount);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 195);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_billedTo
            // 
            // 
            // 
            // 
            this.txt_billedTo.CustomButton.Image = null;
            this.txt_billedTo.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txt_billedTo.CustomButton.Name = "";
            this.txt_billedTo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_billedTo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_billedTo.CustomButton.TabIndex = 1;
            this.txt_billedTo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_billedTo.CustomButton.UseSelectable = true;
            this.txt_billedTo.CustomButton.Visible = false;
            this.txt_billedTo.Lines = new string[0];
            this.txt_billedTo.Location = new System.Drawing.Point(144, 93);
            this.txt_billedTo.MaxLength = 32767;
            this.txt_billedTo.Name = "txt_billedTo";
            this.txt_billedTo.PasswordChar = '\0';
            this.txt_billedTo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_billedTo.SelectedText = "";
            this.txt_billedTo.SelectionLength = 0;
            this.txt_billedTo.SelectionStart = 0;
            this.txt_billedTo.ShortcutsEnabled = true;
            this.txt_billedTo.Size = new System.Drawing.Size(223, 23);
            this.txt_billedTo.TabIndex = 62;
            this.txt_billedTo.UseSelectable = true;
            this.txt_billedTo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_billedTo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_billedTo.TextChanged += new System.EventHandler(this.txt_billedTo_TextChanged);
            this.txt_billedTo.Click += new System.EventHandler(this.txt_billedTo_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(77, 97);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.TabIndex = 61;
            this.metroLabel3.Text = "Billed To:";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // txt_memo
            // 
            // 
            // 
            // 
            this.txt_memo.CustomButton.Image = null;
            this.txt_memo.CustomButton.Location = new System.Drawing.Point(37, 1);
            this.txt_memo.CustomButton.Name = "";
            this.txt_memo.CustomButton.Size = new System.Drawing.Size(165, 165);
            this.txt_memo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_memo.CustomButton.TabIndex = 1;
            this.txt_memo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_memo.CustomButton.UseSelectable = true;
            this.txt_memo.CustomButton.Visible = false;
            this.txt_memo.Lines = new string[0];
            this.txt_memo.Location = new System.Drawing.Point(391, 20);
            this.txt_memo.MaxLength = 32767;
            this.txt_memo.Multiline = true;
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.PasswordChar = '\0';
            this.txt_memo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_memo.SelectedText = "";
            this.txt_memo.SelectionLength = 0;
            this.txt_memo.SelectionStart = 0;
            this.txt_memo.ShortcutsEnabled = true;
            this.txt_memo.Size = new System.Drawing.Size(203, 167);
            this.txt_memo.TabIndex = 60;
            this.txt_memo.UseSelectable = true;
            this.txt_memo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_memo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_memo.Click += new System.EventHandler(this.txt_memo_Click);
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Location = new System.Drawing.Point(342, 24);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(51, 19);
            this.metroLabel25.TabIndex = 59;
            this.metroLabel25.Text = "Memo:";
            this.metroLabel25.Click += new System.EventHandler(this.metroLabel25_Click);
            // 
            // cBoxBilled
            // 
            this.cBoxBilled.FormattingEnabled = true;
            this.cBoxBilled.ItemHeight = 23;
            this.cBoxBilled.Items.AddRange(new object[] {
            "Cash",
            "Installment"});
            this.cBoxBilled.Location = new System.Drawing.Point(144, 52);
            this.cBoxBilled.Name = "cBoxBilled";
            this.cBoxBilled.Size = new System.Drawing.Size(121, 29);
            this.cBoxBilled.TabIndex = 40;
            this.cBoxBilled.UseSelectable = true;
            this.cBoxBilled.SelectedIndexChanged += new System.EventHandler(this.cBoxBilled_SelectedIndexChanged);
            // 
            // cBoxAccount
            // 
            this.cBoxAccount.FormattingEnabled = true;
            this.cBoxAccount.ItemHeight = 23;
            this.cBoxAccount.Items.AddRange(new object[] {
            "Personal",
            "Business"});
            this.cBoxAccount.Location = new System.Drawing.Point(144, 14);
            this.cBoxAccount.Name = "cBoxAccount";
            this.cBoxAccount.Size = new System.Drawing.Size(121, 29);
            this.cBoxAccount.TabIndex = 39;
            this.cBoxAccount.UseSelectable = true;
            this.cBoxAccount.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(58, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Billed From:";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Type of Account:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_amount);
            this.groupBox3.Controls.Add(this.metroLabel8);
            this.groupBox3.Controls.Add(this.GridView);
            this.groupBox3.Controls.Add(this.dtDateRecorded);
            this.groupBox3.Controls.Add(this.lbl_total);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Controls.Add(this.txt_notes);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.txt_amount);
            this.groupBox3.Controls.Add(this.metroLabel24);
            this.groupBox3.Controls.Add(this.metroLabel17);
            this.groupBox3.Controls.Add(this.metroLabel16);
            this.groupBox3.Location = new System.Drawing.Point(23, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(840, 287);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dtDateRecorded
            // 
            this.dtDateRecorded.Location = new System.Drawing.Point(415, 46);
            this.dtDateRecorded.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDateRecorded.Name = "dtDateRecorded";
            this.dtDateRecorded.Size = new System.Drawing.Size(200, 29);
            this.dtDateRecorded.TabIndex = 66;
            this.dtDateRecorded.ValueChanged += new System.EventHandler(this.dtDateRecorded_ValueChanged);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(292, 234);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 0);
            this.lbl_total.TabIndex = 65;
            this.lbl_total.Click += new System.EventHandler(this.lbl_total_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 234);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(95, 19);
            this.metroLabel6.TabIndex = 64;
            this.metroLabel6.Text = "Total Expenses:";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // txt_notes
            // 
            // 
            // 
            // 
            this.txt_notes.CustomButton.Image = null;
            this.txt_notes.CustomButton.Location = new System.Drawing.Point(37, 1);
            this.txt_notes.CustomButton.Name = "";
            this.txt_notes.CustomButton.Size = new System.Drawing.Size(165, 165);
            this.txt_notes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_notes.CustomButton.TabIndex = 1;
            this.txt_notes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_notes.CustomButton.UseSelectable = true;
            this.txt_notes.CustomButton.Visible = false;
            this.txt_notes.Lines = new string[0];
            this.txt_notes.Location = new System.Drawing.Point(624, 38);
            this.txt_notes.MaxLength = 32767;
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.PasswordChar = '\0';
            this.txt_notes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_notes.SelectedText = "";
            this.txt_notes.SelectionLength = 0;
            this.txt_notes.SelectionStart = 0;
            this.txt_notes.ShortcutsEnabled = true;
            this.txt_notes.Size = new System.Drawing.Size(203, 167);
            this.txt_notes.TabIndex = 63;
            this.txt_notes.UseSelectable = true;
            this.txt_notes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_notes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_notes.Click += new System.EventHandler(this.txt_notes_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(624, 16);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 54;
            this.metroLabel5.Text = "Notes:";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(415, 16);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 19);
            this.metroLabel4.TabIndex = 53;
            this.metroLabel4.Text = "Date Recorded:";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // txt_amount
            // 
            // 
            // 
            // 
            this.txt_amount.CustomButton.Image = null;
            this.txt_amount.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.txt_amount.CustomButton.Name = "";
            this.txt_amount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_amount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_amount.CustomButton.TabIndex = 1;
            this.txt_amount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_amount.CustomButton.UseSelectable = true;
            this.txt_amount.CustomButton.Visible = false;
            this.txt_amount.Lines = new string[0];
            this.txt_amount.Location = new System.Drawing.Point(232, 52);
            this.txt_amount.MaxLength = 32767;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.PasswordChar = '\0';
            this.txt_amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_amount.SelectedText = "";
            this.txt_amount.SelectionLength = 0;
            this.txt_amount.SelectionStart = 0;
            this.txt_amount.ShortcutsEnabled = true;
            this.txt_amount.Size = new System.Drawing.Size(158, 23);
            this.txt_amount.TabIndex = 52;
            this.txt_amount.UseSelectable = true;
            this.txt_amount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_amount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_amount.Click += new System.EventHandler(this.txt_amount_Click);
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.Location = new System.Drawing.Point(232, 16);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(59, 19);
            this.metroLabel24.TabIndex = 8;
            this.metroLabel24.Text = "Amount:";
            this.metroLabel24.Click += new System.EventHandler(this.metroLabel24_Click);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(6, 56);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(101, 19);
            this.metroLabel17.TabIndex = 1;
            this.metroLabel17.Text = "Virtual Services:";
            this.metroLabel17.Click += new System.EventHandler(this.metroLabel17_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(6, 16);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(64, 19);
            this.metroLabel16.TabIndex = 0;
            this.metroLabel16.Text = "Expenses:";
            this.metroLabel16.Click += new System.EventHandler(this.metroLabel16_Click);
            // 
            // btn_save
            // 
            this.btn_save.ActiveControl = null;
            this.btn_save.Location = new System.Drawing.Point(647, 63);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(96, 81);
            this.btn_save.TabIndex = 30;
            this.btn_save.Text = "Save";
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ActiveControl = null;
            this.btn_cancel.Location = new System.Drawing.Point(647, 160);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(96, 71);
            this.btn_cancel.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_cancel.TabIndex = 31;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseSelectable = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            this.GridView.Location = new System.Drawing.Point(6, 81);
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
            this.GridView.Size = new System.Drawing.Size(387, 150);
            this.GridView.TabIndex = 67;
            this.GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellContentClick);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(754, 115);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(96, 81);
            this.metroTile1.TabIndex = 32;
            this.metroTile1.Text = "Compute";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(292, 256);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(0, 0);
            this.lbl_amount.TabIndex = 69;
            this.lbl_amount.Click += new System.EventHandler(this.lbl_amount_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 256);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(119, 19);
            this.metroLabel8.TabIndex = 68;
            this.metroLabel8.Text = "Total Amount Paid:";
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // PropertyAccountingPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 559);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropertyAccountingPersonal";
            this.Resizable = false;
            this.Text = "Property Accounting(Personal)";
            this.Load += new System.EventHandler(this.Frm_PropertyAccountingPersonal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txt_memo;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroComboBox cBoxBilled;
        private MetroFramework.Controls.MetroComboBox cBoxAccount;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_billedTo;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox txt_amount;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_notes;
        private MetroFramework.Controls.MetroLabel lbl_total;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroDateTime dtDateRecorded;
        private MetroFramework.Controls.MetroTile btn_save;
        private MetroFramework.Controls.MetroTile btn_cancel;
        private MetroFramework.Controls.MetroGrid GridView;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel lbl_amount;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}