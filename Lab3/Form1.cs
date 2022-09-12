using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private double[,] Solution;
        private AntPathFinder PFinder;

        private int CurVert = 0;
        public Form1()
        {
            InitializeComponent();

            Solution = InitSolution();
            PathFinderMetrix metrix = new PathFinderMetrix();
            metrix.FermentWeight = 3;
            metrix.Heuristic = 1;
            metrix.Volatility = 0.6;
            PFinder = new AntPathFinder(Solution, metrix);
        }

        private string DrawPath(int[] path)
        {
            string res = string.Empty;
            foreach(var point in path)
            {
                res += $"{point} -> ";
            }
            return res;
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            var path = PFinder.FindPath(CurVert);
            testLbl.Text = DrawPath(path);
            lenLbl.Text = WayLen(path).ToString();
            CurVert++;
            if (CurVert >= Solution.GetLength(0)) CurVert = 0;
        }

        private double WayLen(int[] way)
        {
            double waylen = 0;
            for(int i = 0; i < way.Length; i++)
            {
                if(i != way.Length - 1)
                {
                    waylen += Solution[way[i], way[i + 1]];
                }
                else
                {
                    waylen += Solution[way[i], way[0]];
                }
            }
            return waylen;
        }

        private double[,] InitSolution()
        {
            double[,] a = new double[6, 6];
            a[0, 1] = 10;
            a[0, 2] = 15;
            a[0, 3] = 11;
            a[0, 4] = 2;
            a[0, 5] = 55;

            a[1, 0] = a[0, 1];
            a[1, 2] = 16;
            a[1, 3] = 18;
            a[1, 4] = 21;
            a[1, 5] = 13;

            a[2, 0] = a[0, 2];
            a[2, 1] = a[1, 2];
            a[2, 3] = 39;
            a[2, 4] = 22;
            a[2, 5] = 3;

            a[3, 0] = a[0, 3];
            a[3, 1] = a[1, 3];
            a[3, 2] = a[2, 3];
            a[3, 4] = 28;
            a[3, 5] = 25;

            a[4, 0] = a[0, 4];
            a[4, 1] = a[1, 4];
            a[4, 2] = a[2, 4];
            a[4, 3] = a[3, 4];
            a[4, 5] = 2;

            a[5, 0] = a[0, 5];
            a[5, 1] = a[1, 5];
            a[5, 2] = a[2, 5];
            a[5, 3] = a[3, 5];
            a[5, 4] = a[4, 5];

            return a;
        }
    }
}
