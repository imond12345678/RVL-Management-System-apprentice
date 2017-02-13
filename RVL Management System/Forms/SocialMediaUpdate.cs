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
    public partial class SocialMediaUpdate : MetroForm
    {
        public static string currentMarketValue = "";
        public static string updatePrice = "";
        public static string title = "";
        public static string socialMediaNotes = "";
        public static string hashtags = "";
        public static string schedule = "";
        public static string preApproved = "";
        public static string status = "";
        public static string additionalNotes = "";


        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public SocialMediaUpdate()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void refresh()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblSocialMedia";
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void searchAPN()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblSocialMedia WHERE APN_ID = @apnID";
            cmd.Parameters.AddWithValue("apnID", txt_search.Text);
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
            string LOAD = "SELECT * FROM tblSocialMedia WHERE Title = @title";
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

        public void clear()
        {
            txt_apn.Text = null;
            txt_search.Text = null;
            txt_current.Text = null;
            txt_updatePrice.Text = null;
            txt_title.Text = null;
            txt_socialmedia.Text = null;
            txt_hashtags.Text = null;
            txt_schedule.Text = null;
            cBoxPreApproved.Text = null;
            cBoxStatus.Text = null;
            txt_addiotnalNotes.Text = null;
        }

        private void Frm_SocialMediaUpdate_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
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
                txt_apn.Text = row.Cells[0].Value.ToString();
                txt_current.Text = row.Cells[1].Value.ToString();
                txt_updatePrice.Text = row.Cells[2].Value.ToString();
                txt_title.Text = row.Cells[3].Value.ToString();
                txt_socialmedia.Text = row.Cells[4].Value.ToString();
                txt_hashtags.Text = row.Cells[5].Value.ToString();
                txt_schedule.Text = row.Cells[6].Value.ToString();
                cBoxPreApproved.Text = row.Cells[7].Value.ToString();
                cBoxStatus.Text = row.Cells[8].Value.ToString();
                txt_addiotnalNotes.Text = row.Cells[9].Value.ToString();
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_search_ButtonClick(object sender, EventArgs e)
        {
          
            if (cBoxSearchBy.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Search the APN ID or Title you want to update!", "RVL Systems", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cBoxSearchBy.Text != string.Empty)
            {
                if (cBoxSearchBy.Text == "APN ID")
                {
                    searchAPN();
                    
                }
                else if (cBoxSearchBy.Text == "Title")
                {
                    searchTitle();

                }
            }
            else
            {
                

                
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if(cBoxSearchBy.Text == string.Empty)
            {
                MetroMessageBox.Show(this,"Please choose if APN ID or Title you want to update!","RVL Systems",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(txt_current.Text == string.Empty || txt_updatePrice.Text == string.Empty || txt_title.Text == string.Empty || txt_socialmedia.Text == string.Empty || txt_hashtags.Text == string.Empty || txt_schedule.Text == string.Empty || cBoxPreApproved.Text == string.Empty || cBoxStatus.Text == string.Empty || txt_addiotnalNotes.Text == string.Empty )
            {
                MetroMessageBox.Show(this,"Please complete all the required fields you want to update!","RVL Systems",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (MetroMessageBox.Show(this, "Do you want to update this social media information?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    currentMarketValue = txt_current.Text;
                    updatePrice = txt_updatePrice.Text;
                    title = txt_title.Text;
                    socialMediaNotes = txt_socialmedia.Text;
                    hashtags = txt_hashtags.Text;
                    schedule = txt_schedule.Text;
                    preApproved = cBoxPreApproved.Text;
                    status = cBoxStatus.Text;
                    additionalNotes = txt_addiotnalNotes.Text;
                    Class.Cls_cmd.socialMediaUpdate();
                    MetroMessageBox.Show(this,"Update Succesfully","RVL Systems",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    refresh();
                    clear();
                }
                else
                {
                    //IF NO
                    //TODO:NOTHING
                }
            }
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cBoxSearchBy.Text == "APN ID")
            {
                if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if(cBoxSearchBy.Text == "Title")
            {
                if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if(txt_search.Text == string.Empty)
            {
                clear();
            }
        }
    }
}
