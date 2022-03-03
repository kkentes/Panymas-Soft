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
    public partial class Mostrar : Form
    {
        public Mostrar()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = textBox2.Text;
            textBox2.Text = "";
            string Ruta = string.Empty;
            FolderBrowserDialog x = new FolderBrowserDialog();
            if (x.ShowDialog() == DialogResult.OK)
            {
                Ruta = x.SelectedPath;
            }
            DirectoryInfo Drc = new DirectoryInfo(@Ruta);

            using (StreamReader reader = new StreamReader(@Ruta + "\\" + nombre + ".txt"))
            {
                string receta;
                while ((receta = reader.ReadLine()) != null)
                {
                    textBox1.AppendText(receta + "\n");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void nmb_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
