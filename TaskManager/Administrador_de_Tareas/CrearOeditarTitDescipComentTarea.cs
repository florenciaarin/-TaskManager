using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Servicio;

namespace Administrador_de_Tareas
{
    public partial class CrearOeditarTitDescipComentTarea : Form
    {
        Tarea tareaEnVista = new Tarea();
        String evento;
        Comentario comentario = new Comentario();

        public CrearOeditarTitDescipComentTarea()
        {
            InitializeComponent();
        }
        public void recibirDataDeVerEditTarea(Tarea tareaEnVista, String evento)
        {
            this.tareaEnVista = tareaEnVista;
            this.evento = evento;
        }
        public void recibirDataDeVerEditTarea(Tarea tareaEnVista, String evento, Comentario comentario)
        {
            this.tareaEnVista = tareaEnVista;
            this.evento = evento;
            this.comentario = comentario;
        }

        private void buttonSaveCambiosTitComenDescr_Click(object sender, EventArgs e)
        {
            TareaService tareaServicio = new TareaService();
            ActividadService actividadServicio = new ActividadService();
            Actividad actividad = new Actividad();
            actividad.IdTareaGenero = tareaEnVista.IdTarea;
            actividad.UsuarioQueLaGenero = HOME.userLogueado;
            try
            {
                if (evento.Equals("titulo"))
                {
                    tareaServicio.updateNameTask(tareaEnVista.IdTarea, textBoxEditarOcraerDescTitComent.Text);
                    actividad.AccionQueLaGenera = "EDITAR TITULO";
                    actividad.Descripcion = HOME.userLogueado.Nombre + " cambió el título";
                    actividadServicio.insertActividad(actividad);
                }
                if (evento.Equals("descripcion"))
                {
                    tareaServicio.updateDescripcionTask(tareaEnVista.IdTarea, textBoxEditarOcraerDescTitComent.Text);
                    actividad.AccionQueLaGenera = "EDITAR DESCRIPCION";
                    actividad.Descripcion = HOME.userLogueado.Nombre + " editó la descripción";
                    actividadServicio.insertActividad(actividad);
                }
                if (evento.Equals("comentario"))
                {
                    ComentarioService comentarioServicio = new ComentarioService();
                    comentario.Comentarios = textBoxEditarOcraerDescTitComent.Text;
                    comentarioServicio.updateComent(comentario);
                 
                    actividad.AccionQueLaGenera = "EDITAR COMENTARIO";
                    actividad.Descripcion = HOME.userLogueado.Nombre + " editó su comentario";
                    actividadServicio.insertActividad(actividad);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
               

            VerEditarTAREA vistaTarea = Owner as VerEditarTAREA;
            vistaTarea.refreshVerEditarTarea();
            this.Close();
        }

        private void CrearOeditarTitDescipComentTarea_Load(object sender, EventArgs e)
        {
            if (this.evento.Equals("descripcion"))
            {
                textBoxEditarOcraerDescTitComent.Text = this.tareaEnVista.DescripcionTarea;
            }
            else
            {
                if (this.evento.Equals("titulo"))
                {
                    textBoxEditarOcraerDescTitComent.Text = this.tareaEnVista.TituloTarea;
                }
                else
                {
                    if (this.evento.Equals("comentario"))
                    {
                        textBoxEditarOcraerDescTitComent.Text = this.comentario.Comentarios;
                    }
                }
            }
        }
    }
}
