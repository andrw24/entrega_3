using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            float numero1, numero2, suma;
            numero1 = float.Parse(textBox1.Text);
            numero2 = float.Parse(textBox2.Text);
            suma=numero1+numero2;
            MessageBox.Show("La suma es: " + suma);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            float numero1, numero2, resta;
            numero1 = float.Parse(textBox1.Text);
            numero2 = float.Parse(textBox2.Text);
            resta = numero1 - numero2;
            MessageBox.Show("La resta es: " + resta);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            float numero1, numero2, mult;
            numero1 = float.Parse(textBox1.Text);
            numero2 = float.Parse(textBox2.Text);
            mult = numero1 * numero2;
            MessageBox.Show("La multiplicación es: " + mult);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            float numero1, numero2, div;
            numero1 = float.Parse(textBox1.Text);
            numero2 = float.Parse(textBox2.Text);
            div = numero1 / numero2;
            MessageBox.Show("La división es: " + div);
        }
    }
}
