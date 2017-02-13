using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using MetroFramework;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RVL_Management_System.Forms
{
    public partial class PropertyAccountingPersonal : MetroForm
    {
        public static string account = "";
        public static string billedFrom = "";
        public static string billedTo = "";
        public static string memo = "";
        public static string amount = "";
        public static string dateRecorded = "";
        public static string notes = "";
        public static string total = "";

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public PropertyAccountingPersonal()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void computeTotal()
        {
            int sum = 0;
            for (int i = 0; i < GridView.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(GridView.Rows[i].Cells[1].Value);
            }
            lbl_total.Text = sum.ToString();
        }

        public void computeAmountTotal()
        {
            int sum = 0;
            for (int i = 0; i < GridView.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(GridView.Rows[i].Cells[0].Value);
            }
            lbl_amount.Text = sum.ToString();
        }

        public void searchBilledTo()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT Amount,Total,DateRecorded FROM Personal WHERE BilledTo =@bt";
            cmd.Parameters.AddWithValue("bt", txt_billedTo.Text);
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void loadData()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT Amount,Total,DateRecorded FROM Personal";
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void clear()
        {
            cBoxAccount.Text = null;
            cBoxBilled.Text = null;
            txt_billedTo.Text = null;
            txt_memo.Text = null;
            txt_amount.Text = null;
            dtDateRecorded.Text = null;
            txt_notes.Text = null;
            lbl_total.Text = null;
        }

        private void Frm_PropertyAccountingPersonal_Load(object sender, EventArgs e)
        {
            loadData();
            computeTotal();
            computeAmountTotal();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxAccount.Text == "Business")
            {
                PropertyAccountingBusiness business = new PropertyAccountingBusiness();
                business.Show();
                Hide();
            }
            else
            {
                //TODO: NOTHING
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Do you want to save these Informations?", "RVL Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                account = cBoxAccount.Text;
                billedFrom = cBoxBilled.Text;
                billedTo = txt_billedTo.Text;
                memo = txt_memo.Text;
                amount = txt_amount.Text;
                dateRecorded = dtDateRecorded.Text;
                notes = txt_notes.Text;
                total = lbl_amount.Text;
                Class.Cls_cmd.accountingPersonalAdd();
                clear();
            }
            else
            {
                //IF NO
                //TODO: NOTHING 
            }
        }

        private void txt_billedTo_TextChanged(object sender, EventArgs e)
        {
            searchBilledTo();
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
            //computeTotal();
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            computeTotal();
            computeAmountTotal();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_billedTo_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txt_memo_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel25_Click(object sender, EventArgs e)
        {

        }

        private void cBoxBilled_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dtDateRecorded_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void txt_notes_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txt_amount_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel24_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_amount_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }
    }
}
