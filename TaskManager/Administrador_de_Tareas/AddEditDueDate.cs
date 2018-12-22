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
    public partial class AddEditDueDate : Form
    {
        Tarea tareaEnVista = new Tarea();

        public AddEditDueDate()
        {
            InitializeComponent();
        }

        public void recibirDataEditarVerTarea(Tarea tareaEnVista)
        {
            this.tareaEnVista = tareaEnVista;
        }

        private void buttonGuardarDueDate_Click(object sender, EventArgs e)
        {
            tareaEnVista.FechaVencimiento = Convert.ToDateTime(monthCalendar.SelectionEnd.ToShortDateString());
            TareaService tareaServicio = new TareaService();
            tareaServicio.updetearDuaDate(tareaEnVista.IdTarea, tareaEnVista.FechaVencimiento);
            VerEditarTAREA vistaVerEditarTarea = Owner as VerEditarTAREA;

            ActividadService actividadServicio = new ActividadService();
            Actividad actividad = new Actividad();
            actividad.IdTareaGenero = tareaEnVista.IdTarea;
            actividad.UsuarioQueLaGenero = HOME.userLogueado;
            actividad.AccionQueLaGenera = "DUE DATE";
            actividad.Descripcion = HOME.userLogueado.Nombre + " pasó la fecha de vencimiento a: "+ monthCalendar.SelectionEnd.ToShortDateString();
            actividadServicio.insertActividad(actividad);

            vistaVerEditarTarea.refreshVerEditarTarea();
            this.Close();
        }

        private void buttonDeleteDueDate_Click(object sender, EventArgs e)
        {
            tareaEnVista.FechaVencimiento = Convert.ToDateTime("1 / 1 / 0001 00:00:00");
            TareaService tareaServicio = new TareaService();
            tareaServicio.eliminarDuaDate(tareaEnVista.IdTarea);
            VerEditarTAREA vistaVerEditarTarea = Owner as VerEditarTAREA;

            ActividadService actividadServicio = new ActividadService();
            Actividad actividad = new Actividad();
            actividad.IdTareaGenero = tareaEnVista.IdTarea;
            actividad.UsuarioQueLaGenero = HOME.userLogueado;
            actividad.AccionQueLaGenera = "DUE DATE";
            actividad.Descripcion = HOME.userLogueado.Nombre + " eliminó la fecha de vencimiento";
            actividadServicio.insertActividad(actividad);

            vistaVerEditarTarea.refreshVerEditarTarea();
            this.Close();
        }
    }

}
