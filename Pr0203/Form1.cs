namespace Pr0203
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Enabled = false;
                textBox4.Text = textBox1.Text;
                textBox3.Enabled = false;
                textBox3.Text = textBox2.Text;
            }
            else
            {
                textBox4.Enabled = true;
                textBox3.Enabled = true;
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
    }
}