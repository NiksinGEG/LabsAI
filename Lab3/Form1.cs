using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Drawing;
using Lab3.Events;
using Lab3.Graphs;
using Lab3.Input;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private GraphInputHandler _ih;
        private Graph _g;
        private delegate void UpdatePb(int newVal);
        private delegate void UpdateC(int x, double y);
        public Form1()
        {
            InitializeComponent();

            _g = new Graph();
            _ih = new GraphInputHandler(pictureBox1, _g);
        }

        private async void solveBtn_Click(object sender, EventArgs e)
        {
            var metrix = GetPathFinderParams();

            var pathFinder = new AntPathFinder(_g.ToMatrix(), metrix);

            mainChart.Series[0].Points.Clear();
            mainChart.ChartAreas[0].AxisX.IsStartedFromZero = false;
            mainChart.ChartAreas[0].AxisY.IsStartedFromZero = false;
            progressBar.Minimum = 0;
            progressBar.Maximum = pathFinder.Metrix.MaxIterations;
            progressBar.Value = 0;
            pathFinder.OnIterationEnd += UpdateForm;

            var path = await Task.Factory.StartNew(pathFinder.FindPath);
            resLbl.Text = $"Длина пути: {GetLength(path)}";
            var drawer = new GraphDrawer(pictureBox1);
            drawer.DrawGraph(_g);
            drawer.DrawPathByGraph(_g, path);
        }

        private PathFinderMetrix GetPathFinderParams()
        {
            PathFinderMetrix metrix = new PathFinderMetrix();
            metrix.FermentWeight = (double)weightNud.Value;
            metrix.Heuristic = (double)heurNud.Value;
            metrix.Volatility = (double)volatilityNud.Value;
            metrix.MaxIterations = (int)iterationsNud.Value;
            metrix.ColonySize = (int)colonyNud.Value;
            metrix.Strength = (double)qNud.Value;
            return metrix;
        }

        private void UpdateForm(object pathFinder, GraphEventArgs e)
        {
            UpdatePb del1 = new UpdatePb(SetNewPbVal);
            UpdateC del2 = new UpdateC(UpdateChart);
            progressBar.BeginInvoke(del1, e.Iterations);
            mainChart.BeginInvoke(del2, e.Iterations, e.Length);
        }

        private void SetNewPbVal(int value)
        {
            progressBar.Value = value;
        }

        private void UpdateChart(int x, double y)
        {
            mainChart.Series[0].Points.AddXY(x, y);
        }

        private double GetLength(int[] path)
        {
            double res = 0;
            for(int i = 0; i < path.Length - 1; i++)
            {
                var x1 = _g.Vertices.ElementAt(i).X * 100;
                var y1 = _g.Vertices.ElementAt(i).Y * 100;
                var x2 = _g.Vertices.ElementAt(i + 1).X * 100;
                var y2 = _g.Vertices.ElementAt(i + 1).Y * 100;
                res += Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            }
            return res;
        }
    }
}
