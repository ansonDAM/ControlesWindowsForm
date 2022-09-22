using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Pr0202
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
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

        }


        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (Double.Parse(textBox1.Text) == 0 || Double.Parse(textBox2.Text) == 0)
                {
                    MessageBox.Show("No se puede dividir entre 0 mongolo!!");
                    return;
                }
                double resultado = Double.Parse(this.textBox1.Text) / Double.Parse(this.textBox2.Text);
                this.textBox3.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //String patron = @"\d*\,{0,1}";
            //Match resultMatch = Regex.Match(textBox1.Text, patron);

            if (Char.IsLetter(e.KeyChar)) 
            {
                e.Handled = true;
            }
            
            //Debug.WriteLine(resultMatch.Value);
           
            
        }
    }
}