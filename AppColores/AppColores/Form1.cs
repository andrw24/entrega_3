using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppColores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = " ";
            if (chkColor1.Checked == true)
            {
                MessageBox.Show("El color seleccionado es amarillo");
            }
            if (chkColor2.Checked == true)
            {
                MessageBox.Show("El color seleccionado es azul");
            }
            if (chkColor3.Checked == true)
            {
                MessageBox.Show("El color seleccionado es rojo");
            }
        }
    }
}
