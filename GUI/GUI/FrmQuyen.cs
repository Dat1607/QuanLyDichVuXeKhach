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
    public partial class FrmQuyen : DevExpress.XtraEditors.XtraForm
    {
        BDPhanQuyen qlpq = new BDPhanQuyen();
        private string tendn;
        public FrmQuyen(string tendn)
        {
            InitializeComponent();
            this.tendn = tendn;
            cbbquyen.SelectedIndexChanged += Cbbquyen_SelectedIndexChanged;
            cbbquyen.DropDown += Cbbquyen_DropDown;
            cbbquyen.DropDownClosed += Cbbquyen_DropDownClosed;
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maquyen = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string tenquyen = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                FrmPhanQuyen frm = new FrmPhanQuyen(maquyen, tenquyen);
                frm.ShowDialog();
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maq = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txbmaq.Text = maq;
                cbbquyen.Hide();
                btnxoa.Show();
                btnthem.Hide();
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
                string chonGiaTri = cbbquyen.SelectedItem.ToString();
                string giaTriDinhDang = LayGiaTri(chonGiaTri);
                txbmaq.Text = giaTriDinhDang;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!qlpq.KiemTraQuyen(cbbquyen.Text))
            {
                MessageBox.Show("Quyền đã có trong danh sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbquyen.Focus();
                return;
            }
            if (cbbquyen.SelectedItem != null)
            {
                qlpq.themQ(txbmaq.Text, cbbquyen.Text);
                dataGridView1.DataSource = qlpq.LoadQ();
                txbmaq.Clear();
                cbbquyen.Text = "Chọn quyền";
                cbbquyen.ForeColor = Color.Gray;
            }
            else
                MessageBox.Show("Chọn và nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            btnxoa.Hide();
            btnthem.Show();
            cbbquyen.Show();
            txbmaq.Clear();
            cbbquyen.Text = "Chọn quyền";
            cbbquyen.ForeColor = Color.Gray;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            qlpq.xoaQ(txbmaq.Text);
            dataGridView1.DataSource = qlpq.LoadQ();
        }

        private void FrmQuyen_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = qlpq.LoadQ();
            dataGridView1.Columns[0].HeaderText = "Mã quyền";
            dataGridView1.Columns[1].HeaderText = "Tên quyền";
            cbbquyen.Items.Add("Quản Lý");
            cbbquyen.Items.Add("Nhân Viên Bán Vé");
            cbbquyen.Items.Add("Khách Hàng");
            cbbquyen.Text = "Chọn quyền";
            cbbquyen.ForeColor = Color.Gray;
            btnxoa.Hide();
        }
        private string LayGiaTri(string chonGiaTri)
        {
            string[] cau = chonGiaTri.Split(' ');
            string ketqua = "";

            foreach (string tu in cau)
            {
                if (tu.Length >= 2)
                {
                    ketqua += tu.Substring(0, 1);
                }
            }

            ketqua += NgauNhienKhongTrung();
            return ketqua;
        }
        private string NgauNhienKhongTrung()
        {
            Random random = new Random();
            int randomSo;

            do
            {
                randomSo = random.Next(1000, 10000);
            } while (SoDuocSD(randomSo));

            return randomSo.ToString();
        }

        private List<int> lstSo = new List<int>();

        private bool SoDuocSD(int so)
        {
            return lstSo.Contains(so);
        }
    }
}