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
    public partial class CompanyLoginsMenu : MetroForm
    {
        public CompanyLoginsMenu()
        {
            InitializeComponent();
        }

        private void Frm_CompanyLoginsMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            CompanyLoginsAdd fadd = new CompanyLoginsAdd();
            fadd.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            CompanyLoginsUpdate fupdate = new CompanyLoginsUpdate();
            fupdate.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            CompanyLoginsDelete fdelete = new CompanyLoginsDelete();
            fdelete.ShowDialog();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            CompanyLoginsView fview = new CompanyLoginsView();
            fview.ShowDialog();
        }
    }
}
