namespace GUI
{
    partial class FrmTimTheoCCCD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimTheoCCCD));
            this.label1 = new System.Windows.Forms.Label();
            this.btnchon = new DevExpress.XtraEditors.SimpleButton();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.txbnhapcccd = new ThietKeControl.KiemTraNhapSo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Căn cước công dân";
            // 
            // btnchon
            // 
            this.btnchon.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchon.Appearance.Options.UseFont = true;
            this.btnchon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnchon.ImageOptions.Image")));
            this.btnchon.Location = new System.Drawing.Point(540, 19);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(101, 44);
            this.btnchon.TabIndex = 40;
            this.btnchon.Text = "Chọn";
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // btndong
            // 
            this.btndong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Appearance.Options.UseFont = true;
            this.btndong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndong.ImageOptions.Image")));
            this.btndong.Location = new System.Drawing.Point(647, 19);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(101, 44);
            this.btndong.TabIndex = 40;
            this.btndong.Text = "đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // txbnhapcccd
            // 
            this.txbnhapcccd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnhapcccd.Location = new System.Drawing.Point(248, 26);
            this.txbnhapcccd.Name = "txbnhapcccd";
            this.txbnhapcccd.Size = new System.Drawing.Size(275, 32);
            this.txbnhapcccd.TabIndex = 41;
            // 
            // FrmTimTheoCCCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 117);
            this.Controls.Add(this.txbnhapcccd);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.label1);
            this.Name = "FrmTimTheoCCCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTimTheoCCCD";
            this.Load += new System.EventHandler(this.FrmTimTheoCCCD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnchon;
        private DevExpress.XtraEditors.SimpleButton btndong;
        private ThietKeControl.KiemTraNhapSo txbnhapcccd;
    }
}