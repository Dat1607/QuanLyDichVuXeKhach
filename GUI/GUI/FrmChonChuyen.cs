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
    public partial class FrmChonChuyen : DevExpress.XtraEditors.XtraForm
    {
        private string macx;
        BDDatVe qldv = new BDDatVe();
        private FrmDatVe frmDatVe;
        
        public FrmChonChuyen()
        {
            InitializeComponent();
        }

        public FrmChonChuyen(string macx, FrmDatVe frm)
        {
            InitializeComponent();
            this.macx = macx;
            frmDatVe = frm;
        }

        private void FrmChonChuyen_Load(object sender, EventArgs e)
        {
            List<XeS> lstX = qldv.LayXeTheoMaCX(macx);
            dataGridView1.DataSource = lstX;
            dataGridView1.Columns[0].HeaderText = "Mã xe";
            dataGridView1.Columns[1].HeaderText = "Tên tài xế";
            dataGridView1.Columns[2].HeaderText = "Biển số xe";
            dataGridView1.Columns[3].HeaderText = "Số ghế";
            dataGridView1.Columns[4].HeaderText = "Số ghế còn lại";
            dataGridView1.Columns[5].HeaderText = "Tình trạng";
            dataGridView1.Columns[6].HeaderText = "Giờ khởi hành";
            dataGridView1.Columns[7].HeaderText = "Giờ kết thúc";
            dataGridView1.Columns[8].HeaderText = "Mã chuyến xe";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int soGhe = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                string maChuyenXe = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                string maXe = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (soGhe == 16)
                {
                    FrmChonGhe16 form = new FrmChonGhe16(maChuyenXe, maXe);
                    form.ShowInfoOnForm16(maChuyenXe, maXe);
                    form.Show();
                    this.Hide();
                }
                else if (soGhe == 33)
                {
                    FrmChonGhe33 form = new FrmChonGhe33(maChuyenXe, maXe);
                    form.ShowInfoOnForm33(maChuyenXe, maXe);
                    form.Show();
                    this.Hide();
                }
                else if (soGhe == 49)
                {
                    FrmChonGhe49 form = new FrmChonGhe49(maChuyenXe, maXe);
                    form.ShowInfoOnForm49(maChuyenXe, maXe);
                    form.Show();
                    this.Hide();
                }

            }
        }

        private void rdbsangsom_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = (RadioButton)sender;

            if (selectedRadioButton.Checked)
            {
                TimeSpan startTime = TimeSpan.MinValue;
                TimeSpan endTime = TimeSpan.MinValue;

                if (selectedRadioButton == rdbsangsom)
                {
                    startTime = TimeSpan.Parse("00:00:00");
                    endTime = TimeSpan.Parse("05:59:00");
                }
                List<XeS> lstx = qldv.LayXeTheoTGian(macx, startTime, endTime);
                dataGridView1.DataSource = lstx;
            }
        }

        private void rdbbuoisang_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = (RadioButton)sender;

            if (selectedRadioButton.Checked)
            {
                TimeSpan startTime = TimeSpan.MinValue;
                TimeSpan endTime = TimeSpan.MinValue;
                if (selectedRadioButton == rdbbuoisang)
                {
                    startTime = TimeSpan.Parse("06:00:00");
                    endTime = TimeSpan.Parse("11:59:00");
                }
                List<XeS> lstx = qldv.LayXeTheoTGian(macx, startTime, endTime);
                dataGridView1.DataSource = lstx;
            }
        }

        private void rdbbuoichieu_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = (RadioButton)sender;

            if (selectedRadioButton.Checked)
            {
                TimeSpan startTime = TimeSpan.MinValue;
                TimeSpan endTime = TimeSpan.MinValue;
                if (selectedRadioButton == rdbbuoichieu)
                {
                    startTime = TimeSpan.Parse("12:00:00");
                    endTime = TimeSpan.Parse("17:59:00");
                }
                List<XeS> lst = qldv.LayXeTheoTGian(macx, startTime, endTime);
                dataGridView1.DataSource = lst;
            }
        }

        private void rdbbuoitoi_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = (RadioButton)sender;

            if (selectedRadioButton.Checked)
            {
                TimeSpan startTime = TimeSpan.MinValue;
                TimeSpan endTime = TimeSpan.MinValue;
                if (selectedRadioButton == rdbbuoitoi)
                {
                    startTime = TimeSpan.Parse("18:00:00");
                    endTime = TimeSpan.Parse("23:59:00");
                }
                List<XeS> lstx = qldv.LayXeTheoTGian(macx, startTime, endTime);
                dataGridView1.DataSource = lstx;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            rdbsangsom.Checked = false;
            rdbbuoisang.Checked = false;
            rdbbuoichieu.Checked = false;
            rdbbuoitoi.Checked = false;
            List<XeS> lstX = qldv.LayXeTheoMaCX(macx);
            dataGridView1.DataSource = lstX;
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}