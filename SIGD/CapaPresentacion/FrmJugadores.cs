﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FrmJugadores : Form
    {
        public FrmJugadores(String ROL)
        {
            InitializeComponent();
            rolU = ROL;
        }

        public FrmABMJugador activo;
        public String rolU;

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
            Form frmequipos = new FrmEquipos(rolU) {Owner = this.Owner };
            frmequipos.Show();
            this.Close();
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImage = CapaPresentacion.Properties.Resources.circle_xmark_solid_red;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImage = CapaPresentacion.Properties.Resources.circle_xmark_solid;
        }

        private void btnCrearJ_Click(object sender, EventArgs e)
        {
            activo = new FrmABMJugador('A',rolU) { Owner = this };
            activo.Show();
            this.Enabled = false;
        }

        private void btnModificarJ_Click(object sender, EventArgs e)
        {
            activo = new FrmABMJugador('M',rolU) { Owner = this };
            activo.ci= dgvJugadores.SelectedRows[0].Cells[0].Value.ToString();
            activo.nombre = dgvJugadores.SelectedRows[0].Cells[1].Value.ToString();
            activo.apellidoP = dgvJugadores.SelectedRows[0].Cells[2].Value.ToString();
            activo.apellidoS = dgvJugadores.SelectedRows[0].Cells[3].Value.ToString();
            activo.telefono = dgvJugadores.SelectedRows[0].Cells[4].Value.ToString();
            activo.correoElec = dgvJugadores.SelectedRows[0].Cells[5].Value.ToString();
            activo.fnac = dgvJugadores.SelectedRows[0].Cells[6].Value.ToString();
            activo.Show();
            this.Enabled = false;
        }

        private void btnBorrarJ_Click(object sender, EventArgs e)
        {
            activo = new FrmABMJugador('B',rolU) { Owner = this };
            activo.ci = dgvJugadores.SelectedRows[0].Cells[0].Value.ToString();
            activo.nombre = dgvJugadores.SelectedRows[0].Cells[1].Value.ToString();
            activo.apellidoP = dgvJugadores.SelectedRows[0].Cells[2].Value.ToString();
            activo.apellidoS = dgvJugadores.SelectedRows[0].Cells[3].Value.ToString();
            activo.telefono = dgvJugadores.SelectedRows[0].Cells[4].Value.ToString();
            activo.correoElec = dgvJugadores.SelectedRows[0].Cells[5].Value.ToString();
            activo.fnac = dgvJugadores.SelectedRows[0].Cells[6].Value.ToString();
            activo.Show();
            this.Enabled = false;
        }

        private void Cargar()
        {
            try
            {
                CD_Conexion conectABMJ = new CD_Conexion();
                CD_Jugador negocioABMJ = new CD_Jugador();
                //Sentencia
                dgvJugadores.DataSource = negocioABMJ.DGVContenidoJ(conectABMJ.BDUser(rolU), "'1234'");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                {
                    MessageBox.Show("Error: " + ex.Message);
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("No se ha podido conectar a la base de datos, pruebe de vuelta en un minuto o contacte a un administrador.");
                            break;
                        case 1045:
                            MessageBox.Show("A ocurrido un error con las credenciales a la hora de entrar a la base de batos.");
                            break;
                        default:
                            MessageBox.Show("Ha ocurrido un error inesperado, contacte a un administrador.");
                            break;
                    }
                }
            }
        }

        private void FrmJugadores_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void FrmJugadores_Activated(object sender, EventArgs e)
        {
            Cargar();
            if (rolU == "Administrador" || rolU == "Administrativo")
            {
                plAdminEquipos.Visible = true;
            }
            else { plAdminEquipos.Visible = false; }
            if (rolU == "Administrador" || rolU == "Seleccionador")
            {
                plFiltro.Visible = true;
            }
            else { plFiltro.Visible = false; }          
        }
    }
}