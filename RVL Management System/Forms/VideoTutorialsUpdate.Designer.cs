namespace RVL_Management_System.Forms
{
    partial class VideoTutorialsUpdate
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
            this.txt_youtube = new MetroFramework.Controls.MetroTextBox();
            this.txt_process = new MetroFramework.Controls.MetroTextBox();
            this.cBoxSearchBy = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_search = new MetroFramework.Controls.MetroTextBox();
            this.txt_vid = new MetroFramework.Controls.MetroTextBox();
            this.GridView = new MetroFramework.Controls.MetroGrid();
            this.btn_clear = new MetroFramework.Controls.MetroTile();
            this.btn_update = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_youtube
            // 
            // 
            // 
            // 
            this.txt_youtube.CustomButton.Image = null;
            this.txt_youtube.CustomButton.Location = new System.Drawing.Point(259, 2);
            this.txt_youtube.CustomButton.Name = "";
            this.txt_youtube.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txt_youtube.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_youtube.CustomButton.TabIndex = 1;
            this.txt_youtube.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_youtube.CustomButton.UseSelectable = true;
            this.txt_youtube.CustomButton.Visible = false;
            this.txt_youtube.Lines = new string[0];
            this.txt_youtube.Location = new System.Drawing.Point(319, 73);
            this.txt_youtube.MaxLength = 32767;
            this.txt_youtube.Multiline = true;
            this.txt_youtube.Name = "txt_youtube";
            this.txt_youtube.PasswordChar = '\0';
            this.txt_youtube.PromptText = "Youtube Link";
            this.txt_youtube.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_youtube.SelectedText = "";
            this.txt_youtube.SelectionLength = 0;
            this.txt_youtube.SelectionStart = 0;
            this.txt_youtube.ShortcutsEnabled = true;
            this.txt_youtube.Size = new System.Drawing.Size(307, 50);
            this.txt_youtube.TabIndex = 9;
            this.txt_youtube.UseSelectable = true;
            this.txt_youtube.WaterMark = "Youtube Link";
            this.txt_youtube.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_youtube.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_process
            // 
            // 
            // 
            // 
            this.txt_process.CustomButton.Image = null;
            this.txt_process.CustomButton.Location = new System.Drawing.Point(259, 2);
            this.txt_process.CustomButton.Name = "";
            this.txt_process.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txt_process.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_process.CustomButton.TabIndex = 1;
            this.txt_process.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_process.CustomButton.UseSelectable = true;
            this.txt_process.CustomButton.Visible = false;
            this.txt_process.Lines = new string[0];
            this.txt_process.Location = new System.Drawing.Point(6, 73);
            this.txt_process.MaxLength = 32767;
            this.txt_process.Multiline = true;
            this.txt_process.Name = "txt_process";
            this.txt_process.PasswordChar = '\0';
            this.txt_process.PromptText = "Process";
            this.txt_process.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_process.SelectedText = "";
            this.txt_process.SelectionLength = 0;
            this.txt_process.SelectionStart = 0;
            this.txt_process.ShortcutsEnabled = true;
            this.txt_process.Size = new System.Drawing.Size(307, 50);
            this.txt_process.TabIndex = 8;
            this.txt_process.UseSelectable = true;
            this.txt_process.WaterMark = "Process";
            this.txt_process.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_process.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cBoxSearchBy
            // 
            this.cBoxSearchBy.FormattingEnabled = true;
            this.cBoxSearchBy.ItemHeight = 23;
            this.cBoxSearchBy.Items.AddRange(new object[] {
            "VID",
            "Process"});
            this.cBoxSearchBy.Location = new System.Drawing.Point(6, 38);
            this.cBoxSearchBy.Name = "cBoxSearchBy";
            this.cBoxSearchBy.Size = new System.Drawing.Size(200, 29);
            this.cBoxSearchBy.TabIndex = 12;
            this.cBoxSearchBy.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 16);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Search By:";
            // 
            // txt_search
            // 
            // 
            // 
            // 
            this.txt_search.CustomButton.Image = global::RVL_Management_System.Properties.Resources.magnifier;
            this.txt_search.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txt_search.CustomButton.Name = "";
            this.txt_search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search.CustomButton.TabIndex = 1;
            this.txt_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search.CustomButton.UseSelectable = true;
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(225, 38);
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
            this.txt_search.Size = new System.Drawing.Size(195, 23);
            this.txt_search.TabIndex = 14;
            this.txt_search.UseSelectable = true;
            this.txt_search.WaterMark = "Search";
            this.txt_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_search.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txt_search_ButtonClick);
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // txt_vid
            // 
            // 
            // 
            // 
            this.txt_vid.CustomButton.Image = null;
            this.txt_vid.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txt_vid.CustomButton.Name = "";
            this.txt_vid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_vid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_vid.CustomButton.TabIndex = 1;
            this.txt_vid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_vid.CustomButton.UseSelectable = true;
            this.txt_vid.CustomButton.Visible = false;
            this.txt_vid.Enabled = false;
            this.txt_vid.Lines = new string[0];
            this.txt_vid.Location = new System.Drawing.Point(6, 129);
            this.txt_vid.MaxLength = 32767;
            this.txt_vid.Name = "txt_vid";
            this.txt_vid.PasswordChar = '\0';
            this.txt_vid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_vid.SelectedText = "";
            this.txt_vid.SelectionLength = 0;
            this.txt_vid.SelectionStart = 0;
            this.txt_vid.ShortcutsEnabled = true;
            this.txt_vid.Size = new System.Drawing.Size(195, 23);
            this.txt_vid.TabIndex = 17;
            this.txt_vid.UseSelectable = true;
            this.txt_vid.Visible = false;
            this.txt_vid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_vid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.GridView.Location = new System.Drawing.Point(23, 266);
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
            this.GridView.Size = new System.Drawing.Size(663, 229);
            this.GridView.TabIndex = 18;
            this.GridView.SelectionChanged += new System.EventHandler(this.GridView_SelectionChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.ActiveControl = null;
            this.btn_clear.Location = new System.Drawing.Point(457, 129);
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
            this.btn_update.Location = new System.Drawing.Point(540, 129);
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
            this.btn_update.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.txt_process);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.txt_youtube);
            this.groupBox1.Controls.Add(this.cBoxSearchBy);
            this.groupBox1.Controls.Add(this.txt_vid);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 197);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // VideoTutorialsUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoTutorialsUpdate";
            this.Resizable = false;
            this.Text = "Video Tutorials Update";
            this.Load += new System.EventHandler(this.Frm_VideoTutorialsUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txt_youtube;
        private MetroFramework.Controls.MetroTextBox txt_process;
        private MetroFramework.Controls.MetroComboBox cBoxSearchBy;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_search;
        private MetroFramework.Controls.MetroTextBox txt_vid;
        private MetroFramework.Controls.MetroGrid GridView;
        private MetroFramework.Controls.MetroTile btn_clear;
        private MetroFramework.Controls.MetroTile btn_update;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}