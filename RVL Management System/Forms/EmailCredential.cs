using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MetroFramework;

namespace RVL_Management_System.Forms
{
    public partial class EmailCredential : MetroForm
    {
        public static string email = "";
        public static string password = "";
        public static string senderName = "";


        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        public EmailCredential()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        private void EmailCredential_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            

            
            
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            if (txt_email.Text == string.Empty || txt_name.Text == string.Empty || txt_pw.Text == string.Empty)
            {
                MetroMessageBox.Show(this,"Please fill up the required fields","RVL System",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (MetroMessageBox.Show(this, "Are You Sure ?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cmd.Connection = conn;
                    string LOGIN = "SELECT * FROM Email WHERE Email = @email";
                    cmd.Parameters.AddWithValue("email", txt_email.Text);
                    cmd.CommandText = LOGIN;
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        count = count + 1;
                    }

                    if (count == 1)
                    {
                        email = txt_email.Text;
                        password = txt_pw.Text;
                        senderName = txt_name.Text;
                        Class.Cls_cmd.emailUpdate();
                        Email femail = new Email();
                        femail.Show();
                        Hide();
                    }
                    if (count == 0)
                    {
                        email = txt_email.Text;
                        password = txt_pw.Text;
                        senderName = txt_name.Text;
                        Class.Cls_cmd.emailAdd();
                        Email femail = new Email();
                        femail.Show();
                        Hide();
                    }
                    conn.Close();

                    cmd.Parameters.Clear();
                }
                else
                {
                    //IF NO
                    //TODO: NOTHING
                }
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_email.Text = null;
            txt_pw.Text = null;
            txt_name.Text = null;
        }
    }
}
