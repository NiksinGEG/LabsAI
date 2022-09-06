namespace Lab1
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public float Energy
        {
            set { energyLbl.Text = value.ToString(); }
        }

        private FireParameters _params;

        private FieldDrawer _drawer;

        public Form1()
        {
            InitializeComponent();
            _drawer = new FieldDrawer(pictureBox1);
            _params = GetCurrParams();
        }

        private void evalBtn_Click(object sender, EventArgs e)
        {
            _params = GetCurrParams();
            var optimizer = new NQueenSolver(
                _params.N, 
                _params.MaxTemperature, 
                _params.MinTemperature, 
                _params.Steps, 
                _params.Alpha);
            optimizer.Initialize();
            var solution = optimizer.GetSolution();
            Energy = optimizer.CountEnergy(solution);
            _drawer.DrawField(solution);
        }

        private FireParameters GetCurrParams()
        {
            return new FireParameters
            {
                Alpha = (float)alphaNud.Value,
                MaxTemperature = (float)tempNud.Value,
                MinTemperature = (float)minTempNud.Value,
                N = (int)sizeNud.Value,
                Steps = (int)stepsNud.Value
            };
        }

        private void analisBtn_Click(object sender, EventArgs e)
        {
            var analForm = new AnalisForm();
            analForm.ShowDialog();
        }
    }
}