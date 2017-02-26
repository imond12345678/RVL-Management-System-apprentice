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
using Microsoft.Office.Interop.Excel;


namespace RVL_Management_System.Forms
{
    public partial class CompanyLoginsView : MetroForm
    {
        

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public CompanyLoginsView()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void loadData()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblCompanyLogins";
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void searchCategoryID()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblCompanyLogins WHERE CID = @cn";
            cmd.Parameters.AddWithValue("cn", txt_search.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void searchCategoryName()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblCompanyLogins WHERE Category_Name = @cName";
            cmd.Parameters.AddWithValue("cName", txt_search.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        private void Frm_CompanyLoginsView_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_search_ButtonClick(object sender, EventArgs e)
        {
            if (cBoxSearchBy.Text == "Category ID")
            {
                searchCategoryID();
            }
            else if (cBoxSearchBy.Text == "Category Name")
            {
                searchCategoryName();
            }
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in GridView.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell == null)
            {
                MetroMessageBox.Show(this, "No Data Found!", "RVL Systems", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }

        private void txt_search_ClearClicked()
        {
            cBoxSearchBy.Text = null;
        }
    }
}
