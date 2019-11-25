using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLKhoHang
{
    public partial class txtChiNhapSo : TextBox
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
