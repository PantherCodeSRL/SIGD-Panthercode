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
using MySql.Data.MySqlClient;

namespace CapaPresentacion
{
    public partial class FrmFixtures : Form
    {
        public FrmFixtures(String DEPORTE, String ROL)
        {
            InitializeComponent();
            rolU = ROL;
            deporte = DEPORTE;
        }

        public String rolU;
        public String deporte;

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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            deporte = "2";
            cargar();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            deporte = "1";
            cargar();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            deporte = "3";
            cargar();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmFixtures_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            try
            {
                CD_Conexion conectABMF = new CD_Conexion();
                CD_Partido negocioABMF = new CD_Partido();

                dgvRes.DataSource = negocioABMF.DGVContenidoP(conectABMF.BDUser(rolU), "'1234'", "<",deporte);
                dgvProx.DataSource = negocioABMF.DGVContenidoP(conectABMF.BDUser(rolU), "'1234'", ">",deporte);
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
    }
}
