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

namespace RVL_Management_System.Forms
{
    public partial class UserDelete : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public static string uid = "";
        public static string lid = "";
        public UserDelete()
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


        private void UserDelete_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_ButtonClick(object sender, EventArgs e)
        {
            if (cBoxSearchBy.Text == "Account ID")
            {
                UserSearchById();
            }
            else if (cBoxSearchBy.Text == "Full name")
            {
                UserSearchByName();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == string.Empty)
            {
                MetroMessageBox.Show(this,"Please search before you delete an information", "RVL System", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else {
                if (txt_lid.Text == string.Empty || txt_uid.Text == string.Empty)
                {
                    MetroMessageBox.Show(this, "Please select a data to delete", "RVL System", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    lid = txt_lid.Text;
                    uid = txt_uid.Text;
                    Class.Cls_cmd.UserDelete();
                    Class.Cls_cmd.LoginDelete();
                }
            }
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
            }
        }
    }
}
