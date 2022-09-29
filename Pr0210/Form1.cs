namespace Pr0210
{
    public partial class Form1 : Form
    {
        Bitmap imagen;
        int ancho;
        int largo;

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
            }  
        }
    }
}