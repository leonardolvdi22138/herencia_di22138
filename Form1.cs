using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void suma_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija sumar
            sumar suma = new sumar(); //instancie, o hice un nuevo objeto suma 

            textBox3.Text = suma.operar (float.Parse(textBox1.Text), float.Parse(textBox2.Text)).ToString();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija sumar
            restar resta = new restar (); //instancie, o hice un nuevo objeto suma 

            textBox3.Text = resta.operar(float.Parse(textBox1.Text), float.Parse(textBox2.Text)).ToString();
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija sumar
            multiplicar multiplicar = new multiplicar (); //instancie, o hice un nuevo objeto suma 

            textBox3.Text = multiplicar.operar(float.Parse(textBox1.Text), float.Parse(textBox2.Text)).ToString();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dividir_Click(object sender, EventArgs e)
        {

            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija sumar
            dividir dividir = new dividir(); //instancie, o hice un nuevo objeto suma 

            textBox3.Text = dividir.operar(float.Parse(textBox1.Text), float.Parse(textBox2.Text)).ToString();
        }
    }
}
