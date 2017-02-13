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
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;
using MetroFramework;

namespace RVL_Management_System.Forms
{
    public partial class MarketingUpdate : MetroForm
    {
        public static string leadReceived = "";
        public static string lastName = "";
        public static string firstName = "";
        public static string middleName = "";
        public static string phoneNumber = "";
        public static string emailAddress = "";
        public static string issueDescription = "";
        public static string leadSource = "";
        public static string leadStat = "";
        public static string leadFollow = "";
        public static string priority = "";
        public static string leadAssigned = "";
        public static string leadAssesment = "";
        public static string memo = "";
        public static string other = "";

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int AW_SLIDE = 0X40000;

        const int AW_HOR_POSITIVE = 0X1;

        const int AW_HOR_NEGATIVE = 0X2;

        const int AW_BLEND = 0X80000;

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public MarketingUpdate()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void loadLeadSource()
        {

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM tblLeadSource";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string gLeadDes = reader.GetString(reader.GetOrdinal("LeadDescription"));
                cBoxLeadSource.Items.Add(gLeadDes);
            }
            conn.Close();
        }

        public void loadLeadAssigned()
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM tblUser";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string gFullname = reader.GetString(reader.GetOrdinal("Full_Name"));
                cBoxLeadAssigned.Items.Add(gFullname);
            }
            conn.Close();
        }

        public void loadData()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT * FROM tblMarketing";
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void marketingLastName()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT * FROM tblMarketing WHERE Last_Name =@ln";
            cmd.Parameters.AddWithValue("ln", txt_search.Text);
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }
        public void marketingFirstName()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT * FROM tblMarketing WHERE First_Name =@fn";
            cmd.Parameters.AddWithValue("fn", txt_search.Text);
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }
        public void marketingMiddleName()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT * FROM tblMarketing WHERE Middle_Name =@mn";
            cmd.Parameters.AddWithValue("mn", txt_search.Text);
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        private void Frm_MarketingUpdate_Load(object sender, EventArgs e)
        {
            loadLeadSource();
            loadLeadAssigned();
            //loadData();
            cBoxLeadStats.Items.Add("Prospect");
            cBoxLeadStats.Items.Add("Qualified Lead");
            cBoxLeadStats.Items.Add("Buyer");
            cBoxLeadStats.Items.Add("Seller");
            cBoxLeadStats.Items.Add("Invalid Lead");
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_MarketingUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
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
                txt_leadID.Text = row.Cells[0].Value.ToString();
                dtLeadReceived.Text = row.Cells[1].Value.ToString();
                txt_ln.Text = row.Cells[2].Value.ToString();
                txt_fn.Text = row.Cells[3].Value.ToString();
                txt_mn.Text = row.Cells[4].Value.ToString();
                txt_pnum.Text = row.Cells[5].Value.ToString();
                txt_email.Text = row.Cells[6].Value.ToString();
                txt_IssueDes.Text = row.Cells[7].Value.ToString();
                cBoxLeadSource.Text = row.Cells[8].Value.ToString();
                txt_others.Text = row.Cells[9].Value.ToString();
                cBoxLeadFollowUp.Text = row.Cells[10].Value.ToString();
                cBoxLeadStats.Text = row.Cells[11].Value.ToString();
                cBoxPriority.Text = row.Cells[12].Value.ToString();
                txt_memo.Text = row.Cells[13].Value.ToString();
                cBoxLeadAssigned.Text = row.Cells[14].Value.ToString();
                cBoxLeadAssesment.Text = row.Cells[15].Value.ToString();
            }
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_search_ButtonClick(object sender, EventArgs e)
        {
            if (cBoxSearchBy.Text == "Last name")
            {
                marketingLastName();
            }
            if (cBoxSearchBy.Text == "First name")
            {
                marketingFirstName();
            }
            if (cBoxSearchBy.Text == "Middle name")
            {
                marketingMiddleName();
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Do you want to update this information?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                leadReceived = dtLeadReceived.Text;
                lastName = txt_ln.Text;
                firstName = txt_fn.Text;
                middleName = txt_mn.Text;
                phoneNumber = txt_pnum.Text;
                emailAddress = txt_email.Text;
                issueDescription = txt_IssueDes.Text;
                leadSource = cBoxLeadSource.Text;
                leadStat = cBoxLeadStats.Text;
                other = txt_others.Text;
                priority = cBoxPriority.Text;
                leadFollow = cBoxLeadFollowUp.Text;
                leadAssesment = cBoxLeadAssesment.Text;
                leadAssigned = cBoxLeadAssigned.Text;
                memo = txt_memo.Text;
                Class.Cls_cmd.marketingUpdate();
                loadData();
            }
            else
            {
                //TODO: NOTHING
            }
        }

        private void txt_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
