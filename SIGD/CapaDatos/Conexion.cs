using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Conexion
    {
        //private String server = System.Configuration.ConfigurationManager.AppSettings["Server"];
        //private String bd = System.Configuration.ConfigurationManager.AppSettings["Base_de_Datos"];

        private String server = "192.168.2.195";
        private String bd = "PantherCode";
        private String uid = "jirigoin";
        private String pwd = "54233708";
        //private String server = "localhost";
        //private String bd = "Panthercode";
        //private String uid = "root";
        //private String pwd = "";

        private MySqlConnection conexion;

        //public String Esteban()
        //{
        //    return server;
        //}

        public MySqlConnection Iniciar()
        {
            conexion = new MySqlConnection("Server=" + server + ";DataBase=" + bd + ";Uid=" + uid + ";Pwd=" + pwd);
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();

            return conexion;
        }

        public MySqlConnection Conectar(String uid, String pwd)
        {
            conexion = new MySqlConnection("Server=" + server + ";DataBase=" + bd + ";Uid=" + uid + ";Pwd=" + pwd);
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();

            return conexion;
        }

        public MySqlConnection Desconectar()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();

            return conexion;
        }

        public MySqlCommand Login(String cedula, String contra)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = new CD_Conexion().Iniciar();
            comando.CommandText =
                "SELECT ci, PASSWORD(contraseña), nombre, apellidoP," +
                " apellidoS, telefono, CorreoElec, fechaNac, rol FROM Usuario" +
                " WHERE Usuario.ci = '" + cedula + "' AND contraseña = PASSWORD('" + contra + "')";
           return comando;
        }

        public String BDUser(String rol)
        {
            switch (rol)
            {
                case "Administrador":
                    rol = "PantherAdmin";
                    break;
                case "Administrativo":
                    rol = "PantherAdmintivo";
                    break;
                case "Analista":
                    rol = "PantherAnalista";
                    break;
                case "Arbitro":
                    rol = "PantherArbitro";
                    break;
                case "CT":
                    rol = "PantherCT";
                    break;
                case "Seleccionador":
                    rol = "Seleccionador";
                    break;
                case "Invitado":
                    rol = "PantherJugador";
                    break;
            }
            return rol;
        }
    }
}
