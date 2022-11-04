using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Usuario
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

        public void AgregarU(String uid, String pwd, String ci, String contraseña, String nombre, String apellidoP, String apellidoS, String telefono, String correoElec, String fechaNac, String rol)
        {
            comando.Connection = conectAMBU.Conectar(uid, pwd); ;
            comando.CommandText = "INSERT INTO Usuario (ci,contraseña,nombre,apellidoP,apellidoS,telefono,correoElec,fechaNac,rol) " +
                "VALUES(@ci,@contraseña,@nombre,@apellidoP,@apellidoS,@telefono,@correoElec,@fechaNac,@rol)";
            comando.Parameters.AddWithValue("@ci", ci);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellidoP", apellidoP);
            comando.Parameters.AddWithValue("@apellidoS", apellidoS);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@correoElec", correoElec);
            comando.Parameters.AddWithValue("@fechaNac", fechaNac);
            comando.Parameters.AddWithValue("@rol", rol);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectAMBU.Desconectar();
        }

        public void ModificarU(String uid, String pwd, String ci, String contraseña, String nombre, String apellidoP, String apellidoS, String telefono, String correoElec, String fechaNac, String rol)
        {
            comando.Connection = conectAMBU.Conectar(uid, pwd);
            comando.CommandText = "UPDATE Usuario SET ci = @ci,contraseña = @contraseña,nombre = @nombre,apellidoP = @apellidoP,apellidoS = @apellidoS, telefono = @telefono, correoElec = @correoElec, fechaNac = @fechaNac,rol = @rol" +
                "WHERE ci = @ci";
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellidoP", apellidoP);
            comando.Parameters.AddWithValue("@apellidoS", apellidoS);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@fechaNac", fechaNac);
            comando.Parameters.AddWithValue("@correoElec", correoElec);
            comando.Parameters.AddWithValue("@rol", rol);
            comando.Parameters.AddWithValue("@ci", ci);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectAMBU.Desconectar();
        }

        public void BajarU(String uid, String pwd, String ci)
        {
            comando.Connection = conectAMBU.Conectar(uid, pwd);
            comando.CommandText = "DELETE FROM Usuario WHERE ci = @ci";
            comando.Parameters.AddWithValue("@ci", ci);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectAMBU.Desconectar();
        }
    }

    public class CD_Jugador
    {
        private CD_Conexion conectABMJ = new CD_Conexion();
        DataTable dgv = new DataTable();
        MySqlDataReader lector;
        MySqlCommand comando = new MySqlCommand();

        //Agregar al Diagrama de Clases
        public DataTable DGVContenidoU(String uid, String pwd)
        {
            comando.Connection = conectABMJ.Conectar(uid, pwd);
            comando.CommandText = "SELECT ci, nombre, apellidoP, apellidoS, telefono, correoElec, fechaNac, rol FROM Jugador";
            lector = comando.ExecuteReader();
            dgv.Load(lector);
            conectABMJ.Desconectar();
            return dgv;
        }

        public void AgregarJ(String uid, String pwd, String ci, String nombre, String apellidoP, String apellidoS, String telefono, String correoElec, String fechaNac)
        {
            comando.Connection = conectABMJ.Conectar(uid, pwd); ;
            comando.CommandText = "INSERT INTO Jugador (ci,nombre,apellidoP,apellidoS,telefono,correoElec,fechaNac) " +
                "VALUES(@ci,@nombre,@apellidoP,@apellidoS,@telefono,@correoElec,@fechaNac)";
            comando.Parameters.AddWithValue("@ci", ci);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellidoP", apellidoP);
            comando.Parameters.AddWithValue("@apellidoS", apellidoS);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@correoElec", correoElec);
            comando.Parameters.AddWithValue("@fechaNac", fechaNac);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectABMJ.Desconectar();
        }

        public void ModificarJ(String uid, String pwd, String ci, String nombre, String apellidoP, String apellidoS, String telefono, String correoElec, String fechaNac)
        {
            comando.Connection = conectABMJ.Conectar(uid, pwd);
            comando.CommandText = "UPDATE Jugador SET ci = @ci,nombre = @nombre,apellidoP = @apellidoP,apellidoS = @apellidoS, telefono = @telefono, correoElec = @correoElec, fechaNac = @fechaNac" +
                "WHERE ci = @ci";
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellidoP", apellidoP);
            comando.Parameters.AddWithValue("@apellidoS", apellidoS);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@fechaNac", fechaNac);
            comando.Parameters.AddWithValue("@correoElec", correoElec);
            comando.Parameters.AddWithValue("@ci", ci);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectABMJ.Desconectar();
        }

        public void BajarJ(String uid, String pwd, String ci)
        {
            comando.Connection = conectABMJ.Conectar(uid, pwd);
            comando.CommandText = "DELETE FROM Jugador WHERE ci = @ci";
            comando.Parameters.AddWithValue("@ci", ci);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectABMJ.Desconectar();
        }
    }
}
