using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void guardarRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Guardar = new Guardar();
            Guardar.Show();
            this.Hide();
        }

        private void mostrarRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Mostrar().Show();
            this.Hide();
        }

        private void conversionesBásicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Conversiones().Show();
            this.Hide();
        }

        public int timeleft { get; set; }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
            this.Hide();
        }

        private void conversionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
