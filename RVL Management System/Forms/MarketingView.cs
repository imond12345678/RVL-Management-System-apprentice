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
    public partial class MarketingView : MetroForm
    {

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public MarketingView()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void marketingPassed()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT * FROM tblMarketing WHERE Lead_Assesment = 'Passed' ";
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridViewPassed.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void marketingFailed()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT * FROM tblMarketing WHERE Lead_Assesment = 'Failed'";
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridViewFailed.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }


        private void Frm_MarketingView_Load(object sender, EventArgs e)
        {
            marketingPassed();
            marketingFailed();
        }
    }
}
