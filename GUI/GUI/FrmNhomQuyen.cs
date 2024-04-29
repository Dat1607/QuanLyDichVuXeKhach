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
    public partial class FrmNhomQuyen : DevExpress.XtraEditors.XtraForm
    {
        BDPhanQuyen qlpq = new BDPhanQuyen();
        private string tendn;
        public FrmNhomQuyen(string tendn)
        {
            InitializeComponent();
            LoadData();
            this.tendn = tendn;
            cbbquyen.SelectedIndexChanged += Cbbquyen_SelectedIndexChanged;
            cbbquyen.DropDown += Cbbquyen_DropDown;
            cbbquyen.DropDownClosed += Cbbquyen_DropDownClosed;
            dataGridView2.CellClick += DataGridView2_CellClick;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string manq = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string tendn = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string maquyen = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txbmanq.Text = manq;
                txbtenDN.Text = tendn;
                cbbquyen.Text = maquyen;
            }
            btntaomnq.Hide();
            btnthem.Hide();
            btnxoa.Show();
            btnsua.Show();
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string tendn = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                txbtenDN.Text = tendn;
            }
        }

        private void Cbbquyen_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbquyen.Text))
            {
                cbbquyen.Text = "Chọn quyền";
                cbbquyen.ForeColor = Color.Gray;
            }
            else
            {
                cbbquyen.ForeColor = Color.Black;
            }
        }

        private void Cbbquyen_DropDown(object sender, EventArgs e)
        {
            if (cbbquyen.Text == "Chọn quyền")
            {
                cbbquyen.Text = "";
            }
        }

        private void Cbbquyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbquyen.Text == "Chọn quyền" && cbbquyen.SelectedIndex == 0)
            {
                cbbquyen.ForeColor = Color.Gray;
            }
            else
            {
                cbbquyen.ForeColor = Color.Black;
            }
        }

        private void LoadData()
        {
            var qs = qlpq.LoadQ();

            foreach (var q in qs)
            {
                cbbquyen.Items.Add(q.MaQuyen);
            }

            cbbquyen.SelectedIndex = 0;
        }
        private void FrmNhomQuyen_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = qlpq.LoadTK();
            dataGridView1.DataSource = qlpq.LoadNQ();
            dataGridView1.Columns[0].HeaderText = "Mã nhóm quyền";
            dataGridView1.Columns[1].HeaderText = "Tên đăng nhập";
            dataGridView1.Columns[2].HeaderText = "Mã quyền";
            dataGridView2.Columns[0].HeaderText = "Tên đăng nhập";
            dataGridView2.Columns[1].HeaderText = "Mật khẩu";
            cbbquyen.Text = "Chọn quyền";
            cbbquyen.ForeColor = Color.Gray;
            btnxoa.Hide();
            btnsua.Hide();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!qlpq.KiemTraXetQuyen(txbtenDN.Text))
            {
                MessageBox.Show("Đã được xét quyền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbtenDN.Focus();
                return;
            }
            if (cbbquyen.SelectedItem != null && !string.IsNullOrWhiteSpace(txbmanq.Text) && !string.IsNullOrWhiteSpace(txbtenDN.Text))
            {
                qlpq.themNQ(txbmanq.Text, txbtenDN.Text, cbbquyen.Text);
                dataGridView1.DataSource = qlpq.LoadNQ();
                txbmanq.Clear();
                txbtenDN.Clear();
                cbbquyen.Text = "Chọn quyền";
                cbbquyen.ForeColor = Color.Gray;
            }
            else
                MessageBox.Show("Chọn và nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            qlpq.xoaNQ(txbmanq.Text);
            dataGridView1.DataSource = qlpq.LoadNQ();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (cbbquyen.SelectedItem != null && !string.IsNullOrWhiteSpace(txbmanq.Text) && !string.IsNullOrWhiteSpace(txbtenDN.Text))
            {
                qlpq.suaNQ(txbmanq.Text, txbtenDN.Text, cbbquyen.Text);
                dataGridView1.DataSource = qlpq.LoadNQ();
            }
            else
                MessageBox.Show("Chọn và nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txbtenDN.Clear();
            cbbquyen.Text = "Chọn quyền";
            cbbquyen.ForeColor = Color.Gray;
            btnxoa.Hide();
            btnsua.Hide();
            btnthem.Show();
            btntaomnq.Show();
        }
        private string TaoRandomMaNQ()
        {
            Random random = new Random();
            int randomValue;
            string maNQuyen;

            do
            {
                randomValue = random.Next(0, 1000);
                maNQuyen = "NQ" + randomValue.ToString("000");
            } while (KiemTraTrungMaNQ(maNQuyen));

            return maNQuyen;
        }

        private bool KiemTraTrungMaNQ(string maNQuyen)
        {
            return false;
        }

        private void btntaomnq_Click(object sender, EventArgs e)
        {
            txbmanq.Text = TaoRandomMaNQ();
        }
    }
}