using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void btnVentana1_Click(object sender, EventArgs e)
            {
            Form1 Ventana1 = new Form1();
            Ventana1.Show();
            this.Hide();
            }

            private void btnVentana2_Click(object sender, EventArgs e)
            {
            MessageBox.Show("ya estás acá pelotudo(insertar ideas de diseño para que quede lindo estas son las ventanas y listo pero va a ir mejorando como aplicación hasta poder llegar a sorprender a grandes titanes de la industria y ganar millones)");

        }

        private void btnVentana3_Click(object sender, EventArgs e)
            {
            Form3 Ventana3 = new Form3();
            Ventana3.Show();
                this.Hide();
            }

            private void btnVentana4_Click(object sender, EventArgs e)
            {
            Form4 Ventana4 = new Form4();
            Ventana4.Show();
            this.Hide();
            }

            private void btnVentana5_Click(object sender, EventArgs e)
            {
        Form5 Ventana5 = new Form5();
            Ventana5.Show();
            this.Hide();
            }

            private void btnVentana6_Click(object sender, EventArgs e)
            {
        Form6 Ventana6 = new Form6();
            Ventana6.Show();
                this.Hide();
            }

            private void btnVentana7_Click(object sender, EventArgs e)
            {
        Form7 Ventana7 = new Form7();
            Ventana7.Show();
                this.Hide();
            }

        }
    }
