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
    public partial class FrmManHinh : DevExpress.XtraEditors.XtraForm
    {
        BDPhanQuyen qlpq = new BDPhanQuyen();
        private string tendn;
        public FrmManHinh()
        {
            InitializeComponent();
        }
        public FrmManHinh(string tendn)
        {
            InitializeComponent();
            this.tendn = tendn;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!qlpq.KiemTraTenManHinh(txbtenmh.Text))
            {
                MessageBox.Show("Đã được xét quyền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbtenmh.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(txbmamh.Text) && !string.IsNullOrWhiteSpace(txbtenmh.Text))
            {
                qlpq.themMH(txbmamh.Text, txbtenmh.Text);
                dataGridView1.DataSource = qlpq.LoadManHinh();
                txbmamh.Clear();
                txbtenmh.Clear();
            }
            else
                MessageBox.Show("Chọn và nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            btnsua.Hide();
            btnxoa.Hide();
            btnthem.Show();
            btntaommh.Show();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            qlpq.xoaMH(txbmamh.Text);
            dataGridView1.DataSource = qlpq.LoadManHinh();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbmamh.Text) && !string.IsNullOrWhiteSpace(txbtenmh.Text))
            {
                qlpq.suaMH(txbmamh.Text, txbtenmh.Text);
                dataGridView1.DataSource = qlpq.LoadManHinh();
            }
            else
                MessageBox.Show("Chọn và nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmManHinh_Load(object sender, EventArgs e)
        {
            btnsua.Hide();
            btnxoa.Hide();
            dataGridView1.DataSource = qlpq.LoadManHinh();
            dataGridView1.Columns[0].HeaderText = "Mã màn hình";
            dataGridView1.Columns[1].HeaderText = "Tên màn hình";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string mamh = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string tenmh = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txbmamh.Text = mamh;
                txbtenmh.Text = tenmh;
            }
            btntaommh.Hide();
            btnthem.Hide();
            btnxoa.Show();
            btnsua.Show();
        }
        private string TaoRandomMaMH()
        {
            Random random = new Random();
            int randomValue;
            string maMH;

            do
            {
                randomValue = random.Next(0, 1000);
                maMH = "MH" + randomValue.ToString("000");
            } while (KiemTraTrungMaMH(maMH));

            return maMH;
        }

        private bool KiemTraTrungMaMH(string maMH)
        {
            return false;
        }

        private void btntaommh_Click(object sender, EventArgs e)
        {
            txbmamh.Text = TaoRandomMaMH();
        }
    }
}