namespace RVL_Management_System.Forms
{
    partial class PropertyAccountingMenu
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
            this.btn_business = new MetroFramework.Controls.MetroButton();
            this.btn_personal = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn_business
            // 
            this.btn_business.Location = new System.Drawing.Point(57, 89);
            this.btn_business.Name = "btn_business";
            this.btn_business.Size = new System.Drawing.Size(101, 44);
            this.btn_business.TabIndex = 0;
            this.btn_business.Text = "Business";
            this.btn_business.UseSelectable = true;
            this.btn_business.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btn_personal
            // 
            this.btn_personal.Location = new System.Drawing.Point(179, 89);
            this.btn_personal.Name = "btn_personal";
            this.btn_personal.Size = new System.Drawing.Size(101, 44);
            this.btn_personal.TabIndex = 1;
            this.btn_personal.Text = "Personal";
            this.btn_personal.UseSelectable = true;
            this.btn_personal.Click += new System.EventHandler(this.btn_personal_Click);
            // 
            // Frm_PropertyAccountingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 186);
            this.Controls.Add(this.btn_personal);
            this.Controls.Add(this.btn_business);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PropertyAccountingMenu";
            this.Resizable = false;
            this.Text = "Property Accounting Menu";
            this.Load += new System.EventHandler(this.Frm_PropertyAccountingMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_business;
        private MetroFramework.Controls.MetroButton btn_personal;
    }
}