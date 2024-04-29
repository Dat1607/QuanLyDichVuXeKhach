namespace GUI
{
    partial class FrmXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmXe));
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbbiensx = new System.Windows.Forms.TextBox();
            this.txbttx = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnlammoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.txbtentx = new ThietKeControl.KiemTraHoTen();
            this.txbsoghe = new System.Windows.Forms.TextBox();
            this.cbbsoghe = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntimcx = new DevExpress.XtraEditors.SimpleButton();
            this.txbtimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 31);
            this.label3.TabIndex = 44;
            this.label3.Text = "Biển số xe";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(605, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 31);
            this.label8.TabIndex = 47;
            this.label8.Text = "Tình trạng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 31);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tên tài xế";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(645, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 31);
            this.label4.TabIndex = 42;
            this.label4.Text = "Số ghế";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(587, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 42);
            this.label7.TabIndex = 40;
            this.label7.Text = "Xe khách";
            // 
            // txbbiensx
            // 
            this.txbbiensx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbbiensx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbbiensx.Location = new System.Drawing.Point(291, 197);
            this.txbbiensx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbbiensx.Name = "txbbiensx";
            this.txbbiensx.Size = new System.Drawing.Size(222, 34);
            this.txbbiensx.TabIndex = 35;
            this.txbbiensx.Leave += new System.EventHandler(this.txbbiensx_Leave);
            // 
            // txbttx
            // 
            this.txbttx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbttx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbttx.Location = new System.Drawing.Point(773, 204);
            this.txbttx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbttx.Name = "txbttx";
            this.txbttx.ReadOnly = true;
            this.txbttx.Size = new System.Drawing.Size(196, 34);
            this.txbttx.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 257);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1048, 324);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnlammoi
            // 
            this.btnlammoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlammoi.ImageOptions.Image")));
            this.btnlammoi.Location = new System.Drawing.Point(3, 9);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnlammoi.Size = new System.Drawing.Size(43, 31);
            this.btnlammoi.TabIndex = 52;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnsua
            // 
            this.btnsua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Appearance.Options.UseFont = true;
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.Image")));
            this.btnsua.Location = new System.Drawing.Point(1167, 472);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(123, 59);
            this.btnsua.TabIndex = 58;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnxoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Appearance.Options.UseFont = true;
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.Image")));
            this.btnxoa.Location = new System.Drawing.Point(1167, 393);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(123, 59);
            this.btnxoa.TabIndex = 59;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnthem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Appearance.Options.UseFont = true;
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(1167, 314);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(123, 59);
            this.btnthem.TabIndex = 60;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txbtentx
            // 
            this.txbtentx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbtentx.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtentx.Location = new System.Drawing.Point(291, 136);
            this.txbtentx.Name = "txbtentx";
            this.txbtentx.Size = new System.Drawing.Size(222, 35);
            this.txbtentx.TabIndex = 61;
            // 
            // txbsoghe
            // 
            this.txbsoghe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbsoghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbsoghe.Location = new System.Drawing.Point(773, 130);
            this.txbsoghe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbsoghe.Multiline = true;
            this.txbsoghe.Name = "txbsoghe";
            this.txbsoghe.ReadOnly = true;
            this.txbsoghe.Size = new System.Drawing.Size(193, 37);
            this.txbsoghe.TabIndex = 62;
            // 
            // cbbsoghe
            // 
            this.cbbsoghe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbsoghe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbsoghe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbsoghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbsoghe.FormattingEnabled = true;
            this.cbbsoghe.Location = new System.Drawing.Point(773, 130);
            this.cbbsoghe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbsoghe.Name = "cbbsoghe";
            this.cbbsoghe.Size = new System.Drawing.Size(193, 37);
            this.cbbsoghe.TabIndex = 63;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btntimcx);
            this.groupBox1.Controls.Add(this.txbtimkiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(998, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 144);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btntimcx
            // 
            this.btntimcx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btntimcx.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntimcx.ImageOptions.Image")));
            this.btntimcx.Location = new System.Drawing.Point(234, 93);
            this.btntimcx.Name = "btntimcx";
            this.btntimcx.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btntimcx.Size = new System.Drawing.Size(60, 32);
            this.btntimcx.TabIndex = 65;
            this.btntimcx.Click += new System.EventHandler(this.btntimcx_Click);
            // 
            // txbtimkiem
            // 
            this.txbtimkiem.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtimkiem.Location = new System.Drawing.Point(16, 94);
            this.txbtimkiem.Name = "txbtimkiem";
            this.txbtimkiem.Size = new System.Drawing.Size(212, 35);
            this.txbtimkiem.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mã xe hoặc biển số xe";
            // 
            // FrmXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbsoghe);
            this.Controls.Add(this.txbsoghe);
            this.Controls.Add(this.txbtentx);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbbiensx);
            this.Controls.Add(this.txbttx);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmXe";
            this.Text = "FrmXe";
            this.Load += new System.EventHandler(this.FrmXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbbiensx;
        private System.Windows.Forms.TextBox txbttx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btnlammoi;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private ThietKeControl.KiemTraHoTen txbtentx;
        private System.Windows.Forms.TextBox txbsoghe;
        private System.Windows.Forms.ComboBox cbbsoghe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbtimkiem;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btntimcx;
    }
}