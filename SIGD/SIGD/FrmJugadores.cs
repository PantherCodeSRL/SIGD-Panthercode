﻿using System;
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
    public partial class FrmJugadores : Form
    {
        public FrmJugadores()
        {
            InitializeComponent();        
        }

        public Form activo;

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            Form frmequipos = new FrmEquipos() {Owner = this.Owner };
            frmequipos.Show();
            this.Close();
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImage = SIGD.Properties.Resources.circle_xmark_solid_red;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImage = SIGD.Properties.Resources.circle_xmark_solid;
        }

        private void btnCrearE_Click(object sender, EventArgs e)
        {
            activo = new FrmABMJugador('A') { Owner = this };
            activo.Show();
        }

        private void btnModificarE_Click(object sender, EventArgs e)
        {
            activo = new FrmABMJugador('M') { Owner = this };
            activo.Show();
        }

        private void btnBorrarE_Click(object sender, EventArgs e)
        {
            activo = new FrmABMJugador('B') { Owner = this };
            activo.Show();
        }
    }
}
