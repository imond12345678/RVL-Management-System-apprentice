namespace RVL_Management_System.Forms
{
    partial class PropertyInventoryDelete
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
            this.GridView = new MetroFramework.Controls.MetroGrid();
            this.txt_search = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cBoxSearchBy = new MetroFramework.Controls.MetroComboBox();
            this.txt_apnID = new MetroFramework.Controls.MetroTextBox();
            this.btn_update = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
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
            this.GridView.Location = new System.Drawing.Point(23, 161);
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
            this.GridView.Size = new System.Drawing.Size(784, 386);
            this.GridView.TabIndex = 0;
            this.GridView.SelectionChanged += new System.EventHandler(this.GridView_SelectionChanged);
            // 
            // txt_search
            // 
            // 
            // 
            // 
            this.txt_search.CustomButton.BackColor = System.Drawing.Color.White;
            this.txt_search.CustomButton.Image = global::RVL_Management_System.Properties.Resources.magnifier;
            this.txt_search.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.txt_search.CustomButton.Name = "";
            this.txt_search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search.CustomButton.TabIndex = 1;
            this.txt_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search.CustomButton.UseSelectable = true;
            this.txt_search.CustomButton.UseVisualStyleBackColor = false;
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(158, 82);
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
            this.txt_search.Size = new System.Drawing.Size(180, 23);
            this.txt_search.TabIndex = 13;
            this.txt_search.UseSelectable = true;
            this.txt_search.WaterMark = "Search";
            this.txt_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_search.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txt_search_ButtonClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Search By:";
            // 
            // cBoxSearchBy
            // 
            this.cBoxSearchBy.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cBoxSearchBy.FormattingEnabled = true;
            this.cBoxSearchBy.ItemHeight = 19;
            this.cBoxSearchBy.Items.AddRange(new object[] {
            "APN",
            "Title"});
            this.cBoxSearchBy.Location = new System.Drawing.Point(23, 82);
            this.cBoxSearchBy.Name = "cBoxSearchBy";
            this.cBoxSearchBy.Size = new System.Drawing.Size(129, 25);
            this.cBoxSearchBy.TabIndex = 11;
            this.cBoxSearchBy.UseSelectable = true;
            // 
            // txt_apnID
            // 
            // 
            // 
            // 
            this.txt_apnID.CustomButton.Image = null;
            this.txt_apnID.CustomButton.Location = new System.Drawing.Point(11, 1);
            this.txt_apnID.CustomButton.Name = "";
            this.txt_apnID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_apnID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_apnID.CustomButton.TabIndex = 1;
            this.txt_apnID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_apnID.CustomButton.UseSelectable = true;
            this.txt_apnID.CustomButton.Visible = false;
            this.txt_apnID.Lines = new string[0];
            this.txt_apnID.Location = new System.Drawing.Point(344, 82);
            this.txt_apnID.MaxLength = 32767;
            this.txt_apnID.Name = "txt_apnID";
            this.txt_apnID.PasswordChar = '\0';
            this.txt_apnID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_apnID.SelectedText = "";
            this.txt_apnID.SelectionLength = 0;
            this.txt_apnID.SelectionStart = 0;
            this.txt_apnID.ShortcutsEnabled = true;
            this.txt_apnID.Size = new System.Drawing.Size(33, 23);
            this.txt_apnID.TabIndex = 14;
            this.txt_apnID.UseSelectable = true;
            this.txt_apnID.Visible = false;
            this.txt_apnID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_apnID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_update
            // 
            this.btn_update.ActiveControl = null;
            this.btn_update.Location = new System.Drawing.Point(344, 82);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(86, 58);
            this.btn_update.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_update.TabIndex = 51;
            this.btn_update.Text = "Delete";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.TileImage = global::RVL_Management_System.Properties.Resources.cancel;
            this.btn_update.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.UseSelectable = true;
            this.btn_update.UseTileImage = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // PropertyInventoryDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 570);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_apnID);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cBoxSearchBy);
            this.Controls.Add(this.GridView);
            this.MaximizeBox = false;
            this.Name = "PropertyInventoryDelete";
            this.Resizable = false;
            this.Text = "Delete Property Inventory Information";
            this.Load += new System.EventHandler(this.PropertyInventoryDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid GridView;
        private MetroFramework.Controls.MetroTextBox txt_search;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cBoxSearchBy;
        private MetroFramework.Controls.MetroTextBox txt_apnID;
        private MetroFramework.Controls.MetroTile btn_update;
    }
}