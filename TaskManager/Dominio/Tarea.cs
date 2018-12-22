using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Tarea
    {
        public int IdTarea { get; set; }
        public Tablero TableroAlQuePertenece { get; set; }
        public int IdUsuarionQueLaCreo { get; set; }// tb por las dudas si me es mas comodo
        public Estado Estado { get; set; }//estados posibles 1:TODO 2:DOING  3:DONE 4:ARCHIVADO estas eferencias las guardo en la base
        public String TituloTarea { get; set; }
        public String DescripcionTarea { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public List<Usuario> LstResponsables { get; set; }
        public List<Etiqueta> LstEtiquetasDeLaTarea { get; set; }
        public List<Comentario> LstComentarios { get; set; }

    }
}
