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
    public partial class MenuUsuario : Form
    {
      
        public MenuUsuario()
        {
            InitializeComponent();
        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
            this.Close();
                    
        }

        private void linkLabelGoToPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerPERFIL vistaPerfil = new VerPERFIL();
            this.Hide();
            vistaPerfil.Show();
         
        }


    }
}
