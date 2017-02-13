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
    public partial class CompanyLoginsDelete : MetroForm
    {
        public static string CID = "";

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public CompanyLoginsDelete()
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
            txt_cid.Text = null;
            txt_delete.Text = null;
        }

        private void Frm_CompanyLoginsDelete_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
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
                txt_delete.Text = row.Cells[1].Value.ToString();
            }
            else
            {
                MetroMessageBox.Show(this,"No Data Found!","RVL Systems",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_search_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_ButtonClick(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in GridView.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                if (txt_search.Text == string.Empty)
                {
                    MetroMessageBox.Show(this, "Search you want to delete!", "RVL Systems", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    search();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "No Data Found!", "RVL Systems", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void txt_delete_ButtonClick(object sender, EventArgs e)
        {
            if(txt_delete.Text == string.Empty)
            {
                MetroMessageBox.Show(this,"Enter a Company Name you want to delete!","RVL Systems",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (txt_cid.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Select you want to delete!", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MetroMessageBox.Show(this, "Do you want to delete this information?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CID = txt_cid.Text;
                    Class.Cls_cmd.companyDelete();
                    refresh();
                    MetroMessageBox.Show(this,"Succesfully Deleted","RVL Systems",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    //IF NO
                    //TODO: NOTHING
                }
            }
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
