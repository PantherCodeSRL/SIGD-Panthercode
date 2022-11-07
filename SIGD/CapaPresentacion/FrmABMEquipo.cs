using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FrmABMEquipo : Form
    {
        public FrmABMEquipo(char ABM, String ROL)
        {
            InitializeComponent();
            abm = ABM;
            rolU = ROL;
        }

        char abm;
        public String idEquipo, nombreEq, fechaFundacion, rolU;
        CD_Conexion conectABME = new CD_Conexion();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                CD_Equipo negocioABME = new CD_Equipo();
                switch (abm)
                {
                    case 'A':
                        negocioABME.AgregarE(conectABME.BDUser(rolU), "'1234'", txtNombre.Text, dtpFechF.Text);
                        break;
                    case 'M':
                        negocioABME.ModificarE(conectABME.BDUser(rolU), "'1234'", idEquipo, txtNombre.Text, dtpFechF.Text);
                        break;
                    case 'B':
                        negocioABME.BajarE(conectABME.BDUser(rolU), "'1234'", idEquipo);
                        break;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Imposible abrir una conexión el servidor de BD");
                        break;
                    case 1045:
                        MessageBox.Show("Usuario y/o contraseña incorrectas");
                        break;
                    default:
                        MessageBox.Show("Ha ocurrido un error, verifique sus datos o contacte a un administrador.");
                        break;
                }
            }
            Owner.Show();
            this.Owner.Enabled = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            dtpFechF.Value = DateTime.Now;
            cbxDeporte.SelectedIndex = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Owner.Enabled = true;
            this.Close();
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImage = CapaPresentacion.Properties.Resources.circle_xmark_solid;
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImage = CapaPresentacion.Properties.Resources.circle_xmark_solid_red;
        }
    }
}
