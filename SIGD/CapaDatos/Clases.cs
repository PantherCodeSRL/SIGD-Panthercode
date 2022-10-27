using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Jugador
    {
        private CD_Conexion ABM_BD = new CD_Conexion();
        MySqlDataReader reader;
        DataTable listado = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        
    }
}
