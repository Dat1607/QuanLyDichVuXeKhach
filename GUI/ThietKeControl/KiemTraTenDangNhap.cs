using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControl
{
    public class KiemTraTenDangNhap : TextBox
    {
        public KiemTraTenDangNhap()
        {
            this.KeyPress += KiemTraTenDangNhap_KeyPress;
        }

        private void KiemTraTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            string kyTuvaSo = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            if (!kyTuvaSo.Contains(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
