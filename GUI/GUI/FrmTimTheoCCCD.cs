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
    public partial class FrmTimTheoCCCD : DevExpress.XtraEditors.XtraForm
    {
        BDNhanVien nv = new BDNhanVien();
        BDChuyenXe cx = new BDChuyenXe();
        private FrmChuyenXe frmcx;
        public FrmTimTheoCCCD(FrmChuyenXe frm)
        {
            InitializeComponent();
            this.frmcx = frm;
            txbnhapcccd.Leave += Txbnhapcccd_Leave;
            txbnhapcccd.Enter += Txbnhapcccd_Enter;

        }

        private void Txbnhapcccd_Enter(object sender, EventArgs e)
        {
            if (txbnhapcccd.Text == "Nhập căn cước công dân")
            {
                txbnhapcccd.Text = "";
                txbnhapcccd.ForeColor = Color.Black;
            }
        }

        private void Txbnhapcccd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbnhapcccd.Text))
            {
                txbnhapcccd.Text = "Nhập căn cước công dân";
                txbnhapcccd.ForeColor = Color.Gray;
            }
            else if (txbnhapcccd.Text.Length != 12)
            {
                MessageBox.Show("Vui lòng nhập đúng 12 số");
                txbnhapcccd.Clear();
            }
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            bool exists = nv.KiemTraCCCD(txbnhapcccd.Text);
            if (!exists)
            {
                MessageBox.Show("Số căn cước công dân không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmcx.CapNhatMacvTXB(cx.LayMaNV(txbnhapcccd.Text));
                this.Close();
            }
        }

        private void FrmTimTheoCCCD_Load(object sender, EventArgs e)
        {
            txbnhapcccd.Text = "Nhập căn cước công dân";
            txbnhapcccd.ForeColor = Color.Gray;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}