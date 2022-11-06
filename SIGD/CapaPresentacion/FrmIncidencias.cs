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
    public partial class FrmIncidencias : Form
    {
        public FrmIncidencias(String ROL)
        {
            InitializeComponent();
            rolU = ROL;
        }

        public FrmABMIncidencias activo;
        public String rolU;

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

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Owner.Owner.Show();
            this.Owner.Close();
            this.Close();
        }

        private void btnFixture_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Cargar()
        {
            try
            {
                CD_Conexion conectABMI = new CD_Conexion();
                CD_Incidencia negocioABMI = new CD_Incidencia();
                //Sentencia
                dgvIncidencias.DataSource = negocioABMI.DGVContenidoI(conectABMI.BDUser(rolU), "'1234'");
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

        private void FrmIncidencias_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnCrearI_Click(object sender, EventArgs e)
        {
            activo = new FrmABMIncidencias('A', rolU) { Owner = this };
            activo.Show();
            this.Enabled = false;
        }

        private void btnModificarI_Click(object sender, EventArgs e)
        {
            activo = new FrmABMIncidencias('M', rolU) { Owner = this };
            activo.nIncidencia = dgvIncidencias.SelectedRows[0].Cells[0].Value.ToString();
            activo.descripcion = dgvIncidencias.SelectedRows[0].Cells[1].Value.ToString();
            activo.tiempo = dgvIncidencias.SelectedRows[0].Cells[2].Value.ToString();
            activo.idTipoInci= dgvIncidencias.SelectedRows[0].Cells[3].Value.ToString();
            activo.fechaRegistro = dgvIncidencias.SelectedRows[0].Cells[4].Value.ToString();
            activo.Show();
            this.Enabled = false;
        }

        private void btnBorrarI_Click(object sender, EventArgs e)
        {
            activo = new FrmABMIncidencias('B', rolU) { Owner = this };
            activo.nIncidencia = dgvIncidencias.SelectedRows[0].Cells[0].Value.ToString();
            activo.descripcion = dgvIncidencias.SelectedRows[0].Cells[1].Value.ToString();
            activo.tiempo = dgvIncidencias.SelectedRows[0].Cells[2].Value.ToString();
            activo.idTipoInci = dgvIncidencias.SelectedRows[0].Cells[3].Value.ToString();
            activo.fechaRegistro = dgvIncidencias.SelectedRows[0].Cells[4].Value.ToString();
            activo.Show();
            this.Enabled = false;
        }
    }
}
