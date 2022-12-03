using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public class Field
    {
        private readonly Control _canvas;
        private readonly Graphics _g;

        public Field(Control canvas)
        {
            _canvas = canvas;
            _g = canvas.CreateGraphics();
        }

        /// <summary>
        /// Отрисовывает карту указанного размера указанными цветами
        /// </summary>
        /// <param name="colorMatrix">Матрица цветов. Размер матрицы определяет размер отрисовываемого поля</param>
        public void Draw(Color[,] colorMatrix)
        {
            _g.Clear(Color.White);
            var rows = colorMatrix.GetLength(0);
            var cols = colorMatrix.GetLength(1);
            var a = GetSide(rows, cols);
            var points = GetPointsBySize(rows, cols, a);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    DrawByPoint(colorMatrix[i,j], points[i, j], i, j, a);
        }

        private void DrawByPoint(Color c, Point p, int i, int j, int a)
        {
            var points = GetTriangleVertices(p, i, j, a);
            //var pen = new Pen(new SolidBrush(Color.Black), 2);
            _g.FillPolygon(new SolidBrush(c), points);
            //_g.FillClosedCurve(new SolidBrush(c), points);
            //_g.DrawLines(pen, points);
        }

        private Point[] GetTriangleVertices(Point center, int i, int j, int a)
        {
            var res = new Point[4];
            res[0] = new Point()
            {
                X = center.X,
                Y = center.Y + (int)((((i + j) % 2 == 0) ? 1 : -1) * 2*L(a)) //a / Math.Sqrt(3))
            };
            res[1] = new Point()
            {
                X = center.X - (a / 2),
                Y = center.Y - (int)((((i + j) % 2 == 0) ? 1 : -1) * L(a)) //a / (2 * Math.Sqrt(3)))
            };
            res[2] = new Point()
            {
                X = center.X + (a / 2),
                Y = center.Y - (int)((((i + j) % 2 == 0) ? 1 : -1) * L(a))//a / (2 * Math.Sqrt(3)))
            };
            res[3] = res[0];
            return res;
        }

        /// <summary>
        /// Получить длину стороны треугольника (в пикселях) по метрикам размерности
        /// </summary>
        /// <param name="rowCount">Число строк матрицы</param>
        /// <param name="colCount">Число столбцов</param>
        private int GetSide(int rowCount, int colCount)
        {
            int h = _canvas.Height / rowCount; // Высота треугольника
            int a = (int)(2.0 * h / Math.Sqrt(3)); // Сторона треугольника (до поправки на ширину)
            if (colCount * a > _canvas.Width) a = _canvas.Width / colCount; // Поправка на ширину
            return a;
        }

        /// <summary>
        /// Получить набор точек по метрикам размерности
        /// </summary>
        /// <param name="rowCount">Число строк матрицы</param>
        /// <param name="colCount">Число столбцов</param>
        /// <param name="a">Размер стороны треугольника</param>
        /// <returns>Массив координат центров будущих треугольников</returns>
        private Point[,] GetPointsBySize(int rowCount, int colCount, int a)
        {
            var res = new Point[rowCount, colCount];
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < colCount; j++)
                    res[i, j] = GetByIndexes(i, j, a);
            return res;
        }

        /// <summary>
        /// Получить координату центра очередного треугольника
        /// </summary>
        /// <param name="i">Номер строки</param>
        /// <param name="j">Номер столбца</param>
        /// <param name="a">Длина стороны треугольника (в пкс)</param>
        /// <returns></returns>
        private Point GetByIndexes(int i, int j, int a)
        {
            int x = (a / 2) + (a / 2 * j);
            double l = a / (2 * Math.Sqrt(3));
            double h = 3 * l;
            int y = (int)(((i + j) % 2 == 0 ? l : 2 * l) + h * i);
            return new Point(x, y);
        }

        private int L(int a)
        {
            return (int)Math.Ceiling(a / (2 * Math.Sqrt(3)));
        }
    }
}
