using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Lab3.Graphs;

namespace Lab3.Drawing
{
    public class GraphDrawer
    {
        private Control _canvas;

        public GraphDrawer(Control canvas)
        {
            _canvas = canvas;
        }

        public void DrawGraph(Graph graph)
        {
            Graphics g = _canvas.CreateGraphics();
            g.Clear(Color.White);

            foreach (var v in graph.Vertices) DrawVertice(g, v);
        }

        public void DrawPathByGraph(Graph graph, IEnumerable<int> path)
        {
            Graphics g = _canvas.CreateGraphics();
            for(int i = 0; i < path.Count() - 1; i++)
            {
                var cur = path.ElementAt(i);
                var next = path.ElementAt(i + 1);
                DrawLine(g, graph.Vertices.ElementAt(cur), graph.Vertices.ElementAt(next));
            }
        }

        private void DrawLine(Graphics g, Vertice v1, Vertice v2)
        {
            Brush b = new SolidBrush(Color.Black);
            Pen p = new Pen(b, 3f);
            g.DrawLine(p, v1.PixelX, v1.PixelY, v2.PixelX, v2.PixelY);
        }

        private void DrawVertice(Graphics g, Vertice vert)
        {
            Brush b = new SolidBrush(Color.Black);
            int x = vert.PixelX - (vert.Diameter / 2);
            int y = vert.PixelY - (vert.Diameter / 2);
            g.FillEllipse(b, x, y, vert.Diameter, vert.Diameter);
        }
    }
}
