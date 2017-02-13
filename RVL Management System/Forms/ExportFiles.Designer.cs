namespace RVL_Management_System.Forms
{
    partial class ExportFiles
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
            this.btn_videoTutorials = new MetroFramework.Controls.MetroLink();
            this.btn_socialMedia = new MetroFramework.Controls.MetroLink();
            this.btn_landStay = new MetroFramework.Controls.MetroLink();
            this.btn_adminOffice = new MetroFramework.Controls.MetroLink();
            this.btn_company = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // btn_videoTutorials
            // 
            this.btn_videoTutorials.Image = global::RVL_Management_System.Properties.Resources.youtube;
            this.btn_videoTutorials.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_videoTutorials.ImageSize = 32;
            this.btn_videoTutorials.Location = new System.Drawing.Point(63, 324);
            this.btn_videoTutorials.Name = "btn_videoTutorials";
            this.btn_videoTutorials.Size = new System.Drawing.Size(123, 54);
            this.btn_videoTutorials.TabIndex = 4;
            this.btn_videoTutorials.Text = "Video Tutorials";
            this.btn_videoTutorials.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_videoTutorials.UseSelectable = true;
            this.btn_videoTutorials.Click += new System.EventHandler(this.btn_videoTutorials_Click);
            // 
            // btn_socialMedia
            // 
            this.btn_socialMedia.Image = global::RVL_Management_System.Properties.Resources.network;
            this.btn_socialMedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_socialMedia.ImageSize = 32;
            this.btn_socialMedia.Location = new System.Drawing.Point(63, 264);
            this.btn_socialMedia.Name = "btn_socialMedia";
            this.btn_socialMedia.Size = new System.Drawing.Size(123, 54);
            this.btn_socialMedia.TabIndex = 3;
            this.btn_socialMedia.Text = "Social Media";
            this.btn_socialMedia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_socialMedia.UseSelectable = true;
            this.btn_socialMedia.Click += new System.EventHandler(this.btn_socialMedia_Click);
            // 
            // btn_landStay
            // 
            this.btn_landStay.Image = global::RVL_Management_System.Properties.Resources.optimization;
            this.btn_landStay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_landStay.ImageSize = 32;
            this.btn_landStay.Location = new System.Drawing.Point(63, 204);
            this.btn_landStay.Name = "btn_landStay";
            this.btn_landStay.Size = new System.Drawing.Size(123, 54);
            this.btn_landStay.TabIndex = 2;
            this.btn_landStay.Text = "Land Stay";
            this.btn_landStay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_landStay.UseSelectable = true;
            this.btn_landStay.Click += new System.EventHandler(this.btn_landStay_Click);
            // 
            // btn_adminOffice
            // 
            this.btn_adminOffice.Image = global::RVL_Management_System.Properties.Resources.admin_with_cogwheels;
            this.btn_adminOffice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adminOffice.ImageSize = 32;
            this.btn_adminOffice.Location = new System.Drawing.Point(63, 144);
            this.btn_adminOffice.Name = "btn_adminOffice";
            this.btn_adminOffice.Size = new System.Drawing.Size(123, 54);
            this.btn_adminOffice.TabIndex = 1;
            this.btn_adminOffice.Text = "Admin Office";
            this.btn_adminOffice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_adminOffice.UseSelectable = true;
            this.btn_adminOffice.Click += new System.EventHandler(this.btn_adminOffice_Click);
            // 
            // btn_company
            // 
            this.btn_company.Image = global::RVL_Management_System.Properties.Resources.man_with_company;
            this.btn_company.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_company.ImageSize = 32;
            this.btn_company.Location = new System.Drawing.Point(56, 84);
            this.btn_company.Name = "btn_company";
            this.btn_company.Size = new System.Drawing.Size(130, 54);
            this.btn_company.TabIndex = 0;
            this.btn_company.Text = "Company Logins";
            this.btn_company.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_company.UseSelectable = true;
            this.btn_company.Click += new System.EventHandler(this.btn_company_Click);
            // 
            // Frm_ExportFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 410);
            this.Controls.Add(this.btn_videoTutorials);
            this.Controls.Add(this.btn_socialMedia);
            this.Controls.Add(this.btn_landStay);
            this.Controls.Add(this.btn_adminOffice);
            this.Controls.Add(this.btn_company);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ExportFiles";
            this.Resizable = false;
            this.Text = "Export files form";
            this.Load += new System.EventHandler(this.Frm_ExportFiles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink btn_company;
        private MetroFramework.Controls.MetroLink btn_adminOffice;
        private MetroFramework.Controls.MetroLink btn_landStay;
        private MetroFramework.Controls.MetroLink btn_socialMedia;
        private MetroFramework.Controls.MetroLink btn_videoTutorials;
    }
}