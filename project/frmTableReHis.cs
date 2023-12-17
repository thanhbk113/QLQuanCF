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
    public partial class frmTableReHis : Form
    {
        public frmTableReHis()
        {
            InitializeComponent();
            DataProvider provider = new DataProvider();
            dataGridTableReHis.DataSource = provider.LoadBookingHistory();

            //Đặt tên cho các header của DataGridView
            dataGridTableReHis.Columns[0].HeaderText = "STT";
            dataGridTableReHis.Columns[1].HeaderText = "Tên bàn";
            dataGridTableReHis.Columns[2].HeaderText = "Thời gian";
            dataGridTableReHis.Columns[3].HeaderText = "Tổng Tiền";
        }
    }
}
