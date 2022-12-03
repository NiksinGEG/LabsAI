using Lab5.Controllers;
using OxyPlot;
using OxyPlot.Series;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private readonly Field _field;

        private readonly MainController _controller;

        private PlotModel _model;

        private LineSeries _plotSeries;

        public Form1()
        {
            InitializeComponent();
            _field = new Field(mainCanvas);
            _model = new PlotModel();
            _plotSeries = new LineSeries();
            _model.Series.Add(_plotSeries);
            _model.Title = "Лучший результат в поколении";
            plotView1.Model = _model;
            _controller = new MainController();
            _controller.OnIterationStep += OnStep;
        }

        private async void solveBtn_Click(object sender, EventArgs e)
        {
            if (_controller.IsRunning)
            {
                _controller.Cancel();
            }
            else
            {
                _plotSeries.Points.Clear();
                var matrix = new Color[0, 0];
                solveBtn.Text = "Остановить";
                matrix = await _controller.GetSolutionAsync(
                    (int)populationNud.Value,
                    (int)rowCountNud.Value,
                    (int)colCountNud.Value,
                    (double)crossNud.Value,
                    (int)mutationNud.Value,
                    (uint)maxIterationsNud.Value);
                solveBtn.Text = "Решить";
                weighsLbl.Text = "Соприкосновений: " + _controller.Weigh.ToString();
                _field.Draw(matrix);
            }
        }

        private void OnStep(object? _, (int iteration, int weigh) e)
        {
            _plotSeries.Points.Add(new DataPoint(e.iteration, e.weigh));
            plotView1.Invoke(() => plotView1.Refresh());
        }
    }
}