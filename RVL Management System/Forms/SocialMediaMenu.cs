using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;

namespace RVL_Management_System.Forms
{
    public partial class SocialMediaMenu : MetroForm
    {
        public SocialMediaMenu()
        {
            InitializeComponent();
        }

        private void Frm_SocialMediaMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SocialMediaAdd fadd = new SocialMediaAdd();
            fadd.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SocialMediaUpdate fupdate = new SocialMediaUpdate();
            fupdate.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            SocialMediaView fview = new SocialMediaView();
            fview.ShowDialog();
        }
    }
}
