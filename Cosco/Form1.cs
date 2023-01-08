namespace Cosco
{
    public partial class Form1 : Form
    {
        private PictureInput _pinp1;
        private PictureInput _pinp2;
        private CoscoNetwork _net;

        public Form1()
        {
            InitializeComponent();

            int imageSize = 4;
            int assocSize = 3;
            _pinp1 = new PictureInput(pictureBox1, imageSize);
            _pinp2 = new PictureInput(pictureBox2, assocSize);
            _net = new CoscoNetwork(imageSize * imageSize, assocSize * assocSize);
        }

        private void eraseBtn1_Click(object sender, EventArgs e)
        {
            _pinp1.Reset();
        }

        private void eraseBtn2_Click(object sender, EventArgs e)
        {
            _pinp2.Reset();
        }

        private void learnBtn_Click(object sender, EventArgs e)
        {
            var prototypes = DataSaver.FromFile(fileNameTb.Text);
            foreach (var prot in prototypes)
                _net.AddPrototype(prot.Image.Select(x => (double)x), prot.Association.Select(x => (double)x));
        }

        private IEnumerable<double> MapPixels(PictureInput pinp)
        {
            var res = new double[pinp.Size * pinp.Size];
            for (int i = 0; i < pinp.Size; i++)
                for (int j = 0; j < pinp.Size; j++)
                    res[i * pinp.Size + j] = pinp.Pixels[i, j];
            return res;
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            var dialogRes = openFileDialog.ShowDialog();
            if (dialogRes == DialogResult.OK) fileNameTb.Text = openFileDialog.FileName;
        }

        private void associateBtn1_Click(object sender, EventArgs e)
        {
            if (!_net.TryAssociate(MapPixels(_pinp1), out var res)) 
                MessageBox.Show("Близких ассоциаций среди запомненных не найдено.");
            _pinp1.SetPixels(res.img.Select(x => x > 0 ? 1 : 0));
            _pinp2.SetPixels(res.assoc.Select(x => x > 0 ? 1 : 0));
        }

        private void associateBtn2_Click(object sender, EventArgs e)
        {
            if(!_net.TryImagine(MapPixels(_pinp2), out var res))
                MessageBox.Show("Близких ассоциаций среди запомненных не найдено.");
            _pinp1.SetPixels(res.img.Select(x => x > 0 ? 1 : 0));
            _pinp2.SetPixels(res.assoc.Select(x => x > 0 ? 1 : 0));
        }

        private void addAccosBtn_Click(object sender, EventArgs e)
        {
            DataSaver.Save(fileNameTb.Text, new SaveDataModel()
            {
                Image = MapPixels(_pinp1).Select(x => x > 0 ? 1 : -1),
                Association = MapPixels(_pinp2).Select(x => x > 0 ? 1 : -1)
            });
        }
    }
}