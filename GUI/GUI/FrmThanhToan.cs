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
    public partial class FrmThanhToan : DevExpress.XtraEditors.XtraForm
    {
        BDDatGhe qlgn = new BDDatGhe();
        BDVe qlv = new BDVe();
        BDKhachHang qlkh = new BDKhachHang();
        BDXe qlx = new BDXe();
        BDChuyenVaXe qlcvx = new BDChuyenVaXe();
        private string maX;
        private string maCX;
        private Form currentForm;
        public FrmThanhToan()
        {
            InitializeComponent();
        }
        public FrmThanhToan(Form currentForm, string maCX, string maX)
        {
            InitializeComponent();
            this.maX = maX;
            this.maCX = maCX;
            this.currentForm = currentForm;
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

        private void txbthanhtoan_Leave(object sender, EventArgs e)
        {
            string giaTienText = txbthanhtoan.Text;
            if (KiemTraGiaTien(giaTienText) && IsInRange(giaTienText, 100000, 50000000))
            {
                txbthanhtoan.Text = DinhDangGiaTien(giaTienText);
            }
            else
            {
                MessageBox.Show("Giá tiền không hợp lệ. Vui lòng nhập lại theo đúng định dạng và trong khoảng từ 100,000 đến 5,000,000", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbthanhtoan.Text = "";
                txbthanhtoan.Focus();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (currentForm is FrmChonGhe16 frm16)
            {
                if (txbthanhtoan.Text == txbtongtien.Text)
                {
                    DateTime ngayDatHang = DateTime.Now;
                    string ngayDat = ngayDatHang.ToString("ddMMyyyy");
                    string ttthanhtoan = "Đã thanh toán";
                    string makh = "KH" + this.maX;
                    //if (!string.IsNullOrEmpty(frm16.txbsoghe.Text) && !string.IsNullOrEmpty(frm16.txbtenkh.Text) && !string.IsNullOrEmpty(frm16.txbsdt.Text))
                    //{
                    DialogResult result = MessageBox.Show("Đặt vé sẽ không thể hủy", "Xác nhận đặt vé", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        string[] cacGheDaChon = frm16.txbsoghe.Text.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                                               .Select(ghe => ghe.Trim())
                                               .ToArray();
                        foreach (var maGhe in cacGheDaChon)
                        {
                            // Tìm Button tương ứng với mã ghế và đổi màu
                            var button = frm16.FindButtonByMaGhe(maGhe);
                            if (button != null)
                            {
                                button.BackColor = Color.Red;
                            }
                            string maVe = frm16.GenerateTicketCode(maGhe, ngayDat, this.maX);
                            if (!qlv.TicketCodeExists(maVe))
                            {
                                // Add the ticket to the database using the generated ticket code
                                qlv.ThemVX(maVe, maGhe, ngayDatHang, this.maX);

                                // Add customer information with the generated ticket code to the customer database
                                qlkh.ThemKH(makh, frm16.txbtenkh.Text, frm16.txbsdt.Text, maVe, ngayDatHang, ttthanhtoan);
                            }
                            else
                            {
                            }
                        }
                        qlgn.ThemGhe(cacGheDaChon, this.maX);
                        qlcvx.CapNhatCVX(this.maCX, this.maX, Convert.ToInt16(frm16.txbghetrong.Text), frm16.txbtrangthai.Text);
                        frm16.SaveSelectedSeats();
                        this.Close();
                        frm16.Close();
                        FrmChonChuyen frmcc = new FrmChonChuyen();
                        frmcc.Close();
                        MessageBox.Show("Đặt vé thành công");
                    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Nhập đúng giá tiền cần thanh toán");
                    //}    
                }
                else
                {
                    MessageBox.Show("Nhập đúng giá tiền cần thanh toán");
                }
            }
            else if (currentForm is FrmChonGhe33 frm33)
            {
                if (txbthanhtoan.Text == txbtongtien.Text)
                {
                    DateTime ngayDatHang = DateTime.Now;
                    string ngayDat = ngayDatHang.ToString("ddMMyyyy");
                    string ttthanhtoan = "Đã thanh toán";
                    string makh = "KH" + this.maX;
                    //if (!string.IsNullOrEmpty(frm33.txbsoghe.Text) && !string.IsNullOrEmpty(frm33.txbtenkh.Text) && !string.IsNullOrEmpty(frm33.txbsdt.Text))
                    //{
                    DialogResult result = MessageBox.Show("Đặt vé sẽ không thể hủy", "Xác nhận đặt vé", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        string[] cacGheDaChon = frm33.txbsoghe.Text.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                                               .Select(ghe => ghe.Trim())
                                               .ToArray();
                        foreach (var maGhe in cacGheDaChon)
                        {
                            // Tìm Button tương ứng với mã ghế và đổi màu
                            var button = frm33.FindButtonByMaGhe(maGhe);
                            if (button != null)
                            {
                                button.BackColor = Color.Red;
                            }
                            string maVe = frm33.GenerateTicketCode(maGhe, ngayDat, this.maX);
                            if (!qlv.TicketCodeExists(maVe))
                            {
                                // Add the ticket to the database using the generated ticket code
                                qlv.ThemVX(maVe, maGhe, ngayDatHang, this.maX);

                                // Add customer information with the generated ticket code to the customer database
                                qlkh.ThemKH(makh, frm33.txbtenkh.Text, frm33.txbsdt.Text, maVe, ngayDatHang, ttthanhtoan);
                            }
                            else
                            {
                            }
                        }
                        qlgn.ThemGhe(cacGheDaChon, this.maX);
                        qlcvx.CapNhatCVX(this.maCX, this.maX, Convert.ToInt16(frm33.txbghetrong.Text), frm33.txbtrangthai.Text);
                        frm33.SaveSelectedSeats();
                        this.Close();
                        frm33.Close();
                        FrmChonChuyen frmcc = new FrmChonChuyen();
                        frmcc.Close();
                        MessageBox.Show("Đặt vé thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Nhập đúng giá tiền cần thanh toán");
                }
            }
            else if (currentForm is FrmChonGhe49 frm49)
            {
                if (txbthanhtoan.Text == txbtongtien.Text)
                {
                    DateTime ngayDatHang = DateTime.Now;
                    string ngayDat = ngayDatHang.ToString("ddMMyyyy");
                    string ttthanhtoan = "Đã thanh toán";
                    string makh = "KH" + this.maX;
                    //if (!string.IsNullOrEmpty(frm49.txbsoghe.Text) && !string.IsNullOrEmpty(frm49.txbtenkh.Text) && !string.IsNullOrEmpty(frm49.txbsdt.Text))
                    //{
                    DialogResult result = MessageBox.Show("Xác nhận thanh toán", "Xác nhận đặt vé", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        string[] cacGheDaChon = frm49.txbsoghe.Text.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                                               .Select(ghe => ghe.Trim())
                                               .ToArray();
                        foreach (var maGhe in cacGheDaChon)
                        {
                            // Tìm Button tương ứng với mã ghế và đổi màu
                            var button = frm49.FindButtonByMaGhe(maGhe);
                            if (button != null)
                            {
                                button.BackColor = Color.Red;
                            }
                            string maVe = frm49.GenerateTicketCode(maGhe, ngayDat, this.maX);
                            if (!qlv.TicketCodeExists(maVe))
                            {
                                // Add the ticket to the database using the generated ticket code
                                qlv.ThemVX(maVe, maGhe, ngayDatHang, this.maX);

                                // Add customer information with the generated ticket code to the customer database
                                qlkh.ThemKH(makh, frm49.txbtenkh.Text, frm49.txbsdt.Text, maVe, ngayDatHang, ttthanhtoan);
                            }
                            else
                            {
                            }
                        }
                        qlgn.ThemGhe(cacGheDaChon, this.maX);
                        qlcvx.CapNhatCVX(this.maCX, this.maX, Convert.ToInt16(frm49.txbghetrong.Text), frm49.txbtrangthai.Text);
                        frm49.SaveSelectedSeats();
                        this.Close();
                        frm49.Close();
                        FrmChonChuyen frmcc = new FrmChonChuyen();
                        frmcc.Close();
                        MessageBox.Show("Đặt vé thành công");
                    }

                }
                else
                {
                    MessageBox.Show("Nhập đúng giá tiền cần thanh toán");
                }
            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}