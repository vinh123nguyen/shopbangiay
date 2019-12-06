using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeContronl
{
    public class txt_ChiNhapSo:TextBox
    {
        public txt_ChiNhapSo()
        {
            this.KeyPress+=txt_ChiNhapSo_KeyPress;
        }

        private void txt_ChiNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

        }
    }
}
