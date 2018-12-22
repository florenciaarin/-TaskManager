using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Equipo
    {
        public int IdEquipo { get; set; }
        public String NombreEquipo { get; set; }
        public String Descripcion { get; set; }
        public List<Usuario> LstMiembros { get; set; }
        public List<Tablero> LstTablerosDelEquipo { get; set; }

        public override string ToString()
        {
            return NombreEquipo;
        }
    }
}
