namespace RVL_Management_System.Forms
{
    partial class SocialMediaDelete
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
            this.txt_apnDelete = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.btn_update = new MetroFramework.Controls.MetroTile();
            this.cBoxSearchBy = new MetroFramework.Controls.MetroComboBox();
            this.txt_search = new MetroFramework.Controls.MetroTextBox();
            this.GridView = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.GridView);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.cBoxSearchBy);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.txt_apnDelete);
            this.groupBox1.Location = new System.Drawing.Point(15, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 313);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // txt_apnDelete
            // 
            // 
            // 
            // 
            this.txt_apnDelete.CustomButton.Image = null;
            this.txt_apnDelete.CustomButton.Location = new System.Drawing.Point(36, 1);
            this.txt_apnDelete.CustomButton.Name = "";
            this.txt_apnDelete.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_apnDelete.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_apnDelete.CustomButton.TabIndex = 1;
            this.txt_apnDelete.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_apnDelete.CustomButton.UseSelectable = true;
            this.txt_apnDelete.CustomButton.Visible = false;
            this.txt_apnDelete.Enabled = false;
            this.txt_apnDelete.Lines = new string[0];
            this.txt_apnDelete.Location = new System.Drawing.Point(344, 41);
            this.txt_apnDelete.MaxLength = 32767;
            this.txt_apnDelete.Name = "txt_apnDelete";
            this.txt_apnDelete.PasswordChar = '\0';
            this.txt_apnDelete.PromptText = "APN ID";
            this.txt_apnDelete.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_apnDelete.SelectedText = "";
            this.txt_apnDelete.SelectionLength = 0;
            this.txt_apnDelete.SelectionStart = 0;
            this.txt_apnDelete.ShortcutsEnabled = true;
            this.txt_apnDelete.Size = new System.Drawing.Size(58, 23);
            this.txt_apnDelete.TabIndex = 52;
            this.txt_apnDelete.UseSelectable = true;
            this.txt_apnDelete.Visible = false;
            this.txt_apnDelete.WaterMark = "APN ID";
            this.txt_apnDelete.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_apnDelete.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(6, 19);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(66, 19);
            this.metroLabel12.TabIndex = 46;
            this.metroLabel12.Text = "Search By";
            // 
            // btn_update
            // 
            this.btn_update.ActiveControl = null;
            this.btn_update.Location = new System.Drawing.Point(344, 41);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(86, 58);
            this.btn_update.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_update.TabIndex = 50;
            this.btn_update.Text = "Delete";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.TileImage = global::RVL_Management_System.Properties.Resources.cancel;
            this.btn_update.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.UseSelectable = true;
            this.btn_update.UseTileImage = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cBoxSearchBy
            // 
            this.cBoxSearchBy.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cBoxSearchBy.FormattingEnabled = true;
            this.cBoxSearchBy.ItemHeight = 19;
            this.cBoxSearchBy.Items.AddRange(new object[] {
            "APN ID",
            "Title"});
            this.cBoxSearchBy.Location = new System.Drawing.Point(6, 41);
            this.cBoxSearchBy.Name = "cBoxSearchBy";
            this.cBoxSearchBy.Size = new System.Drawing.Size(163, 25);
            this.cBoxSearchBy.TabIndex = 47;
            this.cBoxSearchBy.UseSelectable = true;
            // 
            // txt_search
            // 
            // 
            // 
            // 
            this.txt_search.CustomButton.Image = global::RVL_Management_System.Properties.Resources.magnifier;
            this.txt_search.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txt_search.CustomButton.Name = "";
            this.txt_search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search.CustomButton.TabIndex = 1;
            this.txt_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search.CustomButton.UseSelectable = true;
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(175, 41);
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
            this.txt_search.Size = new System.Drawing.Size(163, 23);
            this.txt_search.TabIndex = 45;
            this.txt_search.UseSelectable = true;
            this.txt_search.WaterMark = "Search";
            this.txt_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_search.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txt_search_ButtonClick);
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
            this.GridView.Location = new System.Drawing.Point(15, 105);
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
            this.GridView.Size = new System.Drawing.Size(498, 194);
            this.GridView.TabIndex = 53;
            this.GridView.SelectionChanged += new System.EventHandler(this.GridView_SelectionChanged);
            // 
            // SocialMediaDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 401);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "SocialMediaDelete";
            this.Resizable = false;
            this.Text = "SocialMediaDelete";
            this.Load += new System.EventHandler(this.SocialMediaDelete_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTile btn_update;
        private MetroFramework.Controls.MetroComboBox cBoxSearchBy;
        private MetroFramework.Controls.MetroTextBox txt_search;
        private MetroFramework.Controls.MetroGrid GridView;
        private MetroFramework.Controls.MetroTextBox txt_apnDelete;
    }
}