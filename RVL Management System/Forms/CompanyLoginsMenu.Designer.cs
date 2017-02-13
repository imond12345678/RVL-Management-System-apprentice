namespace RVL_Management_System.Forms
{
    partial class CompanyLoginsMenu
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
            this.btn_view = new MetroFramework.Controls.MetroLink();
            this.btn_delete = new MetroFramework.Controls.MetroLink();
            this.btn_edit = new MetroFramework.Controls.MetroLink();
            this.btn_add = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // btn_view
            // 
            this.btn_view.Image = global::RVL_Management_System.Properties.Resources.cabinet;
            this.btn_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_view.ImageSize = 32;
            this.btn_view.Location = new System.Drawing.Point(361, 80);
            this.btn_view.Name = "btn_view";
            this.btn_view.NoFocusImage = global::RVL_Management_System.Properties.Resources.cabinet_1;
            this.btn_view.Size = new System.Drawing.Size(89, 75);
            this.btn_view.TabIndex = 3;
            this.btn_view.Text = "View";
            this.btn_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_view.UseSelectable = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::RVL_Management_System.Properties.Resources.delete_photo;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.ImageSize = 32;
            this.btn_delete.Location = new System.Drawing.Point(266, 80);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.NoFocusImage = global::RVL_Management_System.Properties.Resources.rubbish_bin;
            this.btn_delete.Size = new System.Drawing.Size(89, 75);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseSelectable = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Image = global::RVL_Management_System.Properties.Resources.edit;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.ImageSize = 32;
            this.btn_edit.Location = new System.Drawing.Point(147, 80);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.NoFocusImage = global::RVL_Management_System.Properties.Resources.edit_1;
            this.btn_edit.Size = new System.Drawing.Size(113, 75);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit/Update";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit.UseSelectable = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = global::RVL_Management_System.Properties.Resources.plus_1;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.ImageSize = 32;
            this.btn_add.Location = new System.Drawing.Point(63, 80);
            this.btn_add.Name = "btn_add";
            this.btn_add.NoFocusImage = global::RVL_Management_System.Properties.Resources.plus;
            this.btn_add.Size = new System.Drawing.Size(78, 75);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Frm_CompanyLoginsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 171);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CompanyLoginsMenu";
            this.Resizable = false;
            this.Text = "Company Logins Menu";
            this.Load += new System.EventHandler(this.Frm_CompanyLoginsMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink btn_add;
        private MetroFramework.Controls.MetroLink btn_edit;
        private MetroFramework.Controls.MetroLink btn_delete;
        private MetroFramework.Controls.MetroLink btn_view;
    }
}