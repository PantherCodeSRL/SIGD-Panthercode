﻿using System;
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
    public partial class FrmABMJugador : Form
    {
        public FrmABMJugador(char ABM, String ROL)
        {
            InitializeComponent();
            abm = ABM;
            rolU = ROL;
        }

        char abm;
        public String ci, nombre, apellidoP, apellidoS, telefono, correoElec, fnac, rolU;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //String sentencia = "";
            //switch (abm)
            //{
            //    case 'A':
            //        //Falta validar datos antes de ingresar
            //        sentencia = "INSERT INTO Jugador(ci,nombre,apellidoP,apellidoS,telefono,correoElec,fechaNac) VALUES (";
            //        sentencia += mtbCI.Text;
            //        sentencia += ",'";
            //        sentencia += txtNombre.Text;
            //        sentencia += "','";
            //        sentencia += txtPApellido.Text;
            //        sentencia += "','";
            //        sentencia += txtSApellido.Text;
            //        sentencia += "','";
            //        sentencia += mtbTelefonoJ.Text;
            //        sentencia += "','";
            //        sentencia += txtMailJ.Text;
            //        sentencia += "','";
            //        sentencia += dtpFechN.Value.ToString("yyyy-MM-dd");
            //        sentencia += "');";
            //        break;
            //    case 'M':
            //        sentencia = "UPDATE Jugador SET nombre = '";
            //        sentencia += txtNombre.Text;
            //        sentencia += "', apellidoP = '";
            //        sentencia += txtPApellido.Text;
            //        sentencia += "', apellidoS = '";
            //        sentencia += txtSApellido.Text;
            //        sentencia += "', telefono = '";
            //        sentencia += mtbTelefonoJ.Text;
            //        sentencia += "', correoElec = '";
            //        sentencia += txtMailJ.Text;
            //        sentencia += "', fechaNac = '";
            //        sentencia += dtpFechN.Value.ToString("yyyy-MM-dd");
            //        sentencia += "' WHERE ci = '";
            //        sentencia += ci + "';";
            //        break;
            //    case 'B':
            //        sentencia = "DELETE FROM Jugador WHERE ci = '";
            //        sentencia += ci + "';";
            //        break;
            //}
            try
            {
                CD_Jugador negocioABMJ = new CD_Jugador();
                CD_Conexion conectABMJ = new CD_Conexion();
                switch (abm)
                {
                    case 'A':
                        negocioABMJ.AgregarJ(conectABMJ.BDUser(rolU), "'1234'", mtbCI.Text, txtNombre.Text, txtPApellido.Text, txtSApellido.Text, mtbTelefonoJ.Text, txtMailJ.Text, dtpFechN.Value.ToString("yyyy-MM-dd"));
                        break;
                    case 'M':
                        negocioABMJ.ModificarJ(conectABMJ.BDUser(rolU), "'1234'", mtbCI.Text, txtNombre.Text, txtPApellido.Text, txtSApellido.Text, mtbTelefonoJ.Text, txtMailJ.Text, dtpFechN.Value.ToString("yyyy-MM-dd"));
                        break;
                    case 'B':
                        negocioABMJ.BajarJ(conectABMJ.BDUser(rolU), "'1234'", mtbCI.Text);
                        break;
                }
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
            Owner.Show();
            this.Owner.Enabled = true;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Owner.Enabled = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Owner.Enabled = true;
            this.Close();
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImage = CapaPresentacion.Properties.Resources.circle_xmark_solid;
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImage = CapaPresentacion.Properties.Resources.circle_xmark_solid_red;
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
                    mtbTelefonoJ.Text = telefono;
                    txtMailJ.Text = correoElec;
                    dtpFechN.Text = fnac;         
                    break;

                case 'B':
                    btnAceptar.Text = "Eliminar";

                    mtbCI.Text = ci;
                    txtNombre.Text = nombre;
                    txtPApellido.Text = apellidoP;
                    txtSApellido.Text = apellidoS;
                    mtbTelefonoJ.Text = telefono;
                    txtMailJ.Text = correoElec;
                    dtpFechN.Text = fnac;

                    mtbCI.Enabled = false;
                    txtNombre.Enabled = false;
                    txtPApellido.Enabled = false;
                    txtSApellido.Enabled = false;
                    mtbTelefonoJ.Enabled = false;
                    txtMailJ.Enabled = false;
                    dtpFechN.Enabled = false;
                    break;
            }
        }
    }
}