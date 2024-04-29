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
    public partial class FrmThemXeChoChuyen : DevExpress.XtraEditors.XtraForm
    {
        BDChuyenVaXe qlcvx = new BDChuyenVaXe();
        BDXe qlx = new BDXe();
        BDChuyenXe qlcx = new BDChuyenXe();
        private string tendn;
        public FrmThemXeChoChuyen()
        {
            InitializeComponent();
            LoadCX();
            LoadX();
            LoadDataDiem();
        }
        public FrmThemXeChoChuyen(string tendn)
        {
            InitializeComponent();
            this.tendn = tendn;
            LoadCX();
            LoadX();
            LoadDataDiem();
            
        }

        private void FrmThemXeChoChuyen_Load(object sender, EventArgs e)
        {
            cbbmacx.Text = "Chọn mã chuyến xe";
            cbbmacx.ForeColor = Color.Gray;
            txbtt.Text = "Còn ghế";
            txbdiemdi.Clear();
            txbdiemden.Clear();
            cbbmax.Text = "Chọn mã xe";
            cbbmax.ForeColor = Color.Gray;
            txbbiensx.Clear();
            txbghetrong.Clear();
            dtpgiokh.Format = DateTimePickerFormat.Custom;
            dtpgiokh.ShowUpDown = true;
            dtpgiokh.CustomFormat = "HH:mm:ss";
            dtpgiokt.Format = DateTimePickerFormat.Custom;
            dtpgiokt.ShowUpDown = true;
            dtpgiokt.CustomFormat = "HH:mm:ss";
            dataGridView1.DataSource = qlcvx.LoadCVX();
            dataGridView1.Columns[0].HeaderText = "Mã chuyến xe";
            dataGridView1.Columns[1].HeaderText = "Điểm đi";
            dataGridView1.Columns[2].HeaderText = "Điểm đến";
            dataGridView1.Columns[3].HeaderText = "Mã xe";
            dataGridView1.Columns[4].HeaderText = "Biến số xe";
            dataGridView1.Columns[5].HeaderText = "Số ghế cìn lại";
            dataGridView1.Columns[6].HeaderText = "Tình trạng ghế";
            dataGridView1.Columns[7].HeaderText = "Giờ khởi hành";
            dataGridView1.Columns[8].HeaderText = "Giờ kết thúc";
            cbbdiemdau.Text = "Chọn điểm đậu";
            cbbdiemdau.ForeColor = Color.Gray;
        }
        private void LoadCX()
        {
            try
            {
                var cxs = qlcvx.LoadCX();

                cbbmacx.Items.Clear(); // Xóa dữ liệu cũ trước khi thêm mới

                foreach (var cx in cxs)
                {
                    cbbmacx.Items.Add(cx.MaCX);
                }

                if (cbbmacx.Items.Count > 0)
                {
                    cbbmacx.SelectedIndex = 0; // Chọn phần tử đầu tiên nếu có ít nhất một phần tử
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu chuyến xe: {ex.Message}");
            }

        }

        private void cbbmacx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbmacx.Text == "Chọn mã chuyến xe")
            {
                cbbmacx.ForeColor = Color.Gray;
            }
            else
            {
                cbbmacx.ForeColor = Color.Black;
                string chonGiaTri = cbbmacx.SelectedItem.ToString();
                string diemdi = qlcvx.LayDiemDiByMaCX(chonGiaTri);
                string diemden = qlcvx.LayDiemDenByMaCX(chonGiaTri);
                txbdiemdi.Text = diemdi;
                txbdiemden.Text = diemden;
            }
        }

        private void cbbmacx_DropDown(object sender, EventArgs e)
        {
            if (cbbmacx.Text == "Chọn mã chuyến xe")
            {
                cbbmacx.Text = "";
            }
        }

        private void cbbmacx_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbmacx.Text))
            {
                cbbmacx.Text = "Chọn mã chuyến xe";
                cbbmacx.ForeColor = Color.Gray;
            }
        }
        private void LoadX()
        {
            try
            {
                var xs = qlcvx.LoadX();

                cbbmax.Items.Clear(); // Xóa dữ liệu cũ trước khi thêm mới

                foreach (var x in xs)
                {
                    cbbmax.Items.Add(x.MaXe);
                }

                if (cbbmax.Items.Count > 0)
                {
                    cbbmax.SelectedIndex = 0; // Chọn phần tử đầu tiên nếu có ít nhất một phần tử
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu xe: {ex.Message}");
            }

        }

        private void cbbmax_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbmax.Text == "Chọn mã xe")
            {
                cbbmax.ForeColor = Color.Gray;
            }
            else
            {
                cbbmax.ForeColor = Color.Black;
                string chonGiaTri = cbbmax.SelectedItem.ToString();
                string biensx = qlcvx.LayBienSXByMaX(chonGiaTri);
                string soghe = qlcvx.LaySoGheByMaX(chonGiaTri);
                txbbiensx.Text = biensx;
                txbghetrong.Text = soghe;
            }
        }

        private void cbbmax_DropDown(object sender, EventArgs e)
        {
            if (cbbmax.Text == "Chọn mã xe")
            {
                cbbmax.Text = "";
            }
        }

        private void cbbmax_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbmax.Text))
            {
                cbbmax.Text = "Chọn mã xe";
                cbbmax.ForeColor = Color.Gray;
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            cbbmacx.Text = "Chọn mã chuyến xe";
            cbbmacx.ForeColor = Color.Gray;
            cbbmax.Text = "Chọn mã xe";
            cbbmax.ForeColor = Color.Gray;
            cbbdiemdau.Text = "Chọn điểm đậu";
            cbbdiemdau.ForeColor = Color.Gray;
            txbdiemdi.Clear();
            txbdiemden.Clear();
            txbbiensx.Clear();
            txbghetrong.Clear();
            btnsua.Hide();
            btnxoa.Hide();
            btnthem.Show();
            dataGridView1.DataSource = qlcvx.LoadCVX();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string macx = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string diemdi = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string diemden = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string max = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string biensx = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string soghe = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                string tinhtrangx = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                string giokh = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                string giokt = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                cbbmacx.Text = macx;
                txbdiemdi.Text = diemdi;
                txbdiemden.Text = diemden;
                cbbmax.Text = max;
                txbbiensx.Text = biensx;
                txbghetrong.Text = soghe;
                txbtt.Text = tinhtrangx;
                if (TimeSpan.TryParse(giokh, out TimeSpan gioKh))
                {
                    DateTime gioKhDateTime = DateTime.Today + gioKh;
                    dtpgiokh.Value = gioKhDateTime;
                }

                if (TimeSpan.TryParse(giokt, out TimeSpan gioKt))
                {
                    DateTime gioKtDateTime = DateTime.Today + gioKt;
                    dtpgiokt.Value = gioKtDateTime;
                }

                btnxoa.Show();
                btnsua.Show();
                btnthem.Hide();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ttxe = "Đã có chuyến";
            if (!qlcvx.KiemTraTrungChuyenVaXe(cbbmacx.Text, cbbmax.Text))
            {
                MessageBox.Show("Xe đã được thêm vào chuyến", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var giokh = dtpgiokh.Value.ToString("HH:mm:ss");
            var giokt = dtpgiokt.Value.ToString("HH:mm:ss");
            if (cbbmax.SelectedItem != null && cbbmacx.SelectedItem != null)
            {
                qlcvx.ThemCVX(cbbmacx.Text, cbbmax.Text, Convert.ToInt16(txbghetrong.Text), txbtt.Text, TimeSpan.Parse(dtpgiokh.Text), TimeSpan.Parse(dtpgiokt.Text));
                dataGridView1.DataSource = qlcvx.LoadCVX();
                qlx.CapNhatX(cbbmax.Text, ttxe);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn và nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string ttxe = "Không có chuyến";
            qlcvx.XoaCVX(cbbmacx.Text, cbbmax.Text);
            dataGridView1.DataSource = qlcvx.LoadCVX();
            qlx.CapNhatX(cbbmax.Text, ttxe);
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ttxe = "Đã có chuyến";
            if (cbbmax.SelectedItem != null && cbbmacx.SelectedItem != null)
            {
                qlcvx.SuaCVX(cbbmacx.Text, cbbmax.Text, TimeSpan.Parse(dtpgiokh.Text), TimeSpan.Parse(dtpgiokt.Text));
                dataGridView1.DataSource = qlcvx.LoadCVX();
                qlx.CapNhatX(cbbmax.Text, ttxe);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn và nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntracuu_Click(object sender, EventArgs e)
        {
            var timKiem = qlcvx.TraCuuVe(cbbdiemdau.Text);
            if (timKiem.Count > 0)
            {
                dataGridView2.DataSource = timKiem;
                dataGridView2.Columns[0].HeaderText = "Mã xe";
                dataGridView2.Columns[1].HeaderText = "Biển số xe";
                dataGridView2.Columns[2].HeaderText = "Tình trạng xe";
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadDataDiem()
        {
            var tps = qlcx.LoadTP();

            foreach (var tp in tps)
            {
                cbbdiemdau.Items.Add(tp.TP);
            }

            cbbdiemdau.SelectedIndex = 0;
            
        }

        private void cbbdiemdau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbdiemdau.Text == "Chọn điểm đậu")
            {
                cbbdiemdau.ForeColor = Color.Gray;
            }
            else
            {
                cbbdiemdau.ForeColor = Color.Black;
            }
        }

        private void cbbdiemdau_DropDown(object sender, EventArgs e)
        {
            if (cbbdiemdau.Text == "Chọn điểm đậu")
            {
                cbbdiemdau.Text = "";
            }
        }

        private void cbbdiemdau_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbdiemdau.Text))
            {
                cbbdiemdau.Text = "Chọn điểm đậu";
                cbbdiemdau.ForeColor = Color.Gray;
            }
        }
    }
}