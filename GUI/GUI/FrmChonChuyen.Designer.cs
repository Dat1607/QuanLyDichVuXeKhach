namespace GUI
{
    partial class FrmChonChuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChonChuyen));
            this.grpboloc = new System.Windows.Forms.GroupBox();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.rdbbuoitoi = new System.Windows.Forms.RadioButton();
            this.rdbbuoisang = new System.Windows.Forms.RadioButton();
            this.rdbbuoichieu = new System.Windows.Forms.RadioButton();
            this.rdbsangsom = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btntrove = new DevExpress.XtraEditors.SimpleButton();
            this.grpboloc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboloc
            // 
            this.grpboloc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboloc.Controls.Add(this.btnxoa);
            this.grpboloc.Controls.Add(this.rdbbuoitoi);
            this.grpboloc.Controls.Add(this.rdbbuoisang);
            this.grpboloc.Controls.Add(this.rdbbuoichieu);
            this.grpboloc.Controls.Add(this.rdbsangsom);
            this.grpboloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboloc.Location = new System.Drawing.Point(144, 33);
            this.grpboloc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpboloc.Name = "grpboloc";
            this.grpboloc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpboloc.Size = new System.Drawing.Size(760, 204);
            this.grpboloc.TabIndex = 3;
            this.grpboloc.TabStop = false;
            this.grpboloc.Text = "Bộ lọc tìm kiếm";
            // 
            // btnxoa
            // 
            this.btnxoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnxoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Appearance.Options.UseFont = true;
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.Image")));
            this.btnxoa.Location = new System.Drawing.Point(608, 21);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(146, 37);
            this.btnxoa.TabIndex = 39;
            this.btnxoa.Text = "Xóa bộ lọc";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // rdbbuoitoi
            // 
            this.rdbbuoitoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbbuoitoi.AutoSize = true;
            this.rdbbuoitoi.Location = new System.Drawing.Point(413, 149);
            this.rdbbuoitoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbbuoitoi.Name = "rdbbuoitoi";
            this.rdbbuoitoi.Size = new System.Drawing.Size(257, 33);
            this.rdbbuoitoi.TabIndex = 1;
            this.rdbbuoitoi.TabStop = true;
            this.rdbbuoitoi.Text = "Buổi tối 18:00 - 23:59";
            this.rdbbuoitoi.UseVisualStyleBackColor = true;
            this.rdbbuoitoi.CheckedChanged += new System.EventHandler(this.rdbbuoitoi_CheckedChanged);
            // 
            // rdbbuoisang
            // 
            this.rdbbuoisang.AutoSize = true;
            this.rdbbuoisang.Location = new System.Drawing.Point(5, 149);
            this.rdbbuoisang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbbuoisang.Name = "rdbbuoisang";
            this.rdbbuoisang.Size = new System.Drawing.Size(289, 33);
            this.rdbbuoisang.TabIndex = 1;
            this.rdbbuoisang.TabStop = true;
            this.rdbbuoisang.Text = "Buổi sáng 06:00 - 11:59 ";
            this.rdbbuoisang.UseVisualStyleBackColor = true;
            this.rdbbuoisang.CheckedChanged += new System.EventHandler(this.rdbbuoisang_CheckedChanged);
            // 
            // rdbbuoichieu
            // 
            this.rdbbuoichieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbbuoichieu.AutoSize = true;
            this.rdbbuoichieu.Location = new System.Drawing.Point(413, 87);
            this.rdbbuoichieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbbuoichieu.Name = "rdbbuoichieu";
            this.rdbbuoichieu.Size = new System.Drawing.Size(289, 33);
            this.rdbbuoichieu.TabIndex = 1;
            this.rdbbuoichieu.TabStop = true;
            this.rdbbuoichieu.Text = "Buổi chiều 12:00 - 17:59";
            this.rdbbuoichieu.UseVisualStyleBackColor = true;
            this.rdbbuoichieu.CheckedChanged += new System.EventHandler(this.rdbbuoichieu_CheckedChanged);
            // 
            // rdbsangsom
            // 
            this.rdbsangsom.AutoSize = true;
            this.rdbsangsom.Location = new System.Drawing.Point(5, 87);
            this.rdbsangsom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbsangsom.Name = "rdbsangsom";
            this.rdbsangsom.Size = new System.Drawing.Size(290, 33);
            this.rdbsangsom.TabIndex = 1;
            this.rdbsangsom.TabStop = true;
            this.rdbsangsom.Text = "Sáng sớm 00:00 - 05:59 ";
            this.rdbsangsom.UseVisualStyleBackColor = true;
            this.rdbsangsom.CheckedChanged += new System.EventHandler(this.rdbsangsom_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 260);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1027, 307);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btntrove
            // 
            this.btntrove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntrove.ImageOptions.Image")));
            this.btntrove.Location = new System.Drawing.Point(12, -1);
            this.btntrove.Name = "btntrove";
            this.btntrove.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btntrove.Size = new System.Drawing.Size(43, 31);
            this.btntrove.TabIndex = 14;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // FrmChonChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 602);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.grpboloc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmChonChuyen";
            this.Text = "FrmChonChuyen";
            this.Load += new System.EventHandler(this.FrmChonChuyen_Load);
            this.grpboloc.ResumeLayout(false);
            this.grpboloc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboloc;
        private System.Windows.Forms.RadioButton rdbbuoitoi;
        private System.Windows.Forms.RadioButton rdbbuoisang;
        private System.Windows.Forms.RadioButton rdbbuoichieu;
        private System.Windows.Forms.RadioButton rdbsangsom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btntrove;
    }
}