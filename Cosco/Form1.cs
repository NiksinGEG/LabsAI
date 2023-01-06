namespace Cosco
{
    public partial class Form1 : Form
    {
        private PictureInput _pinp1;
        private PictureInput _pinp2;

        public Form1()
        {
            InitializeComponent();

            _pinp1 = new PictureInput(pictureBox1, 8);
            _pinp2 = new PictureInput(pictureBox2, 4);
        }

        private void eraseBtn1_Click(object sender, EventArgs e)
        {
            _pinp1.Reset();
        }

        private void eraseBtn2_Click(object sender, EventArgs e)
        {
            _pinp2.Reset();
        }
    }
}