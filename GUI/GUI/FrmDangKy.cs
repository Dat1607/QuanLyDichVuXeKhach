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
    public partial class FrmDangKy : DevExpress.XtraEditors.XtraForm
    {
        BDDangKy qldk = new BDDangKy();
        public FrmDangKy()
        {
            InitializeComponent();
            txbtenDK.Leave += TxbtenDK_Leave;
            txbmkDK.Leave += TxbmkDK_Leave;
            txbxnmk.Leave += Txbxnmk_Leave;
        }

        private void TxbmkDK_Leave(object sender, EventArgs e)
        {
            string dinhDangMK = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^a-zA-Z\\d]).+$";
            if (string.IsNullOrEmpty(txbmkDK.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbmkDK.Focus();
            }
            else if (txbmkDK.Text.Length < 5 || txbmkDK.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập từ 5 đến 50 ký tự");
                txbmkDK.Focus();
            }
            else if (Regex.IsMatch(txbmkDK.Text, dinhDangMK))
            {
            }
            else
            {
                MessageBox.Show("Mật khẩu không hợp lệ. Vui lòng thử lại");
                txbmkDK.Clear();
                txbmkDK.Focus();
            }
        }

        private void Txbxnmk_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbxnmk.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbxnmk.Focus();
            }
        }

        private void TxbtenDK_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbtenDK.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbtenDK.Focus();
            }
            else if (txbtenDK.Text.Length < 5 || txbtenDK.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập từ 5 đến 50 ký tự");
                txbtenDK.Focus();
            }
            else if (txbtenDK.Text.Contains(" "))
            {
                MessageBox.Show("Vui lòng không nhập khoảng trắng giữa các ký tự");
                txbtenDK.Focus();
            }
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            if (!qldk.KiemTraTrungTenDK(txbtenDK.Text))
            {
                MessageBox.Show("Tên đăng ký đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbtenDK.Focus();
                return;
            }
            if (txbmkDK.Text != txbxnmk.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác", "Vui lòng thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbxnmk.Focus();
            }
            else
            {
                qldk.DangKy(txbtenDK.Text, txbmkDK.Text);
                MessageBox.Show("Tài khoản đã được tạo thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbtenDK.Clear();
                txbmkDK.Clear();
                txbxnmk.Clear();
            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.Show();
            this.Close();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txbtenDK.Clear();
            txbmkDK.Clear();
            txbxnmk.Clear();
        }
    }
}