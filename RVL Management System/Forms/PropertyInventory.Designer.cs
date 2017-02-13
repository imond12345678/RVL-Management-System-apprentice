namespace RVL_Management_System.Forms
{
    partial class PropertyInventory
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.dtDateListed = new MetroFramework.Controls.MetroDateTime();
            this.txt_apn = new MetroFramework.Controls.MetroTextBox();
            this.txt_originalPrice = new MetroFramework.Controls.MetroTextBox();
            this.txt_currentMarketValue = new MetroFramework.Controls.MetroTextBox();
            this.txt_updatedPrice = new MetroFramework.Controls.MetroTextBox();
            this.txt_imageNo = new MetroFramework.Controls.MetroTextBox();
            this.txt_title = new MetroFramework.Controls.MetroTextBox();
            this.txt_urlLinkForSocialMedia = new MetroFramework.Controls.MetroTextBox();
            this.txt_gpsUrl = new MetroFramework.Controls.MetroTextBox();
            this.txt_videoProperty = new MetroFramework.Controls.MetroTextBox();
            this.txt_gpsCoordinates = new MetroFramework.Controls.MetroTextBox();
            this.dtDateSold = new MetroFramework.Controls.MetroDateTime();
            this.txt_soldTo = new MetroFramework.Controls.MetroTextBox();
            this.txt_buyerEmail = new MetroFramework.Controls.MetroTextBox();
            this.txt_buyerPhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.txt_termsAndConditions = new MetroFramework.Controls.MetroTextBox();
            this.txt_notesForTheTerm = new MetroFramework.Controls.MetroTextBox();
            this.txt_paymentTerms = new MetroFramework.Controls.MetroTextBox();
            this.txt_urlDeeds = new MetroFramework.Controls.MetroTextBox();
            this.txt_urlStamp = new MetroFramework.Controls.MetroTextBox();
            this.txt_urlMoonclerk = new MetroFramework.Controls.MetroTextBox();
            this.txt_status = new MetroFramework.Controls.MetroTextBox();
            this.txt_county = new MetroFramework.Controls.MetroTextBox();
            this.cBoxCurrentStatus = new MetroFramework.Controls.MetroComboBox();
            this.cBoxLandsSoldSite = new MetroFramework.Controls.MetroComboBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.btn_clear = new MetroFramework.Controls.MetroTile();
            this.btn_save = new MetroFramework.Controls.MetroTile();
            this.cBoxLandOwner = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_additionalNotes = new MetroFramework.Controls.MetroTextBox();
            this.cBoxPaymentRemarks = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Date listed";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(310, 468);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(91, 19);
            this.metroLabel13.TabIndex = 12;
            this.metroLabel13.Text = "Current Status";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(524, 468);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(97, 19);
            this.metroLabel14.TabIndex = 13;
            this.metroLabel14.Text = "Lands Sold Site";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(310, 522);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(143, 19);
            this.metroLabel15.TabIndex = 14;
            this.metroLabel15.Text = "Date Sold(Moon Clerk)";
            // 
            // dtDateListed
            // 
            this.dtDateListed.Location = new System.Drawing.Point(23, 100);
            this.dtDateListed.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDateListed.Name = "dtDateListed";
            this.dtDateListed.Size = new System.Drawing.Size(200, 29);
            this.dtDateListed.TabIndex = 1;
            // 
            // txt_apn
            // 
            // 
            // 
            // 
            this.txt_apn.CustomButton.Image = null;
            this.txt_apn.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txt_apn.CustomButton.Name = "";
            this.txt_apn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_apn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_apn.CustomButton.TabIndex = 1;
            this.txt_apn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_apn.CustomButton.UseSelectable = true;
            this.txt_apn.CustomButton.Visible = false;
            this.txt_apn.Lines = new string[0];
            this.txt_apn.Location = new System.Drawing.Point(229, 106);
            this.txt_apn.MaxLength = 32767;
            this.txt_apn.Name = "txt_apn";
            this.txt_apn.PasswordChar = '\0';
            this.txt_apn.PromptText = "APN ID";
            this.txt_apn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_apn.SelectedText = "";
            this.txt_apn.SelectionLength = 0;
            this.txt_apn.SelectionStart = 0;
            this.txt_apn.ShortcutsEnabled = true;
            this.txt_apn.Size = new System.Drawing.Size(75, 23);
            this.txt_apn.TabIndex = 2;
            this.txt_apn.UseSelectable = true;
            this.txt_apn.WaterMark = "APN ID";
            this.txt_apn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_apn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_originalPrice
            // 
            this.txt_originalPrice.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_originalPrice.CustomButton.Image = null;
            this.txt_originalPrice.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txt_originalPrice.CustomButton.Name = "";
            this.txt_originalPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_originalPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_originalPrice.CustomButton.TabIndex = 1;
            this.txt_originalPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_originalPrice.CustomButton.UseSelectable = true;
            this.txt_originalPrice.CustomButton.Visible = false;
            this.txt_originalPrice.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_originalPrice.Lines = new string[0];
            this.txt_originalPrice.Location = new System.Drawing.Point(310, 106);
            this.txt_originalPrice.MaxLength = 32767;
            this.txt_originalPrice.Name = "txt_originalPrice";
            this.txt_originalPrice.PasswordChar = '\0';
            this.txt_originalPrice.PromptText = "Original Price";
            this.txt_originalPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_originalPrice.SelectedText = "";
            this.txt_originalPrice.SelectionLength = 0;
            this.txt_originalPrice.SelectionStart = 0;
            this.txt_originalPrice.ShortcutsEnabled = true;
            this.txt_originalPrice.Size = new System.Drawing.Size(105, 23);
            this.txt_originalPrice.TabIndex = 3;
            this.txt_originalPrice.UseSelectable = true;
            this.txt_originalPrice.WaterMark = "Original Price";
            this.txt_originalPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_originalPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_currentMarketValue
            // 
            // 
            // 
            // 
            this.txt_currentMarketValue.CustomButton.Image = null;
            this.txt_currentMarketValue.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txt_currentMarketValue.CustomButton.Name = "";
            this.txt_currentMarketValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_currentMarketValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_currentMarketValue.CustomButton.TabIndex = 1;
            this.txt_currentMarketValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_currentMarketValue.CustomButton.UseSelectable = true;
            this.txt_currentMarketValue.CustomButton.Visible = false;
            this.txt_currentMarketValue.Lines = new string[0];
            this.txt_currentMarketValue.Location = new System.Drawing.Point(421, 106);
            this.txt_currentMarketValue.MaxLength = 32767;
            this.txt_currentMarketValue.Name = "txt_currentMarketValue";
            this.txt_currentMarketValue.PasswordChar = '\0';
            this.txt_currentMarketValue.PromptText = "Current Market Value";
            this.txt_currentMarketValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_currentMarketValue.SelectedText = "";
            this.txt_currentMarketValue.SelectionLength = 0;
            this.txt_currentMarketValue.SelectionStart = 0;
            this.txt_currentMarketValue.ShortcutsEnabled = true;
            this.txt_currentMarketValue.Size = new System.Drawing.Size(132, 23);
            this.txt_currentMarketValue.TabIndex = 4;
            this.txt_currentMarketValue.UseSelectable = true;
            this.txt_currentMarketValue.WaterMark = "Current Market Value";
            this.txt_currentMarketValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_currentMarketValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_updatedPrice
            // 
            // 
            // 
            // 
            this.txt_updatedPrice.CustomButton.Image = null;
            this.txt_updatedPrice.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txt_updatedPrice.CustomButton.Name = "";
            this.txt_updatedPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_updatedPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_updatedPrice.CustomButton.TabIndex = 1;
            this.txt_updatedPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_updatedPrice.CustomButton.UseSelectable = true;
            this.txt_updatedPrice.CustomButton.Visible = false;
            this.txt_updatedPrice.Lines = new string[0];
            this.txt_updatedPrice.Location = new System.Drawing.Point(559, 106);
            this.txt_updatedPrice.MaxLength = 32767;
            this.txt_updatedPrice.Name = "txt_updatedPrice";
            this.txt_updatedPrice.PasswordChar = '\0';
            this.txt_updatedPrice.PromptText = "Updated Price";
            this.txt_updatedPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_updatedPrice.SelectedText = "";
            this.txt_updatedPrice.SelectionLength = 0;
            this.txt_updatedPrice.SelectionStart = 0;
            this.txt_updatedPrice.ShortcutsEnabled = true;
            this.txt_updatedPrice.Size = new System.Drawing.Size(93, 23);
            this.txt_updatedPrice.TabIndex = 5;
            this.txt_updatedPrice.UseSelectable = true;
            this.txt_updatedPrice.WaterMark = "Updated Price";
            this.txt_updatedPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_updatedPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_imageNo
            // 
            // 
            // 
            // 
            this.txt_imageNo.CustomButton.Image = null;
            this.txt_imageNo.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txt_imageNo.CustomButton.Name = "";
            this.txt_imageNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_imageNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_imageNo.CustomButton.TabIndex = 1;
            this.txt_imageNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_imageNo.CustomButton.UseSelectable = true;
            this.txt_imageNo.CustomButton.Visible = false;
            this.txt_imageNo.Lines = new string[0];
            this.txt_imageNo.Location = new System.Drawing.Point(658, 106);
            this.txt_imageNo.MaxLength = 32767;
            this.txt_imageNo.Name = "txt_imageNo";
            this.txt_imageNo.PasswordChar = '\0';
            this.txt_imageNo.PromptText = "Image No.";
            this.txt_imageNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_imageNo.SelectedText = "";
            this.txt_imageNo.SelectionLength = 0;
            this.txt_imageNo.SelectionStart = 0;
            this.txt_imageNo.ShortcutsEnabled = true;
            this.txt_imageNo.Size = new System.Drawing.Size(75, 23);
            this.txt_imageNo.TabIndex = 6;
            this.txt_imageNo.UseSelectable = true;
            this.txt_imageNo.WaterMark = "Image No.";
            this.txt_imageNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_imageNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_title
            // 
            // 
            // 
            // 
            this.txt_title.CustomButton.Image = null;
            this.txt_title.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_title.CustomButton.Name = "";
            this.txt_title.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_title.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_title.CustomButton.TabIndex = 1;
            this.txt_title.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_title.CustomButton.UseSelectable = true;
            this.txt_title.CustomButton.Visible = false;
            this.txt_title.Lines = new string[0];
            this.txt_title.Location = new System.Drawing.Point(23, 144);
            this.txt_title.MaxLength = 32767;
            this.txt_title.Name = "txt_title";
            this.txt_title.PasswordChar = '\0';
            this.txt_title.PromptText = "Title";
            this.txt_title.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_title.SelectedText = "";
            this.txt_title.SelectionLength = 0;
            this.txt_title.SelectionStart = 0;
            this.txt_title.ShortcutsEnabled = true;
            this.txt_title.Size = new System.Drawing.Size(261, 23);
            this.txt_title.TabIndex = 7;
            this.txt_title.UseSelectable = true;
            this.txt_title.WaterMark = "Title";
            this.txt_title.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_title.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_urlLinkForSocialMedia
            // 
            // 
            // 
            // 
            this.txt_urlLinkForSocialMedia.CustomButton.Image = null;
            this.txt_urlLinkForSocialMedia.CustomButton.Location = new System.Drawing.Point(334, 1);
            this.txt_urlLinkForSocialMedia.CustomButton.Name = "";
            this.txt_urlLinkForSocialMedia.CustomButton.Size = new System.Drawing.Size(67, 67);
            this.txt_urlLinkForSocialMedia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_urlLinkForSocialMedia.CustomButton.TabIndex = 1;
            this.txt_urlLinkForSocialMedia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_urlLinkForSocialMedia.CustomButton.UseSelectable = true;
            this.txt_urlLinkForSocialMedia.CustomButton.Visible = false;
            this.txt_urlLinkForSocialMedia.Lines = new string[0];
            this.txt_urlLinkForSocialMedia.Location = new System.Drawing.Point(310, 152);
            this.txt_urlLinkForSocialMedia.MaxLength = 32767;
            this.txt_urlLinkForSocialMedia.Multiline = true;
            this.txt_urlLinkForSocialMedia.Name = "txt_urlLinkForSocialMedia";
            this.txt_urlLinkForSocialMedia.PasswordChar = '\0';
            this.txt_urlLinkForSocialMedia.PromptText = "URL link for each social media";
            this.txt_urlLinkForSocialMedia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_urlLinkForSocialMedia.SelectedText = "";
            this.txt_urlLinkForSocialMedia.SelectionLength = 0;
            this.txt_urlLinkForSocialMedia.SelectionStart = 0;
            this.txt_urlLinkForSocialMedia.ShortcutsEnabled = true;
            this.txt_urlLinkForSocialMedia.Size = new System.Drawing.Size(402, 69);
            this.txt_urlLinkForSocialMedia.TabIndex = 20;
            this.txt_urlLinkForSocialMedia.UseSelectable = true;
            this.txt_urlLinkForSocialMedia.WaterMark = "URL link for each social media";
            this.txt_urlLinkForSocialMedia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_urlLinkForSocialMedia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_gpsUrl
            // 
            // 
            // 
            // 
            this.txt_gpsUrl.CustomButton.Image = null;
            this.txt_gpsUrl.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txt_gpsUrl.CustomButton.Name = "";
            this.txt_gpsUrl.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_gpsUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_gpsUrl.CustomButton.TabIndex = 1;
            this.txt_gpsUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_gpsUrl.CustomButton.UseSelectable = true;
            this.txt_gpsUrl.CustomButton.Visible = false;
            this.txt_gpsUrl.Lines = new string[0];
            this.txt_gpsUrl.Location = new System.Drawing.Point(23, 500);
            this.txt_gpsUrl.MaxLength = 32767;
            this.txt_gpsUrl.Name = "txt_gpsUrl";
            this.txt_gpsUrl.PasswordChar = '\0';
            this.txt_gpsUrl.PromptText = "GPS URL link";
            this.txt_gpsUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_gpsUrl.SelectedText = "";
            this.txt_gpsUrl.SelectionLength = 0;
            this.txt_gpsUrl.SelectionStart = 0;
            this.txt_gpsUrl.ShortcutsEnabled = true;
            this.txt_gpsUrl.Size = new System.Drawing.Size(262, 23);
            this.txt_gpsUrl.TabIndex = 18;
            this.txt_gpsUrl.UseSelectable = true;
            this.txt_gpsUrl.WaterMark = "GPS URL link";
            this.txt_gpsUrl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_gpsUrl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_videoProperty
            // 
            // 
            // 
            // 
            this.txt_videoProperty.CustomButton.Image = null;
            this.txt_videoProperty.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_videoProperty.CustomButton.Name = "";
            this.txt_videoProperty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_videoProperty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_videoProperty.CustomButton.TabIndex = 1;
            this.txt_videoProperty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_videoProperty.CustomButton.UseSelectable = true;
            this.txt_videoProperty.CustomButton.Visible = false;
            this.txt_videoProperty.Lines = new string[0];
            this.txt_videoProperty.Location = new System.Drawing.Point(23, 173);
            this.txt_videoProperty.MaxLength = 32767;
            this.txt_videoProperty.Name = "txt_videoProperty";
            this.txt_videoProperty.PasswordChar = '\0';
            this.txt_videoProperty.PromptText = "Video property link";
            this.txt_videoProperty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_videoProperty.SelectedText = "";
            this.txt_videoProperty.SelectionLength = 0;
            this.txt_videoProperty.SelectionStart = 0;
            this.txt_videoProperty.ShortcutsEnabled = true;
            this.txt_videoProperty.Size = new System.Drawing.Size(261, 23);
            this.txt_videoProperty.TabIndex = 8;
            this.txt_videoProperty.UseSelectable = true;
            this.txt_videoProperty.WaterMark = "Video property link";
            this.txt_videoProperty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_videoProperty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_gpsCoordinates
            // 
            // 
            // 
            // 
            this.txt_gpsCoordinates.CustomButton.Image = null;
            this.txt_gpsCoordinates.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txt_gpsCoordinates.CustomButton.Name = "";
            this.txt_gpsCoordinates.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_gpsCoordinates.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_gpsCoordinates.CustomButton.TabIndex = 1;
            this.txt_gpsCoordinates.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_gpsCoordinates.CustomButton.UseSelectable = true;
            this.txt_gpsCoordinates.CustomButton.Visible = false;
            this.txt_gpsCoordinates.Lines = new string[0];
            this.txt_gpsCoordinates.Location = new System.Drawing.Point(23, 529);
            this.txt_gpsCoordinates.MaxLength = 32767;
            this.txt_gpsCoordinates.Name = "txt_gpsCoordinates";
            this.txt_gpsCoordinates.PasswordChar = '\0';
            this.txt_gpsCoordinates.PromptText = "GPS Coordinates";
            this.txt_gpsCoordinates.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_gpsCoordinates.SelectedText = "";
            this.txt_gpsCoordinates.SelectionLength = 0;
            this.txt_gpsCoordinates.SelectionStart = 0;
            this.txt_gpsCoordinates.ShortcutsEnabled = true;
            this.txt_gpsCoordinates.Size = new System.Drawing.Size(262, 23);
            this.txt_gpsCoordinates.TabIndex = 19;
            this.txt_gpsCoordinates.UseSelectable = true;
            this.txt_gpsCoordinates.WaterMark = "GPS Coordinates";
            this.txt_gpsCoordinates.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_gpsCoordinates.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtDateSold
            // 
            this.dtDateSold.Location = new System.Drawing.Point(313, 544);
            this.dtDateSold.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDateSold.Name = "dtDateSold";
            this.dtDateSold.Size = new System.Drawing.Size(205, 29);
            this.dtDateSold.TabIndex = 26;
            // 
            // txt_soldTo
            // 
            // 
            // 
            // 
            this.txt_soldTo.CustomButton.Image = null;
            this.txt_soldTo.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_soldTo.CustomButton.Name = "";
            this.txt_soldTo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_soldTo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_soldTo.CustomButton.TabIndex = 1;
            this.txt_soldTo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_soldTo.CustomButton.UseSelectable = true;
            this.txt_soldTo.CustomButton.Visible = false;
            this.txt_soldTo.Lines = new string[0];
            this.txt_soldTo.Location = new System.Drawing.Point(23, 442);
            this.txt_soldTo.MaxLength = 32767;
            this.txt_soldTo.Name = "txt_soldTo";
            this.txt_soldTo.PasswordChar = '\0';
            this.txt_soldTo.PromptText = "Sold to - Land buyer";
            this.txt_soldTo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_soldTo.SelectedText = "";
            this.txt_soldTo.SelectionLength = 0;
            this.txt_soldTo.SelectionStart = 0;
            this.txt_soldTo.ShortcutsEnabled = true;
            this.txt_soldTo.Size = new System.Drawing.Size(261, 23);
            this.txt_soldTo.TabIndex = 16;
            this.txt_soldTo.UseSelectable = true;
            this.txt_soldTo.WaterMark = "Sold to - Land buyer";
            this.txt_soldTo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_soldTo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_buyerEmail
            // 
            // 
            // 
            // 
            this.txt_buyerEmail.CustomButton.Image = null;
            this.txt_buyerEmail.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txt_buyerEmail.CustomButton.Name = "";
            this.txt_buyerEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_buyerEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_buyerEmail.CustomButton.TabIndex = 1;
            this.txt_buyerEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_buyerEmail.CustomButton.UseSelectable = true;
            this.txt_buyerEmail.CustomButton.Visible = false;
            this.txt_buyerEmail.Lines = new string[0];
            this.txt_buyerEmail.Location = new System.Drawing.Point(22, 202);
            this.txt_buyerEmail.MaxLength = 32767;
            this.txt_buyerEmail.Name = "txt_buyerEmail";
            this.txt_buyerEmail.PasswordChar = '\0';
            this.txt_buyerEmail.PromptText = "Buyer\'s Email";
            this.txt_buyerEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_buyerEmail.SelectedText = "";
            this.txt_buyerEmail.SelectionLength = 0;
            this.txt_buyerEmail.SelectionStart = 0;
            this.txt_buyerEmail.ShortcutsEnabled = true;
            this.txt_buyerEmail.Size = new System.Drawing.Size(262, 23);
            this.txt_buyerEmail.TabIndex = 9;
            this.txt_buyerEmail.UseSelectable = true;
            this.txt_buyerEmail.WaterMark = "Buyer\'s Email";
            this.txt_buyerEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_buyerEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_buyerPhoneNumber
            // 
            // 
            // 
            // 
            this.txt_buyerPhoneNumber.CustomButton.Image = null;
            this.txt_buyerPhoneNumber.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txt_buyerPhoneNumber.CustomButton.Name = "";
            this.txt_buyerPhoneNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_buyerPhoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_buyerPhoneNumber.CustomButton.TabIndex = 1;
            this.txt_buyerPhoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_buyerPhoneNumber.CustomButton.UseSelectable = true;
            this.txt_buyerPhoneNumber.CustomButton.Visible = false;
            this.txt_buyerPhoneNumber.Lines = new string[0];
            this.txt_buyerPhoneNumber.Location = new System.Drawing.Point(22, 232);
            this.txt_buyerPhoneNumber.MaxLength = 32767;
            this.txt_buyerPhoneNumber.Name = "txt_buyerPhoneNumber";
            this.txt_buyerPhoneNumber.PasswordChar = '\0';
            this.txt_buyerPhoneNumber.PromptText = "Buyer\'s Phone Number";
            this.txt_buyerPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_buyerPhoneNumber.SelectedText = "";
            this.txt_buyerPhoneNumber.SelectionLength = 0;
            this.txt_buyerPhoneNumber.SelectionStart = 0;
            this.txt_buyerPhoneNumber.ShortcutsEnabled = true;
            this.txt_buyerPhoneNumber.Size = new System.Drawing.Size(262, 23);
            this.txt_buyerPhoneNumber.TabIndex = 10;
            this.txt_buyerPhoneNumber.UseSelectable = true;
            this.txt_buyerPhoneNumber.WaterMark = "Buyer\'s Phone Number";
            this.txt_buyerPhoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_buyerPhoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_termsAndConditions
            // 
            // 
            // 
            // 
            this.txt_termsAndConditions.CustomButton.Image = null;
            this.txt_termsAndConditions.CustomButton.Location = new System.Drawing.Point(286, 2);
            this.txt_termsAndConditions.CustomButton.Name = "";
            this.txt_termsAndConditions.CustomButton.Size = new System.Drawing.Size(113, 113);
            this.txt_termsAndConditions.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_termsAndConditions.CustomButton.TabIndex = 1;
            this.txt_termsAndConditions.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_termsAndConditions.CustomButton.UseSelectable = true;
            this.txt_termsAndConditions.CustomButton.Visible = false;
            this.txt_termsAndConditions.Lines = new string[0];
            this.txt_termsAndConditions.Location = new System.Drawing.Point(310, 232);
            this.txt_termsAndConditions.MaxLength = 32767;
            this.txt_termsAndConditions.Multiline = true;
            this.txt_termsAndConditions.Name = "txt_termsAndConditions";
            this.txt_termsAndConditions.PasswordChar = '\0';
            this.txt_termsAndConditions.PromptText = "Terms and Conditions";
            this.txt_termsAndConditions.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_termsAndConditions.SelectedText = "";
            this.txt_termsAndConditions.SelectionLength = 0;
            this.txt_termsAndConditions.SelectionStart = 0;
            this.txt_termsAndConditions.ShortcutsEnabled = true;
            this.txt_termsAndConditions.Size = new System.Drawing.Size(402, 118);
            this.txt_termsAndConditions.TabIndex = 21;
            this.txt_termsAndConditions.UseSelectable = true;
            this.txt_termsAndConditions.WaterMark = "Terms and Conditions";
            this.txt_termsAndConditions.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_termsAndConditions.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_notesForTheTerm
            // 
            // 
            // 
            // 
            this.txt_notesForTheTerm.CustomButton.Image = null;
            this.txt_notesForTheTerm.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txt_notesForTheTerm.CustomButton.Name = "";
            this.txt_notesForTheTerm.CustomButton.Size = new System.Drawing.Size(57, 57);
            this.txt_notesForTheTerm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_notesForTheTerm.CustomButton.TabIndex = 1;
            this.txt_notesForTheTerm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_notesForTheTerm.CustomButton.UseSelectable = true;
            this.txt_notesForTheTerm.CustomButton.Visible = false;
            this.txt_notesForTheTerm.Lines = new string[0];
            this.txt_notesForTheTerm.Location = new System.Drawing.Point(23, 261);
            this.txt_notesForTheTerm.MaxLength = 32767;
            this.txt_notesForTheTerm.Multiline = true;
            this.txt_notesForTheTerm.Name = "txt_notesForTheTerm";
            this.txt_notesForTheTerm.PasswordChar = '\0';
            this.txt_notesForTheTerm.PromptText = "Notes for the terms";
            this.txt_notesForTheTerm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_notesForTheTerm.SelectedText = "";
            this.txt_notesForTheTerm.SelectionLength = 0;
            this.txt_notesForTheTerm.SelectionStart = 0;
            this.txt_notesForTheTerm.ShortcutsEnabled = true;
            this.txt_notesForTheTerm.Size = new System.Drawing.Size(261, 59);
            this.txt_notesForTheTerm.TabIndex = 11;
            this.txt_notesForTheTerm.UseSelectable = true;
            this.txt_notesForTheTerm.WaterMark = "Notes for the terms";
            this.txt_notesForTheTerm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_notesForTheTerm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_paymentTerms
            // 
            // 
            // 
            // 
            this.txt_paymentTerms.CustomButton.Image = null;
            this.txt_paymentTerms.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txt_paymentTerms.CustomButton.Name = "";
            this.txt_paymentTerms.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_paymentTerms.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_paymentTerms.CustomButton.TabIndex = 1;
            this.txt_paymentTerms.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_paymentTerms.CustomButton.UseSelectable = true;
            this.txt_paymentTerms.CustomButton.Visible = false;
            this.txt_paymentTerms.Lines = new string[0];
            this.txt_paymentTerms.Location = new System.Drawing.Point(23, 471);
            this.txt_paymentTerms.MaxLength = 32767;
            this.txt_paymentTerms.Name = "txt_paymentTerms";
            this.txt_paymentTerms.PasswordChar = '\0';
            this.txt_paymentTerms.PromptText = "Payment Terms";
            this.txt_paymentTerms.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_paymentTerms.SelectedText = "";
            this.txt_paymentTerms.SelectionLength = 0;
            this.txt_paymentTerms.SelectionStart = 0;
            this.txt_paymentTerms.ShortcutsEnabled = true;
            this.txt_paymentTerms.Size = new System.Drawing.Size(262, 23);
            this.txt_paymentTerms.TabIndex = 17;
            this.txt_paymentTerms.UseSelectable = true;
            this.txt_paymentTerms.WaterMark = "Payment Terms";
            this.txt_paymentTerms.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_paymentTerms.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_urlDeeds
            // 
            // 
            // 
            // 
            this.txt_urlDeeds.CustomButton.Image = null;
            this.txt_urlDeeds.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_urlDeeds.CustomButton.Name = "";
            this.txt_urlDeeds.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_urlDeeds.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_urlDeeds.CustomButton.TabIndex = 1;
            this.txt_urlDeeds.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_urlDeeds.CustomButton.UseSelectable = true;
            this.txt_urlDeeds.CustomButton.Visible = false;
            this.txt_urlDeeds.Lines = new string[0];
            this.txt_urlDeeds.Location = new System.Drawing.Point(23, 326);
            this.txt_urlDeeds.MaxLength = 32767;
            this.txt_urlDeeds.Name = "txt_urlDeeds";
            this.txt_urlDeeds.PasswordChar = '\0';
            this.txt_urlDeeds.PromptText = "URL Deeds";
            this.txt_urlDeeds.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_urlDeeds.SelectedText = "";
            this.txt_urlDeeds.SelectionLength = 0;
            this.txt_urlDeeds.SelectionStart = 0;
            this.txt_urlDeeds.ShortcutsEnabled = true;
            this.txt_urlDeeds.Size = new System.Drawing.Size(261, 23);
            this.txt_urlDeeds.TabIndex = 12;
            this.txt_urlDeeds.UseSelectable = true;
            this.txt_urlDeeds.WaterMark = "URL Deeds";
            this.txt_urlDeeds.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_urlDeeds.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_urlStamp
            // 
            // 
            // 
            // 
            this.txt_urlStamp.CustomButton.Image = null;
            this.txt_urlStamp.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_urlStamp.CustomButton.Name = "";
            this.txt_urlStamp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_urlStamp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_urlStamp.CustomButton.TabIndex = 1;
            this.txt_urlStamp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_urlStamp.CustomButton.UseSelectable = true;
            this.txt_urlStamp.CustomButton.Visible = false;
            this.txt_urlStamp.Lines = new string[0];
            this.txt_urlStamp.Location = new System.Drawing.Point(23, 384);
            this.txt_urlStamp.MaxLength = 32767;
            this.txt_urlStamp.Name = "txt_urlStamp";
            this.txt_urlStamp.PasswordChar = '\0';
            this.txt_urlStamp.PromptText = "URL - Stamp Deeds";
            this.txt_urlStamp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_urlStamp.SelectedText = "";
            this.txt_urlStamp.SelectionLength = 0;
            this.txt_urlStamp.SelectionStart = 0;
            this.txt_urlStamp.ShortcutsEnabled = true;
            this.txt_urlStamp.Size = new System.Drawing.Size(261, 23);
            this.txt_urlStamp.TabIndex = 14;
            this.txt_urlStamp.UseSelectable = true;
            this.txt_urlStamp.WaterMark = "URL - Stamp Deeds";
            this.txt_urlStamp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_urlStamp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_urlMoonclerk
            // 
            // 
            // 
            // 
            this.txt_urlMoonclerk.CustomButton.Image = null;
            this.txt_urlMoonclerk.CustomButton.Location = new System.Drawing.Point(380, 1);
            this.txt_urlMoonclerk.CustomButton.Name = "";
            this.txt_urlMoonclerk.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_urlMoonclerk.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_urlMoonclerk.CustomButton.TabIndex = 1;
            this.txt_urlMoonclerk.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_urlMoonclerk.CustomButton.UseSelectable = true;
            this.txt_urlMoonclerk.CustomButton.Visible = false;
            this.txt_urlMoonclerk.Lines = new string[0];
            this.txt_urlMoonclerk.Location = new System.Drawing.Point(310, 442);
            this.txt_urlMoonclerk.MaxLength = 32767;
            this.txt_urlMoonclerk.Name = "txt_urlMoonclerk";
            this.txt_urlMoonclerk.PasswordChar = '\0';
            this.txt_urlMoonclerk.PromptText = "URL - Moonclerk form or strope - Upon Purchase of the land";
            this.txt_urlMoonclerk.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_urlMoonclerk.SelectedText = "";
            this.txt_urlMoonclerk.SelectionLength = 0;
            this.txt_urlMoonclerk.SelectionStart = 0;
            this.txt_urlMoonclerk.ShortcutsEnabled = true;
            this.txt_urlMoonclerk.Size = new System.Drawing.Size(402, 23);
            this.txt_urlMoonclerk.TabIndex = 23;
            this.txt_urlMoonclerk.UseSelectable = true;
            this.txt_urlMoonclerk.WaterMark = "URL - Moonclerk form or strope - Upon Purchase of the land";
            this.txt_urlMoonclerk.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_urlMoonclerk.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_status
            // 
            // 
            // 
            // 
            this.txt_status.CustomButton.Image = null;
            this.txt_status.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_status.CustomButton.Name = "";
            this.txt_status.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_status.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_status.CustomButton.TabIndex = 1;
            this.txt_status.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_status.CustomButton.UseSelectable = true;
            this.txt_status.CustomButton.Visible = false;
            this.txt_status.Lines = new string[0];
            this.txt_status.Location = new System.Drawing.Point(23, 355);
            this.txt_status.MaxLength = 32767;
            this.txt_status.Name = "txt_status";
            this.txt_status.PasswordChar = '\0';
            this.txt_status.PromptText = "Status";
            this.txt_status.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_status.SelectedText = "";
            this.txt_status.SelectionLength = 0;
            this.txt_status.SelectionStart = 0;
            this.txt_status.ShortcutsEnabled = true;
            this.txt_status.Size = new System.Drawing.Size(261, 23);
            this.txt_status.TabIndex = 13;
            this.txt_status.UseSelectable = true;
            this.txt_status.WaterMark = "Status";
            this.txt_status.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_status.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_county
            // 
            // 
            // 
            // 
            this.txt_county.CustomButton.Image = null;
            this.txt_county.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_county.CustomButton.Name = "";
            this.txt_county.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_county.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_county.CustomButton.TabIndex = 1;
            this.txt_county.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_county.CustomButton.UseSelectable = true;
            this.txt_county.CustomButton.Visible = false;
            this.txt_county.Lines = new string[0];
            this.txt_county.Location = new System.Drawing.Point(23, 413);
            this.txt_county.MaxLength = 32767;
            this.txt_county.Name = "txt_county";
            this.txt_county.PasswordChar = '\0';
            this.txt_county.PromptText = "County";
            this.txt_county.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_county.SelectedText = "";
            this.txt_county.SelectionLength = 0;
            this.txt_county.SelectionStart = 0;
            this.txt_county.ShortcutsEnabled = true;
            this.txt_county.Size = new System.Drawing.Size(261, 23);
            this.txt_county.TabIndex = 15;
            this.txt_county.UseSelectable = true;
            this.txt_county.WaterMark = "County";
            this.txt_county.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_county.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cBoxCurrentStatus
            // 
            this.cBoxCurrentStatus.FormattingEnabled = true;
            this.cBoxCurrentStatus.ItemHeight = 23;
            this.cBoxCurrentStatus.Items.AddRange(new object[] {
            "Sold",
            "For Sale",
            "Coming Soon"});
            this.cBoxCurrentStatus.Location = new System.Drawing.Point(313, 490);
            this.cBoxCurrentStatus.Name = "cBoxCurrentStatus";
            this.cBoxCurrentStatus.Size = new System.Drawing.Size(181, 29);
            this.cBoxCurrentStatus.TabIndex = 24;
            this.cBoxCurrentStatus.UseSelectable = true;
            // 
            // cBoxLandsSoldSite
            // 
            this.cBoxLandsSoldSite.FormattingEnabled = true;
            this.cBoxLandsSoldSite.ItemHeight = 23;
            this.cBoxLandsSoldSite.Items.AddRange(new object[] {
            "Sold",
            "For Sale",
            "Coming Soon"});
            this.cBoxLandsSoldSite.Location = new System.Drawing.Point(524, 490);
            this.cBoxLandsSoldSite.Name = "cBoxLandsSoldSite";
            this.cBoxLandsSoldSite.Size = new System.Drawing.Size(181, 29);
            this.cBoxLandsSoldSite.TabIndex = 25;
            this.cBoxLandsSoldSite.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(203, 615);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(158, 41);
            this.metroButton3.TabIndex = 60;
            this.metroButton3.Text = "View all social media sites";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.ActiveControl = null;
            this.btn_clear.Location = new System.Drawing.Point(16, 598);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(77, 58);
            this.btn_clear.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_clear.TabIndex = 28;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.TileImage = global::RVL_Management_System.Properties.Resources.cancel;
            this.btn_clear.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseSelectable = true;
            this.btn_clear.UseTileImage = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // btn_save
            // 
            this.btn_save.ActiveControl = null;
            this.btn_save.Location = new System.Drawing.Point(99, 598);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 58);
            this.btn_save.TabIndex = 29;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.TileImage = global::RVL_Management_System.Properties.Resources.plus_1;
            this.btn_save.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseSelectable = true;
            this.btn_save.UseTileImage = true;
            this.btn_save.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // cBoxLandOwner
            // 
            this.cBoxLandOwner.FormattingEnabled = true;
            this.cBoxLandOwner.ItemHeight = 23;
            this.cBoxLandOwner.Location = new System.Drawing.Point(524, 544);
            this.cBoxLandOwner.Name = "cBoxLandOwner";
            this.cBoxLandOwner.Size = new System.Drawing.Size(181, 29);
            this.cBoxLandOwner.TabIndex = 27;
            this.cBoxLandOwner.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(524, 522);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(166, 19);
            this.metroLabel2.TabIndex = 61;
            this.metroLabel2.Text = "Current Owner of the Land";
            // 
            // txt_additionalNotes
            // 
            // 
            // 
            // 
            this.txt_additionalNotes.CustomButton.Image = null;
            this.txt_additionalNotes.CustomButton.Location = new System.Drawing.Point(324, 2);
            this.txt_additionalNotes.CustomButton.Name = "";
            this.txt_additionalNotes.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.txt_additionalNotes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_additionalNotes.CustomButton.TabIndex = 1;
            this.txt_additionalNotes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_additionalNotes.CustomButton.UseSelectable = true;
            this.txt_additionalNotes.CustomButton.Visible = false;
            this.txt_additionalNotes.Lines = new string[0];
            this.txt_additionalNotes.Location = new System.Drawing.Point(310, 356);
            this.txt_additionalNotes.MaxLength = 32767;
            this.txt_additionalNotes.Multiline = true;
            this.txt_additionalNotes.Name = "txt_additionalNotes";
            this.txt_additionalNotes.PasswordChar = '\0';
            this.txt_additionalNotes.PromptText = "Additional Notes(If any from the VA)";
            this.txt_additionalNotes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_additionalNotes.SelectedText = "";
            this.txt_additionalNotes.SelectionLength = 0;
            this.txt_additionalNotes.SelectionStart = 0;
            this.txt_additionalNotes.ShortcutsEnabled = true;
            this.txt_additionalNotes.Size = new System.Drawing.Size(402, 80);
            this.txt_additionalNotes.TabIndex = 22;
            this.txt_additionalNotes.UseSelectable = true;
            this.txt_additionalNotes.WaterMark = "Additional Notes(If any from the VA)";
            this.txt_additionalNotes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_additionalNotes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cBoxPaymentRemarks
            // 
            this.cBoxPaymentRemarks.FormattingEnabled = true;
            this.cBoxPaymentRemarks.ItemHeight = 23;
            this.cBoxPaymentRemarks.Items.AddRange(new object[] {
            "Unpaid",
            "Paid in Full"});
            this.cBoxPaymentRemarks.Location = new System.Drawing.Point(524, 598);
            this.cBoxPaymentRemarks.Name = "cBoxPaymentRemarks";
            this.cBoxPaymentRemarks.Size = new System.Drawing.Size(181, 29);
            this.cBoxPaymentRemarks.TabIndex = 62;
            this.cBoxPaymentRemarks.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(524, 576);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(113, 19);
            this.metroLabel3.TabIndex = 63;
            this.metroLabel3.Text = "Payment Remarks";
            // 
            // PropertyInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 679);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cBoxPaymentRemarks);
            this.Controls.Add(this.cBoxLandOwner);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.cBoxLandsSoldSite);
            this.Controls.Add(this.cBoxCurrentStatus);
            this.Controls.Add(this.txt_additionalNotes);
            this.Controls.Add(this.txt_county);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_urlMoonclerk);
            this.Controls.Add(this.txt_urlStamp);
            this.Controls.Add(this.txt_urlDeeds);
            this.Controls.Add(this.txt_paymentTerms);
            this.Controls.Add(this.txt_notesForTheTerm);
            this.Controls.Add(this.txt_termsAndConditions);
            this.Controls.Add(this.txt_buyerPhoneNumber);
            this.Controls.Add(this.txt_buyerEmail);
            this.Controls.Add(this.txt_soldTo);
            this.Controls.Add(this.dtDateSold);
            this.Controls.Add(this.txt_gpsCoordinates);
            this.Controls.Add(this.txt_videoProperty);
            this.Controls.Add(this.txt_gpsUrl);
            this.Controls.Add(this.txt_urlLinkForSocialMedia);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_imageNo);
            this.Controls.Add(this.txt_updatedPrice);
            this.Controls.Add(this.txt_currentMarketValue);
            this.Controls.Add(this.txt_originalPrice);
            this.Controls.Add(this.txt_apn);
            this.Controls.Add(this.dtDateListed);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropertyInventory";
            this.Resizable = false;
            this.Text = "Add Property Inventory Information";
            this.Load += new System.EventHandler(this.Frm_PropertyInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroDateTime dtDateListed;
        private MetroFramework.Controls.MetroTextBox txt_apn;
        private MetroFramework.Controls.MetroTextBox txt_originalPrice;
        private MetroFramework.Controls.MetroTextBox txt_currentMarketValue;
        private MetroFramework.Controls.MetroTextBox txt_updatedPrice;
        private MetroFramework.Controls.MetroTextBox txt_imageNo;
        private MetroFramework.Controls.MetroTextBox txt_title;
        private MetroFramework.Controls.MetroTextBox txt_urlLinkForSocialMedia;
        private MetroFramework.Controls.MetroTextBox txt_gpsUrl;
        private MetroFramework.Controls.MetroTextBox txt_videoProperty;
        private MetroFramework.Controls.MetroTextBox txt_gpsCoordinates;
        private MetroFramework.Controls.MetroDateTime dtDateSold;
        private MetroFramework.Controls.MetroTextBox txt_soldTo;
        private MetroFramework.Controls.MetroTextBox txt_buyerEmail;
        private MetroFramework.Controls.MetroTextBox txt_buyerPhoneNumber;
        private MetroFramework.Controls.MetroTextBox txt_termsAndConditions;
        private MetroFramework.Controls.MetroTextBox txt_notesForTheTerm;
        private MetroFramework.Controls.MetroTextBox txt_paymentTerms;
        private MetroFramework.Controls.MetroTextBox txt_urlDeeds;
        private MetroFramework.Controls.MetroTextBox txt_urlStamp;
        private MetroFramework.Controls.MetroTextBox txt_urlMoonclerk;
        private MetroFramework.Controls.MetroTextBox txt_status;
        private MetroFramework.Controls.MetroTextBox txt_county;
        private MetroFramework.Controls.MetroComboBox cBoxCurrentStatus;
        private MetroFramework.Controls.MetroComboBox cBoxLandsSoldSite;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTile btn_clear;
        private MetroFramework.Controls.MetroTile btn_save;
        private MetroFramework.Controls.MetroComboBox cBoxLandOwner;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_additionalNotes;
        private MetroFramework.Controls.MetroComboBox cBoxPaymentRemarks;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}