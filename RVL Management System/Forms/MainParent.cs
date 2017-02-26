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
    public partial class MainParent : MetroForm
    {
        public static string name = "";
        public MainParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Main childForm = new Main();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            CompanyLoginsAdd childForm = new CompanyLoginsAdd();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LandStay childForm = new LandStay();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_UserAdd childform = new Frm_UserAdd();
            childform.MdiParent = this;
            childform.Show();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarketingUpdate childform = new MarketingUpdate();
            childform.MdiParent = this;
            childform.Show();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainParent_Load(object sender, EventArgs e)
        {
            lbl_Usertype.Text = Frm_Login.UserType;
            lbl_name.Text = Frm_Login.fullName;

            name = lbl_name.Text;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LandsOwnedDeedAdventure childForm = new LandsOwnedDeedAdventure();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void Marketing_Click(object sender, EventArgs e)
        {
            Frm_LeadGeneration childForm = new Frm_LeadGeneration();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertyInventory childForm = new PropertyInventory();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void SocialMedia_Click(object sender, EventArgs e)
        {
            SocialMediaAdd childForm = new SocialMediaAdd();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void VideoTutorialsAdd_Click(object sender, EventArgs e)
        {
            VideoTutorialsAdd childform = new VideoTutorialsAdd();
            childform.MdiParent = this;
            childform.Show();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminOfficeUpdate childform = new AdminOfficeUpdate();
            childform.MdiParent = this;
            childform.Show();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyLoginsUpdate childform = new CompanyLoginsUpdate();
            childform.MdiParent = this;
            childform.Show();
        }

        private void SocialMediaEdit_Click(object sender, EventArgs e)
        {
            SocialMediaUpdate childform = new SocialMediaUpdate();
            childform.MdiParent = this;
            childform.Show();
        }

        private void UserEdit_Click(object sender, EventArgs e)
        {
            Frm_UserEdit childform = new Frm_UserEdit();
            childform.MdiParent = this;
            childform.Show();
        }

        private void videoTutorialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoTutorialsUpdate childform = new VideoTutorialsUpdate();
            childform.MdiParent = this;
            childform.Show();
        }

        private void leadSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLeadSource childform = new AddLeadSource();
            childform.MdiParent = this;
            childform.Show();
        }

        private void leedOwnedDeedAdventureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminOfficeView childform = new AdminOfficeView();
            childform.MdiParent = this;
            childform.Show();
        }

        private void landStayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyLoginsView childform = new CompanyLoginsView();
            childform.MdiParent = this;
            childform.Show();
        }

        private void marketingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LandsOwnedDeedAdventureView childform = new LandsOwnedDeedAdventureView();
            childform.MdiParent = this;
            childform.Show();
        }

        private void propertyBusinessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LandStayView childform = new LandStayView();
            childform.MdiParent = this;
            childform.Show();
        }

        private void propertyInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertyInventoryView childform = new Forms.PropertyInventoryView();
            childform.MdiParent = this;
            childform.Show();
        }

        private void socialMediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarketingView childform = new MarketingView();
            childform.MdiParent = this;
            childform.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertyAccountingBusinessView childform = new PropertyAccountingBusinessView();
            childform.MdiParent = this;
            childform.Show();
        }

        private void videoTutorialsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PropertyInventoryView childform = new PropertyInventoryView();
            childform.MdiParent = this;
            childform.Show();
        }

        private void socialMediaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SocialMediaView childform = new SocialMediaView();
            childform.MdiParent = this;
            childform.Show();
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_UserView childform = new Frm_UserView();
            childform.MdiParent = this;
            childform.Show();
        }

        private void videoTutorialsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VideoTutorialsView childform = new VideoTutorialsView();
            childform.MdiParent = this;
            childform.Show();
        }

        private void toolsMenu_Click(object sender, EventArgs e)
        {

        }

        private void landStayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LandStay childform = new LandStay();
            childform.MdiParent = this;
            childform.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AdminOfficeDelete childform = new Frm_AdminOfficeDelete();
            childform.MdiParent = this;
            childform.Show();
        }

        private void companyLoginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyLoginsDelete childform = new CompanyLoginsDelete();
            childform.MdiParent = this;
            childform.Show();
        }

        private void landsOwnedDeedAdventureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LandsOwnedDeedAdventureDelete childform = new LandsOwnedDeedAdventureDelete();
            childform.MdiParent = this;
            childform.Show();
        }

        private void propertyInventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PropertyInventoryDelete childform = new PropertyInventoryDelete();
            childform.MdiParent = this;
            childform.Show();
        }

        private void socialMediaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SocialMediaDelete childform = new SocialMediaDelete();
            childform.MdiParent = this;
            childform.Show();
        }

        private void userToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UserDelete childform = new UserDelete();
            childform.MdiParent = this;
            childform.Show();
        }

        private void videoTutorialsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            VideoTutorialsDelete childform = new VideoTutorialsDelete();
            childform.MdiParent = this;
            childform.Show();
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Email childform = new Email();
            childform.MdiParent = this;
            childform.Show();
        }

        private void emailCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailCredential childform = new EmailCredential();
            childform.MdiParent = this;
            childform.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.Show();
            Hide();
        }
    }
}
