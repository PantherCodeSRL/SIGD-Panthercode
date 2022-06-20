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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ocultar() {
            fLPanelEquipos.Visible = false;
            fLPanelJugadores.Visible = false;
            panelIngreso.Visible = false;
        }
        private void btnVentana1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ya estás acá pelotudo(insertar ideas de diseño para que quede lindo estas son las ventanas y listo pero va a ir mejorando como aplicación hasta poder llegar a sorprender a grandes titanes de la industria y ganar millones)");
        }

        private void btnVentana2_Click(object sender, EventArgs e)
        {
        Form2 Ventana2 = new Form2();
            Ventana2.Show();
            this.Hide();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            if (fLPanelEquipos.Visible==false)
            {
                ocultar();
                fLPanelEquipos.Visible = true;
            }else{
                ocultar();
                fLPanelEquipos.Visible = false;
            }
        }

        private void btnVentana4_Click(object sender, EventArgs e)
        {
            if (fLPanelJugadores.Visible == false)
            {
                ocultar();
                fLPanelJugadores.Visible = true;
            }
            else
            {
                ocultar();
                fLPanelJugadores.Visible = false;
            }
        }

        private void btnVentana5_Click(object sender, EventArgs e)
        {
            if (panelIngreso.Visible == false)
            {
                ocultar();
                panelIngreso.Visible = true;
            }
            else
            {
                ocultar();
                panelIngreso.Visible = false;
            }
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

        
        private void Form1_Load(object sender, EventArgs e)
        {
            ocultar();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form3 Equipos = new Form3();
            Equipos.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 Ventana4 = new Form4();
            Ventana4.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 Ventana5 = new Form5();
            Ventana5.Show();
            this.Hide();
        }
    }
}
