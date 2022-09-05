namespace Lab1
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public int[] Solution { get; set; } = new int[0];

        public bool Initialized { get; private set; } = false;

        public float Energy
        {
            get { return float.Parse(energyLbl.Text); }
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

        private void Initialize()
        {
            Solution = new int[_params.N];
            for (int i = 0; i < _params.N; i++) Solution[i] = i;
            Initialized = true;
        }

        private float CountEnergyOf(int[] arr, int i)
        {
            float res = 0;
            for(int j = 0; j < arr.Length; j++)
            {
                if (i == j) continue;
                if (Math.Abs(arr[j] - arr[i]) == Math.Abs(j - i)) res++;
            }
            return res;
        }

        private float CountFullEnergy(int[] arr)
        {
            float res = 0;
            for (int i = 0; i < arr.Length; i++)
                res += CountEnergyOf(arr, i);
            return res;
        }

        private float TemperatureFunc(float t)
        {
            return t * _params.Alpha;
        }

        private void initBtn_Click(object sender, EventArgs e)
        {
            _params = GetCurrParams();
            Initialize();
            _drawer.DrawField(Solution);
        }

        private void evalBtn_Click(object sender, EventArgs e)
        {
            _params = GetCurrParams();
            if(!Initialized) Initialize();

            var optimizer = new FireOptimizer<int>(_params.N, _params.MaxTemperature, _params.MinTemperature, _params.Steps);
            optimizer.Initialize(Solution);
            Solution = optimizer.GetSolution(CountFullEnergy, TemperatureFunc);
            Energy = CountFullEnergy(Solution);
            _drawer.DrawField(Solution);
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

        private void sizeNud_ValueChanged(object sender, EventArgs e)
        {
            Initialized = false;
        }
    }
}