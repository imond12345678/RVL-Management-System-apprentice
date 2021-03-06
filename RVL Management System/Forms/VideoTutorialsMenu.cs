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

namespace RVL_Management_System.Forms
{
    public partial class VideoTutorialsMenu : MetroForm
    {
        public VideoTutorialsMenu()
        {
            InitializeComponent();
        }

        private void VideoTutorialsMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            VideoTutorialsAdd vAdd = new VideoTutorialsAdd();
            vAdd.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            VideoTutorialsUpdate vUpdate = new VideoTutorialsUpdate();
            vUpdate.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            VideoTutorialsDelete vDelete = new VideoTutorialsDelete();
            vDelete.ShowDialog();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            VideoTutorialsView vView = new VideoTutorialsView();
            vView.ShowDialog();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            VideoTutorialsExport vExport = new VideoTutorialsExport();
            vExport.ShowDialog();
        }
    }
}
