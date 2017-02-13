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

namespace RVL_Management_System.Forms
{
    public partial class Main : MetroForm
    {
        public static string name = "";
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbl_Usertype.Text = Frm_Login.UserType;
            lbl_name.Text = Frm_Login.fullName;

            name = lbl_name.Text;

            TabControlMain.SelectedTab = tabPage1;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Frm_UserAdd userAdd = new Frm_UserAdd();
            userAdd.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Frm_UserEdit userEdit = new Frm_UserEdit();
            userEdit.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Frm_UserView userView = new Frm_UserView();
            userView.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            CompanyLoginsAdd companyAdd = new CompanyLoginsAdd();
            companyAdd.ShowDialog();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            CompanyLoginsUpdate companyEdit = new CompanyLoginsUpdate();
            companyEdit.ShowDialog();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            CompanyLoginsDelete companyDelete = new CompanyLoginsDelete();
            companyDelete.ShowDialog();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            CompanyLoginsView companyView = new CompanyLoginsView();
            companyView.ShowDialog();
        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            SocialMediaAdd socialAdd = new SocialMediaAdd();
            socialAdd.ShowDialog();
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            SocialMediaUpdate socialEdit = new SocialMediaUpdate();
            socialEdit.ShowDialog();
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            SocialMediaExport socialExport = new SocialMediaExport();
            socialExport.ShowDialog();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            SocialMediaView socialView = new SocialMediaView();
            socialView.ShowDialog();
        }

        private void metroTile14_Click(object sender, EventArgs e)
        {
            PropertyAccountingBusiness accountBusiness = new PropertyAccountingBusiness();
            accountBusiness.ShowDialog();
        }

        private void metroTile13_Click(object sender, EventArgs e)
        {
            PropertyAccountingPersonal accountPersonal = new PropertyAccountingPersonal();
            accountPersonal.ShowDialog();
        }

        private void metroTile19_Click(object sender, EventArgs e)
        {
            VideoTutorialsAdd vAdd = new VideoTutorialsAdd();
            vAdd.ShowDialog();
        }

        private void metroTile18_Click(object sender, EventArgs e)
        {
            VideoTutorialsUpdate vUpdate = new VideoTutorialsUpdate();
            vUpdate.ShowDialog();
        }

        private void metroTile17_Click(object sender, EventArgs e)
        {
            VideoTutorialsDelete vDelete = new VideoTutorialsDelete();
            vDelete.ShowDialog();
        }

        private void metroTile16_Click(object sender, EventArgs e)
        {
            VideoTutorialsView vView = new VideoTutorialsView();
            vView.ShowDialog();
        }

        private void metroTile15_Click(object sender, EventArgs e)
        {
            VideoTutorialsExport vExport = new VideoTutorialsExport();
            vExport.ShowDialog();
        }

        private void metroTile20_Click(object sender, EventArgs e)
        {
            Frm_LeadGeneration fLead = new Frm_LeadGeneration();
            fLead.ShowDialog();
        }

        private void metroTile21_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.ShowDialog();
        }

        private void metroTile22_Click(object sender, EventArgs e)
        {
            LandStay landstay = new LandStay();
            landstay.ShowDialog();
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            LandsOwnedDeedAdventure landsOwned = new LandsOwnedDeedAdventure();
            landsOwned.ShowDialog();
        }

        private void metroTile3_Click_1(object sender, EventArgs e)
        {
            Frm_Tasks tasks = new Frm_Tasks();
            tasks.ShowDialog();
        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            TrainingMaterials trainMats = new TrainingMaterials();
            trainMats.ShowDialog();
        }

        private void metroTile4_Click_1(object sender, EventArgs e)
        {
            Frm_Login fLogin = new Frm_Login();
            fLogin.Show();
            Hide();
        }

        private void metroTile5_Click_1(object sender, EventArgs e)
        {
            MarketingUpdate update = new MarketingUpdate();
            update.ShowDialog();
        }

        private void btn_exportCompany_Click(object sender, EventArgs e)
        {
            Frm_CompanyLoginsExport export = new Frm_CompanyLoginsExport();
            export.ShowDialog();
        }

        private void metroTile6_Click_1(object sender, EventArgs e)
        {
            LeadAssigned leadAssigned = new LeadAssigned();
            leadAssigned.ShowDialog();

            name = lbl_name.Text;
        }

        private void metroTile8_Click_1(object sender, EventArgs e)
        {
            PropertyInventory inventory = new PropertyInventory();
            inventory.ShowDialog();
        }
    }
}
