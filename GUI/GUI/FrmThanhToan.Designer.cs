namespace GUI
{
    partial class FrmThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThanhToan));
            this.txbthanhtoan = new System.Windows.Forms.TextBox();
            this.txbtongtien = new System.Windows.Forms.TextBox();
            this.txbghedat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btntrove = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txbthanhtoan
            // 
            this.txbthanhtoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbthanhtoan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbthanhtoan.Location = new System.Drawing.Point(177, 195);
            this.txbthanhtoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbthanhtoan.Name = "txbthanhtoan";
            this.txbthanhtoan.Size = new System.Drawing.Size(269, 28);
            this.txbthanhtoan.TabIndex = 64;
            this.txbthanhtoan.Leave += new System.EventHandler(this.txbthanhtoan_Leave);
            // 
            // txbtongtien
            // 
            this.txbtongtien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbtongtien.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtongtien.Location = new System.Drawing.Point(177, 136);
            this.txbtongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbtongtien.Name = "txbtongtien";
            this.txbtongtien.ReadOnly = true;
            this.txbtongtien.Size = new System.Drawing.Size(269, 28);
            this.txbtongtien.TabIndex = 65;
            // 
            // txbghedat
            // 
            this.txbghedat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbghedat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbghedat.Location = new System.Drawing.Point(177, 86);
            this.txbghedat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbghedat.Name = "txbghedat";
            this.txbghedat.ReadOnly = true;
            this.txbghedat.Size = new System.Drawing.Size(269, 28);
            this.txbghedat.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 59;
            this.label4.Text = "Thanh toán";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 60;
            this.label3.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 61;
            this.label2.Text = "Ghế đặt";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 40);
            this.label1.TabIndex = 62;
            this.label1.Text = "Thanh toán vé";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(303, 246);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(143, 48);
            this.simpleButton1.TabIndex = 67;
            this.simpleButton1.Text = "Thanh toán";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btntrove
            // 
            this.btntrove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntrove.ImageOptions.Image")));
            this.btntrove.Location = new System.Drawing.Point(12, -1);
            this.btntrove.Name = "btntrove";
            this.btntrove.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btntrove.Size = new System.Drawing.Size(43, 31);
            this.btntrove.TabIndex = 68;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // FrmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 377);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txbthanhtoan);
            this.Controls.Add(this.txbtongtien);
            this.Controls.Add(this.txbghedat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThanhToan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbthanhtoan;
        public System.Windows.Forms.TextBox txbtongtien;
        public System.Windows.Forms.TextBox txbghedat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btntrove;
    }
}