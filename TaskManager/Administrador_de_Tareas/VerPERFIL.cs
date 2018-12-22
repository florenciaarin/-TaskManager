using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrador_de_Tareas
{
    public partial class VerPERFIL : Form
    {
        public VerPERFIL()
        {
            InitializeComponent();
        }

        private void linkLabelGoToEditarPerfilUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            EditarPerfilUsuario vistaEditPerfil = new EditarPerfilUsuario();
            vistaEditPerfil.Show();
        }

        private void VerPERFIL_Load(object sender, EventArgs e)
        {
            labelMuestraNombreUsuario.Text = HOME.userLogueado.Nombre;
            labelMuestraMail.Text = HOME.userLogueado.Mail;
            labeliniciales.Text = HOME.userLogueado.Iniciales;
        }
    }
}
