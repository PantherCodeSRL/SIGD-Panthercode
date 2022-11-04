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
            comando.CommandText = "UPDATE Usuario SET contraseña = @contraseña,nombre = @nombre,apellidoP = @apellidoP,apellidoS = @apellidoS, telefono = @telefono, correoElec = @correoElec, fechaNac = @fechaNac,rol = @rol" +
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
        public DataTable DGVContenidoJ(String uid, String pwd)
        {
            comando.Connection = conectABMJ.Conectar(uid, pwd);
            comando.CommandText = "SELECT ci, nombre, apellidoP, apellidoS, telefono, correoElec, fechaNac FROM Jugador";
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
            comando.CommandText = "UPDATE Jugador SET nombre = @nombre,apellidoP = @apellidoP,apellidoS = @apellidoS, telefono = @telefono, correoElec = @correoElec, fechaNac = @fechaNac" +
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

    public class CD_Partido
    {
        private CD_Conexion conectABMP = new CD_Conexion();
        DataTable dgv = new DataTable();
        MySqlDataReader lector;
        MySqlCommand comando = new MySqlCommand();

        //Agregar al Diagrama de Clases
        public DataTable DGVContenidoP(String uid, String pwd, String filtro)
        {
            comando.Connection = conectABMP.Conectar(uid, pwd);
            if (filtro != "")
            {
                comando.CommandText = "SELECT idPartido, fechaHora, idLocal, idVisitante, resultadoLocal, resultadoVisita FROM Partido WHERE fechaHora " + filtro;
            }
            else
            {
                comando.CommandText = "SELECT idPartido, fechaHora, idLocal, idVisitante, resultadoLocal, resultadoVisita FROM Partido";
            }
            
            lector = comando.ExecuteReader();
            dgv.Load(lector);
            conectABMP.Desconectar();
            return dgv;
        }

        public void AgregarP(String uid, String pwd, String idPartido, String fechaHora, String idLocal, String idVisitante, String resultadoLocal, String resultadoVisita)
        {
            comando.Connection = conectABMP.Conectar(uid, pwd); ;
            comando.CommandText = "INSERT INTO Partido (idPartido,fechaHora,idLocal,idVisitante,resultadoLocal,resultadoVisita) " +
                "VALUES(@idPartido,@fechaHora,@idLocal,@idVisitante,@resultadoLocal,@resultadoVisita)";
            comando.Parameters.AddWithValue("@idPartido", idPartido);
            comando.Parameters.AddWithValue("@fechaHora", fechaHora);
            comando.Parameters.AddWithValue("@idLocal", idLocal);
            comando.Parameters.AddWithValue("@idVisitante", idVisitante);
            comando.Parameters.AddWithValue("@resultadoLocal", resultadoLocal);
            comando.Parameters.AddWithValue("@resultadoVisita", resultadoVisita);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectABMP.Desconectar();
        }

        public void ModificarP(String uid, String pwd, String idPartido, String fechaHora, String idLocal, String idVisitante, String resultadoLocal, String resultadoVisita)
        {
            comando.Connection = conectABMP.Conectar(uid, pwd);
            comando.CommandText = "UPDATE Partido SET fechaHora = @fechaHora,idLocal = @idLocal,idVisitante = @idVisitante, resultadoLocal = @resultadoLocal, resultadoVisita = @resultadoVisita" +
                "WHERE idPartido = @idPartido";
            comando.Parameters.AddWithValue("@fechaHora", fechaHora);
            comando.Parameters.AddWithValue("@idLocal", idLocal);
            comando.Parameters.AddWithValue("@idVisitante", idVisitante);
            comando.Parameters.AddWithValue("@resultadoLocal", resultadoLocal);
            comando.Parameters.AddWithValue("@resultadoVisita", resultadoVisita);
            comando.Parameters.AddWithValue("@idPartido", idPartido);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectABMP.Desconectar();
        }

        public void BajarP(String uid, String pwd, String idPartido)
        {
            comando.Connection = conectABMP.Conectar(uid, pwd);
            comando.CommandText = "DELETE FROM Partido WHERE idPartido = @idPartido";
            comando.Parameters.AddWithValue("@idPartido", idPartido);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectABMP.Desconectar();
        }
    }

    public class CD_Deporte
    {
        private CD_Conexion conectABMD = new CD_Conexion();
        DataTable dgv = new DataTable();
        MySqlDataReader lector;
        MySqlCommand comando = new MySqlCommand();

        //Agregar al Diagrama de Clases
        public DataTable DGVContenidoD(String uid, String pwd)
        {
            comando.Connection = conectABMD.Conectar(uid, pwd);
            comando.CommandText = "SELECT idDeporte, nombreD FROM Deporte";
            lector = comando.ExecuteReader();
            dgv.Load(lector);
            conectABMD.Desconectar();
            return dgv;
        }

        public void AgregarD(String uid, String pwd, String idDeporte, String nombreD)
        {
            comando.Connection = conectABMD.Conectar(uid, pwd); ;
            comando.CommandText = "INSERT INTO Deporte (idDeporte,nombreD) " +
                "VALUES(@idDeporte,@nombreD)";
            comando.Parameters.AddWithValue("@idDeporte", idDeporte);
            comando.Parameters.AddWithValue("@nombreD", nombreD);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectABMD.Desconectar();
        }

        public void ModificarD(String uid, String pwd, String idDeporte, String nombreD)
        {
            comando.Connection = conectABMD.Conectar(uid, pwd);
            comando.CommandText = "UPDATE Deporte SET nombreD = @nombreD" +
                "WHERE idDeporte = @idDeporte";
            comando.Parameters.AddWithValue("@nombreD", nombreD);
            comando.Parameters.AddWithValue("@idDeporte", idDeporte);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectABMD.Desconectar();
        }

        public void BajarD(String uid, String pwd, String idDeporte)
        {
            comando.Connection = conectABMD.Conectar(uid, pwd);
            comando.CommandText = "DELETE FROM Deporte WHERE idDeporte = @idDeporte";
            comando.Parameters.AddWithValue("@idDeporte", idDeporte);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectABMD.Desconectar();
        }
    }
}
