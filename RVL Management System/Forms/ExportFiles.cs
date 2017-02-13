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
    public partial class ExportFiles : MetroForm
    {
        public ExportFiles()
        {
            InitializeComponent();
        }

        private void Frm_ExportFiles_Load(object sender, EventArgs e)
        {

        }

        private void btn_company_Click(object sender, EventArgs e)
        {
            Frm_CompanyLoginsExport fcompanyView = new Frm_CompanyLoginsExport();
            fcompanyView.ShowDialog();
        }

        private void btn_adminOffice_Click(object sender, EventArgs e)
        {
            AdminOfficeExport fadminView = new AdminOfficeExport();
            fadminView.ShowDialog();
        }

        private void btn_landStay_Click(object sender, EventArgs e)
        {
            LandStayExport flandView = new LandStayExport();
            flandView.ShowDialog();
        }

        private void btn_socialMedia_Click(object sender, EventArgs e)
        {
            SocialMediaExport fsocialExport = new SocialMediaExport();
            fsocialExport.ShowDialog();
        }

        private void btn_videoTutorials_Click(object sender, EventArgs e)
        {
            VideoTutorialsExport fvideoView = new VideoTutorialsExport();
            fvideoView.ShowDialog();
        }
    }
}
