using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Servicio
{
    public class TableroService
    {
        public void updetearEquipoDelTablero(int idTablero, int idEquipo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("update tablero set idequipo =" + idEquipo.ToString() + " where idtablero=" + idTablero.ToString());
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        public void updateNombreTablero(int idTablero, String nuevoNombre)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("update tablero set nombre ='"+nuevoNombre+"' where idtablero="+idTablero.ToString());
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }
        public int traerIdEquipoTablero(int idTablero)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta(" select idequipo from tablero  where idtablero="+idTablero.ToString());
                conexion.leerConsulta();
                conexion.Lector.Read();
                int idEquipo = conexion.Lector.GetInt32(0);
                return idEquipo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        public IList<Tablero> todosLosIdsTablerosDeunEquipo(int idEquipo)
        {
            IList<Tablero> lista = new List<Tablero>();
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta(" select tablero.idtablero, tablero.nombre  from tablero where idequipo=" + idEquipo.ToString());
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {

                    Tablero aux = new Tablero();
                    aux.IdTablero = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        public List<int> todosLosIdsTablerosConEquipo()
        {
            List<int> lista = new List<int>();
            AccesoDatos conexion = new AccesoDatos();
            try
            {

                conexion.setearConsulta(" select idtablero from tablero  where idequipo is not null");
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {
                    int aux = conexion.Lector.GetInt32(0);
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }

        }
        public int obtenerIdCreador(int idTablero)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("select idusuariocreacion from tablero where idtablero="+ idTablero.ToString());
                conexion.leerConsulta();
                conexion.Lector.Read();

                int idUsuarioCreo = conexion.Lector.GetInt32(0);
                return idUsuarioCreo;

            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        public void insertTablero(String nombre, int idUserCreo, int idEquipo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("insert into tablero (nombre, idequipo, idusuariocreacion) values ('"+nombre+"', "+idEquipo.ToString()+", "+idUserCreo.ToString()+")");
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }
        public void insertTablero(String nombre, int idUserCreo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("insert into tablero (nombre, idusuariocreacion) values ('" + nombre + "', " + idUserCreo.ToString() + ")");
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }
        public void  eliminarTablero(int idTablero)
        {
            
            AccesoDatos conexion = new AccesoDatos();
            try
            {
              
                conexion.setearConsulta(

                    "DELETE tarea_responsables from tarea_responsables Tdel inner join tarea Tfiltro on Tdel.tarea = Tfiltro.idtarea where TFiltro.idtablero = "+idTablero.ToString()+
                    "DELETE etiqueta_tareas from etiqueta_tareas Tdel inner join tarea Tfiltro on Tdel.tarea = Tfiltro.idtarea where TFiltro.idtablero  ="+idTablero.ToString()+
                    "DELETE comentario from comentario com inner join tarea tar  on com.idtarea = tar.idtarea where tar.idtablero = " + idTablero.ToString() +
                    "DELETE from tarea where tarea.idtablero = " + idTablero.ToString() +
                    "DELETE from tablero where tablero.idtablero = " + idTablero.ToString()
                    
                    );
                conexion.ejecutarAccion();
             
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        public IList<Tablero> listarTablerosDelUser(int idUser)
        {
            IList<Tablero> lista = new List<Tablero>();
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta(" select tablero.idtablero, tablero.nombre  from tablero inner join equipo on tablero.idequipo = equipo.idequipo inner join equipo_miembros on equipo_miembros.equipo = equipo.idequipo inner join usuario on equipo_miembros.usuario = usuario.idusuario where usuario.idusuario ="+idUser.ToString());
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {

                    Tablero aux = new Tablero();
                    aux.IdTablero = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);
                    
                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }

            AccesoDatos conexion2 = new AccesoDatos();
            try
            {
                conexion2.setearConsulta(" select tablero.idtablero, tablero.nombre  from tablero where tablero.idusuariocreacion =" + idUser.ToString()+"and tablero.idequipo is null");
                conexion2.leerConsulta();
                while (conexion2.Lector.Read())
                {
                    Tablero aux = new Tablero();
                    aux.IdTablero = conexion2.Lector.GetInt32(0);
                    aux.Nombre = conexion2.Lector.GetString(1);
                    lista.Add(aux);
                }
                  return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion2.cerrarConexion();
                conexion2 = null;
            }

            
        }
        
        public void eliminarEquiposDeLosTableros(int idEquipo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("update tablero set idequipo = NULL where idequipo=" + idEquipo.ToString());
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }
    }
}
