using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Comentario
    {
        public int IdComentario { get; set; }
        public int IdTarea { get; set; }
        public String Comentarios { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        

    }
}
