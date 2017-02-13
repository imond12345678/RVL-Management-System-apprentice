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
    public partial class SocialMediaExport : MetroForm
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        public SocialMediaExport()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }
        public void loadData()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblSocialMedia";
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        private void copyAlltoClipboard()
        {
            GridView.SelectAll();
            DataObject dataObj = GridView.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void Frm_SocialMediaExport_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in GridView.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                copyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                MetroMessageBox.Show(this,"Data found!","RVL Systems",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MetroMessageBox.Show(this,"No Data Found!","RVL Systems",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
