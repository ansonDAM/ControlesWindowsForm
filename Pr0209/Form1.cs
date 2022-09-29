namespace Pr0209
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = false;
            } 
        }
    }
}