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
    public partial class FrmABMJugador : Form
    {
        public FrmABMJugador(char ABM)
        {
            InitializeComponent();
            abm = ABM;
        }

        char abm;
        public String ci, nombre, apellidoP, apellidoS, fnac;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String sentencia = "";
            switch (abm)
            {
                case 'A':
                    //Falta validar datos antes de ingresar
                    sentencia = "INSERT INTO datos(ci,nombre,apellidoP,apellidoS,fechaNac) VALUES (ci = '";
                    sentencia += mtbCI.Text;
                    sentencia += ", nombre = '";
                    sentencia += txtNombre.Text;
                    sentencia += "', apellidoP = '";
                    sentencia += txtPApellido.Text;
                    sentencia += "', apellidoS = '";
                    sentencia += txtSApellido.Text;
                    sentencia += "', fechaNac = '";
                    sentencia += dtpFechN.Value.ToString("yyyy-MM-dd");
                    sentencia += "');";
                    break;
                case 'M':
                    sentencia = "UPDATE datos SET nombre = ";
                    sentencia += txtNombre.Text;
                    sentencia += ", apellidoP = '";
                    sentencia += txtPApellido.Text;
                    sentencia += "', apellidoS = '";
                    sentencia += txtSApellido.Text;
                    sentencia += "', fechaNac = '";
                    sentencia += dtpFechN.Value.ToString("yyyy-MM-dd");
                    sentencia += "' WHERE ci = ";
                    sentencia += ci;
                    break;
                case 'B':
                    sentencia = "DELETE FROM datos WHERE ci = ";
                    sentencia += ci;
                    break;
            }
            //try
            //{
            //    //Conexion
            //    MySqlConnection conexion = new MySqlConnection();
            //    conexion.ConnectionString =
            //    "Server=192.168.2.195;Database=agenda;Uid=prueba;Pwd=prueba";
            //    conexion.Open();
            //    //Sentencia
            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexion;
            //    comando.CommandText = sentencia;
            //    comando.ExecuteNonQuery();
            //}
            //catch (MySql.Data.MySqlClient.MySqlException ex)
            //{
            //    switch (ex.Number)
            //    {
            //        case 0:
            //            MessageBox.Show("Imposible abrir una conexión el servidor de BD");
            //            break;
            //        case 1045:
            //            MessageBox.Show("Usuario y/o contraseña incorrectas");
            //            break;
            //    }
            //}
            Owner.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImage = SIGD.Properties.Resources.circle_xmark_solid;
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImage = SIGD.Properties.Resources.circle_xmark_solid_red;
        }

        private void FrmAMBJugador_Load(object sender, EventArgs e)
        {
            switch (abm)
            {
                case 'A':
                    btnAceptar.Text = "Ingresar";
                    break;

                case 'M':
                    btnAceptar.Text = "Modificar";

                    mtbCI.Text = ci;
                    txtNombre.Text = nombre;
                    txtPApellido.Text = apellidoP;
                    txtSApellido.Text = apellidoS;
                    dtpFechN.Text = fnac;         
                    break;

                case 'B':
                    this.Text = "Eliminar un contacto";
                    btnAceptar.Text = "Eliminar";

                    mtbCI.Text = ci;
                    txtNombre.Text = nombre;
                    txtPApellido.Text = apellidoP;
                    txtSApellido.Text = apellidoS;
                    dtpFechN.Text = fnac;

                    mtbCI.Enabled = false;
                    txtNombre.Enabled = false;
                    txtPApellido.Enabled = false;
                    txtSApellido.Enabled = false;
                    dtpFechN.Enabled = false;
                    break;
            }
        }
    }
}
