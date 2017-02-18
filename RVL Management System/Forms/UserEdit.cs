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
    public partial class Frm_UserEdit : MetroForm
    {
        public static string acctID = "";
        public static string userID = "";
        public static string loginID = "";
        public static string fullName = "";
        public static string userName = "";
        public static string passWord = "";
        public static string role = "";

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Frm_UserEdit()
        {
            InitializeComponent(); 

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void UserSearchById()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT U.UID, L.LID, U.Full_Name, U.Email, L.UN, L.PW, A.Account FROM tblUser AS U LEFT JOIN tblLogin AS L ON U.UID = L.UID LEFT JOIN tblAccount AS A ON U.AcctID = A.AcctID WHERE U.UID=@uid";
            cmd.Parameters.AddWithValue("uid", txt_search.Text);
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;
            
            conn.Close();

            cmd.Parameters.Clear();
        }

        public void UserSearchByName()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT U.UID, L.LID, U.Full_Name, U.Email, L.UN, L.PW, A.Account FROM tblUser AS U LEFT JOIN tblLogin AS L ON U.UID = L.UID LEFT JOIN tblAccount AS A ON U.AcctID = A.AcctID WHERE U.Full_Name=@fn";
            cmd.Parameters.AddWithValue("fn", txt_search.Text);
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }


        public void loadUserype()
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

        public void clear()
        {
            txt_uid.Text = null;
            txt_lid.Text = null;
            txt_search.Text = null;
            txt_fName.Text = null;
            txt_un.Text = null;
            txt_pw.Text = null;
            txt_email.Text = null;
            txt_confirmPw.Text = null;
            txt_level.Text = null;
            cBoxSearchBy.Text = null;
            cBoxRole.Text = null;
        }

        private void Frm_UserEdit_Load(object sender, EventArgs e)
        {
            loadUserype();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
        }

        private void GridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in GridView.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txt_uid.Text = row.Cells[0].Value.ToString();
                txt_lid.Text = row.Cells[1].Value.ToString();
                txt_fName.Text = row.Cells[2].Value.ToString();
                txt_email.Text = row.Cells[3].Value.ToString();
                txt_un.Text = row.Cells[4].Value.ToString();
                txt_pw.Text = row.Cells[5].Value.ToString();
                cBoxRole.Text = row.Cells[6].Value.ToString();
            }
        }

        private void cBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxSearchBy.Text == "Admin")
            {
                txt_level.Text = "1";
            }
            else if (cBoxSearchBy.Text == "User")
            {
                txt_level.Text = "2";
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
            txt_un.Enabled = true;
            txt_pw.Enabled = true;
            txt_confirmPw.Enabled = true;
            cBoxRole.Enabled = true;
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox2_ButtonClick(object sender, EventArgs e)
        {
            if(cBoxSearchBy.Text == string.Empty)
            {
                MetroMessageBox.Show(this,"Choose you want to search","RVL Systems",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (cBoxSearchBy.Text == "User Id")
                {
                    UserSearchById();
                }
                else if (cBoxSearchBy.Text == "Full Name")
                {
                    UserSearchByName();
                }
            }
            

        }

        private void txt_un_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_ClearClicked()
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(cBoxSearchBy.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Please choose a query to search in the search by.", "RVL Systems", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txt_search.Text == string.Empty)
            {
                MetroMessageBox.Show(this,"Please fill up the required field - Search","RVL Systems",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (MetroMessageBox.Show(this, "Do you want to update this information?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_pw.Text == txt_confirmPw.Text)
                    {
                        acctID = txt_level.Text;
                        userID = txt_uid.Text;
                        loginID = txt_lid.Text;
                        fullName = txt_fName.Text;
                        userName = txt_un.Text;
                        passWord = txt_pw.Text;
                        role = cBoxRole.Text;
                        Class.Cls_cmd.updateLogin();
                        Class.Cls_cmd.updateUser();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Password not equal!", "RVL System", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //TODO:NOTHING
                }
            }
           
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cBoxRole_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cBoxRole_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if(cBoxRole.Text == "Admin")
            {
                txt_level.Text = "1";
            }
            else if(cBoxRole.Text == "User")
            {
                txt_level.Text = "2";
            }
        }

        private void txt_fName_Click(object sender, EventArgs e)
        {

        }

        private void txt_un_Click(object sender, EventArgs e)
        {

        }

        private void txt_pw_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cBoxSearchBy.Text == "User Id")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if(cBoxSearchBy.Text == "Full Name")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            
        }
    }
}
