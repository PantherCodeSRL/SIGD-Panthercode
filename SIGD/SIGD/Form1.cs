using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;


namespace SIGD
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }


        private void ocultar()
        {
            flowLayoutPanel1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            ocultar();
            InicioSesion iniciosesion = new InicioSesion();
            iniciosesion.Show();

        }
        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {

            int newX = (int)(OriginalControlRect.X);
            int newY = (int)(OriginalControlRect.Y);

            int newWidth = (int)(OriginalControlRect.Width - 2);
            int newHeight = (int)(OriginalControlRect.Height);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);



        }
        
        

        private void label1_click(object sender, EventArgs e)
        {
            Form1I form1I = new Form1I();
            form1I.Show();
            this.Hide();
        }

            private void button3_Click(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Minimized;
            }
             

            private void button1_Click(object sender, EventArgs e)
            {
                FH FH = new FH();
                FH.Show();
                this.Hide();
            }

            private void button12_Click(object sender, EventArgs e)
            {
                FF FF = new FF();
                FF.Show();
                this.Hide();
            }

            private void button9_Click(object sender, EventArgs e)
            {
                FB fb = new FB();
                fb.Show();
                this.Hide();
            }

            private void btnJugadores_Click(object sender, EventArgs e)
            {
                FrmJugadores FrmJugadores = new FrmJugadores();
                FrmJugadores.Show();
                this.Hide();
            }


            private void btnCerrar_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void btnCerrar_MouseEnter(object sender, EventArgs e)
            {
                btnCerrar.BackgroundImage = SIGD.Properties.Resources.circle_xmark_solid_red;
            }

            private void btnCerrar_MouseLeave(object sender, EventArgs e)
            {
                btnCerrar.BackgroundImage = SIGD.Properties.Resources.circle_xmark_solid;
            }


            private void btnEquipos_Click(object sender, EventArgs e)
            {
                FrmEquipos FrmEquipos = new FrmEquipos();
                FrmEquipos.Show();
                this.Hide();
            }



            private void button4_Click(object sender, EventArgs e)
            {
                InicioSesion inicioSesion = new InicioSesion();

                MessageBox.Show(inicioSesion.textBox1.Text + inicioSesion.txtbxC.Text);
            }

        private void btnVentana2_Click_1(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Visible)
            {
                flowLayoutPanel1.Visible = false;
            }
            else
            {
                ocultar();
                flowLayoutPanel1.Visible = true;
            }
        }
    } }
   

