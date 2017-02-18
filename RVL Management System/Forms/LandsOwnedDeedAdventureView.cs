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
    public partial class LandsOwnedDeedAdventureView : MetroForm
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        public LandsOwnedDeedAdventureView()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();


                conn.Open();
                cmd.Connection = conn;
                string LOAD = "SELECT * FROM DeedAdventure";
                cmd.CommandText = LOAD;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView.DataSource = dt;
                conn.Close();
            }
            
        }

        public void searchAPN()
        {
            using (SqlConnection conn = new SqlConnection())
            {

                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();


                conn.Open();
                cmd.Connection = conn;
                string LOAD = "SELECT * FROM DeedAdventure WHERE APN = @apn";
                cmd.Parameters.AddWithValue("apn", txt_search.Text);
                cmd.CommandText = LOAD;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView.DataSource = dt;
                conn.Close();
            }

        }

        public void searchCounty()
        {
            using (SqlConnection conn = new SqlConnection())
            {

                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();


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
            }

        }

        private void LandsOwnedDeedAdventureView_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void txt_search_ButtonClick(object sender, EventArgs e)
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

        private void txt_search_ClearClicked()
        {
            cBoxSearchBy.Text = null;
        }
    }
}
