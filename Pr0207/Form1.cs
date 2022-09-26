namespace Pr0207
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void cargarDatos()
        {
            for (int i = 1; i < 10; i++)
            {
                listBox1.Items.Add("Alumno " + i);
            }
        }
    }
}