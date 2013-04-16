using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(this.numero1.Text);
            int numero2 = int.Parse(this.numero2.Text);
            int operacion = (numero1 + numero2);
            this.resultado.Text = operacion.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            int numero1 = int.Parse(this.numero1.Text);
            int numero2 = int.Parse(this.numero2.Text);
            int operacion = (numero1 - numero2);
            this.resultado.Text = operacion.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(this.numero1.Text);
            int numero2 = int.Parse(this.numero2.Text);
            int operacion = (numero1 * numero2);
            this.resultado.Text = operacion.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(this.numero1.Text);
            int numero2 = int.Parse(this.numero2.Text);
            int operacion = (numero1 / numero2);
            this.resultado.Text = operacion.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
