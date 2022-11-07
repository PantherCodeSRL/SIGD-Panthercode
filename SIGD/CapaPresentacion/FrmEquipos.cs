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
    public partial class FrmEquipos : Form
    {
        public FrmEquipos(String ROL)
        {
            InitializeComponent();
            rolU = ROL;
        }

        public FrmABMEquipo activo;
        public String rolU;
        String sentencia;
        bool valorcambiado = false;
        CD_Conexion conectABME = new CD_Conexion();

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            Form frmjugadores = new FrmJugadores(rolU) { Owner = this.Owner };
            frmjugadores.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImage = CapaPresentacion.Properties.Resources.circle_xmark_solid_red;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImage = CapaPresentacion.Properties.Resources.circle_xmark_solid;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCrearE_Click(object sender, EventArgs e)
        {
            activo = new FrmABMEquipo('A', rolU) { Owner = this };
            activo.Show();
            this.Enabled = false;
        }

        private void btnModificarE_Click(object sender, EventArgs e)
        {
            activo = new FrmABMEquipo('M', rolU) { Owner = this };
            activo.idEquipo = dgvEquipo.SelectedRows[0].Cells[0].Value.ToString();
            activo.nombreEq = dgvEquipo.SelectedRows[0].Cells[1].Value.ToString();
            activo.fechaFundacion = dgvEquipo.SelectedRows[0].Cells[2].Value.ToString();
            this.Enabled = false;
        }

        private void btnBorrarE_Click(object sender, EventArgs e)
        {
            activo = new FrmABMEquipo('B', rolU) { Owner = this };
            activo.idEquipo = dgvEquipo.SelectedRows[0].Cells[0].Value.ToString();
            activo.nombreEq = dgvEquipo.SelectedRows[0].Cells[1].Value.ToString();
            activo.fechaFundacion = dgvEquipo.SelectedRows[0].Cells[2].Value.ToString();
            this.Enabled = false;
        }

        private void FrmEquipos_Load(object sender, EventArgs e)
        {
            CD_Deporte negocioABMD = new CD_Deporte();
            cbxDeporte.DataSource = negocioABMD.CBXContenidoD(conectABME.BDUser(rolU), "'1234'");
            cargar("");
        }

        private void cargar(String filtro)
        {
            try
            {
                CD_Equipo negocioABME = new CD_Equipo();
                //Sentencia
                dgvEquipo.DataSource = negocioABME.DGVContenidoE(conectABME.BDUser(rolU), "'1234'", filtro);
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

        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            if(cbxDeporte.SelectedIndex != 0)
            {
                sentencia += "WHERE nomDeporte = '" + cbxDeporte.SelectedValue + "'";
            }
            if (txtFiltroNombre.Text != "")
            {
                sentencia += "WHERE nombreEq = '" + txtFiltroNombre.Text + "'";
            }
            if (valorcambiado == true)
            {
                sentencia += "WHERE fechaFundacion = '" + dtpFechF.Value.ToString("yyyy-MM-dd") + "'";
            }
            cargar(sentencia);
        }

        private void dtpFechF_ValueChanged(object sender, EventArgs e)
        {
            valorcambiado = true;
        }
    }
}
