namespace Pr0218
{
    public partial class Form1 : Form
    {
        private List<Coche> _coches;
        public Form1()
        {
            InitializeComponent();
            _coches = new List<Coche>();
            cargarDatos();
        }

        public void cargarDatos()
        {
            Coche seat = new Coche();
            seat.Marca = "Seat";
            seat.Modelo = "León";
            seat.Precio = 12000;
            Coche dacia = new Coche();
            dacia.Marca = "Dacia";
            dacia.Modelo = "Logan";
            dacia.Precio = 9000;
            Coche mercedes = new Coche();
            mercedes.Marca = "Mercedes";
            mercedes.Modelo = "ClaseC";
            mercedes.Precio = 15000;
            _coches.Add(seat);
            _coches.Add(dacia);
            _coches.Add(mercedes);  
            dataGridView1.DataSource = _coches.OrderBy(x => x.Precio).ToList();
        }

        private void CargarListaFiltradaOrdenada(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                dataGridView1.DataSource = _coches.OrderByDescending(x => x.Precio).ToList();
            }
            if (radioButton1.Checked)
            {
                dataGridView1.DataSource = _coches.OrderBy(x => x.Precio).ToList();
            }
        }
        private void OrdenarPorTextBox(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                dataGridView1.DataSource = _coches.Where(x => x.Marca.ToUpper().Contains(textBox1.Text.ToUpper())).ToList();
            } else
            {
                dataGridView1.DataSource = _coches.OrderBy(x => x.Precio).ToList();
            }
        }
    }
}