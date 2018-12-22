using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tablero
    {
        public int IdTablero { get; set; }
        public string Nombre { get; set; }//hasta 15 caracteres
        public Usuario UsuarioQueloCreo { get; set; }
        public Equipo EquipoDelTablero { get; set; }
        public List<Tarea> LstTareasDelTablero { get; set; }
        
    }
}
