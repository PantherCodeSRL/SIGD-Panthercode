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
        //public string server = ConfigurationManager.AppSettings.Get("Server");
        //public string bd = ConfigurationManager.AppSettings.Get("Base_de_Datos");

        private string server = "192.168.2.195";
        private string bd = "PantherCode";
        private string uid = "jirigoin";
        private string pwd = "54233708";

        private MySqlConnection conexion;

        //public string Esteban()
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

        public MySqlConnection Conectar(string uid, string pwd)
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

        public MySqlCommand Login(string cedula, string contra)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = new CD_Conexion().Iniciar();
            comando.CommandText =
                "SELECT ci, PASSWORD(contraseña), nombre, apellidoP," +
                " apellidoS, telefono, CorreoElec, fechaNac, rol FROM Usuario" +
                " WHERE Usuario.ci = '" + cedula + "' AND contraseña = PASSWORD('" + contra + "')";
           return comando;
        }
    }
}
