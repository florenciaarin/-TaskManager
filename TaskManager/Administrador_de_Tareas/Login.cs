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
    public  partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            
           UsuarioService usuarioServicio = new UsuarioService();
           try
           {
               String mail =textBoxLoginconmail.Text;
               String pass = textBoxPassw.Text;
               if (usuarioServicio.validarSiExisteUsuario(mail))//trae true si existe ó false si no
               {
                   Usuario userParaLoguearse = usuarioServicio.traerUsuario(mail);
                   if (userParaLoguearse.Password == pass)
                   {

                       HOME.userLogueado = userParaLoguearse;
                       this.Close();
                   }
                   else
                   {
                       MessageBox.Show("Contraseña incorrecta");
                   }
               }
               else
               {
                   MessageBox.Show("No existe un usuario registrado con el mail " + mail);
               }


           }
           catch (Exception ex)
           {
               throw ex;
           }
           
        }

        private void linkLabelSalirApp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HOME.cerrarApp = true;
            this.Close();
        }

        private void textBoxPassw_TextChanged(object sender, EventArgs e)
        {
            textBoxPassw.PasswordChar = '°';
        }

        private void Login_Load(object sender, EventArgs e)
        {
      
        }

        private void linkLabelNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NuevoUsuario nuevoUser = new NuevoUsuario();
            nuevoUser.ShowDialog();
        }

        private void textBoxPassw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.buttonIngresar_Click(sender, e);
            }
        }
    }
}
