using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControl
{
    public class KiemTraNhapSo : TextBox
    {
        public KiemTraNhapSo()
        {
            this.KeyPress += KiemTraNhapSo_KeyPress;
        }

        private void KiemTraNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
