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
    public partial class Pantalla : Form
    {
        public Pantalla()
        {
            InitializeComponent();
        }
        public int timeLeft { get; set; }
        private void Pantalla_Load(object sender, EventArgs e)
        {
            timeLeft = 25;
            Tiempo.Start();
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {

            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                Tiempo.Stop();
                new Menu().Show();
                this.Hide();
            }
        }
    }
}
