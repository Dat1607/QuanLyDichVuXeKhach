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
    public partial class FrmDatVe : DevExpress.XtraEditors.XtraForm
    {
        BDDatVe qldv = new BDDatVe();
        private string tendn;
        public FrmDatVe()
        {
            InitializeComponent();
            LoadData();
        }
        public FrmDatVe(string tendn)
        {
            InitializeComponent();
            LoadData();
            this.tendn = tendn;
        }

        private void FrmDatVe_Load(object sender, EventArgs e)
        {
            cbbdiemdi.Text = "Chọn điểm đi";
            cbbdiemdi.ForeColor = Color.Gray;
            cbbdiemden.Text = "Chọn điểm đến";
            cbbdiemden.ForeColor = Color.Gray;
        }
        private void LoadData()
        {
            var tps = qldv.LoadTP();

            foreach (var tp in tps)
            {
                cbbdiemdi.Items.Add(tp.TP);
                cbbdiemden.Items.Add(tp.TP);
            }

            cbbdiemdi.SelectedIndex = 0;
        }

        private void cbbdiemdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbdiemdi.Text == "Chọn điểm đi")
            {
                cbbdiemdi.ForeColor = Color.Gray;
            }
            else
            {
                cbbdiemdi.ForeColor = Color.Black;
            }
        }

        private void cbbdiemdi_DropDown(object sender, EventArgs e)
        {
            if (cbbdiemdi.Text == "Chọn điểm đi")
            {
                cbbdiemdi.Text = "";
            }
        }

        private void cbbdiemdi_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbdiemdi.Text))
            {
                cbbdiemdi.Text = "Chọn điểm đi";
                cbbdiemdi.ForeColor = Color.Gray;
            }
        }

        private void cbbdiemden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbdiemden.Text == "Chọn điểm đến")
            {
                cbbdiemden.ForeColor = Color.Gray;
            }
            else
            {
                cbbdiemden.ForeColor = Color.Black;
            }
        }

        private void cbbdiemden_DropDown(object sender, EventArgs e)
        {
            if (cbbdiemden.Text == "Chọn điểm đến")
            {
                cbbdiemden.Text = "";
            }
        }

        private void cbbdiemden_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbdiemden.Text))
            {
                cbbdiemden.Text = "Chọn điểm đến";
                cbbdiemden.ForeColor = Color.Gray;
            }
        }

        private void dtpngaydi_Leave(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            DateTime selectedDate = dtpngaydi.Value;

            if (selectedDate <= now)
            {
                MessageBox.Show("Vui lòng chọn một ngày và giờ lớn hơn hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpngaydi.Value = now;
                dtpngaydi.Focus();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string macx = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                FrmChonChuyen frmChonChuyen = new FrmChonChuyen(macx, this);
                frmChonChuyen.Show();
            }
        }

        private void btntimcx_Click(object sender, EventArgs e)
        {
            if (!cbbdiemdi.SelectedItem.Equals(cbbdiemden.SelectedItem))
            {
                List<ChuyenXeSS> lstcx = qldv.TimKiemCX(cbbdiemdi.Text, cbbdiemden.Text, Convert.ToDateTime(dtpngaydi.Text));
                if (lstcx.Count > 0)
                {
                    dataGridView1.DataSource = lstcx;
                    dataGridView1.Columns[0].HeaderText = "Mã chuyến xe";
                    dataGridView1.Columns[1].HeaderText = "Điểm đi";
                    dataGridView1.Columns[2].HeaderText = "Điểm đến";
                    dataGridView1.Columns[3].HeaderText = "Ngày đi";
                    dataGridView1.Columns[4].HeaderText = "Giá vé";
                    int columnIndex = dataGridView1.Columns[4].Index;
                    dataGridView1.Columns[columnIndex].DefaultCellStyle.Format = "N0";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Điểm đi và điểm đến phải khác nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}