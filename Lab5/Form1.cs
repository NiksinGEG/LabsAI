namespace Lab5
{
    public partial class Form1 : Form
    {
        private readonly Field _field;
        public Form1()
        {
            InitializeComponent();
            _field = new Field(mainCanvas);
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            var colors = new Color[] { Color.Green, Color.Blue, Color.Orange, Color.Red };
            var rnd = new Random();
            var matrix = new Color[10, 10];
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    matrix[i, j] = colors[rnd.Next(4)];
            _field.Draw(matrix);
        }
    }
}