using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Principal
{
    public partial class Guardar : Form
    {
        public Guardar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Recets_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addingr_Click(object sender, EventArgs e)
        {
            string RutaArchivo = string.Empty;
            FolderBrowserDialog opn = new FolderBrowserDialog();
            if (opn.ShowDialog() == DialogResult.OK)
            {
                RutaArchivo = opn.SelectedPath;
            }
            string nametxt;
            nametxt = textBox1.Text;
            TextWriter writer = new StreamWriter(@RutaArchivo + "\\" + nametxt + ".txt", true);
            svmsj.Text = "Guardado...";
            string ingrediente = Ingr.Text;
            string proced = procdure.Text;
            writer.WriteLine("\n" + nametxt);
            writer.WriteLine("------------------------------------------------");
            writer.WriteLine(ingrediente);
            writer.WriteLine("------------------------------------------------");
            writer.WriteLine("\nProcedimiento\n");
            writer.WriteLine(proced);
            writer.Close();
        }

        private void leerRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Leer = new Mostrar();
            Leer.Show();
        }

        private void conversionesBasicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Conv = new Conversiones();
            Conv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}
