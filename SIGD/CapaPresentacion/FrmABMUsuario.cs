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

namespace CapaPresentacion
{
    public partial class FrmABMUsuario : Form
    {
        public FrmABMUsuario(char ABM, String rol)
        {
            InitializeComponent();
            abm = ABM;
            rolU = rol;
        }

        char abm;
        public String ci, nombre, apellidoP, apellidoS, telefono, correoElec, fnac, rol;
        public String rolU;

        private void FrmABMUsuario_Activated(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dgvUsuarios_Click(object sender, EventArgs e)
        {
            mtbCI.Text = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
            txtNombreU.Text = dgvUsuarios.SelectedRows[0].Cells[1].Value.ToString();
            txtPApellidoU.Text = dgvUsuarios.SelectedRows[0].Cells[2].Value.ToString();
            txtSApellidoU.Text = dgvUsuarios.SelectedRows[0].Cells[3].Value.ToString();
            mtbTelefonoU.Text = dgvUsuarios.SelectedRows[0].Cells[4].Value.ToString();
            txtMailU.Text = dgvUsuarios.SelectedRows[0].Cells[5].Value.ToString();
            dtpFechNU.Text = dgvUsuarios.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void FrmABMUsuario_Load(object sender, EventArgs e)
        {
            Cargar();
            switch (abm)
            {
                case 'A':
                    btnAceptar.Text = "Ingresar";
                    break;

                case 'M':
                    btnAceptar.Text = "Modificar";
                    break;

                case 'B':
                    btnAceptar.Text = "Eliminar";
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mtbCI.Text = "";
            txtNombreU.Text = "";
            txtPApellidoU.Text = "";
            txtSApellidoU.Text = "";
            mtbTelefonoU.Text = "";
            txtMailU.Text = "";
            dtpFechNU.Text = "";
            cbxRol.SelectedIndex = 6;
            txtCU.Text = "";
            txtRCU.Text = "";
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Owner.Enabled = true;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
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
            switch (abm)
            {
                case 'A':
                    ////Falta validar datos antes de ingresar
                    ////Falta agregar usuarios según el tipo de usuario
                    //sentencia = "INSERT INTO Usuario VALUES (";
                    //sentencia += mtbCI.Text;
                    //sentencia += ",PASSWORD('";
                    //sentencia += txtCU.Text;
                    //sentencia += "'),'";
                    //sentencia += txtNombreU.Text;
                    //sentencia += "','";
                    //sentencia += txtPApellidoU.Text;
                    //sentencia += "','";
                    //sentencia += txtSApellidoU.Text;
                    //sentencia += "','";
                    //sentencia += mtbTelefonoU.Text;
                    //sentencia += "','";
                    //sentencia += txtMailU.Text;
                    //sentencia += "','";
                    //sentencia += dtpFechNU.Value.ToString("yyyy-MM-dd");
                    //sentencia += "','";
                    //sentencia += rol;
                    //sentencia += "');";
                    break;
                case 'M':
                    //Falta agregar modificaciones según el tipo de usuario
                    //sentencia = "UPDATE Usuario SET contraseña = PASSWORD('";
                    //sentencia += txtCU.Text;
                    //sentencia += "'), nombre = '";
                    //sentencia += txtNombreU.Text;
                    //sentencia += "', apellidoP = '";
                    //sentencia += txtPApellidoU.Text;
                    //sentencia += "', apellidoS = '";
                    //sentencia += txtSApellidoU.Text;
                    //sentencia += "', telefono = '";
                    //sentencia += mtbTelefonoU.Text;
                    //sentencia += "', correoElec = '";
                    //sentencia += txtMailU.Text;
                    //sentencia += "', fechaNac = '";
                    //sentencia += dtpFechNU.Value.ToString("yyyy-MM-dd");
                    //sentencia += "' WHERE (ci = '";
                    //sentencia += mtbCI.Text + "');";
                    break;
                case 'B':
                    //Para tener multiples sentencias se tienen que separar en dos variables
                    //sentencia = "DELETE FROM Usuario WHERE (ci = '";
                    //sentencia += mtbCI.Text + "');";
                    break;
            }
            try
            {
                CD_Usuario negocioABMU = new CD_Usuario();
                CD_Conexion conectABMU = new CD_Conexion();

                switch (abm)
                {
                    case 'A':
                        negocioABMU.AgregarU(conectABMU.BDUser(rolU), "'1234'", mtbCI.Text, txtCU.Text, txtNombreU.Text, txtPApellidoU.Text, txtSApellidoU.Text, mtbTelefonoU.Text, txtMailU.Text, dtpFechNU.Value.ToString("yyyy-MM-dd"), rol);
                        break;
                    case 'M':
                        negocioABMU.ModificarU(conectABMU.BDUser(rolU), "'1234'", mtbCI.Text, txtCU.Text, txtNombreU.Text, txtPApellidoU.Text, txtSApellidoU.Text, mtbTelefonoU.Text, txtMailU.Text, dtpFechNU.Value.ToString("yyyy-MM-dd"), rol);
                        break;
                    case 'B':
                        negocioABMU.BajarU(conectABMU.BDUser(rolU), "'1234'", mtbCI.Text);
                        break;
                }

                //Sentencia
                //MySqlCommand comando = new MySqlCommand();
                //comando.Connection = conectABMU.Conectar(conectABMU.BDUser(rolU), "'1234'");
                //comando.CommandText = sentencia;
                //comando.ExecuteNonQuery();                
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
            Cargar();
            dgvUsuarios.ClearSelection();
            mtbCI.Text = "";
            txtNombreU.Text = "";
            txtPApellidoU.Text = "";
            txtSApellidoU.Text = "";
            mtbTelefonoU.Text = "";
            txtMailU.Text = "";
            dtpFechNU.Text = "";
            cbxRol.SelectedIndex = 6;
            txtCU.Text = "";
            txtRCU.Text = "";
        }
        private void Cargar()
        {
            try
            {
                CD_Usuario negocioABMU = new CD_Usuario();
                //Temporal
                CD_Conexion conectABMU = new CD_Conexion();
                dgvUsuarios.DataSource = negocioABMU.DGVContenidoU(conectABMU.BDUser(rolU), "'1234'");
                ////Conexion
                //CD_Conexion conectABMU = new CD_Conexion();

                ////Sentencia
                //MySqlCommand comando = new MySqlCommand();
                //comando.Connection = conectABMU.Conectar(rolU, "");
                //comando.CommandText = "select ci, nombre, apellidoP, apellidoS, telefono, correoElec, fechaNac, rol from Usuario";
                //comando.ExecuteNonQuery();
                ////Adaptador
                //MySqlDataAdapter adaptador = new MySqlDataAdapter();
                //adaptador.SelectCommand = comando;
                ////Conjunto de resultados
                //DataSet ds = new DataSet();
                //adaptador.Fill(ds, "Usuario");
                ////Cargar los resultados en el Data Grid View
                //dgvUsuarios.DataSource = ds.Tables["Usuario"];
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
