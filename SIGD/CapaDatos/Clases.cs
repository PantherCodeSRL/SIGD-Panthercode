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
        public DataTable DGVContenidoP(String uid, String pwd, String filtro, String deporte)
        {
            dgv.Clear();
            comando.Connection = conectABMP.Conectar(uid, pwd);
            if (filtro == "<")
            {
                comando.CommandText = "SELECT idPartido, fechaHora, idLocal, idVisitante, resultadoLocal, resultadoVisita, D.nombreD FROM Partido P " +
                    "JOIN Equipo E JOIN Pertenece R JOIN Deporte D ON P.idLocal = E.idEquipo AND P.idVisitante = E.idEquipo AND E.idEquipo = R.idEquipo AND R.idDeporte = D.idDeporte " +
                    "WHERE D.idDeporte = '" + deporte + "' AND D.idDeporte = R.idDeporte AND fechaHora < now()";
                lector = comando.ExecuteReader();
            }
            else
            {
                comando.CommandText = "SELECT idPartido, fechaHora, idLocal, idVisitante, resultadoLocal, resultadoVisita, D.nombreD FROM Partido P " +
                    "JOIN Equipo E JOIN Pertenece R JOIN Deporte D ON P.idLocal = E.idEquipo AND P.idVisitante = E.idEquipo AND E.idEquipo = R.idEquipo AND R.idDeporte = D.idDeporte " +
                    "WHERE D.idDeporte = '" + deporte + "' AND D.idDeporte = R.idDeporte AND fechaHora >= now()";
                lector = comando.ExecuteReader();
                //'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'";
            }
            
            dgv.Load(lector);
            conectABMP.Desconectar();
            return dgv;
        }

        public void AgregarP(String uid, String pwd, String fechaHora, String idLocal, String idVisitante, String resultadoLocal, String resultadoVisita)
        {
            comando.Connection = conectABMP.Conectar(uid, pwd); ;
            comando.CommandText = "INSERT INTO Partido (fechaHora,idLocal,idVisitante,resultadoLocal,resultadoVisita) " +
                "VALUES(@fechaHora,@idLocal,@idVisitante,@resultadoLocal,@resultadoVisita)";
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

        public DataTable CBXContenidoD(String uid, String pwd)
        {
            comando.Connection = conectABMD.Conectar(uid, pwd);
            comando.CommandText = "SELECT nombreD FROM Deporte";
            lector = comando.ExecuteReader();
            dgv.Load(lector);
            conectABMD.Desconectar();
            return dgv;
        }

        public void AgregarD(String uid, String pwd, String nombreD)
        {
            comando.Connection = conectABMD.Conectar(uid, pwd); ;
            comando.CommandText = "INSERT INTO Deporte (nombreD) " +
                "VALUES(@nombreD)";
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

    public class CD_Incidencia
    {
        private CD_Conexion conectABMI = new CD_Conexion();
        DataTable dgv = new DataTable();
        MySqlDataReader lector;
        MySqlCommand comando = new MySqlCommand();

        //Agregar al Diagrama de Clases
        public DataTable DGVContenidoI(String uid, String pwd)
        {
            comando.Connection = conectABMI.Conectar(uid, pwd);
            comando.CommandText = "SELECT nIncidencia, descripcion, tiempo, idTipoInci, fechaRegistro FROM Incidencia";
            lector = comando.ExecuteReader();
            dgv.Load(lector);
            conectABMI.Desconectar();
            return dgv;
        }

        public void AgregarI(String uid, String pwd, String descripcion, String tiempo, String idTipoInci, String fechaRegistro)
        {
            comando.Connection = conectABMI.Conectar(uid, pwd); ;
            comando.CommandText = "INSERT INTO Incidencia (descripcion,tiempo,idTipoInci,fechaRegistro) " +
                "VALUES(@descripcion,@tiempo,@idTipoInci,@fechaRegistro)";
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@tiempo", tiempo);
            comando.Parameters.AddWithValue("@idTipoInci", idTipoInci);
            comando.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectABMI.Desconectar();
        }

        public void ModificarI(String uid, String pwd, String nIncidencia, String descripcion, String tiempo, String idTipoInci, String fechaRegistro)
        {
            comando.Connection = conectABMI.Conectar(uid, pwd);
            comando.CommandText = "UPDATE Incidencia SET descripcion = @descripcion,tiempo = @tiempo,idTipoInci = @idTipoInci, fechaRegistro = @fechaRegistro " +
                "WHERE nIncidencia = @nIncidencia";
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@tiempo", tiempo);
            comando.Parameters.AddWithValue("@idTipoInci", idTipoInci);
            comando.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
            comando.Parameters.AddWithValue("@nIncidencia", nIncidencia);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectABMI.Desconectar();
        }

        public void BajarI(String uid, String pwd, String nIncidencia)
        {
            comando.Connection = conectABMI.Conectar(uid, pwd);
            comando.CommandText = "DELETE FROM Incidencia WHERE nIncidencia = @nIncidencia";
            comando.Parameters.AddWithValue("@nIncidencia", nIncidencia);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectABMI.Desconectar();
        }
    }

    public class CD_TipoIncidencia
    {
        private CD_Conexion conectABMTi = new CD_Conexion();
        DataTable dgv = new DataTable();
        MySqlDataReader lector;
        MySqlCommand comando = new MySqlCommand();

        //Agregar al Diagrama de Clases
        public DataTable DGVContenidoTi(String uid, String pwd)
        {
            comando.Connection = conectABMTi.Conectar(uid, pwd);
            comando.CommandText = "SELECT idTipoInci, nomIncidencia FROM TipoIncidencia";
            lector = comando.ExecuteReader();
            dgv.Load(lector);
            conectABMTi.Desconectar();
            return dgv;
        }

        public void AgregarTi(String uid, String pwd, String nomIncidencia)
        {
            comando.Connection = conectABMTi.Conectar(uid, pwd); ;
            comando.CommandText = "INSERT INTO TipoIncidencia (nomIncidencia) " +
                "VALUES(@nomIncidencia)";
            comando.Parameters.AddWithValue("@nomIncidencia", nomIncidencia);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectABMTi.Desconectar();
        }

        public void ModificarTi(String uid, String pwd, String idTipoInci, String nomIncidencia)
        {
            comando.Connection = conectABMTi.Conectar(uid, pwd);
            comando.CommandText = "UPDATE TipoIncidencia SET nomIncidencia = @nomIncidencia " +
                "WHERE idTipoInci = @idTipoInci";
            comando.Parameters.AddWithValue("@nomIncidencia", nomIncidencia);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectABMTi.Desconectar();
        }

        public void BajarTi(String uid, String pwd, String idTipoInci)
        {
            comando.Connection = conectABMTi.Conectar(uid, pwd);
            comando.CommandText = "DELETE FROM TipoIncidencia WHERE idTipoInci = @idTipoInci";
            comando.Parameters.AddWithValue("@idTipoInci", idTipoInci);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conectABMTi.Desconectar();
        }
    }
}
