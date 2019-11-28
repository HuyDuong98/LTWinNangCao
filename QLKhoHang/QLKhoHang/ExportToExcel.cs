﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QLKhoHang
{
    public class ExportToExcel
    {
        public void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            int k = 0; 
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++) { obj.Cells[1, i] = g.Columns[i - 1].HeaderText; }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            try
            {
                obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap+"("+k+")" + ".xlsx");
                obj.ActiveWorkbook.Saved = true;
                MessageBox.Show("Xuất thành công");
            }
            catch 
            {
                k += 1;
                export2Excel(g, duongDan, tenTap);
            }
            
            
        }
    }
}