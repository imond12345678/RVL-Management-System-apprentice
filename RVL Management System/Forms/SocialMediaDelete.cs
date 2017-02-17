using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace RVL_Management_System.Forms
{
    public partial class SocialMediaDelete : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public static string apn = "";
        public SocialMediaDelete()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void refresh()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblSocialMedia";
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void searchAPN()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblSocialMedia WHERE APN_ID = @apnID";
            cmd.Parameters.AddWithValue("apnID", txt_search.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void searchTitle()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblSocialMedia WHERE Title = @title";
            cmd.Parameters.AddWithValue("title", txt_search.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        private void SocialMediaDelete_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_ButtonClick(object sender, EventArgs e)
        {
            if (cBoxSearchBy.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Please select a category to search on before searching.", "RVL System", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                if (cBoxSearchBy.Text == "Title")
                {
                    searchTitle();
                }
                else if (cBoxSearchBy.Text == "APN ID")
                {
                    searchAPN();
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
                txt_apnDelete.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_apnDelete.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Please select a data to delete", "RVL System", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                apn = txt_apnDelete.Text;
                Class.Cls_cmd.socialMediaDelete();
                refresh();
            }
        }
    }
}
