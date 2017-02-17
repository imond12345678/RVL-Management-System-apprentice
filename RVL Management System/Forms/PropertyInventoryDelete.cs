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
using System.Configuration;
using System.Data.SqlClient;


namespace RVL_Management_System.Forms
{
    public partial class PropertyInventoryDelete : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public PropertyInventoryDelete()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void searchAPN()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblPorpertyInventory WHERE APN_ID = @apnid";
            cmd.Parameters.AddWithValue("apnid", txt_search.Text);
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
            string LOAD = "SELECT * FROM tblPorpertyInventory WHERE Title = @title";
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


        private void PropertyInventoryDelete_Load(object sender, EventArgs e)
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
                txt_apnID.Text = row.Cells[1].Value.ToString();

            }
        }
    }
}
