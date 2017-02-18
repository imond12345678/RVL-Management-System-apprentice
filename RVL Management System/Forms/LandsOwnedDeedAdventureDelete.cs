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
    public partial class LandsOwnedDeedAdventureDelete : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public static string apn = "";
        public LandsOwnedDeedAdventureDelete()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void searchCounty()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM DeedAdventure WHERE County = @county";
            cmd.Parameters.AddWithValue("county", txt_search.Text);
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
            string LOAD = "SELECT * FROM DeedAdventure WHERE APN = @APN";
            cmd.Parameters.AddWithValue("APN", txt_search.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void refresh()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM DeedAdventure WHERE County";
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }


        private void LandsOwnedDeedAdventureDelete_Load(object sender, EventArgs e)
        {

        }

        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
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
                txt_apnID.Text = row.Cells[0].Value.ToString();

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_apnID.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Please select a data to delete!", "RVL System", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                apn = txt_apnID.Text;
                Class.Cls_cmd.deedAdventureDelete();
                refresh();
            }
        }

        private void txt_search_ButtonClick(object sender, EventArgs e)
        {
            if (cBoxSearchBy.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Please search a category to search.", "RVL System", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                if (cBoxSearchBy.Text == "APN")
                {
                    searchAPN();
                }
                else if (cBoxSearchBy.Text == "County")
                {
                    searchCounty();
                }
            }
        }
    }
}
