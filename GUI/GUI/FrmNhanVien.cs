using BLL_DAL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        BDNhanVien qlnv = new BDNhanVien();
        private string tendn;
        public FrmNhanVien(string tendn)
        {
            InitializeComponent();
            this.tendn = tendn;
            cbbchucvu.SelectedIndexChanged += Cbbchucvu_SelectedIndexChanged;
            cbbchucvu.DropDown += Cbbchucvu_DropDown;
            cbbchucvu.DropDownClosed += Cbbchucvu_DropDownClosed;
            txbtimkiemnv.Enter += Txbtimkiemnv_Enter;
            txbtennv.Leave += Txbtennv_Leave;
            txbemail.Leave += Txbemail_Leave;
            txbcccd.Leave += Txbcccd_Leave;
            chbtimkiem.CheckedChanged += Chbtimkiem_CheckedChanged;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }


        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string manv = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string tennv = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string email = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string cccd = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txbmanv.Text = manv;
                txbtennv.Text = tennv;
                txbemail.Text = email;
                txbcccd.Text = cccd;
                btnxoa.Show();
                btnsua.Show();
            }
        }

        private void Chbtimkiem_CheckedChanged(object sender, EventArgs e)
        {
            txbtimkiemnv.Visible = chbtimkiem.Checked;
            btntimkiemnv.Visible = chbtimkiem.Checked;

            lbmanv.Visible = !chbtimkiem.Checked;
            lbtennv.Visible = !chbtimkiem.Checked;
            lbemail.Visible = !chbtimkiem.Checked;
            lbcccd.Visible = !chbtimkiem.Checked;
            lbchucvu.Visible = !chbtimkiem.Checked;
            txbmanv.Visible = !chbtimkiem.Checked;
            txbtennv.Visible = !chbtimkiem.Checked;
            txbemail.Visible = !chbtimkiem.Checked;
            txbcccd.Visible = !chbtimkiem.Checked;
            cbbchucvu.Visible = !chbtimkiem.Checked;
            btnthem.Visible = !chbtimkiem.Checked;
        }

        private void Txbcccd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbcccd.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbtennv.Focus();
            }
            else if (txbcccd.Text.Length != 12)
            {
                MessageBox.Show("Vui lòng nhập đúng 12 số");
                txbcccd.Focus();
            }
        }

        private void Txbemail_Leave(object sender, EventArgs e)
        {
            string dinhDangMail = @"^[a-zA-Z0-9!@#\$%\^&*\(\)_\-\+=\[\]\{\};:'"",<>./?\\|]+@gmail\.com$";
            if (string.IsNullOrEmpty(txbemail.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbemail.Focus();
            }
            else if (Regex.IsMatch(txbemail.Text, dinhDangMail))
            {
            }
            else
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng thử lại");
                txbemail.Clear();
                txbemail.Focus();
            }
        }

        private void Txbtennv_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbtennv.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbtennv.Focus();
            }
            else if (txbtennv.Text.Length < 5 || txbtennv.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập từ 5 đến 50 ký tự");
                txbtennv.Focus();
            }
            else if (txbtennv.Text.Contains("  "))
            {
                MessageBox.Show("Vui lòng chỉ nhập một khoảng trắng giữa các ký tự");
                txbtennv.Focus();
            }
        }

        private void Txbtimkiemnv_Enter(object sender, EventArgs e)
        {
            if (txbtimkiemnv.Text == "Nhập mã hoặc họ tên hoặc cccd")
            {
                txbtimkiemnv.Text = "";
                txbtimkiemnv.ForeColor = Color.Black;
            }
        }

        private void Cbbchucvu_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbchucvu.Text))
            {
                cbbchucvu.Text = "Chọn chức vụ";
                cbbchucvu.ForeColor = Color.Gray;
            }
        }

        private void Cbbchucvu_DropDown(object sender, EventArgs e)
        {
            if (cbbchucvu.Text == "Chọn chức vụ")
            {
                cbbchucvu.Text = "";
            }
        }

        private void Cbbchucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbchucvu.Text == "Chọn chức vụ" && cbbchucvu.SelectedIndex == 0)
            {
                cbbchucvu.ForeColor = Color.Gray;
            }
            else
            {
                cbbchucvu.ForeColor = Color.Black;
                string chonGiaTri = cbbchucvu.SelectedItem.ToString();
                string giaTriDinhDang = LayGiaTri(chonGiaTri);
                txbmanv.Text = giaTriDinhDang;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!qlnv.KiemTraTrungMaNV(txbmanv.Text))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!qlnv.KiemTraTrungEmail(txbemail.Text))
            {
                MessageBox.Show("Email đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!qlnv.KiemTraTrungCCCD(txbcccd.Text))
            {
                MessageBox.Show("Số căn cước công dân đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbchucvu.SelectedItem != null && !string.IsNullOrWhiteSpace(txbmanv.Text) && !string.IsNullOrWhiteSpace(txbemail.Text) && !string.IsNullOrWhiteSpace(txbcccd.Text))
            {
                qlnv.ThemNV(txbmanv.Text, txbtennv.Text, txbemail.Text, txbcccd.Text, cbbchucvu.Text);
                dataGridView1.DataSource = qlnv.LoadNhanVien();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Chọn và nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            qlnv.XoaNV(txbmanv.Text);
            dataGridView1.DataSource = qlnv.LoadNhanVien();
            MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (cbbchucvu.SelectedItem != null && !string.IsNullOrWhiteSpace(txbmanv.Text) && !string.IsNullOrWhiteSpace(txbemail.Text) && !string.IsNullOrWhiteSpace(txbcccd.Text))
            {
                qlnv.SuaNV(txbmanv.Text, txbtennv.Text, txbemail.Text, txbcccd.Text);
                dataGridView1.DataSource = qlnv.LoadNhanVien();
                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Chọn và nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = qlnv.LoadNhanVien();
            dataGridView1.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[1].HeaderText = "Tên nhân viên";
            dataGridView1.Columns[2].HeaderText = "Email";
            dataGridView1.Columns[3].HeaderText = "Số điện thoại";
            dataGridView1.Columns[4].HeaderText = "Chức vụ";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            txbtimkiemnv.Text = "Nhập mã hoặc họ tên hoặc cccd";
            txbtimkiemnv.ForeColor = Color.Gray;
            cbbchucvu.Items.Add("Nhân Viên");
            cbbchucvu.Items.Add("Quản Lý");
            cbbchucvu.Text = "Chọn chức vụ";
            cbbchucvu.ForeColor = Color.Gray;
            txbtimkiemnv.Hide();
            btntimkiemnv.Hide();
            btnxoa.Hide();
            btnsua.Hide();
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

        private void btntimkiemnv_Click(object sender, EventArgs e)
        {
            var timKiem = qlnv.TimKiemNV(txbtimkiemnv.Text);
            if (timKiem.Count > 0)
            {
                dataGridView1.DataSource = timKiem;
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
        }

        private void btnlammoi_Click_1(object sender, EventArgs e)
        {
            if (chbtimkiem.Checked == false)
            {
                txbmanv.Clear();
                txbtennv.Clear();
                txbemail.Clear();
                txbcccd.Clear();
                cbbchucvu.Show();
                cbbchucvu.Focus();
                cbbchucvu.Text = "Chọn chức vụ";
                cbbchucvu.ForeColor = Color.Gray;
                btnxoa.Hide();
                btnsua.Hide();
                dataGridView1.DataSource = qlnv.LoadNhanVien();
            }
            else
            {
                txbtimkiemnv.Text = "Nhập mã hoặc họ tên hoặc cccd";
                txbtimkiemnv.ForeColor = Color.Gray;
                dataGridView1.DataSource = qlnv.LoadNhanVien();
            }
        }
    }
}