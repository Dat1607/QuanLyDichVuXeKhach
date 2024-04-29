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
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        BDDangNhap qldn = new BDDangNhap();
        public FrmDangNhap()
        {
            InitializeComponent();
            txbtenDN.Leave += TxbtenDN_Leave;
            txbMatKhau.Leave += TxbMatKhau_Leave;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }


        private void TxbMatKhau_Leave(object sender, EventArgs e)
        {
            string dinhDangMK = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^a-zA-Z\\d]).+$";
            if (string.IsNullOrEmpty(txbMatKhau.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbMatKhau.Focus();
            }
            else if (txbMatKhau.Text.Length < 5 || txbMatKhau.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập từ 5 đến 50 ký tự");
                txbMatKhau.Focus();
            }
            else if (Regex.IsMatch(txbMatKhau.Text, dinhDangMK))
            {
            }
            else
            {
                MessageBox.Show("Mật khẩu không hợp lệ. Vui lòng thử lại");
                txbMatKhau.Clear();
                txbMatKhau.Focus();
            }
        }

        private void TxbtenDN_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbtenDN.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbtenDN.Focus();
            }
            else if (txbtenDN.Text.Length < 5 || txbtenDN.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập từ 5 đến 50 ký tự");
                txbtenDN.Focus();
            }
            else if (txbtenDN.Text.Contains(" "))
            {
                MessageBox.Show("Vui lòng không nhập khoảng trắng giữa các ký tự");
                txbtenDN.Focus();
            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            bool ktDangNhap = qldn.KiemTraDangNhap(txbtenDN.Text, txbMatKhau.Text);
            if (ktDangNhap)
            {
                FrmTrangChu frm = new FrmTrangChu(txbtenDN.Text);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbtaotk_Click(object sender, EventArgs e)
        {
            FrmDangKy dk = new FrmDangKy();
            dk.Show();
            this.Hide();
        }
    }
}