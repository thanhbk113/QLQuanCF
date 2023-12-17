using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class frmBillManager : Form
    {
        public frmBillManager()
        {
            InitializeComponent();
            DataProvider provider = new DataProvider();
            dataGridListBill.DataSource = provider.LoadBill();
            //Đặt tên cho các header của DataGridView

         
            dataGridListBill.Columns[0].HeaderText = "Tên Mon";
            dataGridListBill.Columns[1].HeaderText = "So Luong";
            dataGridListBill.Columns[2].HeaderText = "Tổng Tiền";
            dataGridListBill.Columns[3].HeaderText = "Thời gian";
        }

        private void frmBillManager_Load(object sender, EventArgs e)
        {

        }
    }
}
