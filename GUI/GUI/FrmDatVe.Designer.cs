namespace GUI
{
    partial class FrmDatVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatVe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpngaydi = new System.Windows.Forms.DateTimePicker();
            this.cbbdiemden = new System.Windows.Forms.ComboBox();
            this.cbbdiemdi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btntimcx = new DevExpress.XtraEditors.SimpleButton();
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(912, 263);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dtpngaydi
            // 
            this.dtpngaydi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpngaydi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaydi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaydi.Location = new System.Drawing.Point(509, 62);
            this.dtpngaydi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpngaydi.Name = "dtpngaydi";
            this.dtpngaydi.Size = new System.Drawing.Size(228, 30);
            this.dtpngaydi.TabIndex = 10;
            this.dtpngaydi.Leave += new System.EventHandler(this.dtpngaydi_Leave);
            // 
            // cbbdiemden
            // 
            this.cbbdiemden.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbdiemden.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbdiemden.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbdiemden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbdiemden.FormattingEnabled = true;
            this.cbbdiemden.Location = new System.Drawing.Point(279, 60);
            this.cbbdiemden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbdiemden.Name = "cbbdiemden";
            this.cbbdiemden.Size = new System.Drawing.Size(158, 33);
            this.cbbdiemden.TabIndex = 9;
            this.cbbdiemden.DropDown += new System.EventHandler(this.cbbdiemden_DropDown);
            this.cbbdiemden.SelectedIndexChanged += new System.EventHandler(this.cbbdiemden_SelectedIndexChanged);
            this.cbbdiemden.DropDownClosed += new System.EventHandler(this.cbbdiemden_DropDownClosed);
            // 
            // cbbdiemdi
            // 
            this.cbbdiemdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbdiemdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbdiemdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbdiemdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbdiemdi.FormattingEnabled = true;
            this.cbbdiemdi.Location = new System.Drawing.Point(44, 60);
            this.cbbdiemdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbdiemdi.Name = "cbbdiemdi";
            this.cbbdiemdi.Size = new System.Drawing.Size(158, 33);
            this.cbbdiemdi.TabIndex = 5;
            this.cbbdiemdi.DropDown += new System.EventHandler(this.cbbdiemdi_DropDown);
            this.cbbdiemdi.SelectedIndexChanged += new System.EventHandler(this.cbbdiemdi_SelectedIndexChanged);
            this.cbbdiemdi.DropDownClosed += new System.EventHandler(this.cbbdiemdi_DropDownClosed);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày đi";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Điểm đến";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Điểm đi";
            // 
            // btntimcx
            // 
            this.btntimcx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btntimcx.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntimcx.ImageOptions.Image")));
            this.btntimcx.Location = new System.Drawing.Point(770, 60);
            this.btntimcx.Name = "btntimcx";
            this.btntimcx.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btntimcx.Size = new System.Drawing.Size(60, 32);
            this.btntimcx.TabIndex = 13;
            this.btntimcx.Click += new System.EventHandler(this.btntimcx_Click);
            // 
            // FrmDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 398);
            this.Controls.Add(this.btntimcx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpngaydi);
            this.Controls.Add(this.cbbdiemden);
            this.Controls.Add(this.cbbdiemdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDatVe";
            this.Text = "FrmDatVe";
            this.Load += new System.EventHandler(this.FrmDatVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpngaydi;
        private System.Windows.Forms.ComboBox cbbdiemden;
        private System.Windows.Forms.ComboBox cbbdiemdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btntimcx;
    }
}