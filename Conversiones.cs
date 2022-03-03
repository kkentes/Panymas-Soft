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
    public partial class Conversiones : Form
    {
        public Conversiones()
        {
            InitializeComponent();
        }

        private void Conversiones_Load(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
            comboBox1.Items.Clear();
            //ComboBox1
            comboBox1.Items.Add("Onzas (Oz)");
            comboBox1.Items.Add("Libras (Lb)");
            comboBox1.Items.Add("Tazas");
            comboBox1.Items.Add("Kilogramo (Kg)");
            comboBox1.Items.Add("Gramos (g)");
            comboBox1.Items.Add("Cucharadas");
            //ComboBox2
            comboBox2.Items.Add("Libras (Lb)");
            comboBox2.Items.Add("Onzas (Oz)");
            comboBox2.Items.Add("Tazas");
            comboBox2.Items.Add("Kilogramo (Kg)");
            comboBox2.Items.Add("Gramos (g)");
            comboBox2.Items.Add("Cucharadas");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, r;
            n1 = Convert.ToDouble(textBox1.Text);
            //Onzas
            if (comboBox1.SelectedItem.ToString() == "Onzas (Oz)" && comboBox2.SelectedItem.ToString() == "Libras (Lb)")
            {
                r = n1 * 0.0625;
                textBox2.Text = r.ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "Libras (Lb)" && comboBox2.SelectedItem.ToString() == "Onzas (Oz)")
            {
                r = n1 / 0.0625;
                textBox2.Text = r.ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "Tazas" && comboBox2.SelectedItem.ToString() == "Onzas (Oz)")
            {
                r = n1 * 8;
                textBox2.Text = r.ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "Onzas (Oz)" && comboBox2.SelectedItem.ToString() == "Tazas")
            {
                r = n1 / 8;
                textBox2.Text = r.ToString();

            }

            if (comboBox1.SelectedItem.ToString() == "Kilogramo (Kg)" && comboBox2.SelectedItem.ToString() == "Onzas (Oz)")
            {
                r = n1 * 35.274;
                textBox2.Text = r.ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "Onzas (Oz)" && comboBox2.SelectedItem.ToString() == "Kilogramo (Kg)")
            {
                r = n1 / 35.274;
                textBox2.Text = r.ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "Cucharadas" && comboBox2.SelectedItem.ToString() == "Onzas (Oz)")
            {
                r = n1 * 0.5;
                textBox2.Text = r.ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "Onzas (Oz)" && comboBox2.SelectedItem.ToString() == "Cucharadas")
            {
                r = n1 / 0.5;
                textBox2.Text = r.ToString();
            }

            //Kilogramos
            if (comboBox1.SelectedItem.ToString() == "Kilogramo (Kg)" && comboBox2.SelectedItem.ToString() == "Libras (Lb)")
            {
                r = n1 * 2.20;
                textBox2.Text = r.ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "Libras (Lb)" && comboBox2.SelectedItem.ToString() == "Kilogramo (Kg)")
            {
                r = n1 / 2.20;
                textBox2.Text = r.ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "Kilogramo (Kg)" && comboBox2.SelectedItem.ToString() == "Gramos (g)")
            {
                r = n1 * 1000;
                textBox2.Text = r.ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "Gramos (g)" && comboBox2.SelectedItem.ToString() == "Kilogramo (Kg)")
            {
                r = n1 / 1000;
                textBox2.Text = r.ToString();
            }
            // Gramos
            if (comboBox1.SelectedItem.ToString() == "Gramos (g)" && comboBox2.SelectedItem.ToString() == "Libras (Lb)")
            {
                r = n1 / 453.592;
                textBox2.Text = r.ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "Libras (Lb)" && comboBox2.SelectedItem.ToString() == "Gramos (g)")
            {
                r = n1 * 453.592;
                textBox2.Text = r.ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "Gramos (g)" && comboBox2.SelectedItem.ToString() == "Onzas (Oz)")
            {
                r = n1 / 28.3495;
                textBox2.Text = r.ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "Onzas (Oz)" && comboBox2.SelectedItem.ToString() == "Gramos (g)")
            {
                r = n1 * 28.3495;
                textBox2.Text = r.ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "Gramos (g)" && comboBox2.SelectedItem.ToString() == "Cucharadas")
            {
                r = n1 / 15;
                textBox2.Text = r.ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "Cucharadas" && comboBox2.SelectedItem.ToString() == "Gramos (g)")
            {
                r = n1 * 15;
                textBox2.Text = r.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}
