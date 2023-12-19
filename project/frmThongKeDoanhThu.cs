﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // code nút Thống Kê tại đây:
            DataProvider dataProvider = new DataProvider();

            mtbTuNgay.Text = DateTime.Now.ToString("dd/MM/yyyy 00:01");
            mtbToiNgay.Text = DateTime.Now.ToString("dd/MM/yyyy 00:01");

            
            dataGridView3.DataSource = dataProvider.SaveThongKe(DateTime.Parse(mtbTuNgay.Text), DateTime.Parse(mtbToiNgay.Text));
            //Đặt tên cho các header của DataGridView


            dataGridView3.Columns[0].HeaderText = "Bill ID";
            dataGridView3.Columns[1].HeaderText = "Tên Mon";
            dataGridView3.Columns[2].HeaderText = "So Luong";
            dataGridView3.Columns[3].HeaderText = "Tổng Tiền";
            dataGridView3.Columns[4].HeaderText = "Thời gian";
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //code trả về dữ liệu tại đây

        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialogReport.Document = printDocumentReport;
            if (printPreviewDialogReport.ShowDialog() == DialogResult.OK)
            {
                printDocumentReport.Print();
            }
        }

        private void printDocumentReport_PrintPage(object sender, PrintPageEventArgs e)
        {
            //code in ra thong ke doanh thu:

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // code in ra tổng tiền tại đây

        }
    }
}
