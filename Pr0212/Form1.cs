namespace Pr0212
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                //Se asigna la carpeta seleccionada al TextBox
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                //Se crea un objeto de la clase DirectoryInfo para obtener
                //información del directorio
                DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                //Se crea el nodo raiz del TreeView
                TreeNode node = new TreeNode(directoryInfo.Name);
                node.Tag = directoryInfo.FullName;
                //Se recorrer los subdirectorios
                RecorrerSubdirectorios(directoryInfo, node);
                //Se añade el nodo raiz al treeView
                treeView1.Nodes.Add(node);
            }
        }
        private void RecorrerSubdirectorios(DirectoryInfo directoryInfo, TreeNode node)
        {
            //Se recorren los subdirectorios del directorio recibido por parámetro
            foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
            {
                //Se crea el nodo hijo
                TreeNode nodoHijo = new TreeNode(directory.Name);
                nodoHijo.Tag = directory.FullName;
                //Se llama a recursividad
                RecorrerSubdirectorios(directory, nodoHijo);
                //Se añade el nodo al nodo padre
                node.Nodes.Add(nodoHijo);
            }
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            listView1.Items.Clear();

            DirectoryInfo directoryInfo = new DirectoryInfo(treeView1.SelectedNode.Tag.ToString());
            //Se recorren los subdirectorios del directorio
            foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
            {
                //Se añaden al listview
                ListViewItem item = new ListViewItem(directory.Name);
                item.SubItems.Add("Directorio");
                item.ImageIndex = 0;
                listView1.Items.Add(item);
            }
            //Se recorren los ficheros del directorio
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
               // Se añaden al listview
                    ListViewItem item = new ListViewItem(file.Name);
                item.SubItems.Add(file.Extension);
                item.SubItems.Add(file.LastWriteTime.ToString());
                item.ImageIndex = 1;
                listView1.Items.Add(item);
            }
        }
    }
}
