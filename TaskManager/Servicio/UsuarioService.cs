using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Servicio
{
    public class UsuarioService
    {
        public IList<Usuario> traerMiembrosEquipoSinUserLog(int idEquipo, int idUsuario)
        {
            IList<Usuario> lista = new List<Usuario>();
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("SELECT usuario.idusuario, usuario.nombre FROM equipo_miembros INNER JOIN usuario ON usuario.idusuario=equipo_miembros.usuario WHERE equipo_miembros.equipo=" + idEquipo.ToString()+ " and equipo_miembros.usuario <> "+idUsuario.ToString());
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {
                    Usuario aux = new Usuario();
                    aux.IdUsuario = conexion.Lector.GetInt32(0);
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
        public IList<Usuario> traerTodosLosUserMenosLogueado(int idUserLogueado)
        {

            IList<Usuario> lista = new List<Usuario>();
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("SELECT idusuario, nombre FROM usuario where idusuario <>"+idUserLogueado.ToString());
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {
                    Usuario aux = new Usuario();
                    aux.IdUsuario = conexion.Lector.GetInt32(0);
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
        public void updetearUsuario(Usuario user)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("update usuario set nombre='" + user.Nombre + "', iniciales='"+user.Iniciales+"', mail='"+user.Mail+"', password='"+user.Password+"' where idusuario="+user.IdUsuario.ToString());
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
        public void insertUsuario(Usuario user)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("insert into usuario(nombre, iniciales, mail, password) values('" + user.Nombre + "', '" + user.Iniciales + "', '"+user.Mail+"', '"+user.Password+"')");
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
        public Usuario traerUsuario(String mail)
        {
            
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("SELECT idusuario, nombre, iniciales,  mail, password FROM usuario WHERE mail='" + mail +"'");
                conexion.leerConsulta();
                conexion.Lector.Read();
                Usuario user = new Usuario();
                user.IdUsuario = conexion.Lector.GetInt32(0);
                user.Nombre = conexion.Lector.GetString(1);
                user.Iniciales = conexion.Lector.GetString(2);
                user.Mail = conexion.Lector.GetString(3);
                user.Password = conexion.Lector.GetString(4);

                return user;
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
        public Boolean validarSiExisteUsuario(String mail)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("select count(*) from usuario where mail='"+mail+"'");
                conexion.leerConsulta();
                conexion.Lector.Read();
                int resultado = conexion.Lector.GetInt32(0);
                if(resultado == 0)
                {
                    return false;
                }
                else
                {
                    return true;
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
        }


        public IList<Usuario> traerMiembrosEquipo(int idEquipoDelTablero)
        {
            IList<Usuario> lista = new List<Usuario>();
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("SELECT usuario.idusuario, usuario.nombre FROM equipo_miembros INNER JOIN usuario ON usuario.idusuario=equipo_miembros.usuario WHERE equipo_miembros.equipo=" + idEquipoDelTablero.ToString());
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {
                    Usuario aux = new Usuario();
                    aux.IdUsuario = conexion.Lector.GetInt32(0);
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
        public IList<Usuario> traerResponsablesTarea(int idTarea)
        {
            IList<Usuario> lista = new List<Usuario>();
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("SELECT usuario.idusuario, usuario.nombre, usuario.mail FROM tarea_responsables INNER JOIN USUARIO ON tarea_responsables.usuario=usuario.idusuario WHERE tarea_responsables.tarea=" + idTarea.ToString());
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {
                    Usuario aux = new Usuario();
                    aux.IdUsuario = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);
                    aux.Mail = conexion.Lector.GetString(2);
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
