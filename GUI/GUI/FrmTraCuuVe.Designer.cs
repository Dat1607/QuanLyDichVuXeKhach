namespace GUI
{
    partial class FrmTraCuuVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTraCuuVe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btntrove = new DevExpress.XtraEditors.SimpleButton();
            this.btntracuu = new DevExpress.XtraEditors.SimpleButton();
            this.txbtenkh = new ThietKeControl.KiemTraHoTen();
            this.txbsdt = new ThietKeControl.KiemTraNhapSo();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 211);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(716, 274);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 29);
            this.label12.TabIndex = 43;
            this.label12.Text = "Tên khách hàng";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(45, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 29);
            this.label14.TabIndex = 44;
            this.label14.Text = "Số điện thoại";
            // 
            // btntrove
            // 
            this.btntrove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntrove.ImageOptions.Image")));
            this.btntrove.Location = new System.Drawing.Point(3, 3);
            this.btntrove.Name = "btntrove";
            this.btntrove.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btntrove.Size = new System.Drawing.Size(43, 31);
            this.btntrove.TabIndex = 61;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // btntracuu
            // 
            this.btntracuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btntracuu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntracuu.Appearance.Options.UseFont = true;
            this.btntracuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntracuu.ImageOptions.Image")));
            this.btntracuu.Location = new System.Drawing.Point(573, 98);
            this.btntracuu.Name = "btntracuu";
            this.btntracuu.Size = new System.Drawing.Size(123, 59);
            this.btntracuu.TabIndex = 62;
            this.btntracuu.Text = "Tra cứu";
            this.btntracuu.Click += new System.EventHandler(this.btntracuu_Click);
            // 
            // txbtenkh
            // 
            this.txbtenkh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbtenkh.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtenkh.Location = new System.Drawing.Point(211, 71);
            this.txbtenkh.Name = "txbtenkh";
            this.txbtenkh.Size = new System.Drawing.Size(232, 35);
            this.txbtenkh.TabIndex = 63;
            this.txbtenkh.Leave += new System.EventHandler(this.txbtenkh_Leave);
            // 
            // txbsdt
            // 
            this.txbsdt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbsdt.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbsdt.Location = new System.Drawing.Point(211, 120);
            this.txbsdt.Name = "txbsdt";
            this.txbsdt.Size = new System.Drawing.Size(232, 35);
            this.txbsdt.TabIndex = 64;
            this.txbsdt.Leave += new System.EventHandler(this.txbsdt_Leave);
            // 
            // FrmTraCuuVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 495);
            this.Controls.Add(this.txbsdt);
            this.Controls.Add(this.txbtenkh);
            this.Controls.Add(this.btntracuu);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Name = "FrmTraCuuVe";
            this.Text = "FrmTraCuuVe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.SimpleButton btntrove;
        private DevExpress.XtraEditors.SimpleButton btntracuu;
        private ThietKeControl.KiemTraHoTen txbtenkh;
        private ThietKeControl.KiemTraNhapSo txbsdt;
    }
}