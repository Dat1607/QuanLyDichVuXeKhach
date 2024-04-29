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
    public partial class FrmChuyenXe : DevExpress.XtraEditors.XtraForm
    {
        BDChuyenXe qlcx = new BDChuyenXe();
        BDNhanVien nv = new BDNhanVien();
        private string tendn;
        public FrmChuyenXe(string tendn)
        {
            InitializeComponent();
            LoadData();
            this.tendn = tendn;
            cbbDiemdi.SelectedIndexChanged += CbbDiemdi_SelectedIndexChanged;
            cbbDiemden.SelectedIndexChanged += CbbDiemden_SelectedIndexChanged;
            cbbDiemdi.DropDown += CbbDiemdi_DropDown;
            cbbDiemdi.DropDownClosed += CbbDiemdi_DropDownClosed;
            cbbDiemden.DropDown += CbbDiemden_DropDown;
            cbbDiemden.DropDownClosed += CbbDiemden_DropDownClosed;
            dtpngaydi.Leave += Dtpngaydi_Leave;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string diemdi = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string diemden = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string ngaydi = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string ngayden = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string giave = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                string manv = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbbDiemdi.Text = diemdi;
                cbbDiemden.Text = diemden;
                if (DateTime.TryParse(ngaydi, out DateTime ngayDiDateTime))
                {
                    dtpngaydi.Value = ngayDiDateTime;
                }

                if (DateTime.TryParse(ngayden, out DateTime ngayDenDateTime))
                {
                    dtpngayden.Value = ngayDenDateTime;
                }
                if (decimal.TryParse(giave, out decimal giaTien))
                {
                    string giaTienFormatted = giaTien.ToString("#,##0");
                    txbgiave.Text = giaTienFormatted;
                }
                txbmanv.Text = manv;
                btnxoa.Show();
                btnsua.Show();
                btnthem.Hide();
            }
        }

        private void Dtpngaydi_Leave(object sender, EventArgs e)
        {
            //DateTime now = DateTime.Now;

            //DateTime selectedDate = dtpngaydi.Value;

            //if (selectedDate <= now)
            //{
            //    MessageBox.Show("Vui lòng chọn một ngày và giờ lớn hơn hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    dtpngaydi.Value = now;
            //    dtpngaydi.Focus();
            //}
        }

        private void CbbDiemden_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbDiemden.Text))
            {
                cbbDiemden.Text = "Chọn điểm đến";
                cbbDiemden.ForeColor = Color.Gray;
            }
        }

        private void CbbDiemden_DropDown(object sender, EventArgs e)
        {
            if (cbbDiemden.Text == "Chọn điểm đến")
            {
                cbbDiemden.Text = "";
            }
        }

        private void CbbDiemdi_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbDiemdi.Text))
            {
                cbbDiemdi.Text = "Chọn điểm đi";
                cbbDiemdi.ForeColor = Color.Gray;
            }
        }

        private void CbbDiemdi_DropDown(object sender, EventArgs e)
        {
            if (cbbDiemdi.Text == "Chọn điểm đi")
            {
                cbbDiemdi.Text = "";
            }
        }

        private void CbbDiemden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDiemden.Text == "Chọn điểm đến")
            {
                cbbDiemden.ForeColor = Color.Gray;
            }
            else
            {
                cbbDiemden.ForeColor = Color.Black;
            }
        }

        private void CbbDiemdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDiemdi.Text == "Chọn điểm đi")
            {
                cbbDiemdi.ForeColor = Color.Gray;
            }
            else
            {
                cbbDiemdi.ForeColor = Color.Black;
            }
        }

        private void LoadData()
        {
            var tps = qlcx.LoadTP();

            foreach (var tp in tps)
            {
                cbbDiemdi.Items.Add(tp.TP);
                cbbDiemden.Items.Add(tp.TP);
            }

            cbbDiemdi.SelectedIndex = 0;
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            cbbDiemdi.Text = "Chọn điểm đi";
            cbbDiemdi.ForeColor = Color.Gray;
            cbbDiemden.Text = "Chọn điểm đến";
            cbbDiemden.ForeColor = Color.Gray;
            txbgiave.Clear();
            btnxoa.Hide();
            btnsua.Hide();
            btnthem.Show();
            dataGridView1.DataSource = qlcx.LoadCX();
            int columnIndex = dataGridView1.Columns[5].Index;
            dataGridView1.Columns[columnIndex].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!qlcx.KiemTraTrungChuyen(cbbDiemdi.Text, cbbDiemden.Text, Convert.ToDateTime(dtpngaydi.Text)))
            {
                MessageBox.Show("Chuyến đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime now = DateTime.Now;
            DateTime ngaydi = dtpngaydi.Value;
            DateTime ngayden = dtpngayden.Value;
            string dinhDangNgayDi = ngaydi.ToString("ddMMyyyy");
            string macx = "CX" + diemDi() + dinhDangNgayDi + diemDen();
            if (cbbDiemdi.SelectedItem != null && cbbDiemden.SelectedItem != null && !string.IsNullOrWhiteSpace(txbgiave.Text) && !string.IsNullOrWhiteSpace(txbmanv.Text))
            {
                if (!cbbDiemdi.SelectedItem.Equals(cbbDiemden.SelectedItem))
                {
                    if (ngaydi > now && ngayden >= ngaydi)
                    {
                        qlcx.ThemCX(macx, cbbDiemdi.Text, cbbDiemden.Text, Convert.ToDateTime(dtpngaydi.Text), Convert.ToDateTime(dtpngayden.Text), Convert.ToDecimal(txbgiave.Text), txbmanv.Text);
                        dataGridView1.DataSource = qlcx.LoadCX();
                        int columnIndex = dataGridView1.Columns[5].Index;
                        dataGridView1.Columns[columnIndex].DefaultCellStyle.Format = "N0";
                        dataGridView1.Columns[7].Visible = false;
                        dataGridView1.Columns[8].Visible = false;
                        dataGridView1.Columns[9].Visible = false;
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn ngày đi lớn hơn ngày hiện tại hoặc ngày đến lớn hơn bằng ngày đi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Điểm đi và điểm đến phải khác nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn và nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DateTime ngaydi = dtpngaydi.Value;
            string dinhDangNgayDi = ngaydi.ToString("ddMMyyyy");
            string macx = "CX" + diemDi() + dinhDangNgayDi + diemDen();
            qlcx.XoaCX(macx);
            dataGridView1.DataSource = qlcx.LoadCX();
            int columnIndex = dataGridView1.Columns[5].Index;
            dataGridView1.Columns[columnIndex].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime ngaydi = dtpngaydi.Value;
            DateTime ngayden = dtpngayden.Value;
            string dinhDangNgayDi = ngaydi.ToString("ddMMyyyy");
            string macx = "CX" + diemDi() + dinhDangNgayDi + diemDen();
            if (cbbDiemdi.SelectedItem != null && cbbDiemden.SelectedItem != null && !string.IsNullOrWhiteSpace(txbgiave.Text) && !string.IsNullOrWhiteSpace(txbmanv.Text))
            {
                if (!cbbDiemdi.SelectedItem.Equals(cbbDiemden.SelectedItem))
                {
                    if (ngaydi > now && ngayden >= ngaydi)
                    {
                        qlcx.SuaCX(macx, cbbDiemdi.Text, cbbDiemden.Text, Convert.ToDateTime
                            
                            (dtpngaydi.Text), Convert.ToDateTime(dtpngayden.Text), Convert.ToDecimal(txbgiave.Text));
                        dataGridView1.DataSource = qlcx.LoadCX();
                        int columnIndex = dataGridView1.Columns[5].Index;
                        dataGridView1.Columns[columnIndex].DefaultCellStyle.Format = "N0";
                        dataGridView1.Columns[7].Visible = false;
                        dataGridView1.Columns[8].Visible = false;
                        dataGridView1.Columns[9].Visible = false;
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn ngày đi lớn hơn ngày hiện tại hoặc ngày đến lớn hơn bằng ngày đi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Điểm đi và điểm đến phải khác nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn và nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntimkiemnv_Click(object sender, EventArgs e)
        {
            FrmTimTheoCCCD frmTim = new FrmTimTheoCCCD(this);
            frmTim.ShowDialog();
        }
        public void CapNhatMacvTXB(string manv)
        {
            txbmanv.Text = manv;
        }

        private void FrmChuyenXe_Load(object sender, EventArgs e)
        {
            cbbDiemdi.Text = "Chọn điểm đi";
            cbbDiemdi.ForeColor = Color.Gray;
            cbbDiemden.Text = "Chọn điểm đến";
            cbbDiemden.ForeColor = Color.Gray;
            
            btnxoa.Hide();
            btnsua.Hide();
            dataGridView1.DataSource = qlcx.LoadCX();
            dataGridView1.Columns[0].HeaderText = "Mã chuyến xe";
            dataGridView1.Columns[1].HeaderText = "Điểm đi";
            dataGridView1.Columns[2].HeaderText = "Điểm đến";
            dataGridView1.Columns[3].HeaderText = "Ngày đi";
            dataGridView1.Columns[4].HeaderText = "Ngày đến dự kiến";
            dataGridView1.Columns[5].HeaderText = "Giá vé";
            dataGridView1.Columns[6].HeaderText = "Mã nhân viên";
            int columnIndex = dataGridView1.Columns[5].Index;
            dataGridView1.Columns[columnIndex].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }
        private string TaoRandomMaCX()
        {
            Random random = new Random();
            int randomValue;
            string maChuyenXe;

            do
            {
                randomValue = random.Next(0, 1000);
                maChuyenXe = "CX" + randomValue.ToString("000");
            } while (KiemTraTrungMaCX(maChuyenXe));

            return maChuyenXe;
        }

        private bool KiemTraTrungMaCX(string macx)
        {
            return false;
        }
        private bool KiemTraGiaTien(string giaTienText)
        {
            string giaTien = @"^\d{1,3}(,\d{3})*$";
            return System.Text.RegularExpressions.Regex.IsMatch(giaTienText, giaTien);
        }

        private bool IsInRange(string giaTienText, int minValue, int maxValue)
        {
            if (int.TryParse(giaTienText.Replace(",", ""), out int giaTien))
            {
                return giaTien >= minValue && giaTien <= maxValue;
            }
            return false;
        }
        private string DinhDangGiaTien(string giaTienText)
        {
            if (int.TryParse(giaTienText.Replace(",", ""), out int giaTien))
            {
                return giaTien.ToString("N0");
            }
            return giaTienText;
        }

        private void txbgiave_Leave(object sender, EventArgs e)
        {
            string giaTienText = txbgiave.Text;
            if (KiemTraGiaTien(giaTienText) && IsInRange(giaTienText, 100000, 50000000))
            {
                txbgiave.Text = DinhDangGiaTien(giaTienText);
            }
            else
            {
                MessageBox.Show("Giá tiền không hợp lệ. Vui lòng nhập lại theo đúng định dạng và trong khoảng từ 100,000 đến 5,000,000", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbgiave.Text = "";
                txbgiave.Focus();
            }
        }
        private string diemDi()
        {
            string chonDiemdi = cbbDiemdi.SelectedItem.ToString();
            if (chonDiemdi == "TP Hồ Chí Minh")
            {
                string diemdi = "TPHCM";
                return diemdi;
            }
            else
            {
                string[] cau = chonDiemdi.Split(' ');
                string diemdi = "";
                foreach (string tu in cau)
                {
                    if (tu.Length >= 2)
                    {
                        diemdi += tu.Substring(0, 1);
                    }
                }
                return diemdi;
            }
        }
        private string diemDen()
        {
            string chonDiemden = cbbDiemden.SelectedItem.ToString();
            if (chonDiemden == "TP Hồ Chí Minh")
            {
                string diemden = "TPHCM";
                return diemden;
            }
            else
            {
                string[] cau = chonDiemden.Split(' ');
                string diemden = "";
                foreach (string tu in cau)
                {
                    if (tu.Length >= 2)
                    {
                        diemden += tu.Substring(0, 1);
                    }
                }
                return diemden;
            }
        }

        private void txbmanv_TextChanged(object sender, EventArgs e)
        {
            string maNV = txbmanv.Text;
            string tenNV = nv.LayTenNVByMaNV(maNV);
            txbtennv.Text = tenNV;
            
        }
    }
}