namespace Pr0211
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = openFileDialog1.ShowDialog();
            if (dialogo.Equals(DialogResult.OK))
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = saveFileDialog1.ShowDialog();
            if (dialogo.Equals(DialogResult.OK))
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = fontDialog1.ShowDialog();
            if (dialogo.Equals(DialogResult.OK))
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = colorDialog1.ShowDialog();
            if (dialogo.Equals(DialogResult.OK))
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = colorDialog1.ShowDialog();
            if (dialogo.Equals(DialogResult.OK))
            {
                richTextBox1.SelectionBackColor = colorDialog1.Color;
            }
        }



    }
}