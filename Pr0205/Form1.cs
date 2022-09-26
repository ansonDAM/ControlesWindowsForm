namespace Pr0205
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Si continúa, su familia morirá. ¿Qué desea hacer?", "Alerta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
             if (option == DialogResult.Yes)
            {
                MessageBox.Show("Has elegido dejar morir a tu familia.");
            } else if (option == DialogResult.No)
            {
                MessageBox.Show("Has elegido dejar vivir a tu familia.");
            } else if (option == DialogResult.Cancel)
            {
                MessageBox.Show("Cagueta.");
            }
        }
    }
}