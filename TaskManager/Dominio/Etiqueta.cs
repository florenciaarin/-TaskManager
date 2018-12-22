using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Etiqueta
    {
        public int IdEtiqueta { get; set; }
        public String Nombre { get; set; }
        public List<Tarea> TareasConEsaEtiqueta { get; set; }
  
    }
}
