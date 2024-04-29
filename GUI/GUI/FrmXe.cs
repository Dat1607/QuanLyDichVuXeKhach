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
    public partial class FrmXe : DevExpress.XtraEditors.XtraForm
    {
        BDXe qlx = new BDXe();
        private string tendn;
        private AutoCompleteStringCollection autoCompleteStringCollection;
        public FrmXe()
        {
            InitializeComponent();
        }
        public FrmXe(string tendn)
        {
            InitializeComponent();
            this.tendn = tendn;

            autoCompleteStringCollection = new AutoCompleteStringCollection();
            LoadAutoCompleteMaXe();
            LoadAutoCompleteBienSX();
            txbtimkiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txbtimkiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txbtimkiem.AutoCompleteCustomSource = autoCompleteStringCollection;
        }
        private void LoadAutoCompleteMaXe()
        {
            var query = from data in qlx.LoadX()
                        select data.MaXe;

            autoCompleteStringCollection.AddRange(query.ToArray());
        }
        private void LoadAutoCompleteBienSX()
        {
            var query = from data in qlx.LoadX()
                        select data.BienSX;

            autoCompleteStringCollection.AddRange(query.ToArray());
        }
        private void FrmXe_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = qlx.LoadX();
            dataGridView1.Columns[0].HeaderText = "Mã xe";
            dataGridView1.Columns[1].HeaderText = "Tên tài xế";
            dataGridView1.Columns[2].HeaderText = "Biển số xe";
            dataGridView1.Columns[3].HeaderText = "Số ghế";
            dataGridView1.Columns[4].HeaderText = "Tình trạng xe";
            txbsoghe.Hide();
            btnsua.Hide();
            btnxoa.Hide();
            cbbsoghe.Items.Add(16);
            cbbsoghe.Items.Add(33);
            cbbsoghe.Items.Add(49);
            cbbsoghe.Text = "Chọn số ghế";
            cbbsoghe.ForeColor = Color.Gray;
            txbttx.Text = "Không có chuyến";
        }
        private string TaoRandomMaX()
        {
            Random random = new Random();
            int randomValue;
            string maXe;

            do
            {
                randomValue = random.Next(0, 1000);
                maXe = "X" + randomValue.ToString("000");
            } while (KiemTraTrungMaX(maXe));

            return maXe;
        }

        private bool KiemTraTrungMaX(string max)
        {
            return false;
        }

        private void txbtentx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbtentx.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbtentx.Focus();
            }
            else if (txbtentx.Text.Length < 5 || txbtentx.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập từ 5 đến 50 ký tự");
                txbtentx.Focus();
            }
            else if (txbtentx.Text.Contains("  "))
            {
                MessageBox.Show("Vui lòng chỉ nhập một khoảng trắng giữa các ký tự");
                txbtentx.Focus();
            }
        }

        private void txbbiensx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbbiensx.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbbiensx.Focus();
            }
            else if (KiemTraBienSoXeKhach(txbbiensx.Text))
            {
            }
            else
            {
                MessageBox.Show("Biển số xe không hợp lệ. Vui lòng kiểm tra lại vd:55A-38363", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbbiensx.Focus();
            }
        }
        private bool KiemTraBienSoXeKhach(string bienSoXe)
        {
            if (bienSoXe.Length != 9)
            {
                return false;
            }
            return System.Text.RegularExpressions.Regex.IsMatch(bienSoXe, "^[0-9]{2}[A-Z]{1}-[0-9]{5}$");
        }

        private void cbbsoghe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbsoghe.Text == "Chọn số ghế" && cbbsoghe.SelectedIndex == 0)
            {
                cbbsoghe.ForeColor = Color.Gray;
            }
            else
            {
                cbbsoghe.ForeColor = Color.Black;
            }
        }

        private void cbbsoghe_DropDown(object sender, EventArgs e)
        {
            if (cbbsoghe.Text == "Chọn số ghế")
            {
                cbbsoghe.Text = "";
            }
        }

        private void cbbsoghe_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbsoghe.Text))
            {
                cbbsoghe.Text = "Chọn số ghế";
                cbbsoghe.ForeColor = Color.Gray;
            }
            else
            {
                cbbsoghe.ForeColor = Color.Black;
            }
        }




        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!qlx.KiemTraTrungBienSX(txbbiensx.Text))
            {
                MessageBox.Show("Biển số xe đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string bienSX = txbbiensx.Text;
            string namSoCuoiBSX = bienSX.Substring(bienSX.Length - 5);
            string max = "X" + namSoCuoiBSX;
            if (cbbsoghe.SelectedItem != null && !string.IsNullOrWhiteSpace(txbtentx.Text) && !string.IsNullOrWhiteSpace(txbbiensx.Text))
            {
                qlx.ThemX(max, txbtentx.Text, txbbiensx.Text, Convert.ToInt16(cbbsoghe.Text), txbttx.Text);
                dataGridView1.DataSource = qlx.LoadX();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn và nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string bienSX = txbbiensx.Text;
            string namSoCuoiBSX = bienSX.Substring(bienSX.Length - 5);
            string max = "X" + namSoCuoiBSX;
            qlx.XoaX(max);
            dataGridView1.DataSource = qlx.LoadX();
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string tentx = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string biensx = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string soghe = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string tinhtrangx = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txbtentx.Text = tentx;
                txbbiensx.Text = biensx;
                txbsoghe.Text = soghe;
                txbttx.Text = tinhtrangx;
                txbbiensx.ReadOnly = true;
                cbbsoghe.Hide();
                txbsoghe.Show();
                btnxoa.Show();
                btnsua.Show();
                btnthem.Hide();

            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string bienSX = txbbiensx.Text;
            string namSoCuoiBSX = bienSX.Substring(bienSX.Length - 5);
            string max = "X" + namSoCuoiBSX;
            if (cbbsoghe.SelectedItem != null && !string.IsNullOrWhiteSpace(txbtentx.Text) && !string.IsNullOrWhiteSpace(txbbiensx.Text))
            {
                qlx.SuaX(max, txbtentx.Text, txbbiensx.Text, Convert.ToInt16(cbbsoghe.Text), txbttx.Text);
                dataGridView1.DataSource = qlx.LoadX();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn và nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txbtentx.Focus();
            txbbiensx.ReadOnly = false;
            txbtentx.Clear();
            txbbiensx.Clear();
            cbbsoghe.Show();
            cbbsoghe.Text = "Chọn số ghế";
            cbbsoghe.ForeColor = Color.Gray;
            txbttx.Text = "Không có chuyến";
            txbsoghe.Hide();
            btnxoa.Hide();
            btnsua.Hide();
            btnthem.Show();
            dataGridView1.DataSource = qlx.LoadX();
        }

        private void btntimcx_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = qlx.TimKiemXe(txbtimkiem.Text);
        }
    }
}