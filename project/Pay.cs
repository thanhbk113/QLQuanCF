﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class frmPay : Form
    {
        public frmPay()
        {
            InitializeComponent();
        }
        public frmPay(string nameT)
            : this()
        {
            txtNameTable.Text = nameT;
            loadDataForm();
            loadDataBill();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Load len cho nguoi dung xem thoi
        private void loadDataForm()
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.loadTableWhere(txtNameTable.Text);
            txtSTT.Text = table.Rows[0][1].ToString();
            txtTotal.Text = table.Rows[0][2].ToString();
        }
        private void loadDataBill()
        {
            try
            {
                //Don rac
                pnlBill.Controls.Clear();
                DataProvider provider = new DataProvider();
                DataTable table = provider.loadBillWhere(txtNameTable.Text);
                //Load thong tin cac mon trong bill 
                int y = 10;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Label lbl = new Label()
                    {
                        Name = "btnFB" + i,
                        //in ra man hinh tung mon nhu vay no moi dep :)
                        Text = (i + 1) + ".     " + table.Rows[i][2].ToString() + "  X  " + table.Rows[i][3].ToString(),
                        Width = pnlBill.Width - 20,
                        Height = 20,
                        Location = new Point(5, y)
                    };
                    y += 25;
                    pnlBill.Controls.Add(lbl);
                }
            }
            catch
            {
            }
        }

        //nhan nut chap nhan thanh toan
        private void btnPay_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Bạn có muốn thanh toán " + txtNameTable.Text + "\nTổng tiền: " + txtTotal.Text + " VNĐ", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);
            if (ms == DialogResult.Yes)
            {
                //Tih tien
                DataProvider provider = new DataProvider();
                DataTable table = provider.loadBillWhere(txtNameTable.Text);
                string listFood="";
                int count=0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    listFood +=table.Rows[i][2].ToString()+", ";
                    string k = table.Rows[i][3].ToString();
                    int h = int.Parse(k);
                    count += h;
                }
                //MessageBox.Show("Cac loai food: " + listFood + "\t" + " so luong food" + count);
                provider = new DataProvider();
                provider.SaveBill(listFood,count,txtTotal.Text, DateTime.Now); 
                 
                setTableNull();
                deleteBill();
                provider = new DataProvider();
                MessageBox.Show("Đã thanh toán " + txtNameTable.Text, "Xong",MessageBoxButtons.OK,MessageBoxIcon.Information);
                provider.BookTable(txtNameTable.Text, txtTotal.Text,DateTime.Now);
                

                this.Close();
            }
            else if (ms == DialogResult.No)
            {
                this.Close();
            }
        }

        //set ban ve rong
        public void setTableNull()
        {
            DataProvider provider = new DataProvider();
            provider.ClearTable(txtNameTable.Text);
        }

        //Xoa het bill trong ban
        public void deleteBill()
        {
            DataProvider provider = new DataProvider();
            provider.ClearBill(txtNameTable.Text);
        }
    }
}
