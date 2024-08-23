using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void repositorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proyectoToolStripMenuItem.Enabled = !proyectoToolStripMenuItem.Enabled; // para deshabilitar 'proyecto'
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PrintDialog.showDialog();
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Acrobat PDFs|*.pdf|Documentos Word|*.docx;*.doc"; // * -> para completar lo q sigue / |-> para filtro
            //openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
        }

        private void fuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;

            fontDialog1.ShowDialog();
            MessageBox.Show(fontDialog1.Font.ToString());
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(openFileDialog1.FileName);
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            richTextBox1.Width = this.Width - 40;
            richTextBox1.Height = this.Height - 80;
        }
    }
}
