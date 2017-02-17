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
    public partial class VideoTutorialsUpdate : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public static string process = "";
        public static string link = "";
        public static string vid = "";

        public VideoTutorialsUpdate()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void searchProcess()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblVideoTutorial WHERE Process = @process";
            cmd.Parameters.AddWithValue("process", txt_search.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void searchvideoID()
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

        public void clear()
        {
            txt_process.Text = null;
            txt_youtube.Text = null;
            txt_vid.Text = null;
            txt_search.Text = null;
            cBoxSearchBy.Text = null;
        }

        private void Frm_VideoTutorialsUpdate_Load(object sender, EventArgs e)
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
                txt_vid.Text = row.Cells[0].Value.ToString();
                txt_process.Text = row.Cells[1].Value.ToString();
                txt_youtube.Text = row.Cells[2].Value.ToString();

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_search_ButtonClick(object sender, EventArgs e)
        {
            if (cBoxSearchBy.Text == "Process")
            {
                searchProcess();
            }
            else if (cBoxSearchBy.Text == "VID")
            {
                searchvideoID();
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (txt_vid.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Please select a data to update!", "RVL System", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else {
                if (MetroMessageBox.Show(this, "Do you want to update these information?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    process = txt_process.Text;
                    link = txt_youtube.Text;
                    vid = txt_vid.Text;
                    Class.Cls_cmd.videoTutorialsUpdate();
                    clear();
                }
                else
                {
                    //IF NO
                    //TODO:NOTHING
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
