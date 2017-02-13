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
    public partial class CaliforniaGrantDeed : MetroForm
    {
        public static string preparedBy = "";
        public static string returnTo = "";
        public static string statementsToGrantee = "";
        public static string APN = "";
        public static string acknowledged = "";
        public static string grantTo = "";
        public static string countyOf = "";
        public static string dated = "";
        public static string grantor = "";
        public static string grantPrintDeedName = "";
        public static string stateOf = "";
        public static string acknowledgementCountyOf = "";
        public static string acknowledgementOn = "";
        public static string beforeMe = "";
        public static string personallyAppeared = "";
        public static string lawStateOf = "";
        public static string notaryPublic = "";
        public static string commissionExpires = "";
        public static string acknowledgementPrintName = "";
        public static string grantorNameAddressPhone = "";
        public static string granteeNameAddressPhone = "";

        public CaliforniaGrantDeed()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txt_preparedBy.Text = null;
            txt_recordingReturn.Text = null;
            txt_taxstatementGrantee.Text = null;
            txt_apn.Text = null;
            txt_acknowledged.Text = null;
            txt_grantTo.Text = null;
            txt_countyOf.Text = null;
            dtDated.Text = null;
            txt_grantor.Text = null;
            txt_grantPrintName.Text = null;
            txt_stateOf.Text = null;
            txt_acknowledgedCountyOf.Text = null;
            txt_on.Text = null;
            txt_beforeMe.Text = null;
            txt_personallyAppeared.Text = null;
            txt_lawsStateOf.Text = null;
            txt_notaryPublic.Text = null;
            txt_commissionExpires.Text = null;
            txt_acknowledgedPrintName.Text = null;
            txt_grantorName.Text = null;
            txt_granteeName.Text = null;
        }

        private void Frm_CaliforniaGrantDeed_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            preparedBy = txt_preparedBy.Text;
            returnTo = txt_recordingReturn.Text;
            statementsToGrantee = txt_taxstatementGrantee.Text;
            APN = txt_apn.Text;
            acknowledged = txt_acknowledged.Text;
            grantTo = txt_grantTo.Text;
            countyOf = txt_countyOf.Text;
            dated = dtDated.Text;
            grantor = txt_grantor.Text;
            grantPrintDeedName = txt_grantPrintName.Text;
            stateOf = txt_stateOf.Text;
            acknowledgementCountyOf = txt_acknowledgedCountyOf.Text;
            acknowledgementOn = txt_on.Text;
            beforeMe = txt_beforeMe.Text;
            personallyAppeared = txt_personallyAppeared.Text;
            lawStateOf = txt_lawsStateOf.Text;
            notaryPublic = txt_notaryPublic.Text;
            commissionExpires = txt_commissionExpires.Text;
            acknowledgementPrintName = txt_acknowledgedPrintName.Text;
            grantorNameAddressPhone = txt_grantorName.Text;
            granteeNameAddressPhone = txt_granteeName.Text;
            Class.Cls_cmd.californiaDeedAdd();
            clear();
        }
    }
}
