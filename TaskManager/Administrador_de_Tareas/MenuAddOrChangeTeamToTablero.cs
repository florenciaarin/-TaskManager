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
    public partial class MenuAddOrChangeTeamToTablero : Form
    {
        private IList<Equipo> lstEquiposUser = new List<Equipo>();
        public bool vieneOpcionYaConEquipo = false;

        public MenuAddOrChangeTeamToTablero()
        {
            InitializeComponent();
        }

        private void buttonAgregarOcambiarTeamATablero_Click(object sender, EventArgs e)//button GUARDAR
        {
            Equipo eq = (Equipo)comboBoxTodosLosEquiposDelUsuario.SelectedItem;
            TableroService tableroServicio = new TableroService();
            try
            {
                tableroServicio.updetearEquipoDelTablero(HOME.tableroSeleccionado.IdTablero, eq.IdEquipo);
                HOME.tableroSeleccionado.EquipoDelTablero.IdEquipo = eq.IdEquipo;


            }catch(Exception ex)
            {
                throw ex;
            }
            if (!vieneOpcionYaConEquipo)
            {
               TABLERO vistaTab = Owner as TABLERO;
               vistaTab.refreshTablero();
            }
            else
            {
                MenuSiYaTieneEquipoTablero vista = Owner as MenuSiYaTieneEquipoTablero;
                vista.refrescarTablero();
                vieneOpcionYaConEquipo = false;
            }
          
            this.Close();
        }

        private void linkLabelGoToCreateTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CrearEquipo crearEquipo = new CrearEquipo();
            this.Hide();
            crearEquipo.Show();
            
        }

        private void MenuAddOrChangeTeamToTablero_Load(object sender, EventArgs e)
        {
            EquipoService equipoServicio = new EquipoService();
                    
            try
            {
                lstEquiposUser= equipoServicio.ListarEquiposDelUsuario(HOME.userLogueado);
                comboBoxTodosLosEquiposDelUsuario.DataSource = lstEquiposUser;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
