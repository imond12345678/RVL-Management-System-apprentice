﻿using System;
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
using System.Configuration;
using System.Data.SqlClient;


namespace RVL_Management_System.Forms
{
    public partial class PropertyInventoryDelete : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public static string apnID = "";
        public PropertyInventoryDelete()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void searchAPN()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblPropertyInventory WHERE APN_ID = @apnid";
            cmd.Parameters.AddWithValue("apnid", txt_search.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void searchTitle()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblPropertyInventory WHERE Title = @title";
            cmd.Parameters.AddWithValue("title", txt_search.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void refresh()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblPropertyInventory";
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }


        private void PropertyInventoryDelete_Load(object sender, EventArgs e)
        {

        }

        private void GridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in GridView.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txt_apnID.Text = row.Cells[1].Value.ToString();

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_apnID.Text == string.Empty)
            {
                MetroMessageBox.Show(this,"Please select a data to delete!", "RVL System",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                if (MetroMessageBox.Show(this, "Do you want to delete this information?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    apnID = txt_apnID.Text;
                    Class.Cls_cmd.propertyInventoryDelete();
                    refresh();
                }
                else
                {
                    //If no
                    //TODO NOTHING
                }
            }
        }

        private void txt_search_ButtonClick(object sender, EventArgs e)
        {
            if (cBoxSearchBy.Text == string.Empty)
            {
                MetroMessageBox.Show(this,"Please select a category to search on.", "RVL System", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                if (cBoxSearchBy.Text == "APN")
                {
                    searchAPN();
                }
                else if (cBoxSearchBy.Text == "Title")
                {
                    searchTitle();
                }
            }
        }
    }
}
