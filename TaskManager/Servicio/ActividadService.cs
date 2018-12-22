using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Servicio
{
    public class ActividadService
    {
        public void insertActividad(Actividad activdad)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("insert into actividad (fechacreacion, descripcion, accionquelagenero, idusuarioquegenero, idtareagenero) values ( getdate(), '" + activdad.Descripcion+ "', '"+activdad.AccionQueLaGenera+"', "+activdad.UsuarioQueLaGenero.IdUsuario.ToString()+", "+activdad.IdTareaGenero.ToString()+" )");
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
        public IList<Actividad> actividadesPorTarea(int idTarea)
        {
            IList<Actividad> lista = new List<Actividad>();
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("select idactividad, fechacreacion, descripcion, accionquelagenero, idusuarioquegenero, idtareagenero from actividad where idtareagenero=" + idTarea.ToString());
                conexion.leerConsulta();
                while (conexion.Lector.Read())
                {
                    Actividad aux = new Actividad();
                    Usuario usuario = new Usuario();
                    aux.UsuarioQueLaGenero = usuario;
                    aux.IdActividad = conexion.Lector.GetInt32(0);
                    aux.FechaCreacion = conexion.Lector.GetDateTime(1);
                    aux.Descripcion = conexion.Lector.GetString(2);
                    aux.AccionQueLaGenera = conexion.Lector.GetString(3);
                    aux.UsuarioQueLaGenero.IdUsuario = conexion.Lector.GetInt32(4);
                    aux.IdTareaGenero = conexion.Lector.GetInt32(5);
                   
                    
                    lista.Add(aux);
                }
                lista = lista.OrderByDescending(x => x.IdActividad).ToList();
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
