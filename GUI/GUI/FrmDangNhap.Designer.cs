namespace GUI
{
    partial class FrmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.lbtaotk = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.lbtendangnhap = new System.Windows.Forms.Label();
            this.lbdangnhap = new System.Windows.Forms.Label();
            this.btndangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.txbtenDN = new ThietKeControl.KiemTraTenDangNhap();
            this.SuspendLayout();
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMatKhau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.Location = new System.Drawing.Point(252, 191);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(285, 32);
            this.txbMatKhau.TabIndex = 25;
            this.txbMatKhau.Text = "@Admin123";
            this.txbMatKhau.UseSystemPasswordChar = true;
            // 
            // lbtaotk
            // 
            this.lbtaotk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtaotk.AutoSize = true;
            this.lbtaotk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtaotk.Location = new System.Drawing.Point(522, 335);
            this.lbtaotk.Name = "lbtaotk";
            this.lbtaotk.Size = new System.Drawing.Size(144, 25);
            this.lbtaotk.TabIndex = 22;
            this.lbtaotk.Text = "Tạo tài khoản";
            this.lbtaotk.Click += new System.EventHandler(this.lbtaotk_Click);
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatkhau.Location = new System.Drawing.Point(103, 192);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(125, 31);
            this.lbmatkhau.TabIndex = 23;
            this.lbmatkhau.Text = "Mật khẩu";
            // 
            // lbtendangnhap
            // 
            this.lbtendangnhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtendangnhap.AutoSize = true;
            this.lbtendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtendangnhap.Location = new System.Drawing.Point(37, 102);
            this.lbtendangnhap.Name = "lbtendangnhap";
            this.lbtendangnhap.Size = new System.Drawing.Size(195, 31);
            this.lbtendangnhap.TabIndex = 24;
            this.lbtendangnhap.Text = "Tên đăng nhập";
            // 
            // lbdangnhap
            // 
            this.lbdangnhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbdangnhap.AutoSize = true;
            this.lbdangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdangnhap.Location = new System.Drawing.Point(225, 9);
            this.lbdangnhap.Name = "lbdangnhap";
            this.lbdangnhap.Size = new System.Drawing.Size(214, 46);
            this.lbdangnhap.TabIndex = 20;
            this.lbdangnhap.Text = "Đăng nhập";
            // 
            // btndangnhap
            // 
            this.btndangnhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndangnhap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Appearance.Options.UseFont = true;
            this.btndangnhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndangnhap.ImageOptions.Image")));
            this.btndangnhap.Location = new System.Drawing.Point(252, 262);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(154, 59);
            this.btndangnhap.TabIndex = 26;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // txbtenDN
            // 
            this.txbtenDN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbtenDN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtenDN.Location = new System.Drawing.Point(252, 105);
            this.txbtenDN.Name = "txbtenDN";
            this.txbtenDN.Size = new System.Drawing.Size(285, 32);
            this.txbtenDN.TabIndex = 27;
            this.txbtenDN.Text = "admin123";
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 387);
            this.Controls.Add(this.txbtenDN);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.lbtaotk);
            this.Controls.Add(this.lbmatkhau);
            this.Controls.Add(this.lbtendangnhap);
            this.Controls.Add(this.lbdangnhap);
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label lbtaotk;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.Label lbtendangnhap;
        private System.Windows.Forms.Label lbdangnhap;
        private DevExpress.XtraEditors.SimpleButton btndangnhap;
        private ThietKeControl.KiemTraTenDangNhap txbtenDN;
    }
}