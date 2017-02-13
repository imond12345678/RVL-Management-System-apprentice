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
using System.Globalization;

namespace RVL_Management_System.Forms
{
    public partial class PropertyAccountingBusiness : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public static string typeAccount = "";
        public static string typePayment = "";
        public static string paidVia = "";
        public static string apnID = "";
        public static string dateSold = "";
        public static string dateAquired = "";
        public static string closedSale = "";
        public static string originalPrice = "";
        public static string originalPriceExpense = "";
        public static string netSale = "";
        public static string balanceDue = "";
        public static string soldFrom = "";
        public static string soldTo = "";
        public static string termsLLC = "";
        public static string shared60 = "";
        public static string shared40 = "";
        public static string checkNumber = "";
        public static string invoiceNumber = "";
        public static string memo = "";
        public static string datePayment = "";
        public static string amountPayment = "";
        public static string totalAmountPaid = "";
        public static string totalLandCost = "";
        public static string paymentBalanceDue = "";
        public static string categoryExpense = "";
        public static string notes = "";
        public static string recordingFee = "";
        public static string cardProcessingFee = "";
        public static string backTaxes = "";
        public static string notary = "";
        public static string otherExpense = "";
        public static string totalExpense = "";
        public static string netProfit = "";



        public PropertyAccountingBusiness()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void loadPayments()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT Date_Payments,Amount_Payments,Total_Amount_Paid,Total_Land_Cost,Payment_Balance_Due FROM tblAccountingBusiness WHERE Sold_To = @soldTo";
            cmd.Parameters.AddWithValue("soldTo", cBoxSoldTo.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
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
                cBoxSoldFrom.Items.Add(gLandOwn);
            }
            conn.Close();
        }

        public void computePayments()
        {
            int sum = 0;
            for (int i = 0; i < GridView.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(GridView.Rows[i].Cells[1].Value);
            }
            txt_totalAmountPaid.Text = sum.ToString();
        }

        private void Frm_PropertyAccounting_Load(object sender, EventArgs e)
        {
            loadLandOwner();
            loadPayments();

            computePayments();
        }

        private void Frm_PropertyAccountingBusiness_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {

        }

        private void Frm_PropertyAccountingBusiness_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Do you want to save these information?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                typeAccount = cBoxAccount.Text;
                typePayment = cBoxPayment.Text;
                paidVia = cBoxPaid.Text;
                apnID = txt_apn.Text;
                dateSold = dtSold.Text;
                dateAquired = dtAquired.Text;
                closedSale = txt_closedSale.Text;
                originalPrice = txt_origPrice.Text;
                originalPriceExpense = txt_originalPriceExpense.Text;
                netSale = txt_netSale.Text;
                balanceDue = txt_balanceDue.Text;
                soldFrom = cBoxSoldFrom.Text;
                soldTo = cBoxSoldTo.Text;
                termsLLC = txt_termsLLC.Text;
                shared60 = txt_shared60.Text;
                shared40 = txt_shared40.Text;
                checkNumber = txt_checkNumber.Text;
                invoiceNumber = txt_invoiceNumber.Text;
                memo = txt_memo.Text;
                datePayment = dtPayment.Text;
                amountPayment = txt_amount.Text;
                totalAmountPaid = txt_totalAmountPaid.Text;
                totalLandCost = txt_landCost.Text;
                paymentBalanceDue = txt_paymentsBalanceDue.Text;
                categoryExpense = txt_categoryExpense.Text;
                notes = txt_paymentNotes.Text;
                recordingFee = txt_recordingFee.Text;
                cardProcessingFee = txt_cardProcessingFee.Text;
                backTaxes = txt_backTaxes.Text;
                notary = txt_Notary.Text;
                otherExpense = txt_otherExpense.Text;
                totalExpense = txt_totalExpense.Text;
                netProfit = txt_netProfit.Text;
                Class.Cls_cmd.accountingBusinessAdd();
                loadPayments();
                computePayments();
            }
            else
            {
                //IF NO
                //TODO:NOTHING
            }
        }

        private void txt_totalExpense_TextChanged(object sender, EventArgs e)
        {
            txt_totalExpense1.Text = txt_totalExpense.Text;
            //int b = Convert.ToInt32(txt_totalExpense.Text);
            //int c = Convert.ToInt32(txt_origPrice.Text);

            //txt_netSale.Text = (b + c).ToString();
        }

        private void txt_originalPriceExpense_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void metroLabel15_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_totalExpense_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_totalExpense_Leave(object sender, EventArgs e)
        {
            //int value;
            //if (int.TryParse(txt_totalExpense.Text, out value))
            //{
            //    txt_totalExpense.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            //}
            //else
            //{
            //    txt_totalExpense.Text = String.Empty;
            //}
        }

        private void txt_netSale_Leave(object sender, EventArgs e)
        {
            //int value;
            //if (int.TryParse(txt_netSale.Text, out value))
            //    txt_netSale.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            //else
            //    txt_netSale.Text = String.Empty;
        }

        private void txt_balanceDue_Leave(object sender, EventArgs e)
        {
            
        }

        private void txt_originalPriceExpense_Leave(object sender, EventArgs e)
        {
            //int value;
            //if (int.TryParse(txt_originalPriceExpense.Text, out value))
            //    txt_originalPriceExpense.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            //else
            //    txt_originalPriceExpense.Text = String.Empty;
        }

        private void txt_balanceDue_Enter(object sender, EventArgs e)
        {
            //int value;
            //if (int.TryParse(txt_balanceDue.Text, out value))
            //    txt_balanceDue.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            //else
            //    txt_balanceDue.Text = String.Empty;
        }

        private void txt_originalPriceExpense_Click(object sender, EventArgs e)
        {

        }

        private void txt_shared60_Click(object sender, EventArgs e)
        {
            //string.Format("{0:#.00}", Convert.ToInt32(txt_shared60.Text) * 0.60);
        }

        private void txt_netSale_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_recordingFee_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_backTaxes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_cardProcessingFee_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Notary_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_otherExpense_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_recordingFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;

            if (e.KeyChar == (char)13)
            {
                txt_recordingFee.Text = string.Format("{0:n0}", double.Parse(txt_recordingFee.Text));
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (txt_origPrice.Text == string.Empty || txt_recordingFee.Text == string.Empty || txt_cardProcessingFee.Text == string.Empty || txt_backTaxes.Text == string.Empty || txt_Notary.Text == string.Empty || txt_otherExpense.Text == string.Empty || txt_totalExpense.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Make sure to fill-up the required fields! - Original Price, Recording fee, Card processing fee, Back taxes, Notary, Other Expense.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_originalPriceExpense.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToInt32(txt_totalExpense1.Text) + Convert.ToInt32(txt_origPrice1.Text));

                txt_netProfit.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToInt32(txt_totalExpense1.Text) + Convert.ToInt32(txt_origPrice1.Text));

                txt_shared60.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToInt32(txt_origPrice1.Text) * 0.60);
                txt_shared40.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToInt32(txt_origPrice1.Text) * 0.40);


                int a = Convert.ToInt32(txt_origPrice1.Text);
                int b = Convert.ToInt32(txt_origPriceExpense1.Text);
                int c = Convert.ToInt32(txt_origPrice.Text);
                int d = Convert.ToInt32(txt_totalAmountPaid.Text);

                txt_netSale.Text = (a - b).ToString();

                txt_paymentsBalanceDue.Text = (c - d).ToString();
            }
        }

        private void txt_recordingFee_Leave(object sender, EventArgs e)
        {
            txt_totalExpense.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToInt32(txt_recordingFee.Text));

            int a = Convert.ToInt32(txt_recordingFee.Text);
            txt_totalExpense1.Text = (a).ToString();
        }

        private void txt_cardProcessingFee_Leave(object sender, EventArgs e)
        {
           txt_totalExpense.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToInt32(txt_recordingFee.Text) + Convert.ToInt32(txt_cardProcessingFee.Text));

            int a = Convert.ToInt32(txt_recordingFee.Text);
            int b = Convert.ToInt32(txt_cardProcessingFee.Text);
            txt_totalExpense1.Text = (a + b).ToString();
        }

        private void txt_backTaxes_Leave(object sender, EventArgs e)
        {
            txt_totalExpense.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToInt32(txt_recordingFee.Text) + Convert.ToInt32(txt_cardProcessingFee.Text) + Convert.ToInt32(txt_backTaxes.Text));

            int a = Convert.ToInt32(txt_recordingFee.Text);
            int b = Convert.ToInt32(txt_cardProcessingFee.Text);
            int c = Convert.ToInt32(txt_backTaxes.Text);
            txt_totalExpense1.Text = (a + b + c).ToString();

        }

        private void txt_Notary_Leave(object sender, EventArgs e)
        {
            txt_totalExpense.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToInt32(txt_recordingFee.Text) + Convert.ToInt32(txt_cardProcessingFee.Text) + Convert.ToInt32(txt_backTaxes.Text) + Convert.ToInt32(txt_Notary.Text));

            int a = Convert.ToInt32(txt_recordingFee.Text);
            int b = Convert.ToInt32(txt_cardProcessingFee.Text);
            int c = Convert.ToInt32(txt_backTaxes.Text);
            int d = Convert.ToInt32(txt_Notary.Text);
            txt_totalExpense1.Text = (a + b + c + d).ToString();
        }

        private void txt_otherExpense_Leave(object sender, EventArgs e)
        {
            txt_totalExpense.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToInt32(txt_recordingFee.Text) + Convert.ToInt32(txt_cardProcessingFee.Text) + Convert.ToInt32(txt_backTaxes.Text) + Convert.ToInt32(txt_Notary.Text) + Convert.ToInt32(txt_otherExpense.Text));


            int a = Convert.ToInt32(txt_recordingFee.Text);
            int b = Convert.ToInt32(txt_cardProcessingFee.Text);
            int c = Convert.ToInt32(txt_backTaxes.Text);
            int d = Convert.ToInt32(txt_Notary.Text);
            int f = Convert.ToInt32(txt_otherExpense.Text);
            txt_totalExpense1.Text = (a + b + c + d + f).ToString();

            int g = Convert.ToInt32(txt_origPrice1.Text);
            int h = Convert.ToInt32(txt_totalExpense1.Text);

            txt_origPriceExpense1.Text = (g + h).ToString();
        }

        private void txt_origPrice_Validated(object sender, EventArgs e)
        {

        }

        private void txt_origPrice_TextChanged(object sender, EventArgs e)
        {
            txt_origPrice1.Text = txt_origPrice.Text;
            txt_landCost.Text = txt_origPrice.Text;
            txt_origPriceExpense1.Text  = txt_originalPriceExpense.Text;

            int value;
            if (int.TryParse(txt_landCost.Text, out value))
            {
                txt_landCost.Text = String.Format(CultureInfo.CurrentCulture, "{0:C2}", value);
            }
            else
            {
                txt_netSale.Text = String.Empty;
            }
        }

        private void txt_origPrice1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_totalExpense1_TextChanged(object sender, EventArgs e)
        {
            //txt_netSale.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToInt32(txt_origPrice.Text) - Convert.ToInt32(txt_origPriceExpense1.Text));

            
        }

        private void txt_paymentsBalanceDue_TextChanged(object sender, EventArgs e)
        {
            txt_balanceDue.Text = txt_paymentsBalanceDue.Text;
        }

        private void cBoxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxAccount.Text == "Personal")
            {
                PropertyAccountingPersonal personal = new PropertyAccountingPersonal();
                personal.Show();
                Hide();
            }
            else
            {
                //TODO: NOTHING
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
