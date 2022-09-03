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

        private void FormP_Load(object sender, EventArgs e)
        {
            cambioIdioma();
        }
        
        public Form activo;
        bool idioma;
        public String rol = "INVITADO";

        private void cambioIdioma()
        {
            btnJugadores.Text = stringsgobales.jugadores;
            btnEquipos.Text = stringsgobales.equipos;
            btnFixtures.Text = stringsgobales.fixtures;
            btnF.Text = stringsgobales.futbol;
            btnB.Text = stringsgobales.basquetbol;
            btnH.Text = stringsgobales.handbol;
            btnInicioSesion.Text = stringsgobales.iniciosesion;
            lblBienvenido.Text = stringsgobales.bienvenido;
            lblInvitado.Text = stringsgobales.invitado;
            lblIdioma.Text = stringsgobales.idioma;
            lblContactos.Text = stringsgobales.contactos;
            btnTraducir.Text = stringsgobales.traducir;
        }


        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            InicioSesion iniSesion = new InicioSesion();
            iniSesion.principal = this;
            //activo = new InicioSesion() { Owner = this };
            iniSesion.Show();
        }
        
        private void btnTraducir_click(object sender, EventArgs e)
        {
            if (!idioma)
            {
                idioma = true;
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            }
            else if (idioma)
            {
                idioma = false;
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
            }
            cambioIdioma();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
             
        private void btnH_Click(object sender, EventArgs e)
        {
            activo = new FrmFixtures() { Owner = this };
            activo.Show();
            this.Hide();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            activo = new FF() { Owner = this };
            activo.Show();
            this.Hide();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            activo = new FB() { Owner = this };
            activo.Show();
            this.Hide();
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            activo = new FrmJugadores(rol) { Owner = this };
            activo.Show();
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
            activo = new FrmEquipos(rol) { Owner = this };
            activo.Show();
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

        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            if (flpUsuarios.Visible)
            {
                flpUsuarios.Visible = false;
            }
            else
            {
                flpUsuarios.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            activo = new FrmABMUsuario('A') { Owner = this };
            activo.Show();
            this.Hide();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            activo = new FrmABMUsuario('M') { Owner = this };
            activo.Show();
            this.Hide();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            activo = new FrmABMUsuario('B') { Owner = this };
            activo.Show();
            this.Hide();
        }

        private void FormP_Activated(object sender, EventArgs e)
        {
            lblInvitado.Text = rol.ToUpper();
            if (rol == "Administrador" || rol == "Administrativo")
            {
                btnAgregarUser.Visible = true;
                pbAddUser.Visible = true;
            }
            else { btnAgregarUser.Visible = false; pbAddUser.Visible = false; }
        }
    }
}