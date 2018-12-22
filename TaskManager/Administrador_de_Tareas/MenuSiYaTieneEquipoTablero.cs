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

namespace Administrador_de_Tareas
{
    public partial class MenuSiYaTieneEquipoTablero : Form
    {
        private Equipo eqDelTab = new Equipo();
        public MenuSiYaTieneEquipoTablero()
        {
            InitializeComponent();
        }

        private void linkLabelGoToMenuAddOrChangeTeamTablero_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuAddOrChangeTeamToTablero vista = new MenuAddOrChangeTeamToTablero();
            vista.vieneOpcionYaConEquipo = true;
            AddOwnedForm(vista);
            this.Hide();
            vista.Show();
            
         
        }

        public void refrescarTablero()
        {
            TABLERO vistaTablero = Owner as TABLERO;
            vistaTablero.refreshTablero();
        }

        private void linkLabelGoToVerEditarElimTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerEditarEliminarTeam vistaTeam = new VerEditarEliminarTeam();
            AddOwnedForm(vistaTeam);
            vistaTeam.pasarInfo(eqDelTab);
            this.Hide();
            vistaTeam.Show();
        }
   
        public void recibirInfo(Equipo eq)
        {
            eqDelTab = eq;
        }
    }
}
