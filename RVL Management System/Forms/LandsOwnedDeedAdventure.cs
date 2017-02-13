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

namespace RVL_Management_System.Forms
{
    public partial class LandsOwnedDeedAdventure : MetroForm
    {
        public static string apn = "";
        public static string county = "";
        public static string originalPrice = "";
        public static string marketPrice = "";
        public static string statusOfTheLand = "";
        public static string typeOfSale = "";
        public static string downPaymentMade = "";
        public static string monthlyPaymentMade = "";
        public static string paymentPaidSoFar = "";
        public static string amountClosed = "";

        public LandsOwnedDeedAdventure()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txt_apn.Text = null;
            txt_county.Text = null;
            txt_origPrice.Text = null;
            txt_marketPrice.Text = null;
            cBoxStatus.Text = null;
            cBoxTypeOfSale.Text = null;
            txt_downPaymentMade.Text = null;
            txt_monthlyPaymentMade.Text = null;
            txt_paymentPaidSoFar.Text = null;
            txt_amountClosed.Text = null;
        }

        private void LandsOwnedDeedAdventure_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            LandsOwnedDeedAdventureView fview = new LandsOwnedDeedAdventureView();
            fview.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (txt_apn.Text == string.Empty || txt_county.Text == string.Empty || txt_origPrice.Text == string.Empty || txt_marketPrice.Text == string.Empty || cBoxStatus.Text == string.Empty || cBoxTypeOfSale.Text == string.Empty || txt_downPaymentMade.Text == string.Empty || txt_monthlyPaymentMade.Text == string.Empty || txt_paymentPaidSoFar.Text == string.Empty || txt_amountClosed.Text == string.Empty)
            {
                MetroMessageBox.Show(this,"PLease complete the required field","RVL System",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (MetroMessageBox.Show(this, "Do you want to add this information?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    apn = txt_apn.Text;
                    county = txt_county.Text;
                    originalPrice = txt_origPrice.Text;
                    marketPrice = txt_marketPrice.Text;
                    statusOfTheLand = cBoxStatus.Text;
                    typeOfSale = cBoxTypeOfSale.Text;
                    downPaymentMade = txt_downPaymentMade.Text;
                    monthlyPaymentMade = txt_monthlyPaymentMade.Text;
                    paymentPaidSoFar = txt_paymentPaidSoFar.Text;
                    amountClosed = txt_amountClosed.Text;
                    Class.Cls_cmd.deedAdventureAdd();
                }
                else
                {
                    //IF NO
                    //TODO: NOTHING
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

        private void btn_view_Click_1(object sender, EventArgs e)
        {
            LandsOwnedDeedAdventureView lView = new LandsOwnedDeedAdventureView();
            lView.ShowDialog();
        }
    }
}
