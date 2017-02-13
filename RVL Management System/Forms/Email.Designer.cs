namespace RVL_Management_System.Forms
{
    partial class Email
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_attachments = new System.Windows.Forms.TextBox();
            this.txt_cc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_nameFrom = new System.Windows.Forms.TextBox();
            this.btn_emailCreden = new MetroFramework.Controls.MetroButton();
            this.btn_attach = new MetroFramework.Controls.MetroButton();
            this.chckBoxSsl = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_send = new MetroFramework.Controls.MetroButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_smtp = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_attachments);
            this.groupBox1.Controls.Add(this.txt_cc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_to);
            this.groupBox1.Controls.Add(this.txt_subject);
            this.groupBox1.Controls.Add(this.txt_content);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 625);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Message";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Attachments:";
            // 
            // txt_attachments
            // 
            this.txt_attachments.Enabled = false;
            this.txt_attachments.Location = new System.Drawing.Point(97, 388);
            this.txt_attachments.Name = "txt_attachments";
            this.txt_attachments.Size = new System.Drawing.Size(631, 21);
            this.txt_attachments.TabIndex = 29;
            // 
            // txt_cc
            // 
            this.txt_cc.Location = new System.Drawing.Point(97, 41);
            this.txt_cc.Name = "txt_cc";
            this.txt_cc.Size = new System.Drawing.Size(633, 21);
            this.txt_cc.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "CC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_nameFrom);
            this.groupBox2.Controls.Add(this.btn_emailCreden);
            this.groupBox2.Controls.Add(this.btn_attach);
            this.groupBox2.Controls.Add(this.chckBoxSsl);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_port);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btn_send);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_pw);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_smtp);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(97, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 179);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Setting";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Name:";
            // 
            // txt_nameFrom
            // 
            this.txt_nameFrom.Enabled = false;
            this.txt_nameFrom.Location = new System.Drawing.Point(77, 68);
            this.txt_nameFrom.Name = "txt_nameFrom";
            this.txt_nameFrom.Size = new System.Drawing.Size(540, 21);
            this.txt_nameFrom.TabIndex = 31;
            // 
            // btn_emailCreden
            // 
            this.btn_emailCreden.Location = new System.Drawing.Point(274, 146);
            this.btn_emailCreden.Name = "btn_emailCreden";
            this.btn_emailCreden.Size = new System.Drawing.Size(154, 27);
            this.btn_emailCreden.TabIndex = 30;
            this.btn_emailCreden.Text = "Add/Edit Gmail Credentials";
            this.btn_emailCreden.UseSelectable = true;
            this.btn_emailCreden.Click += new System.EventHandler(this.btn_emailCreden_Click);
            // 
            // btn_attach
            // 
            this.btn_attach.Location = new System.Drawing.Point(434, 146);
            this.btn_attach.Name = "btn_attach";
            this.btn_attach.Size = new System.Drawing.Size(112, 27);
            this.btn_attach.TabIndex = 29;
            this.btn_attach.Text = "Add Attachments";
            this.btn_attach.UseSelectable = true;
            this.btn_attach.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // chckBoxSsl
            // 
            this.chckBoxSsl.AutoSize = true;
            this.chckBoxSsl.Checked = true;
            this.chckBoxSsl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckBoxSsl.Enabled = false;
            this.chckBoxSsl.Location = new System.Drawing.Point(365, 103);
            this.chckBoxSsl.Name = "chckBoxSsl";
            this.chckBoxSsl.Size = new System.Drawing.Size(64, 17);
            this.chckBoxSsl.TabIndex = 28;
            this.chckBoxSsl.Text = "Enable";
            this.chckBoxSsl.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Port:";
            // 
            // txt_port
            // 
            this.txt_port.Enabled = false;
            this.txt_port.Location = new System.Drawing.Point(77, 128);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(107, 21);
            this.txt_port.TabIndex = 26;
            this.txt_port.Text = "587";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "SSL(Secure Sockets Layer):";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(552, 146);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 27);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "Send";
            this.btn_send.UseSelectable = true;
            this.btn_send.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Password:";
            // 
            // txt_pw
            // 
            this.txt_pw.Enabled = false;
            this.txt_pw.Location = new System.Drawing.Point(77, 41);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.Size = new System.Drawing.Size(540, 21);
            this.txt_pw.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Smtp:";
            // 
            // txt_smtp
            // 
            this.txt_smtp.Enabled = false;
            this.txt_smtp.Location = new System.Drawing.Point(77, 101);
            this.txt_smtp.Name = "txt_smtp";
            this.txt_smtp.Size = new System.Drawing.Size(107, 21);
            this.txt_smtp.TabIndex = 21;
            this.txt_smtp.Text = "smtp.gmail.com";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(77, 14);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(540, 21);
            this.txt_email.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 16;
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(97, 14);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(633, 21);
            this.txt_to.TabIndex = 13;
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(97, 68);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(633, 21);
            this.txt_subject.TabIndex = 14;
            // 
            // txt_content
            // 
            this.txt_content.Location = new System.Drawing.Point(97, 95);
            this.txt_content.Multiline = true;
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(631, 287);
            this.txt_content.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Content:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 693);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Email";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Resizable = false;
            this.Text = "Email Form";
            this.Load += new System.EventHandler(this.Frm_Email_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.TextBox txt_subject;
        private MetroFramework.Controls.MetroButton btn_send;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_smtp;
        private System.Windows.Forms.CheckBox chckBoxSsl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_attachments;
        private MetroFramework.Controls.MetroButton btn_attach;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroButton btn_emailCreden;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_nameFrom;
    }
}