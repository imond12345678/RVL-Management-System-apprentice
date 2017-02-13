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
    public partial class LandStayView : MetroForm
    {

        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();
        public LandStayView()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void loadData()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblLandStay";
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

       

        private void Frm_LandStayView_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
           
        }
    }
}
