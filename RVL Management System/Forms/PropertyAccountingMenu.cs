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
    public partial class PropertyAccountingMenu : MetroForm
    {
        public PropertyAccountingMenu()
        {
            InitializeComponent();
        }

        private void Frm_PropertyAccountingMenu_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PropertyAccountingBusiness fbusiness = new PropertyAccountingBusiness();
            fbusiness.ShowDialog();
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            PropertyAccountingPersonal fpersonal = new PropertyAccountingPersonal();
            fpersonal.ShowDialog(); 
        }
    }
}
