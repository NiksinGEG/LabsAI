using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1Framework
{
    public class FieldDrawer
    {
        public Control Canvas { get; set; }
        public FieldDrawer(Control canvas)
        {
            Canvas = canvas;
        }
        public void DrawField(int[] solution)
        {
            int n = solution.Length;
            var cellWidth = Canvas.Width / (float)n;
            Graphics g = Canvas.CreateGraphics();
            g.Clear(Color.White);
            DrawGrid(g, cellWidth, n);

            for (int i = 0; i < n; i++)
            {
                DrawQueen(g, i, solution[i], cellWidth);
                for (int j = 0; j < n; j++)
                    if (i != j && (Math.Abs(i - j) == Math.Abs(solution[i] - solution[j])))
                        DrawLine(g, i, solution[i], j, solution[j], cellWidth);
            }
        }

        private void DrawGrid(Graphics g, float cellWidth, int n)
        {
            SolidBrush sb = new SolidBrush(Color.Black);
            Pen blackLnPen = new Pen(sb, 3);

            for (int i = 0; i < n + 1; i++)
            {
                int curPos = (int)(cellWidth * i);

                Point p1 = new Point(curPos, 0);
                Point p2 = new Point(curPos, Canvas.Height);
                g.DrawLine(blackLnPen, p1, p2);

                p1 = new Point(0, curPos);
                p2 = new Point(Canvas.Width, curPos);
                g.DrawLine(blackLnPen, p1, p2);
            }
        }

        private void DrawQueen(Graphics g, int col, int row, float cellWidth)
        {
            SolidBrush sb = new SolidBrush(Color.Black);
            g.FillEllipse(
                sb,
                col * cellWidth,
                row * cellWidth,
                cellWidth,
                cellWidth);
        }

        private void DrawLine(Graphics g, int col1, int row1, int col2, int row2, float cellWidth)
        {
            var p1 = new Point((int)(col1 * cellWidth + (cellWidth / 2)), (int)(row1 * cellWidth + (cellWidth / 2)));
            var p2 = new Point((int)(col2 * cellWidth + (cellWidth / 2)), (int)(row2 * cellWidth + (cellWidth / 2)));
            SolidBrush sb = new SolidBrush(Color.Red);
            Pen pen = new Pen(sb, 2);
            g.DrawLine(pen, p1, p2);
        }
    }
}
