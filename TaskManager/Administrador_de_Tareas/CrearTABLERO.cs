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
    public partial class CrearTABLERO : Form
    {
      //  public Usuario userLogueado = new Usuario();

        public Tablero nuevoTablero = new Tablero();

        private IList<Equipo> listadoEquiposDelUser = new List<Equipo>();
       
        public CrearTABLERO()
        {
            InitializeComponent();
        }
        
        private void CrearTABLERO_Load(object sender, EventArgs e)
        {
            
            EquipoService equipoServicio = new EquipoService();
            try
            {
                listadoEquiposDelUser = equipoServicio.ListarEquiposDelUsuario(HOME.userLogueado);
            }
            catch (Exception)
            {

                throw;
            } 
           
            if (listadoEquiposDelUser.Count() == 0)
            {
                comboBoxTeamParaTablero.Enabled = false;
                comboBoxTeamParaTablero.Text = "No existen equipos aun para asignar";
                checkBoxQuiereTableroPersonal.Checked = true;
            }
            else
            {
                comboBoxTeamParaTablero.DataSource = listadoEquiposDelUser;
            }

        }


        private void buttonCrearTablero_Click(object sender, EventArgs e)
        {
            if (textBoxNombreTablero.Text == null || textBoxNombreTablero.Text.Equals(""))
            {
                MessageBox.Show("Debe tener un nombre el tablero");
            }
            else
            {
                String nuevoNombre = textBoxNombreTablero.Text;
                int idUsuario = HOME.userLogueado.IdUsuario;
                TableroService tableroServicio = new TableroService();
                if (checkBoxQuiereTableroPersonal.Checked == false)
                {
                    //se crea un tablero con el equipo
                    nuevoTablero.EquipoDelTablero = (Equipo)comboBoxTeamParaTablero.SelectedItem;
                    int idEquipo = nuevoTablero.EquipoDelTablero.IdEquipo;
                    tableroServicio.insertTablero(nuevoNombre, idUsuario, idEquipo);
                    this.Close();
                }
                else
                {
                    tableroServicio.insertTablero(nuevoNombre, idUsuario);
                    this.Close();
                }
              
            }
        }

        private void checkBoxQuiereTableroPersonal_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxQuiereTableroPersonal.Checked == true)
            {
                comboBoxTeamParaTablero.Enabled = false;
            }else 
            {
                comboBoxTeamParaTablero.Enabled = true;
            }
        }
    }
}
