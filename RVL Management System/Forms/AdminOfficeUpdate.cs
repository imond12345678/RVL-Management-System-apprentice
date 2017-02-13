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
using MetroFramework;

namespace RVL_Management_System.Forms
{
    public partial class AdminOfficeUpdate : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public static string acid = "";
        public static string fullName = "";
        public static string eMail = "";
        public static string phoneNumber = "";
        public static string address = "";
        public static string county = "";
        public static string category = "";

        public AdminOfficeUpdate()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void searchAdminID()
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

        public void searchAdminFName()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblAdminContact WHERE Full_name LIKE @fname";
            cmd.Parameters.AddWithValue("fname", "%" + txt_search.Text + "%");
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
            txt_fullName.Text = null;
            txt_email.Text = null;
            txt_phoneNumber.Text = null;
            txt_address.Text = null;
            txt_county.Text = null;
            cBoxCategory.Text = null;
            txt_acid.Text = null;
            txt_search.Text = null;
            cBoxSearchBy.Text = null; 
        }

        private void Frm_AdminOfficeUpdate_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (cBoxSearchBy.Text == "Admin Contact ID")
            {
                searchAdminID();
            }
            if (cBoxSearchBy.Text == "Full name")
            {
                searchAdminFName();
            }
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
                txt_fullName.Text = row.Cells[1].Value.ToString();
                txt_email.Text = row.Cells[2].Value.ToString();
                txt_phoneNumber.Text = row.Cells[3].Value.ToString();
                txt_address.Text = row.Cells[4].Value.ToString();
                txt_county.Text = row.Cells[5].Value.ToString();
                cBoxCategory.Text = row.Cells[6].Value.ToString();

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            txt_fullName.Text = null;
            txt_email.Text = null;
            txt_phoneNumber.Text = null;
            txt_address.Text = null;
            txt_county.Text = null;
            cBoxCategory.Text = null;
        }

        private void txt_search_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            if (cBoxSearchBy.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Search first before you update", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MetroMessageBox.Show(this, "Do you want to update these information?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    fullName = txt_fullName.Text;
                    eMail = txt_email.Text;
                    phoneNumber = txt_phoneNumber.Text;
                    address = txt_address.Text;
                    county = txt_county.Text;
                    category = cBoxCategory.Text;
                    acid = txt_acid.Text;
                    Class.Cls_cmd.adminOfficeUpdate();
                    clear();
                }
                else
                {
                    //IF NO
                    //TODO:NOTHING
                }
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {

        }
    }
}
