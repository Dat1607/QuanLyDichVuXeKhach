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
    public partial class FrmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        BDPhanQuyen qlpq = new BDPhanQuyen();
        private string maq;
        private string tenq;
        public FrmPhanQuyen(string maquyen, string tenquyen)
        {
            InitializeComponent();
            this.maq = maquyen;
            this.tenq = tenquyen;
            LoadData();
        }
        public FrmPhanQuyen(string maquyen)
        {
            InitializeComponent();
            this.maq = maquyen;
        }
        private void LoadData()
        {
            var mns = qlpq.LoadManHinh();

            foreach (var mn in mns)
            {
                cbbmamh.Items.Add(mn.MaManHinh);
            }
            cbbmamh.SelectedIndex = 0;
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            cbbmamh.Text = "Chọn mã màn hình";
            cbbmamh.ForeColor = Color.Gray;
            txbtenmh.Text = "";
            chbquyen.Checked = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!qlpq.KiemTraPhanQuyen(cbbmamh.Text, txbMaquyen.Text))
            {
                MessageBox.Show("Đã được phân quyền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbmamh.Focus();
                return;
            }
            if (cbbmamh.SelectedItem != null)
            {
                qlpq.themPQ(cbbmamh.Text, txbMaquyen.Text, chbquyen.Checked);
                dataGridView1.DataSource = qlpq.LoadPQ(maq);
            }
            else
                MessageBox.Show("Chọn và nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            qlpq.xoaPQ(cbbmamh.Text, txbMaquyen.Text);
            dataGridView1.DataSource = qlpq.LoadPQ(maq);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (cbbmamh.SelectedItem != null)
            {
                bool isChecked = chbquyen.Checked;
                qlpq.suaPQ(cbbmamh.Text, txbMaquyen.Text, isChecked);
                dataGridView1.DataSource = qlpq.LoadPQ(maq);
            }
            else
                MessageBox.Show("Chọn và nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmPhanQuyen_Load(object sender, EventArgs e)
        {
            List<PQ> lstPQ = qlpq.LoadPQ(maq);
            txbMaquyen.Text = maq;
            txbTenquyen.Text = tenq;
            dataGridView1.DataSource = lstPQ;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            cbbmamh.Text = "Chọn mã màn hình";
            cbbmamh.ForeColor = Color.Gray;
            txbtenmh.Text = "";
        }

        private void cbbmamh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbmamh.Text == "Chọn mã màn hình" && cbbmamh.SelectedIndex == 0)
            {
                cbbmamh.ForeColor = Color.Gray;
            }
            else
            {
                cbbmamh.ForeColor = Color.Black;
                string chonGiaTri = cbbmamh.SelectedItem.ToString();
                string tenmh = qlpq.LayTenMHByMaMH(chonGiaTri);
                txbtenmh.Text = tenmh;
            }
        }

        private void cbbmamh_DropDown(object sender, EventArgs e)
        {
            if (cbbmamh.Text == "Chọn mã màn hình")
            {
                cbbmamh.Text = "";
            }
        }

        private void cbbmamh_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbmamh.Text))
            {
                cbbmamh.Text = "Chọn mã màn hình";
                cbbmamh.ForeColor = Color.Gray;
            }
            else
            {
                cbbmamh.ForeColor = Color.Black;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string mamh = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string tenmh = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string maq = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string tenq = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbbmamh.Text = mamh;
                txbtenmh.Text = tenmh;
                txbMaquyen.Text = maq;
                txbTenquyen.Text = tenq;

            }
        }
    }
}