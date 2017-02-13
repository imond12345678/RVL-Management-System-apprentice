namespace RVL_Management_System
{
    partial class Frm_Tasks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_uid = new MetroFramework.Controls.MetroTextBox();
            this.GridTask = new MetroFramework.Controls.MetroGrid();
            this.btn_task = new MetroFramework.Controls.MetroButton();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.cBoxTask = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_search = new MetroFramework.Controls.MetroTextBox();
            this.cBoxSearchBy = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTask)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_uid);
            this.groupBox1.Controls.Add(this.GridTask);
            this.groupBox1.Controls.Add(this.btn_task);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.cBoxTask);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.cBoxSearchBy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.groupBox1.Location = new System.Drawing.Point(15, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_uid
            // 
            // 
            // 
            // 
            this.txt_uid.CustomButton.Image = null;
            this.txt_uid.CustomButton.Location = new System.Drawing.Point(43, 1);
            this.txt_uid.CustomButton.Name = "";
            this.txt_uid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_uid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_uid.CustomButton.TabIndex = 1;
            this.txt_uid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_uid.CustomButton.UseSelectable = true;
            this.txt_uid.CustomButton.Visible = false;
            this.txt_uid.Enabled = false;
            this.txt_uid.Lines = new string[0];
            this.txt_uid.Location = new System.Drawing.Point(289, 241);
            this.txt_uid.MaxLength = 32767;
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.PasswordChar = '\0';
            this.txt_uid.PromptText = "User ID";
            this.txt_uid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_uid.SelectedText = "";
            this.txt_uid.SelectionLength = 0;
            this.txt_uid.SelectionStart = 0;
            this.txt_uid.ShortcutsEnabled = true;
            this.txt_uid.Size = new System.Drawing.Size(65, 23);
            this.txt_uid.TabIndex = 11;
            this.txt_uid.UseSelectable = true;
            this.txt_uid.WaterMark = "User ID";
            this.txt_uid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_uid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GridTask
            // 
            this.GridTask.AllowUserToAddRows = false;
            this.GridTask.AllowUserToDeleteRows = false;
            this.GridTask.AllowUserToResizeRows = false;
            this.GridTask.BackgroundColor = System.Drawing.Color.LightCyan;
            this.GridTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridTask.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridTask.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTask.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.GridTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridTask.DefaultCellStyle = dataGridViewCellStyle14;
            this.GridTask.EnableHeadersVisualStyles = false;
            this.GridTask.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridTask.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridTask.Location = new System.Drawing.Point(10, 72);
            this.GridTask.Name = "GridTask";
            this.GridTask.ReadOnly = true;
            this.GridTask.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTask.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.GridTask.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridTask.Size = new System.Drawing.Size(574, 150);
            this.GridTask.TabIndex = 10;
            this.GridTask.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTask_CellContentClick);
            this.GridTask.SelectionChanged += new System.EventHandler(this.GridTask_SelectionChanged);
            // 
            // btn_task
            // 
            this.btn_task.Location = new System.Drawing.Point(7, 331);
            this.btn_task.Name = "btn_task";
            this.btn_task.Size = new System.Drawing.Size(96, 34);
            this.btn_task.TabIndex = 8;
            this.btn_task.Text = "Assign Task";
            this.btn_task.UseSelectable = true;
            this.btn_task.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txt_name
            // 
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.Enabled = false;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(10, 241);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PromptText = "Name";
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(262, 23);
            this.txt_name.TabIndex = 7;
            this.txt_name.UseSelectable = true;
            this.txt_name.WaterMark = "Name";
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cBoxTask
            // 
            this.cBoxTask.FormattingEnabled = true;
            this.cBoxTask.ItemHeight = 23;
            this.cBoxTask.Location = new System.Drawing.Point(10, 296);
            this.cBoxTask.Name = "cBoxTask";
            this.cBoxTask.Size = new System.Drawing.Size(121, 29);
            this.cBoxTask.TabIndex = 5;
            this.cBoxTask.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8F);
            this.label3.Location = new System.Drawing.Point(7, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Task";
            // 
            // txt_search
            // 
            // 
            // 
            // 
            this.txt_search.CustomButton.Image = global::RVL_Management_System.Properties.Resources.magnifier;
            this.txt_search.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txt_search.CustomButton.Name = "";
            this.txt_search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search.CustomButton.TabIndex = 1;
            this.txt_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search.CustomButton.UseSelectable = true;
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(230, 24);
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
            this.txt_search.Size = new System.Drawing.Size(161, 23);
            this.txt_search.TabIndex = 3;
            this.txt_search.UseSelectable = true;
            this.txt_search.WaterMark = "Search";
            this.txt_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_search.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txt_search_ButtonClick);
            // 
            // cBoxSearchBy
            // 
            this.cBoxSearchBy.FormattingEnabled = true;
            this.cBoxSearchBy.ItemHeight = 23;
            this.cBoxSearchBy.Items.AddRange(new object[] {
            "User ID",
            "Last name",
            "First name",
            "Middle name"});
            this.cBoxSearchBy.Location = new System.Drawing.Point(103, 24);
            this.cBoxSearchBy.Name = "cBoxSearchBy";
            this.cBoxSearchBy.Size = new System.Drawing.Size(121, 29);
            this.cBoxSearchBy.TabIndex = 1;
            this.cBoxSearchBy.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By:";
            // 
            // Frm_Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 462);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Frm_Tasks";
            this.Resizable = false;
            this.Text = "Task Assigining";
            this.Load += new System.EventHandler(this.Frm_Tasks_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_Tasks_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cBoxSearchBy;
        private MetroFramework.Controls.MetroTextBox txt_search;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cBoxTask;
        private MetroFramework.Controls.MetroTextBox txt_name;
        private MetroFramework.Controls.MetroButton btn_task;
        private MetroFramework.Controls.MetroGrid GridTask;
        private MetroFramework.Controls.MetroTextBox txt_uid;
    }
}