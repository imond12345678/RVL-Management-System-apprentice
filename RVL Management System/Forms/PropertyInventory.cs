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
    public partial class PropertyInventory : MetroForm
    {
        public static string dateListed = "";
        public static string apnID = "";
        public static string originalPrice = "";
        public static string currentMarketValue = "";
        public static string updatedPrice = "";
        public static string imageNo = "";
        public static string title = "";
        public static string videoPropertyLink = "";
        public static string buyersEmail = "";
        public static string notesForTheTerms = "";
        public static string urlDeeds = "";
        public static string status = "";
        public static string urlStampDeeds = "";
        public static string county = "";
        public static string soldToLandBuyer = "";
        public static string buyersPhoneNumber = "";
        public static string paymentTerms = "";
        public static string gpsUrlLink = "";
        public static string gpsCoordinates = "";
        public static string urlLinkSocialMedia = "";
        public static string termsAndConditions = "";
        public static string additionalNotes = "";
        public static string urlMoonClerk = "";
        public static string currentStatus = "";
        public static string landsSoldSite = "";
        public static string dateSold = "";
        public static string currentOwner = "";
        public static string paymentRemarks = "";

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand(); 
        public PropertyInventory()
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
                cBoxLandsSoldSite.Items.Add(gLeadDes);
            }
            conn.Close();
        }

        public void loadLandOwner()
        {

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM tblLandOwner";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string gLandOwn = reader.GetString(reader.GetOrdinal("Land_Owner"));
                cBoxLandOwner.Items.Add(gLandOwn);
            }
            conn.Close();
        }

        public void clear()
        {
            txt_apn.Text = null;
            dtDateListed.Text = null;
            txt_originalPrice.Text = null;
            txt_currentMarketValue.Text = null;
            txt_updatedPrice.Text = null;
            txt_imageNo.Text = null;
            txt_title.Text = null;
            txt_videoProperty.Text = null;
            txt_buyerEmail.Text = null;
            txt_buyerPhoneNumber.Text = null;
            txt_notesForTheTerm.Text = null;
            txt_urlDeeds.Text = null;
            txt_status.Text = null;
            txt_urlStamp.Text = null;
            txt_county.Text = null;
            txt_soldTo.Text = null;
            txt_paymentTerms.Text = null;
            txt_gpsUrl.Text = null;
            txt_gpsCoordinates.Text = null;
            txt_urlLinkForSocialMedia.Text = null;
            txt_termsAndConditions.Text = null;
            txt_additionalNotes.Text = null;
            txt_urlMoonclerk.Text = null;
            cBoxCurrentStatus.Text = null;
            cBoxLandsSoldSite.Text = null;
            dtDateSold.Text = null;
            cBoxLandOwner.Text = null;
            cBoxPaymentRemarks.Text = null;
        }


        private void Frm_PropertyInventory_Load(object sender, EventArgs e)
        {
            loadLeadSource();
            loadLandOwner();
        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            SocialMedia fsocial = new SocialMedia();
            fsocial.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            apnID = txt_apn.Text;
            dateListed = dtDateListed.Text;
            originalPrice = txt_originalPrice.Text;
            currentMarketValue = txt_currentMarketValue.Text;
            updatedPrice = txt_updatedPrice.Text;
            imageNo = txt_imageNo.Text;
            title = txt_title.Text;
            videoPropertyLink = txt_videoProperty.Text;
            buyersEmail = txt_buyerEmail.Text;
            buyersPhoneNumber = txt_buyerPhoneNumber.Text;
            notesForTheTerms = txt_notesForTheTerm.Text;
            urlDeeds = txt_urlDeeds.Text;
            status = txt_status.Text;
            urlStampDeeds = txt_urlStamp.Text;
            county = txt_county.Text;
            soldToLandBuyer = txt_soldTo.Text;
            paymentTerms = txt_paymentTerms.Text;
            gpsUrlLink = txt_gpsUrl.Text;
            gpsCoordinates = txt_gpsCoordinates.Text;
            urlLinkSocialMedia = txt_urlLinkForSocialMedia.Text;
            termsAndConditions = txt_termsAndConditions.Text;
            additionalNotes = txt_additionalNotes.Text;
            urlMoonClerk = txt_urlMoonclerk.Text;
            currentStatus = cBoxCurrentStatus.Text;
            landsSoldSite = cBoxLandsSoldSite.Text;
            dateSold = dtDateSold.Text;
            currentOwner = cBoxLandOwner.Text;
            paymentRemarks = cBoxPaymentRemarks.Text;
            Class.Cls_cmd.propertyInventoryAdd();
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            clear();
        }
    }
}
