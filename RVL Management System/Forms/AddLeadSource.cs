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
using System.Data.SqlClient;
using System.Configuration;
using MetroFramework;

namespace RVL_Management_System.Forms
{
    public partial class AddLeadSource : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public static string leadDes = "";

        public void loadLID()
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT IDENT_CURRENT('tblLeadSource')+1[LeadID]";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string gLid = reader.GetDecimal(reader.GetOrdinal("LeadID")).ToString();
                txt_lid.Text = gLid;
            }
            conn.Close();
        }

        public AddLeadSource()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        private void Frm_AddLeadSource_Load(object sender, EventArgs e)
        {
            loadLID();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_leadDescription.Text == string.Empty)
            {
                //TODO: Dont save
                MetroMessageBox.Show(this, "Please fill up the required description!", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MetroMessageBox.Show(this, "Do you want to save this information?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    leadDes = txt_leadDescription.Text;
                    Class.Cls_cmd.leadAdd();
                    loadLID();
                    txt_leadDescription.Text = null;
                }
                else
                {
                    //TODO: NOTHING
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_leadDescription.Text = null;
        }
    }
}
