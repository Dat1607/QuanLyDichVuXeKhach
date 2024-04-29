using BLL_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmChonGhe16 : Form
    {
        BDDatVe qlcg = new BDDatVe();
        BDDatGhe qlgn = new BDDatGhe();
        BDVe qlv = new BDVe();
        BDKhachHang qlkh = new BDKhachHang();
        BDXe qlx = new BDXe();
        BDChuyenVaXe qlcvx = new BDChuyenVaXe();
        private bool isFirstButtonClicked = false;
        private int clickedButtonCount = 0;
        private Button firstButton = null;
        private decimal currentTicketPrice;
        //private int totalSeats;
        List<Button> selectedButtons = new List<Button>();
        private string maX;
        private string maCX;
        public class SeatStatus
        {
            public string SeatNumber { get; set; }
            public bool IsSelected { get; set; }
        }
        private Dictionary<string, SeatStatus> seatStatusDict = new Dictionary<string, SeatStatus>();
        public FrmChonGhe16(string maCX, string maX)
        {
            InitializeComponent();
            btng1.Click += Button_Click;
            btng2.Click += Button_Click;
            btng3.Click += Button_Click;
            btng4.Click += Button_Click;
            btng5.Click += Button_Click;
            btng6.Click += Button_Click;
            btng7.Click += Button_Click;
            btng8.Click += Button_Click;
            btng9.Click += Button_Click;
            btng10.Click += Button_Click;
            btng11.Click += Button_Click;
            btng12.Click += Button_Click;
            btng13.Click += Button_Click;
            btng14.Click += Button_Click;
            btng15.Click += Button_Click;
            seatStatusDict["G1"] = new SeatStatus { SeatNumber = "G1", IsSelected = false };
            seatStatusDict["G2"] = new SeatStatus { SeatNumber = "G2", IsSelected = false };
            seatStatusDict["G3"] = new SeatStatus { SeatNumber = "G3", IsSelected = false };
            seatStatusDict["G4"] = new SeatStatus { SeatNumber = "G4", IsSelected = false };
            seatStatusDict["G5"] = new SeatStatus { SeatNumber = "G5", IsSelected = false };
            this.maX = maX;
            this.maCX = maCX;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int totalSeats = UpdateEmptySeatCount1();
            Button button = (Button)sender;
            if (button.BackColor == Color.Red)
            {
                MessageBox.Show("Ghế đã được chọn");
            }
            else
            {
                if (button == firstButton)
                {
                    button.BackColor = SystemColors.Control;
                    string buttonText = button.Text;
                    string textToRemove = buttonText + ", ";
                    string textToRemoveWithoutComma = buttonText;

                    // Kiểm tra xem TextBox có chứa dấu phẩy hay không
                    if (txbsoghe.Text.Contains(", "))
                    {
                        // Nếu có dấu phẩy, xóa tên button và dấu phẩy
                        txbsoghe.Text = txbsoghe.Text.Replace(textToRemove, "");
                    }
                    else if (txbsoghe.Text.Contains(textToRemoveWithoutComma))
                    {
                        // Nếu không có dấu phẩy, xóa chỉ tên button
                        txbsoghe.Text = txbsoghe.Text.Replace(textToRemoveWithoutComma, "");
                    }
                    clickedButtonCount--;
                    totalSeats++;

                    if (totalSeats > 15)
                    {
                        totalSeats = 15;
                    }
                    CalculateTotalPrice();
                    isFirstButtonClicked = false;
                    firstButton = null;
                }
                else if (button.BackColor == SystemColors.Control)
                {
                    if (clickedButtonCount < 5)
                    {
                        button.BackColor = Color.Beige;
                        txbsoghe.Text += (txbsoghe.Text == "" ? "" : ", ") + button.Text;
                        clickedButtonCount++;
                        totalSeats--;
                        if (totalSeats < 0)
                        {
                            totalSeats = 0;
                        }
                        CalculateTotalPrice();
                        if (firstButton == null)
                        {
                            firstButton = button;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã chọn tối đa 5 ghế.");
                    }
                }
                else
                {
                    button.BackColor = SystemColors.Control;
                    string buttonText = button.Text;
                    string textPhaySau = buttonText + ", ";
                    string textPhayTruoc = ", " + buttonText;
                    string textToRemoveWithoutComma = buttonText;

                    // Kiểm tra xem TextBox có chứa dấu phẩy hay không
                    if (txbsoghe.Text.Contains(", "))
                    {
                        // Nếu có dấu phẩy, xóa tên button và dấu phẩy
                        txbsoghe.Text = txbsoghe.Text.Replace(textPhaySau, "");
                        txbsoghe.Text = txbsoghe.Text.Replace(textPhayTruoc, "");
                    }
                    else if (txbsoghe.Text.Contains(textToRemoveWithoutComma))
                    {
                        // Nếu không có dấu phẩy, xóa chỉ tên button
                        txbsoghe.Text = txbsoghe.Text.Replace(textToRemoveWithoutComma, "");
                    }
                    clickedButtonCount--;
                    totalSeats++;

                    if (totalSeats > 15)
                    {
                        totalSeats = 15;
                    }
                    CalculateTotalPrice();
                }
                txbghetrong.Text = totalSeats.ToString();
                isFirstButtonClicked = true;
            }
        }

        private void FrmChonGhe16_Load(object sender, EventArgs e)
        {
            RestoreSelectedSeats();
        }
        private void CalculateTotalPrice()
        {
            decimal totalPrice = clickedButtonCount * currentTicketPrice;
            txbtongtien.Text = totalPrice.ToString("N0");
        }

        public void ShowInfoOnForm16(string maChuyenXe, string maXe)
        {
            FrmChonChuyen frm = new FrmChonChuyen();
            frm.Hide();
            TT tt = qlcg.LayTTTheoMaChuyenXe(maChuyenXe);
            TTX ttx = qlcg.LayTTTheoXe(maXe);
            TTCVX ttcvx = qlcg.LayTTTheoChVXe(maChuyenXe, maXe);
            if (tt != null && ttx != null)
            {
                txbdiemdi.Text = tt.DiemDi;
                txbdiemden.Text = tt.DiemDen;
                txbngaydi.Text = tt.NgayDi.Value.ToString();
                txbngayden.Text = tt.NgayDen.Value.ToString(); ;
                txbbxdi.Text = tt.BenXeDi;
                txbbxden.Text = tt.BenXeDen;
                txbgiave.Text = tt.GiaVe.Value.ToString("#,##0");
                txbbsx.Text = ttx.BienSX;
                txbgiokh.Text = ttcvx.GioKH.ToString();
                txbgiokt.Text = ttcvx.GioKT.ToString();
                txbtongtien.Text = "0";
                if (decimal.TryParse(txbgiave.Text, out currentTicketPrice))
                {
                }
                else
                {
                    MessageBox.Show("Không thể lấy giá vé từ TextBox.");
                }

                UpdateEmptySeatCount();
            }
            RestoreSelectedSeats();
        }
        public string GenerateTicketCode(string maG, string ngaydat, string maX)
        {
            string MaV = "VX" + maG + ngaydat + maX;
            return MaV;
        }

        private void btnghechon_Click(object sender, EventArgs e)
        {
            
        }
        public Button FindButtonByMaGhe(string maGhe)
        {
            foreach (Control control in grbxe16.Controls)
            {
                if (control is Button button && button.Text == maGhe)
                {
                    return button;
                }
            }
            return null;
        }
        public void SaveSelectedSeats()
        {
            // Lấy mã xe từ ứng dụng của bạn, giả sử là this.maX
            string maXe = this.maX;

            // Lấy danh sách ghế đã chọn và lưu vào tệp tin
            string[] cacGheDaChon = GetSelectedSeats();
            File.WriteAllLines($"SelectedSeats_{maXe}.txt", cacGheDaChon);
            if (int.TryParse(txbghetrong.Text, out int soGheTrong))
            {
                //soGheTrong -= cacGheDaChon.Length;
                File.WriteAllText($"EmptySeats_{maXe}.txt", soGheTrong.ToString());
                //txbghetrong.Text = soGheTrong.ToString();
            }
        }


        // Hàm khôi phục trạng thái ghế đã chọn từ tệp tin
        private void RestoreSelectedSeats()
        {
            // Lấy mã xe từ ứng dụng của bạn, giả sử là this.maX
            string maXe = this.maX;

            // Kiểm tra xem tệp tin có tồn tại không
            if (File.Exists($"SelectedSeats_{maXe}.txt"))
            {
                // Đọc danh sách ghế đã chọn từ tệp tin
                string[] cacGheDaChon = File.ReadAllLines($"SelectedSeats_{maXe}.txt");

                // Đặt màu sắc của các ghế đã chọn thành màu đỏ
                foreach (var maGhe in cacGheDaChon)
                {
                    var button = FindButtonByMaGhe(maGhe);
                    if (button != null)
                    {
                        button.BackColor = Color.Red;
                    }
                }
            }
            if (File.Exists($"EmptySeats_{maXe}.txt"))
            {
                // Đọc số ghế trống từ tệp tin
                string gheTrongText = File.ReadAllText($"EmptySeats_{maXe}.txt");

                // Chuyển đổi số ghế trống sang kiểu số nguyên
                if (int.TryParse(gheTrongText, out int soGheTrong))
                {
                    // Hiển thị số ghế trống trong TextBox
                    txbghetrong.Text = soGheTrong.ToString();
                }
            }

        }

        // Hàm lấy danh sách ghế đã chọn
        private string[] GetSelectedSeats()
        {
            // Duyệt qua tất cả các ghế và lấy mã của những ghế có màu đỏ
            var selectedSeats = grbxe16.Controls.OfType<Button>()
                                      .Where(button => button.BackColor == Color.Red)
                                      .Select(button => button.Text)
                                      .ToArray();

            return selectedSeats;
        }
        private int GetDefaultSeatCount()
        {
            // Duyệt qua tất cả các ghế và đếm số ghế có màu mặc định
            int defaultSeatCount = grbxe16.Controls.OfType<Button>()
                                          .Count(button => button.BackColor == SystemColors.Control);

            return defaultSeatCount;
        }
        private void UpdateEmptySeatCount()
        {
            int defaultSeatCount = GetDefaultSeatCount();

            // Hiển thị số ghế trống trong TextBox
            txbghetrong.Text = defaultSeatCount.ToString();
        }
        private int UpdateEmptySeatCount1()
        {
            // Lấy giá trị từ TextBox và trả về
            if (int.TryParse(txbghetrong.Text, out int parsedTotalSeats))
            {
                // Hiển thị số ghế trống trong TextBox
                txbghetrong.Text = parsedTotalSeats.ToString();
                return parsedTotalSeats;
            }
            else
            {
                return 0;
            }
        }

        private void txbghetrong_TextChanged(object sender, EventArgs e)
        {
            if (txbghetrong.Text == "0")
            {
                txbtrangthai.Text = "Hết ghế";
            }
            else
            {
                txbtrangthai.Text = "Còn ghế";
            }
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

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnghechon_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbsoghe.Text) && !string.IsNullOrEmpty(txbtenkh.Text) && !string.IsNullOrEmpty(txbsdt.Text))
            {
                FrmThanhToan frm = new FrmThanhToan(this, this.maCX, this.maX);
                frm.Show();
                frm.txbghedat.Text = txbsoghe.Text;
                frm.txbtongtien.Text = txbtongtien.Text;
            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin và đặt ghế");
            }
        }

    }
}
