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
    public partial class FormP : Form
    {
        public FormP()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            InicioSesion iniciosesion = new InicioSesion();
            iniciosesion.Show();
        }
        //private void resizeControl(Rectangle OriginalControlRect, Control control)
        //{
        //    int newX = (int)(OriginalControlRect.X);
        //    int newY = (int)(OriginalControlRect.Y);

        //    int newWidth = (int)(OriginalControlRect.Width - 2);
        //    int newHeight = (int)(OriginalControlRect.Height);

        //    control.Location = new Point(newX, newY);
        //    control.Size = new Size(newWidth, newHeight);
        //}

        private void lblTraducir_click(object sender, EventArgs e)
        {
            Form1I form1I = new Form1I();
            form1I.Show();
            this.Hide();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
             

        private void btnH_Click(object sender, EventArgs e)
        {
            FH fh = new FH();
            fh.Show();
            this.Hide();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            FF ff = new FF();
            ff.Show();
            this.Hide();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            FB fb = new FB();
            fb.Show();
            this.Hide();
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            FrmJugadores frmjugadores = new FrmJugadores();
            frmjugadores.Show();
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
            FrmEquipos frmequipos = new FrmEquipos();
            frmequipos.Show();
            this.Hide();
        }

        private void btnFixtures_Click(object sender, EventArgs e)
        {
            if (flpFix.Visible)
            {
                flpFix.Visible = false;
            }
            else
            {
                flpFix.Visible = true;
            }
        }
    }
}
   

