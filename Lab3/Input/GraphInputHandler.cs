using System;
using System.Windows.Forms;
using Lab3.Graphs;
using Lab3.Drawing;

namespace Lab3.Input
{
    public class GraphInputHandler
    {
        private Control _control;

        private Graph _graph;

        private GraphDrawer _drawer;

        public GraphInputHandler(Control control, Graph graph)
        {
            _control = control;
            _graph = graph;
            _drawer = new GraphDrawer(control);
            _control.MouseClick += HandleClick;
        }

        public void HandleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                HandleLkm(sender, e);
            if (e.Button == MouseButtons.Right)
                HandleRkm(sender, e);
            _drawer.DrawGraph(_graph);
        }

        private void HandleLkm(object sender, MouseEventArgs e)
        {
            var v = new Vertice
            {
                PixelX = e.X,
                PixelY = e.Y,
                X = (double)e.X / _control.Width,
                Y = (double)e.Y / _control.Height,
                Diameter = Math.Min(_control.Width, _control.Height) / 20
            };
            _graph.Vertices.Add(v);
        }

        private void HandleRkm(object sender, MouseEventArgs e)
        {
            var v = GetClicked(e.X, e.Y);
            if (v != null)
                _graph.Vertices.Remove(v);
        }

        private Vertice GetClicked(int x, int y)
        {
            foreach (var v in _graph.Vertices)
                if (Math.Sqrt(Math.Pow(x - v.PixelX, 2) + Math.Pow(y - v.PixelY, 2)) < v.Diameter)
                    return v;
            return null;
        }
    }
}
