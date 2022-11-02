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
using CapaDatos;
using System.Configuration;


namespace CapaPresentacion
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }
        public String rolU;
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
            if (mtbCI.Text == "" || txtPwd.Text == "")
            {
                MessageBox.Show("Complete correctamente los campos de ingreso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Conexion
                    //CD_Conexion conexion = new CD_Conexion();

                    //MySqlConnection conexion = new MySqlConnection();
                    //conexion.ConnectionString =
                    //"Server=192.168.2.195;Database=PantherCode;Uid=jirigoin;Pwd=54233708";
                    ////"Server=localhost;Database=Panthercode;Uid=root;Pwd=";
                    //conexion.Open();
                    //CD_Conexion.Iniciar();

                    //Sentencia
                    MySqlCommand comando = new MySqlCommand();
                    CD_Conexion inicio = new CD_Conexion();
                    comando.Connection = inicio.Iniciar();

                    //comando.CommandText =
                    //    "SELECT ci, PASSWORD(contraseña), nombre, apellidoP," +
                    //    " apellidoS, telefono, CorreoElec, fechaNac, rol FROM Usuario" +
                    //    " WHERE Usuario.ci = '" + mtbCI.Text + "' AND contraseña = PASSWORD('" + txtPwd.Text + "')";
                    comando = inicio.Login(mtbCI.Text, txtPwd.Text);
                    MySqlDataReader lector = comando.ExecuteReader();

                    if (lector.HasRows)
                    {
                        lector.Read();
                        String nombre = lector.GetString("nombre");
                        String rolU = lector.GetString("rol");
                        MessageBox.Show("Hola: " + nombre + ", sos: " + rolU);
                        //this.Owner.Enabled = true;
                        //this.Owner.Show();
                        inicio.Desconectar();
                        principal.Enabled = true;
                        principal.Show();
                        principal.rolU = rolU;
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
            //MessageBox.Show(new CD_Conexion().Esteban());
        }
    }
}
