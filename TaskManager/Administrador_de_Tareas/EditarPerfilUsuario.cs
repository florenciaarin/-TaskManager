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
    public partial class EditarPerfilUsuario : Form
    {
        private bool passwordActualCoincide;
        private bool mailValidado;
        private bool cofirmacionValidada;
    


        public EditarPerfilUsuario()
        {
            InitializeComponent();
            passwordActualCoincide = true;
            mailValidado = true;
            cofirmacionValidada = true;
       
    }

       
        private void buttonGuardarCambiosUser_Click(object sender, EventArgs e)
        {
            if(mailValidado && passwordActualCoincide && cofirmacionValidada)
            {
                UsuarioService usuarioServicio = new UsuarioService();
                Usuario userUpdate = new Usuario();
                userUpdate.IdUsuario = HOME.userLogueado.IdUsuario;
                userUpdate.Nombre = textBoxNameUser.Text;
                userUpdate.Iniciales = textBoxInicialesUsuario.Text;
                userUpdate.Mail = textBoxMailUser.Text.Trim();
                userUpdate.Password = textBoxNewPasswordUser.Text.Trim();
                try
                {
                    usuarioServicio.updetearUsuario(userUpdate);
                    //guardo en ram
                    HOME.userLogueado.Nombre = textBoxNameUser.Text;
                    HOME.userLogueado.Iniciales = textBoxInicialesUsuario.Text;
                    HOME.userLogueado.Mail = textBoxMailUser.Text.Trim();
                    HOME.userLogueado.Password = textBoxNewPasswordUser.Text.Trim();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("No es posible guardar los cambios hasta que esten todos los campos correctos");
            }
           
        }

        private void EditarPerfilUsuario_Load(object sender, EventArgs e)
        {
            textBoxInicialesUsuario.Text = HOME.userLogueado.Iniciales;
            textBoxNameUser.Text = HOME.userLogueado.Nombre;
            textBoxMailUser.Text = HOME.userLogueado.Mail;

            textBoxConfirmNewPassUser.Visible = false;
            textBoxNewPasswordUser.Visible = false;
            textBoxOldPasswordUser.Visible = false;
            labelNewPassOne.Visible = false;
            labelNewPasswordRepit.Visible = false;
            labelPasswordActual.Visible = false;

            textBoxOldPasswordUser.Text = HOME.userLogueado.Password;
            textBoxNewPasswordUser.Text = HOME.userLogueado.Password;
            textBoxConfirmNewPassUser.Text = HOME.userLogueado.Password;

            

        }

        private void linkLabelCambiarPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBoxOldPasswordUser.Text = "";
            labelPasswordActual.Visible = true;
            textBoxOldPasswordUser.Visible = true;
            passwordActualCoincide = false;
            cofirmacionValidada = false;

    }
        //evento para  la validacion de mail ingresado correctamente
        private void textBoxMailUser_Leave(object sender, EventArgs e)
        {
            if (!Mail.validarEmail(textBoxMailUser.Text))
            {
                MessageBox.Show(textBoxMailUser.Text+" no es un dirección de correo válida");
                textBoxMailUser.BackColor = Color.Red;
                mailValidado = false;
            }
            else
            {
                mailValidado = true;
                textBoxMailUser.BackColor = Color.White;
            }
        }

        private void textBoxOldPasswordUser_Leave(object sender, EventArgs e)
        {
            if (!HOME.userLogueado.Password.Equals(textBoxOldPasswordUser.Text))
            {
                MessageBox.Show("Contraseña incorrecta");
                textBoxOldPasswordUser.BackColor = Color.Red;
                passwordActualCoincide = false;
            }
            else
            {
                textBoxOldPasswordUser.BackColor = Color.White;
                passwordActualCoincide = true;
                textBoxNewPasswordUser.Text = "";
                textBoxConfirmNewPassUser.Text = "";
                labelNewPassOne.Visible = true;
                textBoxNewPasswordUser.Visible = true;

               
            }
          
        }

        private void textBoxConfirmNewPassUser_Leave(object sender, EventArgs e)
        {
            if (!textBoxNewPasswordUser.Text.Trim().Equals(textBoxConfirmNewPassUser.Text.Trim()))
            {
                MessageBox.Show("La nueva contraseña ingresada no coincide con la confirmación");
                textBoxNewPasswordUser.BackColor = Color.Red;
                textBoxConfirmNewPassUser.BackColor = Color.Red;
                cofirmacionValidada = false;

            }
            else
            {
                textBoxNewPasswordUser.BackColor = Color.White;
                textBoxConfirmNewPassUser.BackColor = Color.White;
                cofirmacionValidada = true;
            }
          
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxOldPasswordUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.textBoxOldPasswordUser_Leave(sender, e);
            }
        }


        private void textBoxConfirmNewPassUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.textBoxConfirmNewPassUser_Leave(sender, e);
            }
        }

        private void textBoxNewPasswordUser_Leave(object sender, EventArgs e)
        {
            
                labelNewPasswordRepit.Visible = true;
                textBoxConfirmNewPassUser.Visible = true;
               
            
           
        
        }

        private void textBoxNewPasswordUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.textBoxNewPasswordUser_Leave(sender, e);
            }
        }
    }
}
