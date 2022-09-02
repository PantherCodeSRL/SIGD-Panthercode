using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGD
{
    public partial class FrmABMUsuario : Form
    {
        public FrmABMUsuario(char ABM)
        {
            InitializeComponent();
            abm = ABM;
        }

        char abm;
        public String ci, nombre, apellidoP, apellidoS, telefono, correoElec, fnac;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String sentencia = "";
            switch (abm)
            {
                case 'A':
                    //Falta validar datos antes de ingresar
                    sentencia = "INSERT INTO Usuario(ci,contraseña,nombre,apellidoP,apellidoS,telefono,correoElec,fechaNac) VALUES (ci = '";
                    sentencia += mtbCI.Text;
                    sentencia += ", nombre = '";
                    sentencia += txtNombreU.Text;
                    sentencia += "', apellidoP = '";
                    sentencia += txtPApellidoU.Text;
                    sentencia += "', apellidoS = '";
                    sentencia += txtSApellidoU.Text;
                    sentencia += "', telefono = '";
                    sentencia += mtbTelefonoU.Text;
                    sentencia += "', correoElec = '";
                    sentencia += txtMailU.Text;
                    sentencia += "', fechaNac = '";
                    sentencia += dtpFechNU.Value.ToString("yyyy-MM-dd");
                    sentencia += "');";
                    break;
                case 'M':
                    sentencia = "UPDATE Jugador SET nombre = ";
                    sentencia += txtNombreU.Text;
                    sentencia += "', apellidoP = '";
                    sentencia += txtPApellidoU.Text;
                    sentencia += "', apellidoS = '";
                    sentencia += txtSApellidoU.Text;
                    sentencia += "', telefono = '";
                    sentencia += mtbTelefonoU.Text;
                    sentencia += "', correoElec = '";
                    sentencia += txtMailU.Text;
                    sentencia += "', fechaNac = '";
                    sentencia += dtpFechNU.Value.ToString("yyyy-MM-dd");
                    sentencia += "' WHERE ci = ";
                    sentencia += ci;
                    break;
                case 'B':
                    sentencia = "DELETE FROM Jugador WHERE ci = ";
                    sentencia += ci;
                    break;
            }
            Owner.Show();
            this.Owner.Enabled = true;
            this.Close();
        }
    }
}
