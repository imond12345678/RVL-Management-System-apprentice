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
    public partial class UserMenu : MetroForm
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Frm_UserAdd fadd = new Frm_UserAdd();
            fadd.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Frm_UserEdit fedit = new Frm_UserEdit();
            fedit.ShowDialog();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            Frm_UserView fview = new Frm_UserView();
            fview.ShowDialog();
        }
    }
}
