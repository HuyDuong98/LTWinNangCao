using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhoHang
{
    public partial class dataGridViewSTT : System.Windows.Forms.DataGridView
    {
        public dataGridViewSTT()
        {
            InitializeComponent();
        }

        public dataGridViewSTT(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();

            }
        }

    }
}
