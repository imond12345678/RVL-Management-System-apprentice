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
    public partial class VideoTutorialsDelete : MetroForm
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        public static string vid = "";

        public VideoTutorialsDelete()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void searchVideoID()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblVideoTutorial WHERE VID = @vid";
            cmd.Parameters.AddWithValue("vid", txt_search.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void searchProcess()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblVideoTutorial WHERE Process = @proc";
            cmd.Parameters.AddWithValue("proc", txt_search.Text);
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
            string LOAD = "SELECT * FROM tblVideoTutorial";
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
            txt_vid.Text = null;
            txt_search.Text = null;
            cBoxSearchBy.Text = null;
        }

        private void Frm_VideoTutorialsDelete_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
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
                txt_vid.Text = row.Cells[0].Value.ToString();
                txt_delete.Text = row.Cells[1].Value.ToString();

            }
        }

        private void txt_search_ButtonClick(object sender, EventArgs e)
        {
            if (cBoxSearchBy.Text == "VID")
            {
                searchVideoID();
            }
            else if (cBoxSearchBy.Text == "Process")
            {
                searchProcess();
            }
        }

        private void txt_search_ClearClicked()
        {
            clear();   
        }

        private void metroTextBox1_ButtonClick(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Do you want to delete these informations?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vid = txt_vid.Text;
                Class.Cls_cmd.videoTutorialsDelete();
                clear();
                refresh();
            }
            else
            {
                //IF NO
                //TODO:NOTHING
            }
        }
    }
}
