using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Actividad
    {
        public int IdActividad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Usuario UsuarioQueLaGenero { get; set; }
        public String AccionQueLaGenera { get; set; }//ejemplo si la movieron de lista, la eliminaron, etc
        public String Descripcion { get; set; }//por ahi esta no hace falta porque lo genero sobrescribiendo ToString de actividad con los datos anteriores se genera automatico y ya
        public int IdTareaGenero { get; set; }

    }
}
