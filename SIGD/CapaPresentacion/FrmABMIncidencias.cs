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
    public partial class FrmABMIncidencias : Form
    {
        public FrmABMIncidencias(char ABM, String ROL)
        {
            InitializeComponent();
            abm = ABM;
            rolU = ROL;
        }

        char abm;
        public String nIncidencia, descripcion, tiempo, idTipoInci, fechaRegistro, rolU;

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                CD_Incidencia negocioABMI = new CD_Incidencia();
                CD_Conexion conectABMI = new CD_Conexion();
                switch (abm)
                {
                    case 'A':
                        negocioABMI.AgregarI(conectABMI.BDUser(rolU), "'1234'", txtDescripcion.Text, nudTiempo.Text, idTipoInci, DateTime.Now.ToString("yyyy-MM-dd"));
                        break;
                    case 'M':
                        negocioABMI.ModificarI(conectABMI.BDUser(rolU), "'1234'", nIncidencia, txtDescripcion.Text, nudTiempo.Text, idTipoInci, DateTime.Now.ToString("yyyy-MM-dd"));
                        break;
                    case 'B':
                        negocioABMI.BajarI(conectABMI.BDUser(rolU), "'1234'", nIncidencia);
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
            cbxTipoInci.Text = "Seleccione";
            txtDescripcion.Text = "";
            nudTiempo.Value = 0;
        }
    }
}
