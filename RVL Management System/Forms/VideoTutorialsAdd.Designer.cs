namespace RVL_Management_System.Forms
{
    partial class VideoTutorialsAdd
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
            this.txt_process = new MetroFramework.Controls.MetroTextBox();
            this.txt_youtube = new MetroFramework.Controls.MetroTextBox();
            this.btn_clear = new MetroFramework.Controls.MetroTile();
            this.btn_save = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
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
            this.txt_process.Location = new System.Drawing.Point(23, 63);
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
            this.txt_process.TabIndex = 2;
            this.txt_process.UseSelectable = true;
            this.txt_process.WaterMark = "Process";
            this.txt_process.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_process.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txt_youtube.Location = new System.Drawing.Point(336, 63);
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
            this.txt_youtube.TabIndex = 3;
            this.txt_youtube.UseSelectable = true;
            this.txt_youtube.WaterMark = "Youtube Link";
            this.txt_youtube.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_youtube.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_clear
            // 
            this.btn_clear.ActiveControl = null;
            this.btn_clear.Location = new System.Drawing.Point(483, 119);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(77, 58);
            this.btn_clear.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_clear.TabIndex = 18;
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
            this.btn_save.Location = new System.Drawing.Point(566, 119);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 58);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.TileImage = global::RVL_Management_System.Properties.Resources.plus_1;
            this.btn_save.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseSelectable = true;
            this.btn_save.UseTileImage = true;
            this.btn_save.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // VideoTutorialsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 193);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_youtube);
            this.Controls.Add(this.txt_process);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoTutorialsAdd";
            this.Resizable = false;
            this.Text = "Add Youtube Link Tutorials";
            this.Load += new System.EventHandler(this.Frm_YoutubeTutorials_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txt_process;
        private MetroFramework.Controls.MetroTextBox txt_youtube;
        private MetroFramework.Controls.MetroTile btn_clear;
        private MetroFramework.Controls.MetroTile btn_save;
    }
}