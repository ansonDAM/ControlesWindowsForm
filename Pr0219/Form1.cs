using System.Windows.Forms;

namespace Pr0219
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
            comboBox1.DataSource = _coches.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coche coche = (Coche)comboBox1.SelectedItem;
            textBox1.Text = coche.Marca;
            textBox2.Text = coche.Modelo;
            textBox3.Text = coche.Precio.ToString();
        }
    }
}