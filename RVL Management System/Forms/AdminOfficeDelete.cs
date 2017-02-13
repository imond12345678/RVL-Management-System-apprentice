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
    public partial class Frm_AdminOfficeDelete : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public static string acid = "";
        public Frm_AdminOfficeDelete()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void searchAdminContactID()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblAdminContact WHERE ACID = @acid";
            cmd.Parameters.AddWithValue("acid", txt_search.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void searchAdminContactFName()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblAdminContact WHERE Full_name = @fname";
            cmd.Parameters.AddWithValue("fname", txt_search.Text);
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
            string LOAD = "SELECT * FROM tblAdminContact";
            cmd.Parameters.AddWithValue("fname", txt_search.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void clear()
        {
            txt_acid.Text = null;
            txt_search.Text = null;
            cBoxSearchBy.Text = null;
        }

        private void Frm_AdminOfficeDelete_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
        }

        private void btn_delete_Click(object sender, EventArgs e)
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
                txt_acid.Text = row.Cells[0].Value.ToString();
            }
        }

        private void txt_search_ButtonClick(object sender, EventArgs e)
        {

            if (cBoxSearchBy.Text == "ACID")
            {
                searchAdminContactID();
            }
            else if (cBoxSearchBy.Text == "Full name")
            {
                searchAdminContactFName();
            }
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (cBoxSearchBy.Text == string.Empty || txt_acid.Text == string.Empty || txt_search.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Search first before you delete", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MetroMessageBox.Show(this, "Do you want to delete these informations?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    acid = txt_acid.Text;
                    Class.Cls_cmd.adminOfficeDelete();
                    clear();
                    refresh();
                }
                else
                {
                    //IF NO
                    //TODO: NOTHING
                }
            }
        }

        private void txt_search_ClearClicked()
        {
            cBoxSearchBy.Text = null;
        }
    }
}
