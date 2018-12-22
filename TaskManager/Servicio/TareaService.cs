using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Servicio
{
    public class TareaService
    {
        public void deleteResponsableATarea(int idResponsable, int idTarea)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("delete from tarea_responsables where usuario="+ idResponsable.ToString() + " and tarea=" + idTarea.ToString());
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
        public void insertarResponsableATarea(int idResponsable, int idTarea)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("insert into tarea_responsables(usuario,tarea) values("+idResponsable.ToString()+","+idTarea.ToString()+")");
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
      
        public void eliminarTarea(int idTarea)
        {
      
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta(

                     "DELETE tarea_responsables from tarea_responsables Tdel inner join tarea Tfiltro on Tdel.tarea = Tfiltro.idtarea where TFiltro.idtarea = " + idTarea.ToString() +
                    "DELETE etiqueta_tareas from etiqueta_tareas Tdel inner join tarea Tfiltro on Tdel.tarea = Tfiltro.idtarea where TFiltro.idtarea  =" + idTarea.ToString() +
                    "DELETE comentario from comentario com inner join tarea tar  on com.idtarea = tar.idtarea where tar.idtarea = " + idTarea.ToString() +
                    "DELETE from tarea where tarea.idtablero = " + idTarea.ToString() 

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
        public void updetearIdEstadoTarea(int idTarea,int idEstado)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("update tarea set idestado = " + idEstado.ToString() + " where idtarea=" + idTarea.ToString());
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
        public void updateDescripcionTask(int idTarea, String descripcion)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("update tarea set descripcion = '" + descripcion + "' where idtarea=" + idTarea.ToString());
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

        public Tarea traerTarea(int idTarea)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("select idtarea, idtablero, idestado, titulo, idusuariocreo, fechacreacion, descripcion, fechavencimiento from tarea where idtarea=" + idTarea.ToString());
                conexion.leerConsulta();
                conexion.Lector.Read();
                
                    Tarea aux = new Tarea();
                    Tablero tabAux = new Tablero();
                    Estado auxEstado = new Estado();
                    aux.Estado = auxEstado;
                    aux.TableroAlQuePertenece = tabAux;
                    aux.IdTarea = conexion.Lector.GetInt32(0);
                    aux.TableroAlQuePertenece.IdTablero = conexion.Lector.GetInt32(1);
                    aux.Estado.IdEstado = conexion.Lector.GetInt32(2);
                    aux.TituloTarea = conexion.Lector.GetString(3);
                    aux.IdUsuarionQueLaCreo = conexion.Lector.GetInt32(4);
                    aux.FechaCreacion = conexion.Lector.GetDateTime(5);
                    aux.DescripcionTarea = conexion.Lector.GetString(6);
                    aux.FechaVencimiento = conexion.Lector.GetDateTime(7);
                   
                
                return aux;
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
        public void updateNameTask(int idTarea, String titulo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("update tarea set titulo = '"+ titulo +"' where idtarea="+idTarea.ToString());
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
        public void eliminarDuaDate(int idTarea)
        {

            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("update tarea set fechavencimiento = '1/1/0001 00:00:00' where idtarea =" + idTarea.ToString());
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

        public void updetearDuaDate(int idTarea, DateTime fechaVencimiento)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("update tarea set fechavencimiento = '"+fechaVencimiento.ToString()+"' where idtarea ="+idTarea.ToString());
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
        public void createTareaToTablero(int idTablero, int idUsuario, int idEstado, String titulo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("insert into tarea (idtablero, idusuariocreo, descripcion, idestado, titulo, fechacreacion, fechavencimiento)" +
                    "values ("+idTablero.ToString()+", "+idUsuario.ToString()+", 'Sin descripción', "+idEstado.ToString()+", '"+titulo+ "', getdate(), '1/1/0001 00:00:00')");
                conexion.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }
        public IList<Tarea> tareasPorEstadoDelTablero(int idTablero, int idEstado)
        {
            IList<Tarea> lista = new List<Tarea>();
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("select idtarea, idtablero, idestado, titulo, idusuariocreo, fechacreacion, descripcion, fechavencimiento from tarea where idtablero =" + idTablero.ToString() + " and idestado=" + idEstado.ToString());
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {
                    Tarea aux = new Tarea();
                    Tablero tabAux = new Tablero();
                    Estado auxEstado = new Estado();
                    aux.Estado = auxEstado;
                    aux.TableroAlQuePertenece = tabAux;
                    aux.IdTarea = conexion.Lector.GetInt32(0);
                    aux.TableroAlQuePertenece.IdTablero = conexion.Lector.GetInt32(1);
                    aux.Estado.IdEstado = conexion.Lector.GetInt32(2);
                    aux.TituloTarea = conexion.Lector.GetString(3);
                    aux.IdUsuarionQueLaCreo = conexion.Lector.GetInt32(4);
                    aux.FechaCreacion = conexion.Lector.GetDateTime(5);
                    aux.DescripcionTarea = conexion.Lector.GetString(6);
                    aux.FechaVencimiento= conexion.Lector.GetDateTime(7);
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
