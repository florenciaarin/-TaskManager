using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Servicio
{
    public class EquipoService
    {
        public void updetearEquipo(String nombre, String descripcion, int idEquipo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("update equipo set nombre='" + nombre + "', descripcion='" + descripcion + "' where idequipo=" + idEquipo.ToString());
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
        public void agregarMiembroAequipo(int idEquipo, int idUsuario)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("insert into equipo_miembros (equipo, usuario) values (" + idEquipo.ToString() + ", " + idUsuario.ToString() + ")");
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
        public void borrarMiembroAequipo(int idEquipo, int idUsuario)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("delete from equipo_miembros where equipo=" + idEquipo.ToString() + " and usuario=" + idUsuario.ToString());
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
        public int insertEquipo(String nombre, String descripcion)//retorna el id del equipo creado
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("insert into equipo (nombre, descripcion) values ('" + nombre + "', '" + descripcion + "')");
                conexion.ejecutarAccion();

                int idEquipoCreado = this.obtenerUltimoIdEquipoGenerado();
                             

                return idEquipoCreado;
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

        public void borrarEquipo(int idEquipo)
        {

            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("delete from equipo where idequipo=" + idEquipo.ToString());
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

        public int obtenerUltimoIdEquipoGenerado()//retorna el id del equipo creado
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("SELECT MAX(idequipo) FROM equipo");
                conexion.leerConsulta();
                conexion.Lector.Read();
                int idEquipoCreado = conexion.Lector.GetInt32(0);
                
                return idEquipoCreado;
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
        public Equipo traerDataPrincipalEquipo(int idEquipo)
        {
            Equipo equipo = new Equipo();
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("select idequipo, nombre, descripcion from equipo where idequipo = "+idEquipo.ToString());
                conexion.leerConsulta();
                conexion.Lector.Read();
                equipo.IdEquipo = conexion.Lector.GetInt32(0);
                equipo.NombreEquipo = conexion.Lector.GetString(1);
                equipo.Descripcion = conexion.Lector.GetString(2);
                return equipo;
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

       
        public IList<Equipo> ListarEquiposDelUsuario(Usuario userLogueado)
        {
            IList<Equipo> lista = new List<Equipo>();
            AccesoDatos conexion = new AccesoDatos();
            int idUser = userLogueado.IdUsuario;
            try
            {
                conexion.setearConsulta("select equipo.idequipo, equipo.nombre, equipo.descripcion from equipo inner join equipo_miembros on equipo.idequipo = equipo_miembros.equipo where equipo_miembros.usuario =" + idUser.ToString());
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {
                    Equipo aux = new Equipo();
                    aux.IdEquipo = conexion.Lector.GetInt32(0);
                    aux.NombreEquipo = conexion.Lector.GetString(1);
                    aux.Descripcion = conexion.Lector.GetString(2);
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
    }
}
