using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Servicio
{
    public class ComentarioService
    {
        public void eliminarComent(Comentario coment)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("delete from comentario where idcomentario="+coment.IdComentario.ToString());
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
        public void updateComent(Comentario comentario)
        {
            AccesoDatos conexion = new AccesoDatos();
            
            try
            {
                conexion.setearConsulta("update comentario set descripcomentario ='" + comentario.Comentarios + "', fechacreacion = getdate() where idcomentario=" + comentario.IdComentario.ToString());
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


        public IList<Comentario> traerComentariosDeTarea(int idTarea)
        {
            IList<Comentario> lista = new List<Comentario>();
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("SELECT comentario.descripcomentario, comentario.fechacreacion, " +
                    "comentario.idcomentario, comentario.idtarea, usuario.idusuario,usuario.iniciales," +
                    " usuario.mail, usuario.nombre FROM comentario INNER JOIN usuario ON " +
                    "usuario.idusuario=comentario.idusuariocreacion WHERE comentario.idtarea="+ idTarea.ToString());
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {
                    Comentario aux = new Comentario();
                    Usuario us = new Usuario();
                    aux.Usuario = us;
                    aux.Comentarios = conexion.Lector.GetString(0);
                    aux.Fecha = conexion.Lector.GetDateTime(1);
                    aux.IdComentario = conexion.Lector.GetInt32(2);
                    aux.IdTarea = conexion.Lector.GetInt32(3);
                    aux.Usuario.IdUsuario = conexion.Lector.GetInt32(4);
                    aux.Usuario.Iniciales= conexion.Lector.GetString(5);
                    aux.Usuario.Mail = conexion.Lector.GetString(6);
                    aux.Usuario.Nombre= conexion.Lector.GetString(7);



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

        public void agrgarComentDeTarea(int idTarea, int idUserCreador, String comentario)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("insert into comentario (idtarea, idusuariocreacion, descripcomentario, fechacreacion)" +
                    "values (" + idTarea.ToString() + ", " + idUserCreador.ToString() + ", '" + comentario + "', getdate())");
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
