using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }//libres caracteres
        public string Iniciales { get; set; }//solo dos caracteres permitidos maximo
        public string Mail { get; set; }
        public string Password { get; set; }//minimo 6 caracteres
        public List<Tablero> LstTableros { get; set; }
        public List<Equipo> LstEquipos { get; set; }
        public List<Tarea> LstTareasAcargo { get; set; }//no creo que la use 
        public List<Comentario> LstComentarios { get; set; }//no creo que la use

        public override string ToString()
        {
            return Nombre;
        }
        public Usuario() { }

        public Usuario( int idUser, String name, String iniciales, String mail, String password)
        {
            this.IdUsuario = idUser;
            this.Nombre = name;
            this.Iniciales = iniciales;
            this.Mail = mail;
            this.Password = password;
            
            
        }
    }
}
