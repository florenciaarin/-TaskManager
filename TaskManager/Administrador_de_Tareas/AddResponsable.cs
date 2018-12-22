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
    public partial class AddResponsable : Form
    {
        private int idEquipoDelTablero;
        private int idTareaEnVista;
        private IList<Usuario> lstMiembrosEquipo = new List<Usuario>();

        public AddResponsable()
        {
            InitializeComponent();
        }
        public void recibirDataVerEditTask(int idEquipoDelTablero, int idTareaEnVista)
        {
            this.idEquipoDelTablero = idEquipoDelTablero;
            this.idTareaEnVista = idTareaEnVista;
        }

        private void buttonAgregarResponsableAccion_Click(object sender, EventArgs e)
        {
            TareaService tareaServicio = new TareaService();
            Usuario responsable = (Usuario)cbBoxMiembrosParaAddResponsable.SelectedItem;
            tareaServicio.insertarResponsableATarea(responsable.IdUsuario, idTareaEnVista);
            VerEditarTAREA vistaTarea = Owner as VerEditarTAREA;

            ActividadService actividadServicio = new ActividadService();
            Actividad actividad = new Actividad();
            actividad.IdTareaGenero = idTareaEnVista;
            actividad.UsuarioQueLaGenero = HOME.userLogueado;
            actividad.AccionQueLaGenera = "ADD RESPONSABLE";
            actividad.Descripcion = HOME.userLogueado.Nombre + " agregó como responsable a: "+responsable.Nombre;
            actividadServicio.insertActividad(actividad);

            vistaTarea.refreshVerEditarTarea();
            this.Close();
        }

        private void AddResponsable_Load(object sender, EventArgs e)
        {
            UsuarioService usuarioServicio = new UsuarioService();
            lstMiembrosEquipo=usuarioServicio.traerMiembrosEquipo(idEquipoDelTablero);
            cbBoxMiembrosParaAddResponsable.DataSource = lstMiembrosEquipo;
        }
    }
}
