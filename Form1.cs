using System.IO;

namespace Form1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SalvarClick(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void SalvarOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string caminho = saveFileDialog1.FileName;
            File.WriteAllText(caminho, Txbjanela.Text);
        }
    }
}