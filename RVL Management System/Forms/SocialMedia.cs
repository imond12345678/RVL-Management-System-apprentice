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

namespace RVL_Management_System.Forms
{
    public partial class SocialMedia : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public void loadData()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT Category_Name, URL_Link FROM tblCompanyLogins";
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void searchLinks()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT Category_Name, URL_Link FROM tblCompanyLogins WHERE URL_Link = @urlLinks";
            cmd.Parameters.AddWithValue("urlLinks", txt_search.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public SocialMedia()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        private void Frm_SocialMedia_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            searchLinks();
        }
    }
}
