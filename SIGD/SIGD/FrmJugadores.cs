using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CapaPresentacion
{
    public partial class FrmJugadores : Form
    {
        public FrmJugadores(String ROL)
        {
            InitializeComponent();
            rol = ROL;
        }

        public FrmABMJugador activo;
        public String rol;

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
            Form frmequipos = new FrmEquipos(rol) {Owner = this.Owner };
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

        private void btnCrearE_Click(object sender, EventArgs e)
        {
            activo = new FrmABMJugador('A') { Owner = this };
            activo.Show();
            this.Enabled = false;
        }

        private void btnModificarE_Click(object sender, EventArgs e)
        {
            activo = new FrmABMJugador('M') { Owner = this };
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

        private void btnBorrarE_Click(object sender, EventArgs e)
        {
            activo = new FrmABMJugador('B') { Owner = this };
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

        public void Cargar()
        {
            try
            {
                //Conexion
                MySqlConnection conexion = new MySqlConnection();
                conexion.ConnectionString =
                "Server=192.168.2.195;Database=PantherCode;Uid=jirigoin;Pwd=54233708";
                //"Server=localhost;Database=Panthercode;Uid=root;Pwd=";
                conexion.Open();
                //Sentencia
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "select * from Jugador";
                comando.ExecuteNonQuery();
                //Adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = comando;
                //Conjunto de resultados
                DataSet ds = new DataSet();
                adaptador.Fill(ds, "Jugador");
                //Cargar los resultados en el Data Grid View
                dgvJugadores.DataSource = ds.Tables["Jugador"];
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                {
                    //MessageBox.Show("Error: " + ex.Message);
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
            if (rol == "Administrador" || rol == "Administrativo")
            {
                plAdminEquipos.Visible = true;
            }
            else { plAdminEquipos.Visible = false; }
            if (rol == "Administrador" || rol == "Seleccionador")
            {
                plFiltro.Visible = true;
            }
            else { plFiltro.Visible = false; }          
        }
    }
}