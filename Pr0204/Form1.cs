namespace Pr0204
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                try
                {
                    double resultado = Double.Parse(this.textBox1.Text) + Double.Parse(this.textBox2.Text);
                    this.textBox3.Text = resultado.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else if (radioButton2.Checked)
            {
                try
                {
                    double resultado = Double.Parse(this.textBox1.Text) * Double.Parse(this.textBox2.Text);
                    this.textBox3.Text = resultado.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (radioButton3.Checked)
            {
                try
                {
                    double resultado = Double.Parse(this.textBox1.Text) - Double.Parse(this.textBox2.Text);
                    this.textBox3.Text = resultado.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (radioButton4.Checked)
            {
                try
                {
                    double resultado = Double.Parse(this.textBox1.Text) / Double.Parse(this.textBox2.Text);
                    this.textBox3.Text = resultado.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}