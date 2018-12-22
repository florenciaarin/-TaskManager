using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Servicio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        //En el new de mi clase acceso datos creo la conexion y configuro parte del comando.
        public AccesoDatos()
        {
            conexion = new SqlConnection("initial catalog=TP_ADM_TAREAS; data source=.\\SQLExpress; integrated security=sspi");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }

        //seteo type y text cuando es una consulta simple (select, update, delete, insert)
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        //metodo que ejecuta la lectura
        public void leerConsulta()
        {
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //metodo que cierra la conexion
        public void cerrarConexion()
        {
            conexion.Close();
        }

        //metodo que ejecuta el insert, luego en realidad también lo vamos a usar
        //para delete y update.
        public void ejecutarAccion()
        {
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void limpiarParametros()
        {
            comando.Parameters.Clear();
        }

        public void agregarParametro(string nombre, string valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void setearSP(string sp)
        {
            //comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sp;
        }

    }
}
