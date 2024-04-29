namespace GUI
{
    partial class FrmPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhanQuyen));
            this.cbbmamh = new System.Windows.Forms.ComboBox();
            this.chbquyen = new System.Windows.Forms.CheckBox();
            this.txbtenmh = new System.Windows.Forms.TextBox();
            this.txbMaquyen = new System.Windows.Forms.TextBox();
            this.txbTenquyen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnlammoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbmamh
            // 
            this.cbbmamh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbmamh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbmamh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmamh.FormattingEnabled = true;
            this.cbbmamh.Location = new System.Drawing.Point(233, 126);
            this.cbbmamh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbmamh.Name = "cbbmamh";
            this.cbbmamh.Size = new System.Drawing.Size(208, 37);
            this.cbbmamh.TabIndex = 48;
            this.cbbmamh.DropDown += new System.EventHandler(this.cbbmamh_DropDown);
            this.cbbmamh.SelectedIndexChanged += new System.EventHandler(this.cbbmamh_SelectedIndexChanged);
            this.cbbmamh.DropDownClosed += new System.EventHandler(this.cbbmamh_DropDownClosed);
            // 
            // chbquyen
            // 
            this.chbquyen.AutoSize = true;
            this.chbquyen.Location = new System.Drawing.Point(233, 203);
            this.chbquyen.Margin = new System.Windows.Forms.Padding(4);
            this.chbquyen.Name = "chbquyen";
            this.chbquyen.Size = new System.Drawing.Size(18, 17);
            this.chbquyen.TabIndex = 47;
            this.chbquyen.UseVisualStyleBackColor = true;
            // 
            // txbtenmh
            // 
            this.txbtenmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtenmh.Location = new System.Drawing.Point(745, 126);
            this.txbtenmh.Margin = new System.Windows.Forms.Padding(4);
            this.txbtenmh.Name = "txbtenmh";
            this.txbtenmh.ReadOnly = true;
            this.txbtenmh.Size = new System.Drawing.Size(213, 34);
            this.txbtenmh.TabIndex = 44;
            // 
            // txbMaquyen
            // 
            this.txbMaquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaquyen.Location = new System.Drawing.Point(233, 66);
            this.txbMaquyen.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaquyen.Name = "txbMaquyen";
            this.txbMaquyen.ReadOnly = true;
            this.txbMaquyen.Size = new System.Drawing.Size(208, 34);
            this.txbMaquyen.TabIndex = 45;
            // 
            // txbTenquyen
            // 
            this.txbTenquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenquyen.Location = new System.Drawing.Point(745, 66);
            this.txbTenquyen.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenquyen.Name = "txbTenquyen";
            this.txbTenquyen.ReadOnly = true;
            this.txbTenquyen.Size = new System.Drawing.Size(213, 34);
            this.txbTenquyen.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Quyền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(561, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 29);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tên màn hình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mã màn hình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tên quyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã quyền";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 292);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(919, 322);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnlammoi
            // 
            this.btnlammoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlammoi.ImageOptions.Image")));
            this.btnlammoi.Location = new System.Drawing.Point(3, -2);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnlammoi.Size = new System.Drawing.Size(43, 31);
            this.btnlammoi.TabIndex = 49;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnsua
            // 
            this.btnsua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Appearance.Options.UseFont = true;
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.Image")));
            this.btnsua.Location = new System.Drawing.Point(834, 226);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(123, 59);
            this.btnsua.TabIndex = 50;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Appearance.Options.UseFont = true;
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.Image")));
            this.btnxoa.Location = new System.Drawing.Point(705, 226);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(123, 59);
            this.btnxoa.TabIndex = 51;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Appearance.Options.UseFont = true;
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(576, 226);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(123, 59);
            this.btnthem.TabIndex = 52;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // FrmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 640);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.cbbmamh);
            this.Controls.Add(this.chbquyen);
            this.Controls.Add(this.txbtenmh);
            this.Controls.Add(this.txbMaquyen);
            this.Controls.Add(this.txbTenquyen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmPhanQuyen";
            this.Text = "FrmPhanQuyen";
            this.Load += new System.EventHandler(this.FrmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbmamh;
        private System.Windows.Forms.CheckBox chbquyen;
        private System.Windows.Forms.TextBox txbtenmh;
        private System.Windows.Forms.TextBox txbMaquyen;
        private System.Windows.Forms.TextBox txbTenquyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btnlammoi;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnthem;
    }
}