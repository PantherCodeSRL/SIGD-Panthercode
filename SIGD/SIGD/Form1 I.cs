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
    public partial class Form1I : Form
    {
        public Form1I()
        {

            InitializeComponent();

        }


        private void ocultar()
        {
            flowLayoutPanel1.Visible = false;
        }

        private void Form1I_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            ocultar();
            InicioSesionI iniciosesionI = new InicioSesionI();
            iniciosesionI.Show();

        }
        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {

            int newX = (int)(OriginalControlRect.X);
            int newY = (int)(OriginalControlRect.Y);

            int newWidth = (int)(OriginalControlRect.Width);
            int newHeight = (int)(OriginalControlRect.Height);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);

        }
        
        

        private void label1_click(object sender, EventArgs e)
        {
            
            FormP form1 = new FormP();
            form1.Show();
            this.Hide();

        }

            private void button3_Click(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Minimized;
            }
             

            private void button1_Click(object sender, EventArgs e)
            {
                FHI FHI = new FHI();
                FHI.Show();
                this.Hide();
            }

            private void button12_Click(object sender, EventArgs e)
            {
                FFI FFI = new FFI();
                FFI.Show();
                this.Hide();
            }

            private void button9_Click(object sender, EventArgs e)
            {
                FBI fbI = new FBI();
                fbI.Show();
                this.Hide();
            }

            private void btnJugadores_Click(object sender, EventArgs e)
            {
                FrmJugadoresI FrmJugadoresI = new FrmJugadoresI();
                FrmJugadoresI.Show();
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
                FrmEquiposI FrmEquiposI = new FrmEquiposI();
                FrmEquiposI.Show();
                this.Hide();
            }



            private void button4_Click(object sender, EventArgs e)
            {
                InicioSesionI inicioSesionI = new InicioSesionI();

                MessageBox.Show(inicioSesionI.textBox1.Text + inicioSesionI.txtbxC.Text);
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
   

