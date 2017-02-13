using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace RVL_Management_System.Forms
{
    public partial class LandStay : MetroForm
    {
        //add
        public static string seller = "";
        public static string phone = "";
        public static string sellerEmail = "";
        public static string sellerNotes = "";
        public static string sellerName = "";
        public static string availability = "";
        public static string state = "";
        public static string county = "";
        public static string APN = "";
        public static string acres = "";
        public static string legal = "";
        public static string gps = "";
        public static string price = "";
        public static string contactOrCheckout = "";

        //update
        public static string lsid = "";
        public static string sellerUpdate = "";
        public static string phoneUpdate = "";
        public static string sellerEmailUpdate = "";
        public static string sellerNotesUpdate = "";
        public static string sellerNameUpdate = "";
        public static string availabilityUpdate = "";
        public static string stateUpdate = "";
        public static string countyUpdate = "";
        public static string APNUpdate = "";
        public static string acresUpdate = "";
        public static string legalUpdate = "";
        public static string gpsUpdate = "";
        public static string priceUpdate = "";
        public static string contactOrCheckoutUpdate = "";

        //delete
        public static string lsidDelete = "";


        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public LandStay()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void loadData()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT * FROM tblLandStay";
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void loadDataUpdate()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT * FROM tblLandStay";
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridViewUpdate.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void clear()
        {
            txt_seller.Text = null;
            txt_phone.Text = null; 
            txt_sellerEmail.Text = null;
            txt_sellerNotes.Text = null;
            txt_sellerName.Text = null;
            cBoxAvailability.Text = null;
            txt_state.Text = null;
            txt_county.Text = null;
            txt_apn.Text = null;
            txt_acres.Text = null;
            txt_legal.Text = null;
            txt_gps.Text = null;
            txt_price.Text= null;
            txt_contactOrCheckout.Text = null;
        }

        public void search()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT * FROM tblLandStay WHERE LSID = @lsid";
            cmd.Parameters.AddWithValue("lsid", txt_search.Text);
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridViewUpdate.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void searchDelete()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT * FROM tblLandStay WHERE LSID = @lsid";
            cmd.Parameters.AddWithValue("lsid", txt_searchDelete.Text);
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridViewDelete.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }


        public void clearUpdate()
        {
            txt_sellerUpdate.Text = null;
            txt_phoneUpdate.Text = null;
            txt_sellerEmailUpdate.Text = null;
            txt_sellerNotesUpdate.Text = null;
            txt_sellerNameUpdate.Text = null;
            cBoxAvailabilityUpdate.Text = null;
            txt_stateUpdate.Text = null;
            txt_countyUpdate.Text = null;
            txt_apnUpdate.Text = null;
            txt_acresUpdate.Text = null;
            txt_legalUpdate.Text = null;
            txt_gpsUpdate.Text = null;
            txt_priceUpdate.Text = null;
            txt_contactOrCheckoutUpdate.Text = null;
        }

        private void Frm_LandStayAdd_Load(object sender, EventArgs e)
        {
            loadData();
            //loadDataUpdate();

            metroTabControl1.SelectedTab = tabPage1;

        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Do you want to add these Information?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                seller = txt_seller.Text;
                phone = txt_phone.Text;
                sellerEmail = txt_sellerEmail.Text;
                sellerNotes = txt_sellerNotes.Text;
                sellerName = txt_sellerName.Text;
                availability = cBoxAvailability.Text;
                state = txt_state.Text;
                county = txt_county.Text;
                APN = txt_apn.Text;
                acres = txt_acres.Text;
                legal = txt_legal.Text;
                gps = txt_gps.Text;
                price = txt_price.Text;
                contactOrCheckout = txt_contactOrCheckout.Text;
                Class.Cls_cmd.landStayAdd();
                loadData();
                clear();
            }
            else
            {
                //IF NO
                //TODO:NOTHING
            }
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Do you want to update these Information?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lsid = lbl_lsid.Text;
                sellerUpdate = txt_sellerUpdate.Text;
                phoneUpdate = txt_phoneUpdate.Text;
                sellerEmailUpdate = txt_sellerEmailUpdate.Text;
                sellerNotesUpdate = txt_sellerNotesUpdate.Text;
                sellerNameUpdate = txt_sellerNameUpdate.Text;
                availabilityUpdate = cBoxAvailabilityUpdate.Text;
                stateUpdate = txt_stateUpdate.Text;
                countyUpdate = txt_countyUpdate.Text;
                APNUpdate = txt_apnUpdate.Text;
                acresUpdate = txt_acresUpdate.Text;
                legalUpdate = txt_legalUpdate.Text;
                gpsUpdate = txt_gpsUpdate.Text;
                priceUpdate = txt_priceUpdate.Text;
                contactOrCheckoutUpdate = txt_contactOrCheckoutUpdate.Text;
                Class.Cls_cmd.landStayUpdate();
                loadDataUpdate();
                clearUpdate();
            }
            else
            {
                //IF NO
                //TODO:NOTHING
            }
        }

        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void GridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void GridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in GridViewUpdate.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                lbl_lsid.Text = row.Cells[0].Value.ToString();
                txt_sellerUpdate.Text = row.Cells[1].Value.ToString();
                txt_phoneUpdate.Text = row.Cells[2].Value.ToString();
                txt_sellerEmailUpdate.Text = row.Cells[3].Value.ToString();
                txt_sellerNotesUpdate.Text = row.Cells[4].Value.ToString();
                txt_sellerNameUpdate.Text = row.Cells[5].Value.ToString();
                cBoxAvailabilityUpdate.Text = row.Cells[6].Value.ToString();
                txt_stateUpdate.Text = row.Cells[7].Value.ToString();
                txt_countyUpdate.Text = row.Cells[8].Value.ToString();
                txt_apnUpdate.Text = row.Cells[9].Value.ToString();
                txt_acresUpdate.Text = row.Cells[10].Value.ToString();
                txt_legalUpdate.Text = row.Cells[11].Value.ToString();
                txt_gpsUpdate.Text = row.Cells[12].Value.ToString();
                txt_priceUpdate.Text = row.Cells[13].Value.ToString();
                txt_contactOrCheckoutUpdate.Text = row.Cells[14].Value.ToString();
            }
            else
            {
                lbl_lsid.Text = null;
                txt_sellerUpdate.Text = null;
                txt_phoneUpdate.Text = null;
                txt_sellerEmailUpdate.Text = null;
                txt_sellerNotesUpdate.Text = null;
                txt_sellerNameUpdate.Text = null;
                cBoxAvailabilityUpdate.Text = null;
                txt_stateUpdate.Text = null;
                txt_countyUpdate.Text = null;
                txt_apnUpdate.Text = null;
                txt_acresUpdate.Text = null;
                txt_legalUpdate.Text = null;
                txt_gpsUpdate.Text = null;
                txt_priceUpdate.Text = null;
                txt_contactOrCheckoutUpdate.Text = null;
            }
        }

        private void GridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in GridViewUpdate.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                lbl_lsid.Text = row.Cells[0].Value.ToString();
                txt_sellerUpdate.Text = row.Cells[1].Value.ToString();
                txt_phoneUpdate.Text = row.Cells[2].Value.ToString();
                txt_sellerEmailUpdate.Text = row.Cells[3].Value.ToString();
                txt_sellerNotesUpdate.Text = row.Cells[4].Value.ToString();
                txt_sellerNameUpdate.Text = row.Cells[5].Value.ToString();
                cBoxAvailabilityUpdate.Text = row.Cells[6].Value.ToString();
                txt_stateUpdate.Text = row.Cells[7].Value.ToString();
                txt_countyUpdate.Text = row.Cells[8].Value.ToString();
                txt_apnUpdate.Text = row.Cells[9].Value.ToString();
                txt_acresUpdate.Text = row.Cells[10].Value.ToString();
                txt_legalUpdate.Text = row.Cells[11].Value.ToString();
                txt_gpsUpdate.Text = row.Cells[12].Value.ToString();
                txt_priceUpdate.Text = row.Cells[13].Value.ToString();
                txt_contactOrCheckoutUpdate.Text = row.Cells[14].Value.ToString();
            }
            else
            {
                lbl_lsid.Text = null;
                txt_sellerUpdate.Text = null;
                txt_phoneUpdate.Text = null;
                txt_sellerEmailUpdate.Text = null;
                txt_sellerNotesUpdate.Text = null;
                txt_sellerNameUpdate.Text = null;
                cBoxAvailabilityUpdate.Text = null;
                txt_stateUpdate.Text = null;
                txt_countyUpdate.Text = null;
                txt_apnUpdate.Text = null;
                txt_acresUpdate.Text = null;
                txt_legalUpdate.Text = null;
                txt_gpsUpdate.Text = null;
                txt_priceUpdate.Text = null;
                txt_contactOrCheckoutUpdate.Text = null;
            }
        }

        private void btn_clearUpdate_Click(object sender, EventArgs e)
        {
            clearUpdate();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_searchDelete_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
           
        }

        private void GridViewDelete_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in GridViewDelete.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                lbl_lsidDelete.Text = row.Cells[0].Value.ToString();
            }
            else
            {
                lbl_lsidDelete.Text = null;

            }
        }

        private void GridViewDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txt_search_Click(object sender, EventArgs e)
        {

        }

        private void txt_searchDelete_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel23_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_ButtonClick(object sender, EventArgs e)
        {
            search();

        }

        private void txt_searchDelete_ButtonClick(object sender, EventArgs e)
        {
            searchDelete();

        }

        private void txt_searchDelete_ClearClicked()
        {
            txt_searchDelete.Text = null;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_searchDelete.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Please select an information to delete.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MetroMessageBox.Show(this, "Do you want to delete these information?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lsidDelete = lbl_lsidDelete.Text;
                    Class.Cls_cmd.LandStayDelete();
                }
                else
                {
                    //IF NO
                    //TODO:NOTHING
                }
            }
        }
    }
}
