using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhoHang
{
    public partial class txtChiNhapSo : System.Windows.Forms.TextBox
    {
        public txtChiNhapSo()
        {
            InitializeComponent();
        }

        public txtChiNhapSo(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
