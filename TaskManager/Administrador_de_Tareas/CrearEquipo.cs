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
    public partial class CrearEquipo : Form
    {
        private IList<Usuario> lstTodoslosUser = new List<Usuario>();
        private List<Usuario> lstMiembros = new List<Usuario>();
        public bool vieneDeHome = false;

        public CrearEquipo()
        {
            InitializeComponent();
        }

        private void CrearEquipo_Load(object sender, EventArgs e)
        {
            UsuarioService usuarioServicio = new UsuarioService();
            try
            {
                lstTodoslosUser = usuarioServicio.traerTodosLosUserMenosLogueado(HOME.userLogueado.IdUsuario);
                if (lstTodoslosUser.Count() == 0)
                {
                  buttonAddMiembroAListaParaCrearTeam.Enabled = false;
                }
                else
                {
                   
                    lstMiembros.Add(HOME.userLogueado);
                    foreach(Usuario us in lstTodoslosUser)
                    {
                        listBoxAllUsers.Items.Add(us);
                    }
                     
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void buttonAddMiembroAListaParaCrearTeam_Click(object sender, EventArgs e)
        {
            if (listBoxAllUsers.SelectedItem != null)
            {
                if (listBoxAllUsers.Items.Count == 0)
                {
                    MessageBox.Show("No hay usuarios para agregar");
                }
                else
                {
                    Usuario userSelected = (Usuario)listBoxAllUsers.SelectedItem;
                    lstMiembros.Add(userSelected);
                    listBoxConMiembrosNewTeam.Items.Add(userSelected);
                    lstTodoslosUser.Remove(userSelected);//por las dudas
                    listBoxAllUsers.Items.Remove(userSelected);
                }
            }
          
         
           
        }

        private void buttonQuitarMiembroDeListaParaNewTeam_Click(object sender, EventArgs e)
        {
            if (listBoxConMiembrosNewTeam.SelectedItem != null)
            {
                if (listBoxConMiembrosNewTeam.Items.Count == 0)
                {
                    MessageBox.Show("No hay miembros agregados para quitar");
                }
                else
                {
                    Usuario userSelected = (Usuario)listBoxConMiembrosNewTeam.SelectedItem;
                    lstMiembros.Remove(userSelected);
                    listBoxConMiembrosNewTeam.Items.Remove(userSelected);
                    lstTodoslosUser.Add(userSelected);//por las dudas
                    listBoxAllUsers.Items.Add(userSelected);
                }
            }
       
         
        }

        private void buttonCrearTeam_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Debe agregar un nombre al equipo");
            }
            else if(listBoxConMiembrosNewTeam.Items.Count==0)
            {
                MessageBox.Show("Debe agregar integrantes al equipo");
            }
            else
            {
                EquipoService equipoServicio = new EquipoService();
                TableroService tableroServicio = new TableroService();
                try
                {
                    int idEquipo= equipoServicio.insertEquipo(textBoxName.Text, textBoxDescrip.Text);
                    foreach (Usuario us in lstMiembros)
                    {
                        equipoServicio.agregarMiembroAequipo(idEquipo, us.IdUsuario);
                    }
                    if (vieneDeHome)
                    {
                        HOME vistaHome = Owner as HOME;
                        vistaHome.refreshHome();
                    }
                    else
                    {
                        tableroServicio.updetearEquipoDelTablero(HOME.tableroSeleccionado.IdTablero, idEquipo);
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                this.Close();
            }
        }
    }
}
