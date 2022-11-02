using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Usuario/*(String uid, String pwd)*/
    {
        private CD_Conexion conectAMBU = new CD_Conexion();
        DataTable dgv = new DataTable();
        MySqlDataReader lector;
        MySqlCommand comando = new MySqlCommand();

        //Agregar al Diagrama de Clases
        public DataTable DGVContenidoU(String uid, String pwd)
        {
            comando.Connection = conectAMBU.Conectar(uid, pwd);
            comando.CommandText = "SELECT ci, nombre, apellidoP, apellidoS, telefono, correoElec, fechaNac, rol FROM Usuario";
            lector = comando.ExecuteReader();
            dgv.Load(lector);
            conectAMBU.Desconectar();
            return dgv;
        }

        //Modificar en el Digarama de Clases
        public void AgregarU(String uid, String pwd, String ci, String contraseña, String nombre, String apellidoP, String apellidoS, String telefono, String fechaNac, String rol)
        {
            comando.Connection = conectAMBU.Conectar(uid, pwd); ;
            comando.CommandText = "INSERT INTO Usuario (ci,contraseña,nombre,apellidoP,apellidoS,telefono,fechaNac,rol) " +
                "VALUES(@ci,@contraseña,@nombre,@apellidoP,@apellidoS,@telefono,@fechaNac,@rol)";
            comando.Parameters.AddWithValue("@ci", ci);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellidoP", apellidoP);
            comando.Parameters.AddWithValue("@apellidoS", apellidoS);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@fechaNac", fechaNac);
            comando.Parameters.AddWithValue("@rol", rol);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectAMBU.Desconectar();
        }

        public void ModificarU(String uid, String pwd, String ci, String contraseña, String nombre, String apellidoP, String apellidoS, String telefono, DateTime fechaNac, String rol)
        {
            comando.Connection = conectAMBU.Conectar(uid, pwd);
            comando.CommandText = "UPDATE Usuario SET ci = @ci,contraseña = @contraseña,nombre = @nombre,apellidoP = @apellidoP,apellidoS = @apellidoS, telefono = @telefono,fechaNac = @fechaNac,rol = @rol" +
                "WHERE ci = @ci";
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellidoP", apellidoP);
            comando.Parameters.AddWithValue("@apellidoS", apellidoS);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@fechaNac", fechaNac);
            comando.Parameters.AddWithValue("@rol", rol);
            comando.Parameters.AddWithValue("@ci", ci);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectAMBU.Desconectar();
        }

        public void BajarU(String uid, String pwd, String ci)
        {
            comando.Connection = conectAMBU.Conectar(uid, pwd);
            comando.CommandText = "DELETE FROM usuario WHERE ci = @ci";
            comando.Parameters.AddWithValue("@ci", ci);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectAMBU.Desconectar();
        }
    }
}
