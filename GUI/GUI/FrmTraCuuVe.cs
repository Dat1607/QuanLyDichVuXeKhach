using BLL_DAL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmTraCuuVe : DevExpress.XtraEditors.XtraForm
    {
        BDVe qlv = new BDVe();
        private string tendn;
        public FrmTraCuuVe(string tendn)
        {
            InitializeComponent();
            this.tendn = tendn;
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntracuu_Click(object sender, EventArgs e)
        {
            var timKiem = qlv.TraCuuVe(txbtenkh.Text, txbsdt.Text);
            if (timKiem.Count > 0)
            {
                dataGridView1.DataSource = timKiem;
                dataGridView1.Columns[0].HeaderText = "Mã vé xe";
                dataGridView1.Columns[1].HeaderText = "Mã ghế ngồi";
                dataGridView1.Columns[2].HeaderText = "Ngày đặt";
                dataGridView1.Columns[3].HeaderText = "Mã xe";
                dataGridView1.Columns[5].HeaderText = "Mã khách hàng";
                dataGridView1.Columns[6].HeaderText = "Tên khách hàng";
                dataGridView1.Columns[4].Visible = false;
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tenKhachHang = txbtenkh.Text;
            string sdt = txbsdt.Text;

            List<VeX> ves = qlv.TraCuuVe(tenKhachHang, sdt);

            dataGridView1.DataSource = ves;
        }

        private void txbtenkh_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbtenkh.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbtenkh.Focus();
            }
            else if (txbtenkh.Text.Length < 5 || txbtenkh.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập từ 5 đến 50 ký tự");
                txbtenkh.Focus();
            }
            else if (txbtenkh.Text.Contains("  "))
            {
                MessageBox.Show("Vui lòng chỉ nhập một khoảng trắng giữa các ký tự");
                txbtenkh.Focus();
            }
        }

        private void txbsdt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbsdt.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbsdt.Focus();
            }
            else if (txbsdt.Text.Length != 10)
            {
                MessageBox.Show("Vui lòng nhập đúng 10 số");
                txbsdt.Focus();
            }
        }
    }
}