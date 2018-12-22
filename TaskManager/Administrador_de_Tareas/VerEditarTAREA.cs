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
using System.Globalization;

namespace Administrador_de_Tareas
{
    public partial class VerEditarTAREA : Form
    {
        private Tarea tareaEnVista = new Tarea();
        private Usuario userLogueado = new Usuario();
        private Tablero tableroEnUso = new Tablero();
        private IList<Comentario> lstComentarios = new List<Comentario>();
        private IList<Usuario> lstResponsables = new List<Usuario>();
        private IList<Actividad> lstActividades = new List<Actividad>();
        private Comentario comentarioSeleccionado;

        public VerEditarTAREA()
        {
            InitializeComponent();
        }

        public void recibirDataTablero(Tarea tareaVista, Usuario userLogueado, Tablero tableroEnUso)
        {
            this.tareaEnVista = tareaVista;
            this.userLogueado = userLogueado;
            this.tableroEnUso = tableroEnUso;
        }
        private void VerEditarTAREA_Load(object sender, EventArgs e)
        {
            
            textBoxAgregarComent.Text = "";
            TareaService tareaServicio = new TareaService();
            UsuarioService usuarioServicio = new UsuarioService();
            ActividadService actividadServicio = new ActividadService();
            try
            {
                dgvActividades.DataSource = actividadServicio.actividadesPorTarea(tareaEnVista.IdTarea);
                dgvActividades.Columns[0].Visible = false;
                dgvActividades.Columns[2].Visible = false;
                dgvActividades.Columns[3].Visible = false;
                dgvActividades.Columns[5].Visible = false;
                tareaEnVista =tareaServicio.traerTarea(tareaEnVista.IdTarea);
                lstResponsables = usuarioServicio.traerResponsablesTarea(tareaEnVista.IdTarea);
                cmBoxResponsablesTarea.DataSource = lstResponsables;
                if (tableroEnUso.EquipoDelTablero.NombreEquipo == "no tiene equipo")
                {
                    buttonAddResponsable.Enabled = false;
                    buttonEliminarResponsable.Enabled = false;
                }
                else
                {
                    buttonAddResponsable.Enabled = true;
                    buttonEliminarResponsable.Enabled = true;
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            labelTituloTarea.Text = tareaEnVista.TituloTarea;
            if (tareaEnVista.Estado.IdEstado == 1)
            {
                labelNombreListaDeTarea.Text = "TO DO";
            }
            else if(tareaEnVista.Estado.IdEstado == 2)
            {
                labelNombreListaDeTarea.Text = "DOING";
            }else if (tareaEnVista.Estado.IdEstado == 3)
            {
                labelNombreListaDeTarea.Text = "DONE";
            }else if (tareaEnVista.Estado.IdEstado == 4)
            {
                labelNombreListaDeTarea.Text = "Archivados";
            }
            labelDescripcionTarea.Text = tareaEnVista.DescripcionTarea;
            if (tareaEnVista.FechaVencimiento.ToString().Equals("1/1/0001 00:00:00"))
            {
                labelFechaVenTextFormato.Text = "Sin fecha asignada";
            }
            else
            {
                labelFechaVenTextFormato.Text = tareaEnVista.FechaVencimiento.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            try
            {
                ComentarioService comentarioServicio = new ComentarioService();
                lstComentarios = comentarioServicio.traerComentariosDeTarea(tareaEnVista.IdTarea);
                dgvComentariosTarea.DataSource = null;
                dgvComentariosTarea.DataSource = lstComentarios;
                dgvComentariosTarea.Columns[0].Visible = false;
                dgvComentariosTarea.Columns[1].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (lstComentarios.Count==0)
            {
                buttonVerComentario.Enabled = false;
                buttonEditComent.Enabled = false;
                buttonDeleteComent.Enabled = false;
            }
            else
            {
                buttonVerComentario.Enabled = true;
                buttonEditComent.Enabled = true;
                buttonDeleteComent.Enabled = true;
            }


        }
        public void refreshVerEditarTarea()//copy paste always load
        {
            textBoxAgregarComent.Text = "";
            TareaService tareaServicio = new TareaService();
            UsuarioService usuarioServicio = new UsuarioService();
            ActividadService actividadServicio = new ActividadService(); 

            try
            {
                dgvActividades.DataSource = actividadServicio.actividadesPorTarea(tareaEnVista.IdTarea);
                dgvActividades.Columns[0].Visible = false;
                dgvActividades.Columns[2].Visible = false;
                dgvActividades.Columns[3].Visible = false;
                dgvActividades.Columns[5].Visible = false;
                tareaEnVista = tareaServicio.traerTarea(tareaEnVista.IdTarea);
                lstResponsables = usuarioServicio.traerResponsablesTarea(tareaEnVista.IdTarea);
                cmBoxResponsablesTarea.DataSource = lstResponsables;
                if (tableroEnUso.EquipoDelTablero.NombreEquipo == "no tiene equipo")
                {
                    buttonAddResponsable.Enabled = false;
                    buttonEliminarResponsable.Enabled = false;
                }
                else
                {
                    buttonAddResponsable.Enabled = true;
                    buttonEliminarResponsable.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            labelTituloTarea.Text = tareaEnVista.TituloTarea;
            if (tareaEnVista.Estado.IdEstado == 1)
            {
                labelNombreListaDeTarea.Text = "TO DO";
            }
            else if (tareaEnVista.Estado.IdEstado == 2)
            {
                labelNombreListaDeTarea.Text = "DOING";
            }
            else if (tareaEnVista.Estado.IdEstado == 3)
            {
                labelNombreListaDeTarea.Text = "DONE";
            }
            else if (tareaEnVista.Estado.IdEstado == 4)
            {
                labelNombreListaDeTarea.Text = "Archivados";
            }
            labelDescripcionTarea.Text = tareaEnVista.DescripcionTarea;
            if (tareaEnVista.FechaVencimiento.ToString().Equals("1/1/0001 00:00:00"))
            {
                labelFechaVenTextFormato.Text = "Sin fecha asignada";
            }
            else
            {
                labelFechaVenTextFormato.Text = tareaEnVista.FechaVencimiento.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            try
            {
                ComentarioService comentarioServicio = new ComentarioService();
                lstComentarios = comentarioServicio.traerComentariosDeTarea(tareaEnVista.IdTarea);
                dgvComentariosTarea.DataSource = null;
                dgvComentariosTarea.DataSource = lstComentarios;
                dgvComentariosTarea.Columns[0].Visible = false;
                dgvComentariosTarea.Columns[1].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (lstComentarios.Count == 0)
            {
                buttonVerComentario.Enabled = false;
                buttonEditComent.Enabled = false;
                buttonDeleteComent.Enabled = false;
            }
            else
            {
                buttonVerComentario.Enabled = true;
                buttonEditComent.Enabled = true;
                buttonDeleteComent.Enabled = true;
            }

        }

        private void buttonVolverAtablero_Click(object sender, EventArgs e)
        {
            TABLERO vistaTablero = Owner as TABLERO;
            vistaTablero.refreshTablero();
            this.Close();
        }

        private void buttonCraerEditarFechaVenc_Click(object sender, EventArgs e)
        {
            AddEditDueDate vistaDueDate = new AddEditDueDate();
            vistaDueDate.recibirDataEditarVerTarea(tareaEnVista);
            AddOwnedForm(vistaDueDate);
            vistaDueDate.Show();
        }

        private void buttonEditarTitulo_Click(object sender, EventArgs e)
        {
            CrearOeditarTitDescipComentTarea nuevaVentana = new CrearOeditarTitDescipComentTarea();
            nuevaVentana.recibirDataDeVerEditTarea(tareaEnVista,"titulo");
            AddOwnedForm(nuevaVentana);
            nuevaVentana.Show();
        }

        private void buttonEditarDescripcion_Click(object sender, EventArgs e)
        {
            CrearOeditarTitDescipComentTarea nuevaVentana = new CrearOeditarTitDescipComentTarea();
            nuevaVentana.recibirDataDeVerEditTarea(tareaEnVista, "descripcion");
            AddOwnedForm(nuevaVentana);
            nuevaVentana.Show();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            MoverTarea vistaMoverTask = new MoverTarea();
            vistaMoverTask.recibirDataEditarVerTarea(tareaEnVista);
            AddOwnedForm(vistaMoverTask);
            vistaMoverTask.Show();
            
        }

        private void buttonArchivar_Click(object sender, EventArgs e)
        {
            TareaService tareaServicio = new TareaService();
            try
            {
                tareaServicio.updetearIdEstadoTarea(tareaEnVista.IdTarea, 4);
                ActividadService actividadServicio = new ActividadService();
                Actividad actividad = new Actividad();
                actividad.IdTareaGenero = tareaEnVista.IdTarea;
                actividad.UsuarioQueLaGenero = HOME.userLogueado;
                actividad.AccionQueLaGenera = "ARCHIVAR";
                actividad.Descripcion = HOME.userLogueado.Nombre + " archivó la tarea";
                actividadServicio.insertActividad(actividad);

                this.refreshVerEditarTarea();

                MessageBox.Show("Tarea Archivada");
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void buttonEliminarTarea_Click(object sender, EventArgs e)
        {
            TareaService tareaServicio = new TareaService();
            ActividadService actividadServicio = new ActividadService();
            Actividad actividad = new Actividad();
            actividad.IdTareaGenero = tareaEnVista.IdTarea;
            actividad.UsuarioQueLaGenero = HOME.userLogueado;
            actividad.AccionQueLaGenera = "ELIMINAR";
            actividad.Descripcion = HOME.userLogueado.Nombre+" eliminó la tarea";
            try
            {
                if (tareaEnVista.IdUsuarionQueLaCreo == userLogueado.IdUsuario)
                {
                    tareaServicio.eliminarTarea(tareaEnVista.IdTarea);
                    MessageBox.Show("La tarea fue eliminada");
                    actividadServicio.insertActividad(actividad);
                    this.Close();
                    this.buttonVolverAtablero_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Solo el creador de la tarea puede eliminarla");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void buttonAgregarComent_Click(object sender, EventArgs e)
        {
            try
            {
                ComentarioService comentarioServicio = new ComentarioService();
                comentarioServicio.agrgarComentDeTarea(tareaEnVista.IdTarea, userLogueado.IdUsuario, textBoxAgregarComent.Text);

                ActividadService actividadServicio = new ActividadService();
                Actividad actividad = new Actividad();
                actividad.IdTareaGenero = tareaEnVista.IdTarea;
                actividad.UsuarioQueLaGenero = HOME.userLogueado;
                actividad.AccionQueLaGenera = "ADD COMENTARIO";
                actividad.Descripcion = HOME.userLogueado.Nombre + " hizo un comentario";
                actividadServicio.insertActividad(actividad);

                this.refreshVerEditarTarea();
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        private void buttonVerComentario_Click(object sender, EventArgs e)
        {
            if (comentarioSeleccionado != null)
            {
                try
                {
                    Comentario comentarioSeleccionado = (Comentario)dgvComentariosTarea.CurrentRow.DataBoundItem;
                    MessageBox.Show(comentarioSeleccionado.Comentarios);
                    comentarioSeleccionado = null;
                }
                catch (Exception ex)
                {

                    throw ex;

                }
            }
            else
            {
                MessageBox.Show("Seleccione un comentario");
            }
           
            
       
            
        }

        private void buttonEditComent_Click(object sender, EventArgs e)
        {
          
            if (comentarioSeleccionado != null)
            {
                
                if (userLogueado.IdUsuario == comentarioSeleccionado.Usuario.IdUsuario)
                {
                    CrearOeditarTitDescipComentTarea nuevaVentana = new CrearOeditarTitDescipComentTarea();
                    nuevaVentana.recibirDataDeVerEditTarea(tareaEnVista, "comentario", comentarioSeleccionado);
                    AddOwnedForm(nuevaVentana);
                    nuevaVentana.Show();
                }
                else
                {
                    MessageBox.Show("No tiene permitido modificar este comentario");
                }
                comentarioSeleccionado = null;
            }
            else
            {
                MessageBox.Show("Seleccione un comentario por favor");
            }
           
        }

        private void buttonDeleteComent_Click(object sender, EventArgs e)
        {
            if (comentarioSeleccionado != null)
            {
                if (userLogueado.IdUsuario == comentarioSeleccionado.Usuario.IdUsuario)
                {
                    try
                    {
                        ComentarioService comentarioServicio = new ComentarioService();
                        comentarioServicio.eliminarComent(comentarioSeleccionado);
                        MessageBox.Show("Comentario Eliminado");
                        ActividadService actividadServicio = new ActividadService();
                        Actividad actividad = new Actividad();
                        actividad.IdTareaGenero = tareaEnVista.IdTarea;
                        actividad.UsuarioQueLaGenero = HOME.userLogueado;
                        actividad.AccionQueLaGenera = "ELIMINAR COMENTARIO";
                        actividad.Descripcion = HOME.userLogueado.Nombre + " eliminó su comentario";
                        actividadServicio.insertActividad(actividad);
                        this.refreshVerEditarTarea();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    MessageBox.Show("No tiene permitido eliminar este comentario");
                }
                comentarioSeleccionado = null;
            }
            else
            {
                MessageBox.Show("Seleccione un comentario");
            }
          
        }

  
        private void buttonAddResponsable_Click_1(object sender, EventArgs e)
        {
            AddResponsable vistaAddResp = new AddResponsable();
            vistaAddResp.recibirDataVerEditTask(tableroEnUso.EquipoDelTablero.IdEquipo, tareaEnVista.IdTarea);
            AddOwnedForm(vistaAddResp);
            vistaAddResp.ShowDialog();
        }

        private void buttonEliminarResponsable_Click(object sender, EventArgs e)
        {
            try
            {
                TareaService tareaServicio = new TareaService();
                Usuario responsable = (Usuario)cmBoxResponsablesTarea.SelectedItem;
                tareaServicio.deleteResponsableATarea(responsable.IdUsuario, tareaEnVista.IdTarea);

                ActividadService actividadServicio = new ActividadService();
                Actividad actividad = new Actividad();
                actividad.IdTareaGenero = tareaEnVista.IdTarea;
                actividad.UsuarioQueLaGenero = HOME.userLogueado;
                actividad.AccionQueLaGenera = "DELETE RESPONSABLE";
                actividad.Descripcion = HOME.userLogueado.Nombre + " eliminó como responsable a:"+responsable.Nombre;
                actividadServicio.insertActividad(actividad);

                this.refreshVerEditarTarea();


            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }

     

        private void dgvComentariosTarea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.comentarioSeleccionado = (Comentario)dgvComentariosTarea.CurrentRow.DataBoundItem;
        }

        private void dgvComentariosTarea_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.comentarioSeleccionado = (Comentario)dgvComentariosTarea.CurrentRow.DataBoundItem;
            this.buttonVerComentario_Click(sender, e);
        }

        private void buttonSeguir_Click(object sender, EventArgs e)
        {
            try
            {
                ActividadService actividadServicio = new ActividadService();
                Actividad actividad = new Actividad();
                actividad.IdTareaGenero = tareaEnVista.IdTarea;
                actividad.UsuarioQueLaGenero = HOME.userLogueado;
                actividad.AccionQueLaGenera = "SEGUIR";
                actividad.Descripcion = HOME.userLogueado.Nombre + " empezó a seguir la tarea";
                actividadServicio.insertActividad(actividad);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioService usuarioServicio = new UsuarioService();
                IList<Usuario> responsables = usuarioServicio.traerResponsablesTarea(tareaEnVista.IdTarea);

                if (responsables.Count > 0)
                {
                    foreach (Usuario responsable in responsables)
                    {
                       
                            String cuerpo = cargarCuerpoMail();
                            MailService mailServicio = new MailService();
                            mailServicio.sendMail(responsable.Mail, tableroEnUso.Nombre, cuerpo);


                    }
                    MessageBox.Show("Se ha compartido la tarea con los responsables");
                }
                else
                {
                    MessageBox.Show("Por favor agregue responsables para compartir esta tarea");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
             
            
        }

        private String cargarCuerpoMail()
        {
            try
            {
                ComentarioService comentarioServicio = new ComentarioService();
                IList<Comentario> comentariosTarea = comentarioServicio.traerComentariosDeTarea(tareaEnVista.IdTarea);
                String cuerpo = "Tarea: "+tareaEnVista.TituloTarea + "<br> Descripción: " + tareaEnVista.DescripcionTarea + "<br> Comentarios: ";
                foreach (Comentario comentario in comentariosTarea)
                {
                    cuerpo += "<br>"+comentario.Comentarios;
                }
                return cuerpo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}

