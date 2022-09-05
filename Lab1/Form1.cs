namespace Lab1
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public int N { get; set; }

        public float Alpha { get; set; } = 0.98f;

        public Form1()
        {
            InitializeComponent();
        }

        private int[] Initialize()
        {
            int[] res = new int[N];
            for (int i = 0; i < N; i++)
                res[i] = i;
            return res;
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
            return t * Alpha;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            N = (int)sizeNud.Value;
            var arr = Initialize();
            RedrawField(arr);
        }

        private void RedrawField(int[] solution)
        {
            int n = solution.Length;
            var cellWidth = pictureBox1.Width / (float)n;
            Graphics g = pictureBox1.CreateGraphics();
            DrawGrid(g, cellWidth, n);

            SolidBrush sb = new SolidBrush(Color.Black);
            Pen blackLnPen = new Pen(sb, 3);

            
            for (int i = 0; i < solution.Length; i++)
            {
                DrawQueen(g, i, solution[i], cellWidth);
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
                Point p2 = new Point(curPos, pictureBox1.Height);
                g.DrawLine(blackLnPen, p1, p2);

                p1 = new Point(0, curPos);
                p2 = new Point(pictureBox1.Width, curPos);
                g.DrawLine(blackLnPen, p1, p2);
            }
        }

        private void DrawQueen(Graphics g, int col, int row, float cellWidth)
        {
            SolidBrush sb = new SolidBrush(Color.Black);
            Pen blackLnPen = new Pen(sb, 3);
            g.DrawEllipse(
                blackLnPen,
                col * cellWidth,
                row * cellWidth,
                cellWidth,
                cellWidth);
        }

        private void evalBtn_Click(object sender, EventArgs e)
        {
            N = (int)sizeNud.Value;
            Alpha = (float)alphaNud.Value;
            var temp = (float)tempNud.Value;

            var solution = Initialize();

            var optimizer = new FireOptimizer<int>(N, temp, 0.5f, 100);
            optimizer.Initialize(solution);
            solution = optimizer.GetSolution(CountFullEnergy, TemperatureFunc);
            RedrawField(solution);
        }
    }
}