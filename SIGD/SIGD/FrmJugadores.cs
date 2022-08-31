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

        private void FrmJugadores_Load(object sender, EventArgs e)
        {
            try
            {
                //Conexion
                MySqlConnection conexion = new MySqlConnection();
                conexion.ConnectionString =
                //"Server=192.168.2.195;Database=agenda;Uid=prueba;Pwd=prueba";
                "Server=localhost;Database=Panthercode;Uid=jirigoin;Pwd=54233708";
                conexion.Open();
                //Sentencia
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "select * from jugadores";
                comando.ExecuteNonQuery();
                //Adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = comando;
                //Conjunto de resultados
                DataSet ds = new DataSet();
                adaptador.Fill(ds, "datos");
                //Cargar los resultados en el Data Grid View
                dgvJugadores.DataSource = ds.Tables["datos"];
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
                            MessageBox.Show("Usuario y/o contraseña incorrectas");
                            break;
                    }
                }
            }
        }
    }
}
