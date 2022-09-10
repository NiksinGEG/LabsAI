using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab2
{
    public partial class ParamsForm : Form
    {
        public IEnumerable<Tuple<DigitVector, IEnumerable<DigitVector>>> Clasters { get; private set; }
        public event EventHandler AfterClasterisation;
        private Label StateLbl;
        private delegate void ChangeState(string newState);
        public ParamsForm(Label stateLbl)
        {
            InitializeComponent();
            StateLbl = stateLbl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            csvFileChooser.ShowDialog();
            if (!csvFileChooser.CheckFileExists)
            {
                this.Close();
                return;
            }
            StateLbl.BeginInvoke(new ChangeState(ChangeStatleLbl), "Парсинг файла...");
            var attributes = CsvParser.ParseToDigVec(csvFileChooser.FileName, headersCb.Checked, separatorCb.Text[0]);
            var art = new ART1((double)betaNud.Value, (double)mindfulnessNud.Value);
            StateLbl.BeginInvoke(new ChangeState(ChangeStatleLbl), "Кластеризация...");
            Clasters = art.Clasterisate(attributes);
            AfterClasterisation?.Invoke(this, new EventArgs());
            this.Close();
        }

        private void ChangeStatleLbl(string state)
        {
            StateLbl.Text = state;
        }
    }
}
