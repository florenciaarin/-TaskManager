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

    public partial class HOME : Form
    {
        public  static Usuario userLogueado;
        public  static Tablero tableroSeleccionado;

        public static Boolean cerrarApp = false;

        private IList<Tablero> tablerosDelUserLogueado = new List<Tablero>();
        private IList<Equipo> EquipoDelUserLogueado = new List<Equipo>();
        
        private Equipo equipoSeleccionado;

        public HOME()
        {
            InitializeComponent();
            this.iniciarSesion();

            
        }

        private void buttonGoTablero_Click(object sender, EventArgs e)
        {
            if (tableroSeleccionado != null)
            {
                TABLERO formTablero = new TABLERO();
                tableroSeleccionado = (Tablero)dgvTableros.CurrentRow.DataBoundItem;
                formTablero.recibirDatosDeHome(tableroSeleccionado, userLogueado);
                AddOwnedForm(formTablero);
                this.Hide();
                formTablero.ShowDialog();
                
                
            }
            else
            {
                MessageBox.Show("Por favor seleccione un tablero");
            }
        }

        private void buttonEliminarTablero_Click(object sender, EventArgs e)
        {
            if (tableroSeleccionado!=null)
            {
                try
                {
                    tableroSeleccionado = (Tablero)dgvTableros.CurrentRow.DataBoundItem;
                    TableroService tableroService = new TableroService();

                    if (tableroService.obtenerIdCreador(tableroSeleccionado.IdTablero) == userLogueado.IdUsuario)
                    {
                        tableroService.eliminarTablero(tableroSeleccionado.IdTablero);

                        tablerosDelUserLogueado = tableroService.listarTablerosDelUser(userLogueado.IdUsuario);


                        dgvTableros.DataSource = null;
                        dgvTableros.DataSource = tablerosDelUserLogueado;
                        dgvTableros.Columns[0].Visible = false;
                        dgvTableros.Columns[2].Visible = false;
                        dgvTableros.Columns[3].Visible = false;

                        tableroSeleccionado = null;
                    }
                    else
                    {
                        MessageBox.Show("Solo el creador del tablero pueden eliminarlo");
                    }


                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un tablero");
            }
           


        }

        private void buttonNewTablero_Click(object sender, EventArgs e)
        {
            CrearTABLERO nuevoFormCrearTablero = new CrearTABLERO();
            nuevoFormCrearTablero.ShowDialog();
            TableroService tableroService = new TableroService();
          
            tablerosDelUserLogueado = tableroService.listarTablerosDelUser(userLogueado.IdUsuario);
            
            dgvTableros.DataSource = null;
            dgvTableros.DataSource = tablerosDelUserLogueado;
            dgvTableros.Columns[0].Visible = false;
            dgvTableros.Columns[2].Visible = false;
            dgvTableros.Columns[3].Visible = false;
            dgvTableros.Focus();
        }

        private void buttonVerTeam_Click(object sender, EventArgs e)
        {
            if (equipoSeleccionado != null)
            {
                VerEditarEliminarTeam vistaTeam = new VerEditarEliminarTeam();
                vistaTeam.pasarInfo(equipoSeleccionado);
                vistaTeam.vieneDeHome = true;
                AddOwnedForm(vistaTeam);
                vistaTeam.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un equipo");
            }
        }

        private void buttonNewTeam_Click(object sender, EventArgs e)
        {
            CrearEquipo vistaTeam = new CrearEquipo();
            AddOwnedForm(vistaTeam);
            vistaTeam.vieneDeHome = true;
            vistaTeam.ShowDialog();
        }

        private void HOME_Load(object sender, EventArgs e)
        {
            if (cerrarApp)
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                this.Show();
                try
                {
                    buttonMenuPerfil.Text = userLogueado.Iniciales;
                    TableroService tableroServicio = new TableroService();
                    tablerosDelUserLogueado = tableroServicio.listarTablerosDelUser(userLogueado.IdUsuario);
                    dgvTableros.DataSource = null;
                    dgvTableros.DataSource = tablerosDelUserLogueado;
                    dgvTableros.Columns[0].Visible = false;
                    dgvTableros.Columns[2].Visible = false;
                    dgvTableros.Columns[3].Visible = false;

                    EquipoService equipoServicio = new EquipoService();
                    EquipoDelUserLogueado = equipoServicio.ListarEquiposDelUsuario(userLogueado);
                    dgvEquipos.DataSource = null;
                    dgvEquipos.DataSource = EquipoDelUserLogueado;
                    dgvEquipos.Columns[0].Visible = false;
                    dgvEquipos.Columns[2].Visible = false;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
           
        

        }
        public void refreshHome()//siempre clonar aca el load
        {
            if (cerrarApp)
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                this.Show();
                try
                {
                    buttonMenuPerfil.Text = userLogueado.Iniciales;
                    TableroService tableroServicio = new TableroService();
                    tablerosDelUserLogueado = tableroServicio.listarTablerosDelUser(userLogueado.IdUsuario);
                    dgvTableros.DataSource = null;
                    dgvTableros.DataSource = tablerosDelUserLogueado;
                    dgvTableros.Columns[0].Visible = false;
                    dgvTableros.Columns[2].Visible = false;
                    dgvTableros.Columns[3].Visible = false;

                    EquipoService equipoServicio = new EquipoService();
                    EquipoDelUserLogueado = equipoServicio.ListarEquiposDelUsuario(userLogueado);
                    dgvEquipos.DataSource = null;
                    dgvEquipos.DataSource = EquipoDelUserLogueado;
                    dgvEquipos.Columns[0].Visible = false;
                    dgvEquipos.Columns[2].Visible = false;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
       
        }
     


        private void buttonMenuPerfil_Click(object sender, EventArgs e)
        {
            MenuUsuario vistaMenuUser = new MenuUsuario();
            vistaMenuUser.Show();

        }

        public  void iniciarSesion()
        {
            Login vistaLogin = new Login();
            this.Hide();
            vistaLogin.ShowDialog();

        }

    

        private void dgvTableros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tableroSeleccionado = (Tablero)dgvTableros.CurrentRow.DataBoundItem;
            this.buttonGoTablero_Click(sender, e);
        }

        private void dgvTableros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tableroSeleccionado = (Tablero)dgvTableros.CurrentRow.DataBoundItem;
        }

   

        private void dgvEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            equipoSeleccionado = (Equipo)dgvEquipos.CurrentRow.DataBoundItem;
        }

        private void dgvEquipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            equipoSeleccionado = (Equipo)dgvEquipos.CurrentRow.DataBoundItem;
            this.buttonVerTeam_Click(sender, e);
        }

        
    }
}
