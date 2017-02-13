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
using MetroFramework;
using System.Data.SqlClient;
using System.Configuration;

namespace RVL_Management_System
{
    public partial class Frm_UserAdd : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public static string fullName = "";
        public static string email = "";
        public static string userName = "";
        public static string Password = "";
        public static string role = "";
        public static string acctID = "";
        public static string uID = "";

        public Frm_UserAdd()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }
        public void loadUserType()
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM tblAccount";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string gCategory = reader.GetString(reader.GetOrdinal("Account"));
                cBoxRole.Items.Add(gCategory);
            }
            conn.Close();
        }

        public void loadUID()
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT IDENT_CURRENT('tblLogin')+1[UID]";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string gUid = reader.GetDecimal(reader.GetOrdinal("UID")).ToString();
                txt_userID.Text = gUid;
            }
            conn.Close();
        }

        public void clear()
        {
            txt_un.Text = null;
            txt_pw.Text = null;
            cBoxRole.Text = null;
            txt_level.Text = null;
            txt_fullname.Text = null;
            txt_email.Text = null;
            txt_confirmPw.Text = null;
        }

        private void Frm_UserAdd_Load(object sender, EventArgs e)
        {
            loadUID();
            loadUserType();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void cBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_confirmPw_TextChanged(object sender, EventArgs e)
        {
            txt_confirmPw.Text.CompareTo(txt_pw.Text);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_un.Text == string.Empty || txt_pw.Text == string.Empty || cBoxRole.Text == string.Empty || txt_fullname.Text == string.Empty || txt_email.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Please fill up the required fields!", "RVL System", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if(txt_confirmPw.Text != txt_pw.Text)
            {
                MetroMessageBox.Show(this,"Password did not match","RVL Systems",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                userName = txt_un.Text;
                Password = txt_pw.Text;
                role = cBoxRole.Text;
                acctID = txt_level.Text;
                uID = txt_userID.Text;
                fullName = txt_fullname.Text;
                email = txt_email.Text;
                Class.Cls_cmd.userAdd();
                Class.Cls_cmd.userLogin();
                MetroMessageBox.Show(this,"Saved Succesfully in Database","RVL Systems",MessageBoxButtons.OK,MessageBoxIcon.Information);
                clear();
                loadUID();
            }
            
        }

        private void cBoxRole_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cBoxRole.Text == "Admin")
            {
                txt_level.Text = "1";
            }
            else
            {
                txt_level.Text = "2";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txt_confirmPw_TextChanged_1(object sender, EventArgs e)
        {
            /*if (txt_confirmPw.Text != txt_pw.Text)
            {
                MetroMessageBox.Show(this, "Passwords are not equal!", "RVL System", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                //TODO: NOTHING
            }*/
        }
    }
}
