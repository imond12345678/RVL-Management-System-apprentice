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


namespace RVL_Management_System
{
    public partial class Frm_UserView : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Frm_UserView()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void UserSearch()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT L.LID, U.UID, U.Full_Name, L.UN, L.PW, A.Account FROM tblUser AS U LEFT JOIN tblLogin AS L ON U.UID = L.UID LEFT JOIN tblAccount AS A ON U.AcctID = A.AcctID WHERE U.UID=@uid";
            cmd.Parameters.AddWithValue("uid", txt_search.Text);
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void UserIDSearch()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT L.LID, U.UID, U.Full_Name, L.UN, L.PW, A.Account FROM tblUser AS U LEFT JOIN tblLogin AS L ON U.UID = L.UID LEFT JOIN tblAccount AS A ON U.AcctID = A.AcctID WHERE U.UID=@uid";
            cmd.Parameters.AddWithValue("uid", txt_search.Text);
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void FullNameSearch()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT L.LID, U.UID, U.Full_Name, L.UN, L.PW, A.Account FROM tblUser AS U LEFT JOIN tblLogin AS L ON U.UID = L.UID LEFT JOIN tblAccount AS A ON U.AcctID = A.AcctID WHERE U.Full_Name=@fn";
            cmd.Parameters.AddWithValue("fn", txt_search.Text);
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }
        public void UsernameSearch()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT L.LID, U.UID, U.Full_Name, L.UN, L.PW, A.Account FROM tblUser AS U LEFT JOIN tblLogin AS L ON U.UID = L.UID LEFT JOIN tblAccount AS A ON U.AcctID = A.AcctID WHERE L.UN=@un";
            cmd.Parameters.AddWithValue("un", txt_search.Text);
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        private void Frm_UserView_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_ButtonClick(object sender, EventArgs e)
        {
            if(cBoxSearchBy.Text == string.Empty)
            {
                MetroMessageBox.Show(this,"Choose the type you want to search","RVL Systems",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(txt_search.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Enter first you want to search", "RVL Systems", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cBoxSearchBy.Text == "User ID")
                {
                    UserIDSearch(); 
                }
                else if (cBoxSearchBy.Text == "Full name")
                {
                    FullNameSearch();
                }
                else if (cBoxSearchBy.Text == "Username")
                {
                    UsernameSearch();
                }
            }
            
        }

        private void cBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cBoxSearchBy.Text == "User ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (cBoxSearchBy.Text == "Full name")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (cBoxSearchBy.Text == "Username")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
