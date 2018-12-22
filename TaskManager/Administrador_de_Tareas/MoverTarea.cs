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
    public partial class MoverTarea : Form
    {
        private Tarea tareaEnVista = new Tarea();
        public MoverTarea()
        {
            InitializeComponent();
        }
        public void recibirDataEditarVerTarea(Tarea tareaEnVista)
        {
            this.tareaEnVista = tareaEnVista;
        }

        private void buttonMoverTarea_Click(object sender, EventArgs e)
        {

            TareaService tareaServicio = new TareaService();
            ActividadService actividadServicio = new ActividadService();
            Actividad actividad = new Actividad();
            actividad.IdTareaGenero=tareaEnVista.IdTarea;
            actividad.UsuarioQueLaGenero = HOME.userLogueado;
            actividad.AccionQueLaGenera="MOVER";
            actividad.Descripcion = HOME.userLogueado.Nombre + " movió la tarea a " + comboBox2.Text;
           
            try
            {
                Estado aux = (Estado)comboBox2.SelectedItem;
                int idEst = aux.IdEstado;
                tareaServicio.updetearIdEstadoTarea(tareaEnVista.IdTarea, idEst);
                actividadServicio.insertActividad(actividad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            VerEditarTAREA vistaTarea = Owner as VerEditarTAREA;
            vistaTarea.refreshVerEditarTarea();
            this.Close();
        }

        private void MoverTarea_Load(object sender, EventArgs e)
        {
            List<Estado> lstEstados = new List<Estado>();
            Estado todo = new Estado(1,"TO DO");
            Estado doing = new Estado(2, "DOING");
            Estado done = new Estado(3, "DONE");
          
            lstEstados.Add(todo);
            lstEstados.Add(doing);
            lstEstados.Add(done);
        
            comboBox2.DataSource = lstEstados;
        }
    }
}
