using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public class PictureInput
    {
        public double[,] Pixels { get; set; }

        private Control _canvas;

        public int Size { get; set; }

        private Graphics _g { get; set; }

        public PictureInput(Control canvas, int size)
        {
            _canvas = canvas;
            _canvas.MouseClick += HandleClick;
            _g = _canvas.CreateGraphics();
            Size = size;
            Pixels = new double[size,size];
        }

        public void Draw()
        {
            _g.Clear(Color.White);
            DrawGrid();
            DrawPixels();
        }

        private void DrawGrid()
        {
            var b = new SolidBrush(Color.Black);
            var pen = new Pen(b, 3f);
            var cellSize = new Size(_canvas.Width / Size, _canvas.Height / Size);
            for(int i = 0; i < Size; i++)
            {
                var p1 = new Point(cellSize.Width * i, 0);
                var p2 = new Point(cellSize.Width * i, _canvas.Height);
                var p3 = new Point(0, cellSize.Height * i);
                var p4 = new Point(_canvas.Width, cellSize.Height * i);
                _g.DrawLine(pen, p1, p2);
                _g.DrawLine(pen, p3, p4);
            }
        }

        private void DrawPixels()
        {
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    DrawPixel(i, j, Pixels[i, j]);
        }

        private void DrawPixel(int i, int j, double val)
        {
            if (val <= 0.5)
                return;
            var cellSize = new Size(_canvas.Width / Size, _canvas.Height / Size);
            var b = new SolidBrush(Color.Black);
            _g.FillRectangle(b, cellSize.Width * j, cellSize.Height * i, cellSize.Width, cellSize.Height);
        }

        private void HandleClick(object sender, MouseEventArgs e)
        {
            var i = IndexByClick(e.X, e.Y);
            Pixels[i.Item1, i.Item2] = Pixels[i.Item1, i.Item2] > 0.5 ? 0 : 1;
            Draw();
        }

        private (int,int) IndexByClick(int x, int y)
        {
            var cellWidth = _canvas.Width / Size;
            int j = x / cellWidth;
            var cellHeight = _canvas.Height / Size;
            int i = y / cellHeight;
            return (i, j);
        }
    }
}
