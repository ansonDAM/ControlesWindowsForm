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
            for (int i = 1; i < 11; i++)
            {
                listBox1.Items.Add("Alumno " + i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (object i in listBox1.SelectedItems)
            {
                listBox2.Items.Add(i);
            }

            foreach (object i in listBox2.Items)
            {
                listBox1.Items.Remove(i);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (object i in listBox1.Items)
            {
                listBox2.Items.Add(i);
            }
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (object i in listBox2.Items)
            {
                listBox1.Items.Add(i);
            }
            listBox2.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (object i in listBox2.SelectedItems)
            {
                listBox1.Items.Add(i);
            }

            foreach (object i in listBox1.Items)
            {
                listBox2.Items.Remove(i);
            }
        }

        private void saliraltf4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}