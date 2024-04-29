using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL_DAL;
using DevExpress.XtraTabbedMdi;
using static DevExpress.Skins.SolidColorHelper;

namespace GUI
{
    public partial class FrmTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BDPhanQuyen qlpq = new BDPhanQuyen();
        private string tendn;
        private int currentImageIndex = 0;
        public FrmTrangChu()
        {
            InitializeComponent();
        }
        public void CloseAllTab()
        {
            for (int i = xtraTabbedMdiManager1.Pages.Count - 1; i >= 0; i--)
            {
                xtraTabbedMdiManager1.Pages[i].MdiChild.Close();
            }
        }
        public FrmTrangChu(string tendn)
        {
            InitializeComponent();
            this.tendn = tendn;
            TenTK.TenDN = tendn;
            LoadImage();
            InitializeTimer();
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseAllTab();
            imageSlider1.Hide();
            int width = 0;
            int height = 0;
            FrmNhanVien nv = new FrmNhanVien(tendn);

            width = nv.Size.Width;
            height = nv.Size.Height;
            nv.MdiParent = this;
            nv.Show();
            this.ClientSize = new Size(width, height + 195);
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            FrmDangNhap frm = new FrmDangNhap();
            frm.Show();

        }

        private void FrmTrangChu_Load(object sender, EventArgs e)
        {
            // Kích thước màn hình đầy đủ
            this.WindowState = FormWindowState.Maximized;
            // Ẩn thanh công cụ và đường biên của cửa sổ
            this.FormBorderStyle = FormBorderStyle.None;
            string maQ = qlpq.LayMaQ(tendn);

            //trangChủToolStripMenuItem.Visible = qlpq.CheckPermission(maQ, "MH001");
            tabNhanVien.Visible = qlpq.CheckPermission(maQ, "MH002");
            tabPhanQuyen.Visible = qlpq.CheckPermission(maQ, "MH003");
            tabQLChuyenXe.Visible = qlpq.CheckPermission(maQ, "MH004");
            tabQLXe.Visible = qlpq.CheckPermission(maQ, "MH005");
            tabQLVe.Visible = qlpq.CheckPermission(maQ, "MH006");
            tabDatVe.Visible = qlpq.CheckPermission(maQ, "MH007");
            tabTraCuuVe.Visible = qlpq.CheckPermission(maQ, "MH008");

            lbltentk.Caption = tendn;
        }

        private void btnQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imageSlider1.Hide();
            CloseAllTab();
            int width = 0;
            int height = 0;
            FrmQuyen q = new FrmQuyen(tendn);

            width = q.Size.Width;
            height = q.Size.Height;
            q.MdiParent = this;
            q.Show();
            this.ClientSize = new Size(width, height + 195);
        }

        private void btnNhomQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imageSlider1.Hide();
            CloseAllTab();
            int width = 0;
            int height = 0;
            FrmNhomQuyen nq = new FrmNhomQuyen(tendn);

            width = nq.Size.Width;
            height = nq.Size.Height;
            nq.MdiParent = this;
            nq.Show();
            this.ClientSize = new Size(width, height + 195);
        }

        private void btnDangXuatPQ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            FrmDangNhap frm = new FrmDangNhap();
            frm.Show();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnQLChuyenXe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imageSlider1.Hide();
            CloseAllTab();
            int width = 0;
            int height = 0;
            FrmChuyenXe cx = new FrmChuyenXe(tendn);

            width = cx.Size.Width;
            height = cx.Size.Height;
            cx.MdiParent = this;
            cx.Show();
            this.ClientSize = new Size(width, height + 195);
        }

        private void btnDangXuatCX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            FrmDangNhap frm = new FrmDangNhap();
            frm.Show();
        }

        private void btnXe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imageSlider1.Hide();
            CloseAllTab();
            int width = 0;
            int height = 0;
            FrmXe cx = new FrmXe(tendn);

            width = cx.Size.Width;
            height = cx.Size.Height;
            cx.MdiParent = this;
            cx.Show();
            this.ClientSize = new Size(width, height + 195);
        }

        private void btnDangXuatXe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            FrmDangNhap frm = new FrmDangNhap();
            frm.Show();
        }

        private void btnVe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imageSlider1.Hide();
            CloseAllTab();
            int width = 0;
            int height = 0;
            FrmVe cx = new FrmVe(tendn);

            width = cx.Size.Width;
            height = cx.Size.Height;
            cx.MdiParent = this;
            cx.Show();
            this.ClientSize = new Size(width, height + 195);
        }

        private void btnDangXuatVe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            FrmDangNhap frm = new FrmDangNhap();
            frm.Show();
        }

        private void btnDatVe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imageSlider1.Hide();
            CloseAllTab();
            int width = 0;
            int height = 0;
            FrmDatVe cx = new FrmDatVe(tendn);

            width = cx.Size.Width;
            height = cx.Size.Height;
            cx.MdiParent = this;
            cx.Show();
            this.ClientSize = new Size(width, height + 195);
        }

        private void btnDangXuatDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            FrmDangNhap frm = new FrmDangNhap();
            frm.Show();
        }

        private void btnTraCuuVe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imageSlider1.Hide();
            CloseAllTab();
            int width = 0;
            int height = 0;
            FrmTraCuuVe cx = new FrmTraCuuVe(tendn);

            width = cx.Size.Width;
            height = cx.Size.Height;
            cx.MdiParent = this;
            cx.Show();
            this.ClientSize = new Size(width, height + 195);
        }

        private void btnChonXeChoChuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imageSlider1.Hide();
            CloseAllTab();
            int width = 0;
            int height = 0;
            FrmThemXeChoChuyen frm = new FrmThemXeChoChuyen(tendn);

            width = frm.Size.Width;
            height = frm.Size.Height;
            frm.MdiParent = this;
            frm.Show();
            this.ClientSize = new Size(width, height + 195);
        }

        private void btnManHinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imageSlider1.Hide();
            CloseAllTab();
            int width = 0;
            int height = 0;
            FrmManHinh frm = new FrmManHinh(tendn);

            width = frm.Size.Width;
            height = frm.Size.Height;
            frm.MdiParent = this;
            frm.Show();
            this.ClientSize = new Size(width, height + 195);
        }
        public void LoadImage()
        {
            string[] imagePaths = new string[]
        {
            "D:\\image\\16Cho.jpg",
            //"D:\\image\\33Cho.png",
            //"D:\\image\\49Cho.jpg",
        };

            foreach (var imagePath in imagePaths)
            {
                if (File.Exists(imagePath))
                {
                    imageSlider1.Images.Add(Image.FromFile(imagePath));
                }
                else
                {
                    // Xử lý trường hợp file không tồn tại
                    MessageBox.Show($"File not found: {imagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Hiển thị hình ảnh đầu tiên
            imageSlider1.CurrentImageIndex = currentImageIndex;
        }
        private void InitializeTimer()
        {
            timer1.Interval = 2800; 

            // Bắt đầu Timer
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % imageSlider1.Images.Count;
            imageSlider1.CurrentImageIndex = currentImageIndex;
        }
    }
}
