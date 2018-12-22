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
    public partial class TABLERO : Form
    {
        public  Tablero tableroEnUso = new Tablero();
        private Usuario userLogueado = new Usuario();
        private IList<Tarea> listaTODO= new List<Tarea>();
        private IList<Tarea> listaDOING = new List<Tarea>();
        private IList<Tarea> listaDONE = new List<Tarea>();
        

        public TABLERO()
        {
            InitializeComponent();
        }

        public void renameBoard(String rename)
        {
            buttonParaCambiarNameTablero.Text = rename;
        }
        public void recibirDatosDeHome(Tablero tableroRecibo, Usuario user)
        {
           this.tableroEnUso = tableroRecibo;
            this.userLogueado = user;
        }

        private void TABLERO_Load(object sender, EventArgs e)
        {
            buttonMenuPerfil.Text = HOME.userLogueado.Iniciales;
            buttonParaCambiarNameTablero.Text = tableroEnUso.Nombre;
            //actualizacion nombre equipo dependiendo si tiene o no   
                try
                {
                 TableroService tableroServicio = new TableroService();
                 List<int> lstIdsTablerosConEquipo =tableroServicio.todosLosIdsTablerosConEquipo();
                if (lstIdsTablerosConEquipo.Contains(tableroEnUso.IdTablero))//eltablero en vista tiene equipo
                    {
                        int idEquipoDelTablero = tableroServicio.traerIdEquipoTablero(tableroEnUso.IdTablero);
                        EquipoService equipoServicio = new EquipoService();
                        Equipo equipoDelTablero = equipoServicio.traerDataPrincipalEquipo(idEquipoDelTablero);
                        buttonDosOpcionesSegunTableroTengaTeam.Text = equipoDelTablero.NombreEquipo;
                        tableroEnUso.EquipoDelTablero = equipoDelTablero;
                }
                else
                {
                    Equipo equipo = new Equipo();
                    equipo.NombreEquipo = "no tiene equipo";
                    tableroEnUso.EquipoDelTablero = equipo;
                }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            //fin actualizacion
            //carga de listas
            try
            {
                TareaService tareaServicio = new TareaService();
                listaTODO = tareaServicio.tareasPorEstadoDelTablero(tableroEnUso.IdTablero,1);
                listaDOING = tareaServicio.tareasPorEstadoDelTablero(tableroEnUso.IdTablero, 2);
                listaDONE = tareaServicio.tareasPorEstadoDelTablero(tableroEnUso.IdTablero, 3);
                dgvTODO.DataSource = null;
                dgvDOING.DataSource = null;
                dgvDONE.DataSource = null;
                dgvTODO.DataSource = listaTODO;
                dgvDOING.DataSource = listaDOING;
                dgvDONE.DataSource = listaDONE;
                dgvTODO.Columns[0].Visible = false;
                dgvTODO.Columns[1].Visible = false;
                dgvTODO.Columns[2].Visible = false;
                dgvTODO.Columns[3].Visible = false;
                dgvTODO.Columns[5].Visible = false;
                dgvTODO.Columns[6].Visible = false;
                dgvTODO.Columns[7].Visible = false;
                dgvDOING.Columns[0].Visible = false;
                dgvDOING.Columns[1].Visible = false;
                dgvDOING.Columns[2].Visible = false;
                dgvDOING.Columns[3].Visible = false;
                dgvDOING.Columns[5].Visible = false;
                dgvDOING.Columns[6].Visible = false;
                dgvDOING.Columns[7].Visible = false;
                dgvDONE.Columns[0].Visible = false;
                dgvDONE.Columns[1].Visible = false;
                dgvDONE.Columns[2].Visible = false;
                dgvDONE.Columns[3].Visible = false;
                dgvDONE.Columns[5].Visible = false;
                dgvDONE.Columns[6].Visible = false;
                dgvDONE.Columns[7].Visible = false;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            

        }
        public void refreshTablero()//copy paste always load de tablero
        {
           // this.Show();

            buttonMenuPerfil.Text = HOME.userLogueado.Iniciales;
            buttonParaCambiarNameTablero.Text = tableroEnUso.Nombre;
            //actualizacion nombre equipo dependiendo si tiene o no   
            try
            {
                TableroService tableroServicio = new TableroService();
                List<int> lstIdsTablerosConEquipo = tableroServicio.todosLosIdsTablerosConEquipo();
                if (lstIdsTablerosConEquipo.Contains(tableroEnUso.IdTablero))//eltablero en vista tiene equipo
                {
                    int idEquipoDelTablero = tableroServicio.traerIdEquipoTablero(tableroEnUso.IdTablero);
                    EquipoService equipoServicio = new EquipoService();
                    Equipo equipoDelTablero = equipoServicio.traerDataPrincipalEquipo(idEquipoDelTablero);
                    buttonDosOpcionesSegunTableroTengaTeam.Text = equipoDelTablero.NombreEquipo;
                    tableroEnUso.EquipoDelTablero = equipoDelTablero;
                }
                else
                {
                    Equipo equipo = new Equipo();
                    equipo.NombreEquipo = "no tiene equipo";
                    tableroEnUso.EquipoDelTablero = equipo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //fin actualizacion
            //carga de listas
            try
            {
                TareaService tareaServicio = new TareaService();
                listaTODO = tareaServicio.tareasPorEstadoDelTablero(tableroEnUso.IdTablero, 1);
                listaDOING = tareaServicio.tareasPorEstadoDelTablero(tableroEnUso.IdTablero, 2);
                listaDONE = tareaServicio.tareasPorEstadoDelTablero(tableroEnUso.IdTablero, 3);
                dgvTODO.DataSource = null;
                dgvDOING.DataSource = null;
                dgvDONE.DataSource = null;
                dgvTODO.DataSource = listaTODO;
                dgvDOING.DataSource = listaDOING;
                dgvDONE.DataSource = listaDONE;
                dgvTODO.Columns[0].Visible = false;
                dgvTODO.Columns[1].Visible = false;
                dgvTODO.Columns[2].Visible = false;
                dgvTODO.Columns[3].Visible = false;
                dgvTODO.Columns[5].Visible = false;
                dgvTODO.Columns[6].Visible = false;
                dgvTODO.Columns[7].Visible = false;
                dgvDOING.Columns[0].Visible = false;
                dgvDOING.Columns[1].Visible = false;
                dgvDOING.Columns[2].Visible = false;
                dgvDOING.Columns[3].Visible = false;
                dgvDOING.Columns[5].Visible = false;
                dgvDOING.Columns[6].Visible = false;
                dgvDOING.Columns[7].Visible = false;
                dgvDONE.Columns[0].Visible = false;
                dgvDONE.Columns[1].Visible = false;
                dgvDONE.Columns[2].Visible = false;
                dgvDONE.Columns[3].Visible = false;
                dgvDONE.Columns[5].Visible = false;
                dgvDONE.Columns[6].Visible = false;
                dgvDONE.Columns[7].Visible = false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void buttonParaCambiarNameTablero_Click(object sender, EventArgs e)
        {

            RenombarTABLERO renameBoard = new RenombarTABLERO();
            renameBoard.recibirInfoTablero(tableroEnUso, userLogueado);
            AddOwnedForm(renameBoard);
            renameBoard.Show();
            

        }

        private void buttonGoHome_Click(object sender, EventArgs e)
        {
            HOME vistaHome = Owner as HOME;
            HOME.tableroSeleccionado = null;
            vistaHome.refreshHome();
            this.Close();

        }

        private void buttonAddTareaTODO_Click(object sender, EventArgs e)
        {
           
            AddTAREA nuevaTarea = new AddTAREA();
            nuevaTarea.recibirDatosDeTablero(tableroEnUso, userLogueado,1);//paso datos para guardar tarea
            AddOwnedForm(nuevaTarea);
            
            nuevaTarea.ShowDialog();
        }

        private void buttonAddTareaDOING_Click(object sender, EventArgs e)
        {
            AddTAREA nuevaTarea = new AddTAREA();
            nuevaTarea.recibirDatosDeTablero(tableroEnUso, userLogueado, 2);//paso datos para guardar tarea
            AddOwnedForm(nuevaTarea);
          
            nuevaTarea.ShowDialog();
        }

        private void buttonAddTareaDONE_Click(object sender, EventArgs e)
        {
            AddTAREA nuevaTarea = new AddTAREA();
            nuevaTarea.recibirDatosDeTablero(tableroEnUso, userLogueado, 3);//paso datos para guardar tarea
            AddOwnedForm(nuevaTarea);
           
            nuevaTarea.ShowDialog();
        }

        private void dgvTODO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tarea tareaSeleccionada = (Tarea)dgvTODO.CurrentRow.DataBoundItem;
            VerEditarTAREA vistaTarea = new VerEditarTAREA();
            vistaTarea.recibirDataTablero(tareaSeleccionada, userLogueado, tableroEnUso);
            AddOwnedForm(vistaTarea);
            this.Hide();
            vistaTarea.ShowDialog();
            this.Show();
        }

        private void dgvDOING_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tarea tareaSeleccionada = (Tarea)dgvDOING.CurrentRow.DataBoundItem;
            VerEditarTAREA vistaTarea = new VerEditarTAREA();
            vistaTarea.recibirDataTablero(tareaSeleccionada, userLogueado, tableroEnUso);
            AddOwnedForm(vistaTarea);
            this.Hide();
            vistaTarea.ShowDialog();
            this.Show();
        }

        private void dgvDONE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tarea tareaSeleccionada = (Tarea)dgvDONE.CurrentRow.DataBoundItem;
            VerEditarTAREA vistaTarea = new VerEditarTAREA();
            vistaTarea.recibirDataTablero(tareaSeleccionada, userLogueado, tableroEnUso);
            AddOwnedForm(vistaTarea);
            this.Hide();
            vistaTarea.ShowDialog();
            this.Show();
        }
        
        private void buttonMenuPerfil_Click(object sender, EventArgs e)
        {
            MenuUsuario vistaMenuUser = new MenuUsuario();
            vistaMenuUser.ShowDialog();
        }

        private void buttonDosOpcionesSegunTableroTengaTeam_Click(object sender, EventArgs e)
        {
            if (buttonDosOpcionesSegunTableroTengaTeam.Text.Equals("Tablero Personal"))
            {
                MenuAddOrChangeTeamToTablero vistaAddTeamOrChange = new MenuAddOrChangeTeamToTablero();
                this.refreshTablero();
                AddOwnedForm(vistaAddTeamOrChange);
                vistaAddTeamOrChange.Show();

            }
            else
            {
                MenuSiYaTieneEquipoTablero vistaMenuYaTieneTeam = new MenuSiYaTieneEquipoTablero();
                this.refreshTablero();
                vistaMenuYaTieneTeam.recibirInfo(tableroEnUso.EquipoDelTablero);
                AddOwnedForm(vistaMenuYaTieneTeam);
                vistaMenuYaTieneTeam.Show();
            }

        }
    }
}
