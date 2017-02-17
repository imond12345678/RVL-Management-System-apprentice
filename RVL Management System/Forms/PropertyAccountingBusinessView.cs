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
    public partial class PropertyAccountingBusinessView : MetroForm
    {

        SqlCommand cmd = new SqlCommand();

        public PropertyAccountingBusinessView()
        {
            InitializeComponent();
        }

        public void searchAPN()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

                conn.Open();
                cmd.Connection = conn;
                string Show = "SELECT * FROM tblAccountingBusiness WHERE APN_ID =@apn";
                cmd.Parameters.AddWithValue("apn", txt_search.Text);
                cmd.CommandText = Show;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView.DataSource = dt;

                conn.Close();

                cmd.Parameters.Clear();
            }
        }

        public void searchSoldTo()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

                conn.Open();
                cmd.Connection = conn;
                string Show = "SELECT * FROM tblAccountingBusiness WHERE Sold_To =@soldTo";
                cmd.Parameters.AddWithValue("soldTo", txt_search.Text);
                cmd.CommandText = Show;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView.DataSource = dt;

                conn.Close();

                cmd.Parameters.Clear();
            }
        }

        private void PropertyAccountingBusinessView_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_ButtonClick(object sender, EventArgs e)
        {
            if (cBoxSearchBy.Text == "APN ID")
            {
                searchAPN();
            }
            else if (cBoxSearchBy.Text == "Sold To")
            {
                searchSoldTo();
            }
        }
    }
}
