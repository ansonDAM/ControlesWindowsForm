namespace Pr0210
{
    public partial class Form1 : Form
    {
        private Bitmap imagen;
        int width;
        int heigth;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult seleccion = openFileDialog1.ShowDialog(this);
            if (seleccion.Equals(DialogResult.OK)) {
                imagen = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = imagen;
                width = imagen.Width;
                heigth = imagen.Height;
            }  
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Size newSize = new Size(width+trackBar1.Value, heigth+trackBar1.Value);
            pictureBox1.Image = new Bitmap(imagen, newSize);
        }
    }
}