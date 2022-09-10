using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private delegate void ChangeState(string newState);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stateLbl.BeginInvoke(new ChangeState(ChangeStatleLbl), "Выбор CSV файла...");

            ParamsForm paramsDialog = new ParamsForm(stateLbl);
            paramsDialog.AfterClasterisation += ReFillGrid;
            paramsDialog.ShowDialog();

            stateLbl.BeginInvoke(new ChangeState(ChangeStatleLbl), "Выберите CSV файл...");
        }

        private void ChangeStatleLbl(string state)
        {
            stateLbl.Text = state;
        }

        private void ReFillGrid(object sender, EventArgs _)
        {
            clastersDataGrid.Rows.Clear();
            clastersDataGrid.Columns.Clear();
            var clasters = ((ParamsForm)sender).Clasters;
            var rows = new List<string>();
            foreach (var c in clasters)
            {
                var col = new DataGridViewColumn();
                col.Name = c.Item1.ToBeautyString();
                col.HeaderText = c.Item1.ToBeautyString();
                col.CellTemplate = new DataGridViewTextBoxCell();
                clastersDataGrid.Columns.Add(col);

                var sb = new StringBuilder();
                foreach(var attr in c.Item2)
                {
                    if (attr != c.Item2.Last())
                        sb.Append(attr.ToBeautyString() + Environment.NewLine);
                    else
                        sb.Append(attr.ToBeautyString());
                }
                rows.Add(sb.ToString());
            }
            clastersDataGrid.Rows.Add(rows.ToArray());
        }
    }
}
