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
    public partial class LandOwner : MetroForm
    {
        public static string landOwner = "";
        public LandOwner()
        {
            InitializeComponent();
        }

        private void Frm_LandOwner_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_landowner.Text == string.Empty)
            {
                MetroMessageBox.Show(this,"Please enter the name of the Land Owner","RVL System",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (MetroMessageBox.Show(this, "Do you want to add this information?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    landOwner = txt_landowner.Text;
                    Class.Cls_cmd.landOwnerAdd();
                    txt_landowner.Text = null;
                }
                else
                {
                    //IF NO
                    //TODO: NOTHING
                }
            }
        }
    }
}
