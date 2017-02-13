namespace RVL_Management_System
{
    partial class Frm_LeadGeneration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxLeadAssesment = new System.Windows.Forms.ComboBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.cBoxLeadAssigned = new System.Windows.Forms.ComboBox();
            this.cBoxPriority = new System.Windows.Forms.ComboBox();
            this.cBoxLeadFollowUp = new System.Windows.Forms.ComboBox();
            this.txt_others = new MetroFramework.Controls.MetroTextBox();
            this.cBoxLeadStats = new System.Windows.Forms.ComboBox();
            this.cBoxLeadSource = new System.Windows.Forms.ComboBox();
            this.txt_memo = new MetroFramework.Controls.MetroTextBox();
            this.txt_IssueDes = new MetroFramework.Controls.MetroTextBox();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.txt_pnum = new MetroFramework.Controls.MetroTextBox();
            this.txt_mn = new MetroFramework.Controls.MetroTextBox();
            this.txt_fn = new MetroFramework.Controls.MetroTextBox();
            this.txt_ln = new MetroFramework.Controls.MetroTextBox();
            this.dtLeadReceived = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.GridView = new MetroFramework.Controls.MetroGrid();
            this.btn_clear = new MetroFramework.Controls.MetroTile();
            this.btn_save = new MetroFramework.Controls.MetroTile();
            this.btn_viewLead = new MetroFramework.Controls.MetroTile();
            this.btn_update = new MetroFramework.Controls.MetroTile();
            this.btn_viewAll = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxLeadAssesment);
            this.groupBox1.Controls.Add(this.metroLabel15);
            this.groupBox1.Controls.Add(this.cBoxLeadAssigned);
            this.groupBox1.Controls.Add(this.cBoxPriority);
            this.groupBox1.Controls.Add(this.cBoxLeadFollowUp);
            this.groupBox1.Controls.Add(this.txt_others);
            this.groupBox1.Controls.Add(this.cBoxLeadStats);
            this.groupBox1.Controls.Add(this.cBoxLeadSource);
            this.groupBox1.Controls.Add(this.txt_memo);
            this.groupBox1.Controls.Add(this.txt_IssueDes);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_pnum);
            this.groupBox1.Controls.Add(this.txt_mn);
            this.groupBox1.Controls.Add(this.txt_fn);
            this.groupBox1.Controls.Add(this.txt_ln);
            this.groupBox1.Controls.Add(this.dtLeadReceived);
            this.groupBox1.Controls.Add(this.metroLabel13);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marketing Information";
            // 
            // cBoxLeadAssesment
            // 
            this.cBoxLeadAssesment.FormattingEnabled = true;
            this.cBoxLeadAssesment.Items.AddRange(new object[] {
            "Passed",
            "Failed"});
            this.cBoxLeadAssesment.Location = new System.Drawing.Point(239, 273);
            this.cBoxLeadAssesment.Name = "cBoxLeadAssesment";
            this.cBoxLeadAssesment.Size = new System.Drawing.Size(187, 21);
            this.cBoxLeadAssesment.TabIndex = 91;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(239, 245);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(102, 19);
            this.metroLabel15.TabIndex = 90;
            this.metroLabel15.Text = "Lead Assesment";
            // 
            // cBoxLeadAssigned
            // 
            this.cBoxLeadAssigned.FormattingEnabled = true;
            this.cBoxLeadAssigned.Location = new System.Drawing.Point(18, 319);
            this.cBoxLeadAssigned.Name = "cBoxLeadAssigned";
            this.cBoxLeadAssigned.Size = new System.Drawing.Size(187, 21);
            this.cBoxLeadAssigned.TabIndex = 89;
            // 
            // cBoxPriority
            // 
            this.cBoxPriority.FormattingEnabled = true;
            this.cBoxPriority.Items.AddRange(new object[] {
            "Low Priority",
            "Medium Priority",
            "High Priority"});
            this.cBoxPriority.Location = new System.Drawing.Point(239, 217);
            this.cBoxPriority.Name = "cBoxPriority";
            this.cBoxPriority.Size = new System.Drawing.Size(187, 21);
            this.cBoxPriority.TabIndex = 88;
            // 
            // cBoxLeadFollowUp
            // 
            this.cBoxLeadFollowUp.FormattingEnabled = true;
            this.cBoxLeadFollowUp.Items.AddRange(new object[] {
            "Texted",
            "Emailed",
            "Called",
            "Called-Left Voicemail",
            "Wrong Number",
            "Completed Follow-up",
            "Lead - Positive Buyer"});
            this.cBoxLeadFollowUp.Location = new System.Drawing.Point(18, 273);
            this.cBoxLeadFollowUp.Name = "cBoxLeadFollowUp";
            this.cBoxLeadFollowUp.Size = new System.Drawing.Size(187, 21);
            this.cBoxLeadFollowUp.TabIndex = 87;
            // 
            // txt_others
            // 
            // 
            // 
            // 
            this.txt_others.CustomButton.Image = null;
            this.txt_others.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_others.CustomButton.Name = "";
            this.txt_others.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_others.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_others.CustomButton.TabIndex = 1;
            this.txt_others.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_others.CustomButton.UseSelectable = true;
            this.txt_others.CustomButton.Visible = false;
            this.txt_others.Enabled = false;
            this.txt_others.Lines = new string[0];
            this.txt_others.Location = new System.Drawing.Point(18, 215);
            this.txt_others.MaxLength = 32767;
            this.txt_others.Name = "txt_others";
            this.txt_others.PasswordChar = '\0';
            this.txt_others.PromptText = "Others";
            this.txt_others.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_others.SelectedText = "";
            this.txt_others.SelectionLength = 0;
            this.txt_others.SelectionStart = 0;
            this.txt_others.ShortcutsEnabled = true;
            this.txt_others.Size = new System.Drawing.Size(187, 23);
            this.txt_others.TabIndex = 86;
            this.txt_others.UseSelectable = true;
            this.txt_others.WaterMark = "Others";
            this.txt_others.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_others.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cBoxLeadStats
            // 
            this.cBoxLeadStats.FormattingEnabled = true;
            this.cBoxLeadStats.Location = new System.Drawing.Point(239, 169);
            this.cBoxLeadStats.Name = "cBoxLeadStats";
            this.cBoxLeadStats.Size = new System.Drawing.Size(187, 21);
            this.cBoxLeadStats.TabIndex = 84;
            // 
            // cBoxLeadSource
            // 
            this.cBoxLeadSource.AutoCompleteCustomSource.AddRange(new string[] {
            "Others"});
            this.cBoxLeadSource.FormattingEnabled = true;
            this.cBoxLeadSource.Location = new System.Drawing.Point(18, 169);
            this.cBoxLeadSource.Name = "cBoxLeadSource";
            this.cBoxLeadSource.Size = new System.Drawing.Size(187, 21);
            this.cBoxLeadSource.TabIndex = 83;
            this.cBoxLeadSource.SelectedIndexChanged += new System.EventHandler(this.cBoxLeadSource_SelectedIndexChanged);
            // 
            // txt_memo
            // 
            // 
            // 
            // 
            this.txt_memo.CustomButton.Image = null;
            this.txt_memo.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_memo.CustomButton.Name = "";
            this.txt_memo.CustomButton.Size = new System.Drawing.Size(89, 89);
            this.txt_memo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_memo.CustomButton.TabIndex = 1;
            this.txt_memo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_memo.CustomButton.UseSelectable = true;
            this.txt_memo.CustomButton.Visible = false;
            this.txt_memo.Lines = new string[0];
            this.txt_memo.Location = new System.Drawing.Point(440, 217);
            this.txt_memo.MaxLength = 32767;
            this.txt_memo.Multiline = true;
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.PasswordChar = '\0';
            this.txt_memo.PromptText = "Memo(From GPG Staff/Luke/Gil)";
            this.txt_memo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_memo.SelectedText = "";
            this.txt_memo.SelectionLength = 0;
            this.txt_memo.SelectionStart = 0;
            this.txt_memo.ShortcutsEnabled = true;
            this.txt_memo.Size = new System.Drawing.Size(329, 91);
            this.txt_memo.TabIndex = 78;
            this.txt_memo.UseSelectable = true;
            this.txt_memo.WaterMark = "Memo(From GPG Staff/Luke/Gil)";
            this.txt_memo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_memo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_IssueDes
            // 
            // 
            // 
            // 
            this.txt_IssueDes.CustomButton.Image = null;
            this.txt_IssueDes.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_IssueDes.CustomButton.Name = "";
            this.txt_IssueDes.CustomButton.Size = new System.Drawing.Size(89, 89);
            this.txt_IssueDes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_IssueDes.CustomButton.TabIndex = 1;
            this.txt_IssueDes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_IssueDes.CustomButton.UseSelectable = true;
            this.txt_IssueDes.CustomButton.Visible = false;
            this.txt_IssueDes.Lines = new string[0];
            this.txt_IssueDes.Location = new System.Drawing.Point(440, 113);
            this.txt_IssueDes.MaxLength = 32767;
            this.txt_IssueDes.Multiline = true;
            this.txt_IssueDes.Name = "txt_IssueDes";
            this.txt_IssueDes.PasswordChar = '\0';
            this.txt_IssueDes.PromptText = "Call/Issue Description(Notes about the call or Inquiry)";
            this.txt_IssueDes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_IssueDes.SelectedText = "";
            this.txt_IssueDes.SelectionLength = 0;
            this.txt_IssueDes.SelectionStart = 0;
            this.txt_IssueDes.ShortcutsEnabled = true;
            this.txt_IssueDes.Size = new System.Drawing.Size(329, 91);
            this.txt_IssueDes.TabIndex = 73;
            this.txt_IssueDes.UseSelectable = true;
            this.txt_IssueDes.WaterMark = "Call/Issue Description(Notes about the call or Inquiry)";
            this.txt_IssueDes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_IssueDes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_email
            // 
            // 
            // 
            // 
            this.txt_email.CustomButton.Image = null;
            this.txt_email.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_email.CustomButton.Name = "";
            this.txt_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_email.CustomButton.TabIndex = 1;
            this.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_email.CustomButton.UseSelectable = true;
            this.txt_email.CustomButton.Visible = false;
            this.txt_email.Lines = new string[0];
            this.txt_email.Location = new System.Drawing.Point(239, 113);
            this.txt_email.MaxLength = 32767;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PromptText = "Email Address";
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(187, 23);
            this.txt_email.TabIndex = 72;
            this.txt_email.UseSelectable = true;
            this.txt_email.WaterMark = "Email Address";
            this.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_pnum
            // 
            // 
            // 
            // 
            this.txt_pnum.CustomButton.Image = null;
            this.txt_pnum.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_pnum.CustomButton.Name = "";
            this.txt_pnum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_pnum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pnum.CustomButton.TabIndex = 1;
            this.txt_pnum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pnum.CustomButton.UseSelectable = true;
            this.txt_pnum.CustomButton.Visible = false;
            this.txt_pnum.Lines = new string[0];
            this.txt_pnum.Location = new System.Drawing.Point(18, 113);
            this.txt_pnum.MaxLength = 32767;
            this.txt_pnum.Name = "txt_pnum";
            this.txt_pnum.PasswordChar = '\0';
            this.txt_pnum.PromptText = "Phone Number";
            this.txt_pnum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pnum.SelectedText = "";
            this.txt_pnum.SelectionLength = 0;
            this.txt_pnum.SelectionStart = 0;
            this.txt_pnum.ShortcutsEnabled = true;
            this.txt_pnum.Size = new System.Drawing.Size(187, 23);
            this.txt_pnum.TabIndex = 71;
            this.txt_pnum.UseSelectable = true;
            this.txt_pnum.WaterMark = "Phone Number";
            this.txt_pnum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pnum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_mn
            // 
            // 
            // 
            // 
            this.txt_mn.CustomButton.Image = null;
            this.txt_mn.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_mn.CustomButton.Name = "";
            this.txt_mn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_mn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_mn.CustomButton.TabIndex = 1;
            this.txt_mn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_mn.CustomButton.UseSelectable = true;
            this.txt_mn.CustomButton.Visible = false;
            this.txt_mn.Lines = new string[0];
            this.txt_mn.Location = new System.Drawing.Point(440, 84);
            this.txt_mn.MaxLength = 32767;
            this.txt_mn.Name = "txt_mn";
            this.txt_mn.PasswordChar = '\0';
            this.txt_mn.PromptText = "Middle Name";
            this.txt_mn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_mn.SelectedText = "";
            this.txt_mn.SelectionLength = 0;
            this.txt_mn.SelectionStart = 0;
            this.txt_mn.ShortcutsEnabled = true;
            this.txt_mn.Size = new System.Drawing.Size(187, 23);
            this.txt_mn.TabIndex = 70;
            this.txt_mn.UseSelectable = true;
            this.txt_mn.WaterMark = "Middle Name";
            this.txt_mn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_mn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_fn
            // 
            // 
            // 
            // 
            this.txt_fn.CustomButton.Image = null;
            this.txt_fn.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_fn.CustomButton.Name = "";
            this.txt_fn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_fn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_fn.CustomButton.TabIndex = 1;
            this.txt_fn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_fn.CustomButton.UseSelectable = true;
            this.txt_fn.CustomButton.Visible = false;
            this.txt_fn.Lines = new string[0];
            this.txt_fn.Location = new System.Drawing.Point(239, 84);
            this.txt_fn.MaxLength = 32767;
            this.txt_fn.Name = "txt_fn";
            this.txt_fn.PasswordChar = '\0';
            this.txt_fn.PromptText = "First Name";
            this.txt_fn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_fn.SelectedText = "";
            this.txt_fn.SelectionLength = 0;
            this.txt_fn.SelectionStart = 0;
            this.txt_fn.ShortcutsEnabled = true;
            this.txt_fn.Size = new System.Drawing.Size(187, 23);
            this.txt_fn.TabIndex = 69;
            this.txt_fn.UseSelectable = true;
            this.txt_fn.WaterMark = "First Name";
            this.txt_fn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_fn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_ln
            // 
            // 
            // 
            // 
            this.txt_ln.CustomButton.Image = null;
            this.txt_ln.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_ln.CustomButton.Name = "";
            this.txt_ln.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ln.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ln.CustomButton.TabIndex = 1;
            this.txt_ln.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ln.CustomButton.UseSelectable = true;
            this.txt_ln.CustomButton.Visible = false;
            this.txt_ln.Lines = new string[0];
            this.txt_ln.Location = new System.Drawing.Point(18, 84);
            this.txt_ln.MaxLength = 32767;
            this.txt_ln.Name = "txt_ln";
            this.txt_ln.PasswordChar = '\0';
            this.txt_ln.PromptText = "Last Name";
            this.txt_ln.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ln.SelectedText = "";
            this.txt_ln.SelectionLength = 0;
            this.txt_ln.SelectionStart = 0;
            this.txt_ln.ShortcutsEnabled = true;
            this.txt_ln.Size = new System.Drawing.Size(187, 23);
            this.txt_ln.TabIndex = 68;
            this.txt_ln.UseSelectable = true;
            this.txt_ln.WaterMark = "Last Name";
            this.txt_ln.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ln.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtLeadReceived
            // 
            this.dtLeadReceived.Location = new System.Drawing.Point(18, 49);
            this.dtLeadReceived.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtLeadReceived.Name = "dtLeadReceived";
            this.dtLeadReceived.Size = new System.Drawing.Size(212, 29);
            this.dtLeadReceived.TabIndex = 67;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(18, 297);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(107, 19);
            this.metroLabel13.TabIndex = 66;
            this.metroLabel13.Text = "Lead assigned to";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(239, 193);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(51, 19);
            this.metroLabel11.TabIndex = 64;
            this.metroLabel11.Text = "Priority";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(18, 241);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(131, 19);
            this.metroLabel10.TabIndex = 63;
            this.metroLabel10.Text = "Lead follow up status";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(239, 139);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(113, 19);
            this.metroLabel9.TabIndex = 62;
            this.metroLabel9.Text = "Lead Status Result";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(18, 139);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 19);
            this.metroLabel8.TabIndex = 61;
            this.metroLabel8.Text = "Lead Source";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(18, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(193, 19);
            this.metroLabel1.TabIndex = 54;
            this.metroLabel1.Text = "Date of the Call/ Lead Received";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marketing";
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridView.Location = new System.Drawing.Point(7, 450);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(936, 184);
            this.GridView.TabIndex = 82;
            // 
            // btn_clear
            // 
            this.btn_clear.ActiveControl = null;
            this.btn_clear.Location = new System.Drawing.Point(799, 74);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(77, 58);
            this.btn_clear.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_clear.TabIndex = 87;
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
            this.btn_save.Location = new System.Drawing.Point(882, 74);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 58);
            this.btn_save.TabIndex = 86;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.TileImage = global::RVL_Management_System.Properties.Resources.plus_1;
            this.btn_save.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseSelectable = true;
            this.btn_save.UseTileImage = true;
            this.btn_save.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btn_viewLead
            // 
            this.btn_viewLead.ActiveControl = null;
            this.btn_viewLead.Location = new System.Drawing.Point(799, 180);
            this.btn_viewLead.Name = "btn_viewLead";
            this.btn_viewLead.Size = new System.Drawing.Size(144, 84);
            this.btn_viewLead.TabIndex = 88;
            this.btn_viewLead.Text = "&View Lead Assigned";
            this.btn_viewLead.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_viewLead.TileImage = global::RVL_Management_System.Properties.Resources.data_search_interface_symbol;
            this.btn_viewLead.UseSelectable = true;
            this.btn_viewLead.UseTileImage = true;
            this.btn_viewLead.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // btn_update
            // 
            this.btn_update.ActiveControl = null;
            this.btn_update.Location = new System.Drawing.Point(799, 360);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(144, 84);
            this.btn_update.TabIndex = 89;
            this.btn_update.Text = "&Update Records";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_update.TileImage = global::RVL_Management_System.Properties.Resources.folder_edit_symbol_for_interface;
            this.btn_update.UseSelectable = true;
            this.btn_update.UseTileImage = true;
            this.btn_update.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // btn_viewAll
            // 
            this.btn_viewAll.ActiveControl = null;
            this.btn_viewAll.Location = new System.Drawing.Point(799, 270);
            this.btn_viewAll.Name = "btn_viewAll";
            this.btn_viewAll.Size = new System.Drawing.Size(144, 84);
            this.btn_viewAll.TabIndex = 90;
            this.btn_viewAll.Text = "&View all Records";
            this.btn_viewAll.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_viewAll.TileImage = global::RVL_Management_System.Properties.Resources.data_search_interface_symbol;
            this.btn_viewAll.UseSelectable = true;
            this.btn_viewAll.UseTileImage = true;
            this.btn_viewAll.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // Frm_LeadGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 652);
            this.Controls.Add(this.btn_viewAll);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_viewLead);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Frm_LeadGeneration";
            this.Load += new System.EventHandler(this.Frm_LeadGeneration_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_LeadGeneration_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txt_memo;
        private MetroFramework.Controls.MetroTextBox txt_IssueDes;
        private MetroFramework.Controls.MetroTextBox txt_email;
        private MetroFramework.Controls.MetroTextBox txt_pnum;
        private MetroFramework.Controls.MetroTextBox txt_mn;
        private MetroFramework.Controls.MetroTextBox txt_fn;
        private MetroFramework.Controls.MetroTextBox txt_ln;
        private MetroFramework.Controls.MetroDateTime dtLeadReceived;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxLeadSource;
        private System.Windows.Forms.ComboBox cBoxLeadStats;
        private MetroFramework.Controls.MetroTextBox txt_others;
        private System.Windows.Forms.ComboBox cBoxLeadFollowUp;
        private System.Windows.Forms.ComboBox cBoxPriority;
        private System.Windows.Forms.ComboBox cBoxLeadAssigned;
        private MetroFramework.Controls.MetroGrid GridView;
        private System.Windows.Forms.ComboBox cBoxLeadAssesment;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTile btn_clear;
        private MetroFramework.Controls.MetroTile btn_save;
        private MetroFramework.Controls.MetroTile btn_viewLead;
        private MetroFramework.Controls.MetroTile btn_update;
        private MetroFramework.Controls.MetroTile btn_viewAll;
    }
}