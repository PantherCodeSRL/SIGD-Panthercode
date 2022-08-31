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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnSalida_MouseEnter(object sender, EventArgs e)
        {
            btnSalida.BackgroundImage = SIGD.Properties.Resources.circle_xmark_solid_red;
        }

        private void btnSalida_MouseLeave(object sender, EventArgs e)
        {
            btnSalida.BackgroundImage = SIGD.Properties.Resources.circle_xmark_solid;
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            this.Owner.Enabled = true;
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
            this.Owner.Enabled = true;
            this.Close();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPwd.Text == "")
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
                    "Server=192.168.2.195;Database=Panthercode;Uid=jirigoin;Pwd=jirigoin";
                    conexion.Open();

                    //Sentencia
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = conexion;
                    comando.CommandText =
                        "select * from usuarios where usuario ='" + txtUser.Text
                        + "' AND contra = PASSWORD('" + txtPwd.Text + "')";

                    MySqlDataReader lector = comando.ExecuteReader();

                    if (lector.HasRows)
                    {
                        String nombre, rol;
                        lector.Read();
                        nombre = lector.GetString("nombre");
                        rol = lector.GetString("rol");
                        MessageBox.Show("Hola: " + nombre + ", sos: " + rol);
                        this.Owner.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrectos");
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    {
                        //MessageBox.Show("Error: " + ex.Message);
                        switch (ex.Number)
                        {
                            case 0:
                                MessageBox.Show("Imposible abrir una conexión el servidor de BD");
                                break;
                            case 1045:
                                MessageBox.Show("Usuario y/o contraseña incorrectas");
                                break;
                        }
                    }
                }
            }
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }
    }
}
