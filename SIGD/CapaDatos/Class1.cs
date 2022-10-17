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
    public class CP_Conexion
    {
        private static string server = ConfigurationManager.AppSettings.Get("Server").ToString();
        private static string bd = ConfigurationManager.AppSettings.Get("Base_de_Datos").ToString();
        private static string uid = ConfigurationManager.AppSettings.Get("Id_Usuario").ToString();
        private static string pwd = ConfigurationManager.AppSettings.Get("Contraseña_Usuario").ToString();

        private MySqlConnection conexion = new MySqlConnection("Server=" + server + ";DataBase=" + bd + ";Uid=" + uid + ";Pwd=" + pwd);

        public MySqlConnection Conectar()
        {
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
    }
}
