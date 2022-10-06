namespace Pr0216
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Form2 form2 = new Form2();
            if (form2.ShowDialog().Equals(DialogResult.OK))
            {
                
            } else
            {
                MessageBox.Show("Operación cancelada por el usuario.");
            }
        }
    }
}