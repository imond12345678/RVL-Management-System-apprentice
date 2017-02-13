namespace RVL_Management_System.Forms
{
    partial class VideoTutorialsDelete
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
            this.txt_vid = new MetroFramework.Controls.MetroTextBox();
            this.GridView = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cBoxSearchBy = new MetroFramework.Controls.MetroComboBox();
            this.txt_search = new MetroFramework.Controls.MetroTextBox();
            this.txt_delete = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_vid
            // 
            // 
            // 
            // 
            this.txt_vid.CustomButton.Image = null;
            this.txt_vid.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.txt_vid.CustomButton.Name = "";
            this.txt_vid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_vid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_vid.CustomButton.TabIndex = 1;
            this.txt_vid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_vid.CustomButton.UseSelectable = true;
            this.txt_vid.CustomButton.Visible = false;
            this.txt_vid.Lines = new string[0];
            this.txt_vid.Location = new System.Drawing.Point(209, 129);
            this.txt_vid.MaxLength = 32767;
            this.txt_vid.Name = "txt_vid";
            this.txt_vid.PasswordChar = '\0';
            this.txt_vid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_vid.SelectedText = "";
            this.txt_vid.SelectionLength = 0;
            this.txt_vid.SelectionStart = 0;
            this.txt_vid.ShortcutsEnabled = true;
            this.txt_vid.Size = new System.Drawing.Size(180, 23);
            this.txt_vid.TabIndex = 15;
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
            this.GridView.GridColor = System.Drawing.Color.White;
            this.GridView.Location = new System.Drawing.Point(23, 158);
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
            this.GridView.Size = new System.Drawing.Size(606, 150);
            this.GridView.TabIndex = 13;
            this.GridView.SelectionChanged += new System.EventHandler(this.GridView_SelectionChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Search By:";
            // 
            // cBoxSearchBy
            // 
            this.cBoxSearchBy.FormattingEnabled = true;
            this.cBoxSearchBy.ItemHeight = 23;
            this.cBoxSearchBy.Items.AddRange(new object[] {
            "VID",
            "Process"});
            this.cBoxSearchBy.Location = new System.Drawing.Point(23, 93);
            this.cBoxSearchBy.Name = "cBoxSearchBy";
            this.cBoxSearchBy.Size = new System.Drawing.Size(129, 29);
            this.cBoxSearchBy.TabIndex = 8;
            this.cBoxSearchBy.UseSelectable = true;
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
            this.txt_search.Location = new System.Drawing.Point(158, 99);
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
            this.txt_search.TabIndex = 10;
            this.txt_search.UseSelectable = true;
            this.txt_search.WaterMark = "Search";
            this.txt_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_search.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txt_search_ButtonClick);
            this.txt_search.ClearClicked += new MetroFramework.Controls.MetroTextBox.LUClear(this.txt_search_ClearClicked);
            // 
            // txt_delete
            // 
            // 
            // 
            // 
            this.txt_delete.CustomButton.BackColor = System.Drawing.Color.White;
            this.txt_delete.CustomButton.Image = global::RVL_Management_System.Properties.Resources.cancel;
            this.txt_delete.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.txt_delete.CustomButton.Name = "";
            this.txt_delete.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_delete.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_delete.CustomButton.TabIndex = 1;
            this.txt_delete.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_delete.CustomButton.UseSelectable = true;
            this.txt_delete.CustomButton.UseVisualStyleBackColor = false;
            this.txt_delete.Lines = new string[0];
            this.txt_delete.Location = new System.Drawing.Point(23, 128);
            this.txt_delete.MaxLength = 32767;
            this.txt_delete.Name = "txt_delete";
            this.txt_delete.PasswordChar = '\0';
            this.txt_delete.PromptText = "Delete";
            this.txt_delete.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_delete.SelectedText = "";
            this.txt_delete.SelectionLength = 0;
            this.txt_delete.SelectionStart = 0;
            this.txt_delete.ShortcutsEnabled = true;
            this.txt_delete.ShowButton = true;
            this.txt_delete.ShowClearButton = true;
            this.txt_delete.Size = new System.Drawing.Size(180, 23);
            this.txt_delete.TabIndex = 16;
            this.txt_delete.UseSelectable = true;
            this.txt_delete.WaterMark = "Delete";
            this.txt_delete.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_delete.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_delete.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.metroTextBox1_ButtonClick);
            // 
            // VideoTutorialsDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 325);
            this.Controls.Add(this.txt_delete);
            this.Controls.Add(this.txt_vid);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cBoxSearchBy);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoTutorialsDelete";
            this.Resizable = false;
            this.Text = "Video Tutorials Information Delete";
            this.Load += new System.EventHandler(this.Frm_VideoTutorialsDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_vid;
        private MetroFramework.Controls.MetroGrid GridView;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cBoxSearchBy;
        private MetroFramework.Controls.MetroTextBox txt_search;
        private MetroFramework.Controls.MetroTextBox txt_delete;
    }
}