using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Estado
    {
        public int IdEstado { get; set; }
        public String NombreEstado { get; set; }
        public List<Tarea> TareasConEseEstado { get; set; }

        public override string ToString()
        {
            return NombreEstado;
        }
        public Estado()
        {

        }
        public Estado(int id, String name)
        {
            IdEstado = id;
            NombreEstado = name;
        }
    }
}
