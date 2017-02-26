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
    public partial class CompanyLoginsUpdate : MetroForm
    {
        public static string categoryID = "";
        public static string categoryName = "";
        public static string URLlink = "";
        public static string userName = "";
        public static string passWord = "";
        public static string nameLogin = "";
        public static string giveAccess = "";

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public CompanyLoginsUpdate()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void search()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblCompanyLogins WHERE Category_Name = @cn";
            cmd.Parameters.AddWithValue("cn", txt_search.Text);
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
            string LOAD = "SELECT * FROM tblCompanyLogins";
            cmd.Parameters.AddWithValue("cn", txt_search.Text);
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
            txt_search.Text = null;
            txt_cid.Text = null;
            txt_categoryName.Text = null;
            txt_url.Text = null;
            txt_un.Text = null;
            txt_pw.Text = null;
            txt_nameLogin.Text = null;
            txt_giveAccess.Text = null;

        }

      
        private void Frm_CompanyLoginsUpdate_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_search_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_update_Click(object sender, EventArgs e)
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
                txt_cid.Text = row.Cells[0].Value.ToString();
                txt_categoryName.Text = row.Cells[1].Value.ToString();
                txt_url.Text = row.Cells[2].Value.ToString();
                txt_un.Text = row.Cells[3].Value.ToString();
                txt_pw.Text = row.Cells[4].Value.ToString();
                txt_nameLogin.Text = row.Cells[5].Value.ToString();
                txt_giveAccess.Text = row.Cells[6].Value.ToString();
            }
            else
            {
               
            }
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_export_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_search_ButtonClick(object sender, EventArgs e)
        {
            if (txt_search.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Please enter company name!", "RVL Systems", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                search();
            }
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in GridView.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
               
            }
            else
            {
                MetroMessageBox.Show(this, "No Data Found!", "RVL Systems", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
            
        }

        private void txt_search_ClearClicked()
        {
            clear();
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            if (txt_cid.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Please select a data to update!", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MetroMessageBox.Show(this, "Do you want to update this Company Login Information?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    categoryID = txt_cid.Text;
                    categoryName = txt_categoryName.Text;
                    URLlink = txt_url.Text;
                    userName = txt_un.Text;
                    passWord = txt_pw.Text;
                    nameLogin = txt_nameLogin.Text;
                    giveAccess = txt_giveAccess.Text;
                    Class.Cls_cmd.companyUpdate();
                    clear();
                    refresh();
                }
                else
                {
                    //if no 
                    //TODO:NOTHING
                }
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            CompanyLoginsView fview = new CompanyLoginsView();
            fview.ShowDialog();
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
