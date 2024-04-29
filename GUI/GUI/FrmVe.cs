using BLL_DAL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmVe : DevExpress.XtraEditors.XtraForm
    {
        BDVe qlv = new BDVe();
        private string tendn;
        public FrmVe(string tendn)
        {
            InitializeComponent();
            this.tendn = tendn;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            var timKiem = qlv.TimKiemVe(txbtimkiem.Text);
            if (timKiem.Count > 0)
            {
                dataGridView1.DataSource = timKiem;
                dataGridView1.Columns[0].HeaderText = "Mã vé xe";
                dataGridView1.Columns[1].HeaderText = "Mã ghế ngồi";
                dataGridView1.Columns[2].HeaderText = "Ngày đặt vé";
                dataGridView1.Columns[3].HeaderText = "Mã xe";
                dataGridView1.Columns[4].Visible = false;
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmVe_Load(object sender, EventArgs e)
        {
            
        }
    }
}