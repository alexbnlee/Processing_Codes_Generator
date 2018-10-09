using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace 自动生成处理程序代码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Excel.Application ex = new Excel.Application();
        Excel.Workbook eWorkbook;
        Excel.Worksheet eWorksheet;

        private void Form1_Load(object sender, EventArgs e)
        {
            eWorkbook = ex.Workbooks.Open(Directory.GetCurrentDirectory() + @"\config.xlsx", Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            eWorksheet = eWorkbook.Sheets[1];
            cb_year.Text = eWorksheet.Range["A2:A2"].Value.ToString();
            nud_year.Value = Convert.ToInt32(cb_year.Text);
            cb_month.Text = eWorksheet.Range["B2:B2"].Value.ToString();
            nud_month.Value = Convert.ToInt32(cb_month.Text);
            cb_area.Text = eWorksheet.Range["C2:C2"].Value.ToString();
            tb_result.Font = new System.Drawing.Font("Courier New", 18, FontStyle.Bold);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codeStr;
            string yearStr = cb_year.Text;
            string monthStr = cb_month.Text;
            string areaStr = "b";
            switch (cb_area.Text)
            {
                case "全部海域":
                    areaStr = "a";
                    break;
                case "浙江海域":
                    areaStr = "z";
                    break;
                case "北戴河海域":
                    areaStr = "b";
                    break;
                case "江苏海域":
                    areaStr = "j";
                    break;
                case "东海海域":
                    areaStr = "d";
                    break;
                case "福建海域":
                    areaStr = "f";
                    break;
                case "曹妃甸":
                    areaStr = "c";
                    break;
                case "辽东湾海域":
                    areaStr = "l";
                    break;
            }
            codeStr="./bnli.sh -y " + yearStr + " -m " + monthStr + " -" + areaStr + ";";
            tb_result.Text = codeStr;
            Clipboard.Clear();
            Clipboard.SetDataObject(codeStr + "\n");
            if (nud_month.Value == 12)
                nud_year.Value++;
            nud_month.Value++;
        }

        private void cb_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            eWorksheet.Range["A2:A2"].Value = cb_year.Text;
            nud_year.Value = Convert.ToInt32(cb_year.Text);
        }

        private void cb_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            eWorksheet.Range["B2:B2"].Value = cb_month.Text;
            nud_month.Value = Convert.ToInt32(cb_month.Text);
        }

        private void cb_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            eWorksheet.Range["C2:C2"].Value = cb_area.Text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            eWorkbook.Save();
            eWorkbook.Close();
            ex.Quit();
        }

        private void nud_year_ValueChanged(object sender, EventArgs e)
        {
            cb_year.Text = nud_year.Value.ToString();
            eWorksheet.Range["A2:A2"].Value = cb_year.Text;
            if (nud_year.Value == 2021)
                nud_year.Value = 2000;
            if (nud_year.Value == 1999)
                nud_year.Value = 2020;
        }

        private void nud_month_ValueChanged(object sender, EventArgs e)
        {
            cb_month.Text = nud_month.Value.ToString();
            eWorksheet.Range["B2:B2"].Value = cb_month.Text;
            if (nud_month.Value == 13)
                nud_month.Value = 1;
            if (nud_month.Value == 0)
                nud_month.Value = 12;
        }

    }
}
