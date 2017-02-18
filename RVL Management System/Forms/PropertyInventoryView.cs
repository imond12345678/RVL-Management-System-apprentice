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
    public partial class PropertyInventoryView : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public PropertyInventoryView()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void searchAPN()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblPropertyInventory WHERE APN_ID = @apn";
            cmd.Parameters.AddWithValue("apn", txt_search.Text);
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
            string LOAD = "SELECT * FROM tblPropertyInventory WHERE Title = @title";
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

        private void PropertyInventoryView_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_ButtonClick(object sender, EventArgs e)
        {
            if (cBoxSearchBy.Text == "APN")
            {
                searchAPN();
            }
            else if (cBoxSearchBy.Text == "Title")
            {
                searchTitle();
            }
        }

        private void txt_search_ClearClicked()
        {
            cBoxSearchBy.Text = null;
        }
    }
}
