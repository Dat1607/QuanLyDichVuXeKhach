namespace GUI
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.label1 = new System.Windows.Forms.Label();
            this.lbmanv = new System.Windows.Forms.Label();
            this.lbcccd = new System.Windows.Forms.Label();
            this.lbtennv = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbchucvu = new System.Windows.Forms.Label();
            this.txbtimkiemnv = new System.Windows.Forms.TextBox();
            this.txbmanv = new System.Windows.Forms.TextBox();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbbchucvu = new System.Windows.Forms.ComboBox();
            this.chbtimkiem = new System.Windows.Forms.CheckBox();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btntimkiemnv = new DevExpress.XtraEditors.SimpleButton();
            this.btnlammoi = new DevExpress.XtraEditors.SimpleButton();
            this.txbtennv = new ThietKeControl.KiemTraHoTen();
            this.txbcccd = new ThietKeControl.KiemTraNhapSo();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 42);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nhân viên";
            // 
            // lbmanv
            // 
            this.lbmanv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbmanv.AutoSize = true;
            this.lbmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmanv.Location = new System.Drawing.Point(18, 125);
            this.lbmanv.Name = "lbmanv";
            this.lbmanv.Size = new System.Drawing.Size(154, 29);
            this.lbmanv.TabIndex = 25;
            this.lbmanv.Text = "Mã nhân viên";
            // 
            // lbcccd
            // 
            this.lbcccd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbcccd.AutoSize = true;
            this.lbcccd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcccd.Location = new System.Drawing.Point(579, 188);
            this.lbcccd.Name = "lbcccd";
            this.lbcccd.Size = new System.Drawing.Size(218, 29);
            this.lbcccd.TabIndex = 24;
            this.lbcccd.Text = "Căn cước công dân";
            // 
            // lbtennv
            // 
            this.lbtennv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbtennv.AutoSize = true;
            this.lbtennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtennv.Location = new System.Drawing.Point(9, 188);
            this.lbtennv.Name = "lbtennv";
            this.lbtennv.Size = new System.Drawing.Size(164, 29);
            this.lbtennv.TabIndex = 23;
            this.lbtennv.Text = "Tên nhân viên";
            // 
            // lbemail
            // 
            this.lbemail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(727, 125);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(74, 29);
            this.lbemail.TabIndex = 22;
            this.lbemail.Text = "Email";
            // 
            // lbchucvu
            // 
            this.lbchucvu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbchucvu.AutoSize = true;
            this.lbchucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbchucvu.Location = new System.Drawing.Point(67, 248);
            this.lbchucvu.Name = "lbchucvu";
            this.lbchucvu.Size = new System.Drawing.Size(98, 29);
            this.lbchucvu.TabIndex = 21;
            this.lbchucvu.Text = "Chức vụ";
            // 
            // txbtimkiemnv
            // 
            this.txbtimkiemnv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbtimkiemnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtimkiemnv.Location = new System.Drawing.Point(264, 57);
            this.txbtimkiemnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbtimkiemnv.Name = "txbtimkiemnv";
            this.txbtimkiemnv.Size = new System.Drawing.Size(450, 38);
            this.txbtimkiemnv.TabIndex = 17;
            // 
            // txbmanv
            // 
            this.txbmanv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbmanv.Location = new System.Drawing.Point(186, 116);
            this.txbmanv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbmanv.Name = "txbmanv";
            this.txbmanv.ReadOnly = true;
            this.txbmanv.Size = new System.Drawing.Size(326, 38);
            this.txbmanv.TabIndex = 27;
            // 
            // txbemail
            // 
            this.txbemail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbemail.Location = new System.Drawing.Point(809, 120);
            this.txbemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(326, 38);
            this.txbemail.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 294);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(899, 309);
            this.dataGridView1.TabIndex = 29;
            // 
            // cbbchucvu
            // 
            this.cbbchucvu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbchucvu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbchucvu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbchucvu.DropDownHeight = 150;
            this.cbbchucvu.DropDownWidth = 400;
            this.cbbchucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbchucvu.FormattingEnabled = true;
            this.cbbchucvu.IntegralHeight = false;
            this.cbbchucvu.Location = new System.Drawing.Point(186, 245);
            this.cbbchucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbchucvu.Name = "cbbchucvu";
            this.cbbchucvu.Size = new System.Drawing.Size(222, 37);
            this.cbbchucvu.TabIndex = 16;
            // 
            // chbtimkiem
            // 
            this.chbtimkiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbtimkiem.AutoSize = true;
            this.chbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbtimkiem.Location = new System.Drawing.Point(18, 58);
            this.chbtimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbtimkiem.Name = "chbtimkiem";
            this.chbtimkiem.Size = new System.Drawing.Size(232, 33);
            this.chbtimkiem.TabIndex = 33;
            this.chbtimkiem.Text = "Tìm kiếm thông tin";
            this.chbtimkiem.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Appearance.Options.UseFont = true;
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(984, 294);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(123, 59);
            this.btnthem.TabIndex = 34;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnxoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Appearance.Options.UseFont = true;
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.Image")));
            this.btnxoa.Location = new System.Drawing.Point(984, 373);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(123, 59);
            this.btnxoa.TabIndex = 34;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Appearance.Options.UseFont = true;
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.Image")));
            this.btnsua.Location = new System.Drawing.Point(984, 452);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(123, 59);
            this.btnsua.TabIndex = 34;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btntimkiemnv
            // 
            this.btntimkiemnv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btntimkiemnv.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiemnv.Appearance.Options.UseFont = true;
            this.btntimkiemnv.AutoSize = true;
            this.btntimkiemnv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiemnv.ImageOptions.Image")));
            this.btntimkiemnv.Location = new System.Drawing.Point(732, 58);
            this.btntimkiemnv.Name = "btntimkiemnv";
            this.btntimkiemnv.Size = new System.Drawing.Size(134, 36);
            this.btntimkiemnv.TabIndex = 34;
            this.btntimkiemnv.Text = "Tìm kiếm";
            this.btntimkiemnv.Click += new System.EventHandler(this.btntimkiemnv_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.AutoSize = true;
            this.btnlammoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlammoi.ImageOptions.Image")));
            this.btnlammoi.Location = new System.Drawing.Point(12, 3);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnlammoi.Size = new System.Drawing.Size(38, 36);
            this.btnlammoi.TabIndex = 35;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click_1);
            // 
            // txbtennv
            // 
            this.txbtennv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbtennv.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtennv.Location = new System.Drawing.Point(186, 183);
            this.txbtennv.Name = "txbtennv";
            this.txbtennv.Size = new System.Drawing.Size(326, 40);
            this.txbtennv.TabIndex = 37;
            // 
            // txbcccd
            // 
            this.txbcccd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbcccd.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcccd.Location = new System.Drawing.Point(809, 183);
            this.txbcccd.Name = "txbcccd";
            this.txbcccd.Size = new System.Drawing.Size(326, 40);
            this.txbcccd.TabIndex = 38;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 614);
            this.Controls.Add(this.txbcccd);
            this.Controls.Add(this.txbtennv);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btntimkiemnv);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.chbtimkiem);
            this.Controls.Add(this.cbbchucvu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbemail);
            this.Controls.Add(this.txbmanv);
            this.Controls.Add(this.txbtimkiemnv);
            this.Controls.Add(this.lbchucvu);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbtennv);
            this.Controls.Add(this.lbcccd);
            this.Controls.Add(this.lbmanv);
            this.Controls.Add(this.label1);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbmanv;
        private System.Windows.Forms.Label lbcccd;
        private System.Windows.Forms.Label lbtennv;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbchucvu;
        private System.Windows.Forms.TextBox txbtimkiemnv;
        private System.Windows.Forms.TextBox txbmanv;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbchucvu;
        private System.Windows.Forms.CheckBox chbtimkiem;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btntimkiemnv;
        private DevExpress.XtraEditors.SimpleButton btnlammoi;
        private ThietKeControl.KiemTraHoTen txbtennv;
        private ThietKeControl.KiemTraNhapSo txbcccd;
    }
}