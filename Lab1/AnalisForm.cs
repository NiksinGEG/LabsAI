using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public enum ChangableValues { MaxTemperature, MinTemperature, Steps, Alpha, N }
    public partial class AnalisForm : Form
    {
        public List<Tuple<float, float>> EnergyByTemperature { get; set; }

        public List<Tuple<int, float>> BadChosesByTemperature { get; set; }

        public ChangableValues ChangableValue { get; set; }

        private readonly int _valueControlsNum = 5;

        private Control[] _valueControls;

        private bool _stop = false;

        public AnalisForm()
        {
            InitializeComponent();

            _valueControls = new Control[_valueControlsNum];
            _valueControls[0] = finNud1;
            _valueControls[1] = finNud2;
            _valueControls[2] = finNud3;
            _valueControls[3] = finNud4;
            _valueControls[4] = finNud5;

            EnergyByTemperature = new List<Tuple<float, float>>();

            BadChosesByTemperature = new List<Tuple<int, float>>();
        }

        private void RadioChoose(int num)
        {
            for(int i = 0; i < _valueControlsNum; i++)
            {
                _valueControls[i].Enabled = i == (num - 1);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioChoose(1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioChoose(2);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioChoose(3);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioChoose(4);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioChoose(5);
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            var curParams = GetInitialParams();
            var finParams = GetFinalParams();

            progressBar1.Maximum = (int)GetChangeableValue(curParams);
            progressBar1.Minimum = (int)GetChangeableValue(finParams);
            progressBar1.Value = progressBar1.Maximum - (int)GetChangeableValue(curParams) + progressBar1.Minimum;

            _stop = false;

            Task.Factory.StartNew(() =>
            {
                while (!_stop && !ParamsAreEqual(curParams, finParams))
                {
                    var optimizer = new NQueenSolver(
                        curParams.N,
                        curParams.MaxTemperature,
                        curParams.MinTemperature,
                        curParams.Steps,
                        curParams.Alpha);
                    optimizer.Initialize();

                    optimizer.OnBadSolutionChoses += AddBadChoseByTemp;

                    var solution = optimizer.GetSolution();
                    var nrg = optimizer.CountEnergy(solution);
                    EnergyByTemperature.Add(new Tuple<float, float>(nrg, GetInitialParams().MaxTemperature));

                    curParams = DicreaseValue(curParams);
                    progressBar1.BeginInvoke(() => progressBar1.Value = progressBar1.Maximum - (int)GetChangeableValue(curParams) + progressBar1.Minimum);
                }
            });
            
        }

        private void AddBadChoseByTemp(object? optimizer, EventArgs _)
        {
            NQueenSolver op = optimizer as NQueenSolver;
            var elem = BadChosesByTemperature.FirstOrDefault(x => x.Item2 == op.Temperature);
            if(elem != null)
            {
                elem = new Tuple<int, float>(elem.Item1 + 1, elem.Item2);
            }
            else
            {
                BadChosesByTemperature.Add(new Tuple<int, float>(1, op.Temperature));
            }
        }

        private FireParameters GetInitialParams()
        {
            return new FireParameters
            {
                MaxTemperature = (float)startNud1.Value,
                MinTemperature = (float)startNud2.Value,
                Steps = (int)startNud3.Value,
                Alpha = (float)startNud4.Value,
                N = (int)startNud5.Value
            };
        }

        private FireParameters GetFinalParams()
        {
            return new FireParameters
            {
                MaxTemperature = (float)(radioButton1.Checked ? finNud1.Value : startNud1.Value),
                MinTemperature = (float)(radioButton2.Checked ? finNud2.Value : startNud2.Value),
                Steps = (int)(radioButton3.Checked ? finNud3.Value : startNud3.Value),
                Alpha = (float)(radioButton4.Checked ? finNud4.Value : startNud4.Value),
                N = (int)(radioButton5.Checked ? finNud5.Value : startNud5.Value),
            };
        }

        private bool ParamsAreEqual(FireParameters p1, FireParameters p2)
        {
            return p1.MaxTemperature == p2.MaxTemperature
                && p1.MinTemperature == p2.MinTemperature
                && p1.Steps == p2.Steps
                && p1.Alpha == p2.Alpha
                && p1.N == p2.N;
        }

        private float GetChangeableValue(FireParameters fParams)
        {
            switch (ChangableValue)
            {
                case ChangableValues.MaxTemperature:
                    return (float)fParams.MaxTemperature;
                case ChangableValues.MinTemperature:
                    return (float)fParams.MinTemperature;
                case ChangableValues.Steps:
                    return (float)fParams.Steps;
                case ChangableValues.Alpha:
                    return (float)fParams.Alpha;
                case ChangableValues.N:
                    return (float)fParams.N;
                default:
                    return 1f;
            }
        }

        private float GetChangeStep()
        {
            switch(ChangableValue)
            {
                case ChangableValues.MaxTemperature:
                    return (float)startNud1.Increment;
                case ChangableValues.MinTemperature:
                    return (float)startNud2.Increment;
                case ChangableValues.Steps:
                    return (float)startNud3.Increment;
                case ChangableValues.Alpha:
                    return (float)startNud4.Increment;
                case ChangableValues.N:
                    return (float)startNud5.Increment;
                default:
                    return 1f;
            }
        }

        private FireParameters DicreaseValue(FireParameters current)
        {
            switch(ChangableValue)
            {
                case ChangableValues.MaxTemperature:
                    current.MaxTemperature -= GetChangeStep();
                    break;
                case ChangableValues.MinTemperature:
                    current.MinTemperature -= GetChangeStep();
                    break;
                case ChangableValues.Alpha:
                    current.Alpha -= GetChangeStep();
                    break;
                case ChangableValues.Steps:
                    current.Steps -= (int)GetChangeStep();
                    break;
                case ChangableValues.N:
                    current.N -= (int)GetChangeStep();
                    break;
            }
            return current;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            _stop = true;
        }
    }
}
