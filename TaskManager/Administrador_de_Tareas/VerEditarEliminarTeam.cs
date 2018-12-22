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
    public partial class VerEditarEliminarTeam : Form
    {
        private IList<Usuario> lstTodoslosUser = new List<Usuario>();
        private IList<Usuario> lstMiembros = new List<Usuario>();
        private IList<Usuario> lstMiembrosBackUp = new List<Usuario>();
        private IList<Usuario> lstTodoslosUserAux = new List<Usuario>();
        public bool vieneDeHome = false;
        private Equipo equipoEnMuestra;

        public VerEditarEliminarTeam()
        {
            InitializeComponent();
        }
        public void pasarInfo(Equipo equipoSelected)
        {
            equipoEnMuestra = equipoSelected;
        }
        private void VerEditarEliminarTeam_Load(object sender, EventArgs e)
        {
            labelUserLog.Text = HOME.userLogueado.Nombre;
            textBoxNombre.Text = equipoEnMuestra.NombreEquipo;
            textBoxDescripcion.Text = equipoEnMuestra.Descripcion;
            UsuarioService usuarioServicio = new UsuarioService();
            listBoxAllUsers.Visible = false;
            labelUsuarios.Visible = false;
            buttonAgregarMiembroALista.Visible = false;
            buttonSacarMiembro.Visible = false;
            try
            {
                TableroService tableroServicio = new TableroService();
                IList<Tablero> lstTablerosDelEquipo =tableroServicio.todosLosIdsTablerosDeunEquipo(equipoEnMuestra.IdEquipo);
                dgvTablerosDelEquipo.DataSource = lstTablerosDelEquipo;
                lstMiembros = usuarioServicio.traerMiembrosEquipoSinUserLog(equipoEnMuestra.IdEquipo, HOME.userLogueado.IdUsuario);
                lstMiembrosBackUp = usuarioServicio.traerMiembrosEquipoSinUserLog(equipoEnMuestra.IdEquipo, HOME.userLogueado.IdUsuario);
                dgvTablerosDelEquipo.Columns[0].Visible = false;
                dgvTablerosDelEquipo.Columns[2].Visible = false;
                dgvTablerosDelEquipo.Columns[3].Visible = false;
              //  if (lstMiembros.Count() == 0)
               // {
                 //   buttonSacarMiembro.Enabled = false;
                //}
              //  else
                {

                    foreach (Usuario us in lstMiembros)
                    {
                        listBoxAparecenMiembrosTeam.Items.Add(us);
                    }

                }
                     lstTodoslosUser = usuarioServicio.traerTodosLosUserMenosLogueado(HOME.userLogueado.IdUsuario);
                      if (lstTodoslosUser.Count() == 0)
                      {
                          buttonAgregarMiembroALista.Enabled = false;
                      }
                      else
                      {
                    
                    int cont;

                          foreach (Usuario us in lstTodoslosUser)
                          {
                               cont= 0;
                               foreach (Usuario miembro in lstMiembros)
                              {
                                  
                                  if (us.IdUsuario == miembro.IdUsuario)
                                  {
                                   cont++;
                                  }
                              }
                        if (cont == 0)
                        {
                            listBoxAllUsers.Items.Add(us);
                            lstTodoslosUserAux.Add(us);
                        }
                       
                          }
                    
                      }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxAllUsers.Visible = true;
            labelUsuarios.Visible = true;
            buttonAgregarMiembroALista.Visible = true;
            buttonSacarMiembro.Visible = true;
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxAllUsers.Visible = true;
            labelUsuarios.Visible = true;
            buttonAgregarMiembroALista.Visible = true;
            buttonSacarMiembro.Visible = true;
        }

        private void buttonSacarMiembro_Click(object sender, EventArgs e)
        {
            if(listBoxAparecenMiembrosTeam.SelectedItem != null)
            {
                if (listBoxAparecenMiembrosTeam.Items.Count == 0)
                {
                    MessageBox.Show("No hay miembros agregados para quitar");
                }
                else
                {
                    Usuario userSelected = (Usuario)listBoxAparecenMiembrosTeam.SelectedItem;
                    lstMiembros.Remove(userSelected);
                    listBoxAparecenMiembrosTeam.Items.Remove(userSelected);
                    lstTodoslosUserAux.Add(userSelected);//por las dudas
                    listBoxAllUsers.Items.Add(userSelected);
                }
            }
        }

        private void buttonAgregarMiembroALista_Click(object sender, EventArgs e)
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
                    listBoxAparecenMiembrosTeam.Items.Add(userSelected);
                    lstTodoslosUserAux.Remove(userSelected);//por las dudas
                    listBoxAllUsers.Items.Remove(userSelected);
                }
            }
        }

        private void buttonGuardarCambiosTeam_Click(object sender, EventArgs e)
        {
            try
            {
                EquipoService equipoServicio = new EquipoService();
                equipoServicio.updetearEquipo(textBoxNombre.Text, textBoxDescripcion.Text, equipoEnMuestra.IdEquipo);
                int contYaEstaba;//a vr entro al nuevo comparo con todos los viejos si encuentr coincidencia no hace nada
                //si no encuentra coincidencia tienen que insertarllo xq es uno nuevo
                
                foreach (Usuario nuevo in lstMiembros)
                {
                    contYaEstaba = 0;
                    foreach (Usuario viejo in lstMiembrosBackUp)
                    {
                        if (nuevo.IdUsuario == viejo.IdUsuario)
                        {
                            contYaEstaba++;
                        }
                    }
                    if (contYaEstaba == 0) // Es decir, si el miembro nuevo no esta en la lista de los viejos...:
                    {
                        equipoServicio.agregarMiembroAequipo(equipoEnMuestra.IdEquipo, nuevo.IdUsuario);
                    }
                }
                foreach (Usuario viejo in lstMiembrosBackUp)
                {
                    contYaEstaba = 0;
                    foreach (Usuario  nuevo in lstMiembros)
                    {
                        if (nuevo.IdUsuario == viejo.IdUsuario)
                        {
                            contYaEstaba++;
                        }
                    }
                    if (contYaEstaba == 0) // Es decir, si el miembro viejo no esta en la lista de los nuevos...:
                    {
                        equipoServicio.borrarMiembroAequipo(equipoEnMuestra.IdEquipo, viejo.IdUsuario);
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            if (vieneDeHome)
            {
                HOME vistaHome = Owner as HOME;
                vistaHome.refreshHome();
                vieneDeHome = false;
            }
            else
            {
                MenuSiYaTieneEquipoTablero menu = Owner as MenuSiYaTieneEquipoTablero;
                menu.refrescarTablero();
            }
           
            this.Close();
      
        }

        private void buttonDeleteTeam_Click(object sender, EventArgs e)
        {
            try
            {
                TableroService tableroServicio = new TableroService();
                tableroServicio.eliminarEquiposDeLosTableros(equipoEnMuestra.IdEquipo);
                EquipoService equipoServicio = new EquipoService();
                foreach(Usuario us in lstMiembros)
                {
                    equipoServicio.borrarMiembroAequipo(equipoEnMuestra.IdEquipo,us.IdUsuario);
                }
                equipoServicio.borrarMiembroAequipo(equipoEnMuestra.IdEquipo, HOME.userLogueado.IdUsuario);
                equipoServicio.borrarEquipo(equipoEnMuestra.IdEquipo);
               
                HOME vistaHome = Owner as HOME;
                vistaHome.refreshHome();
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
