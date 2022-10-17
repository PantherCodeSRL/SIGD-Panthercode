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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        bool unavez = false;
        public String rol;
        public FormP principal;

        private void btnSalida_MouseEnter(object sender, EventArgs e)
        {
            btnSalida.BackgroundImage = CapaPresentacion.Properties.Resources.circle_xmark_solid_red;
        }

        private void btnSalida_MouseLeave(object sender, EventArgs e)
        {
            btnSalida.BackgroundImage = CapaPresentacion.Properties.Resources.circle_xmark_solid;
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            principal.Enabled = true;
            this.Close();
        }

        private void cbxMC_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxMC.Checked)
            {
                txtPwd.UseSystemPasswordChar = false;
            }
            else
            {
                txtPwd.UseSystemPasswordChar = true;
            }
        }

        private void lblPwd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stringsgobales.recuperacion);
        }

        private void btnInvitado_Click(object sender, EventArgs e)
        {
            principal.Enabled = true;
            this.Close();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (mtbCI.Text == "" || txtPwd.Text == "" || cbxRol.Text == "(seleccione)")
            {
                MessageBox.Show("Complete correctamente los campos de ingreso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Conexion
                    MySqlConnection conexion = new MySqlConnection();
                    conexion.ConnectionString =
                    "Server=192.168.2.195;Database=PantherCode;Uid=jirigoin;Pwd=54233708";
                    //"Server=localhost;Database=Panthercode;Uid=root;Pwd=";
                    conexion.Open();

                    switch (cbxRol.SelectedIndex)
                    {
                        case 0:
                            rol = "Administrador";
                            break;
                        case 1:
                            rol = "Administrativo";
                            break;
                        case 2:
                            rol = "Analista";
                            break;
                        case 3:
                            rol = "Arbitro";
                            break;
                        case 4:
                            rol = "CT";
                            break;
                        case 5:
                            rol = "Seleccionador";
                            break;
                    }
                    //Sentencia
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = conexion;
                    comando.CommandText =
                        "SELECT " + rol + ".ci, PASSWORD(Usuario.contraseña), Usuario.nombre, Usuario.apellidoP," +
                        " Usuario.apellidoS, Usuario.telefono, Usuario.CorreoElec, Usuario.fechaNac FROM Usuario" +
                        " JOIN " + rol + " ON Usuario.ci = " + rol + ".ci" +
                        " WHERE Usuario.ci = '" + mtbCI.Text + "' AND contraseña = PASSWORD('" + txtPwd.Text + "')";

                    MySqlDataReader lector = comando.ExecuteReader();

                    if (lector.HasRows)
                    {
                        lector.Read();
                        String nombre = lector.GetString("nombre");
                        //rol = lector.GetString("rol");
                        MessageBox.Show("Hola: " + nombre + ", sos: " + rol);
                        //this.Owner.Enabled = true;
                        //this.Owner.Show();
                        principal.Enabled = true;
                        principal.Show();
                        principal.rol = rol;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cédula, contraseña y/o rol incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    {
                        //MessageBox.Show("Error: " + ex.Message);
                        switch (ex.Number)
                        {
                            case 0:
                                MessageBox.Show("Imposible abrir una conexión el servidor de BD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case 1045:
                                MessageBox.Show("Usuario y/o contraseña incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            default:
                                MessageBox.Show("Ha ocurrido un error, verifique los datos o contacte a un Administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                }
            }
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            //this.Owner.Enabled = false;
            principal.Enabled = false;
            cbxRol.SelectedIndex = 6;
            unavez = false;
        }

        private void cbxRol_Click(object sender, EventArgs e)
        {
            if (unavez == false)
            {
                cbxRol.Items.RemoveAt(6);
            }
            unavez = true;
        }
    }
}
