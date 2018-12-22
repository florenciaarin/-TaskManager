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
    public partial class NuevoUsuario : Form
    {
        private bool mailUnicoEnbase;
        private bool mailValidado;
        private bool cofirmacionValidadaPassword;

        public NuevoUsuario()
        {
            InitializeComponent();
            mailUnicoEnbase = false;
            mailValidado = false;
            cofirmacionValidadaPassword = false;
    }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (mailValidado && mailUnicoEnbase && cofirmacionValidadaPassword)
            {
                UsuarioService usuarioServicio = new UsuarioService();
                Usuario user = new Usuario();
                user.Nombre = textBoxName.Text;
                user.Iniciales = textBoxIniciales.Text;
                user.Mail = textBoxEmail.Text.Trim();
                user.Password = textBoxPassword.Text.Trim();
                try
                {
                    usuarioServicio.insertUsuario(user);

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

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (!Mail.validarEmail(textBoxEmail.Text))
            {
                MessageBox.Show(textBoxEmail.Text + " no es un dirección de correo válida");
                textBoxEmail.BackColor = Color.Red;
                mailValidado = false;
            }
            else if(this.usuarioMailRegistrado(textBoxEmail.Text))
            {
                MessageBox.Show("Ya existe un usuario registrado con el correo "+ textBoxEmail.Text);
                textBoxEmail.BackColor = Color.Red;
                mailValidado = true;

            }
            else
            {
                //todo bien
                textBoxEmail.BackColor = Color.White;
                mailValidado = true;
            }
        }

        private bool usuarioMailRegistrado(String mail)
        {
            UsuarioService usuarioServicio = new UsuarioService();
            try
            {
                if (usuarioServicio.validarSiExisteUsuario(mail))
                {
                    mailUnicoEnbase = false;
                    return true;
                }
                else
                {
                    mailUnicoEnbase = true;
                    return false;
                }


            }catch(Exception ex)
            {
                throw ex;
            }
        }

        private void textBoxConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (!textBoxPassword.Text.Trim().Equals(textBoxConfirmPassword.Text.Trim()))
            {
                MessageBox.Show("La nueva contraseña ingresada no coincide con la confirmación");
                textBoxPassword.BackColor = Color.Red;
                textBoxConfirmPassword.BackColor = Color.Red;
                cofirmacionValidadaPassword = false;
            }
            else
            {
                textBoxPassword.BackColor = Color.White;
                textBoxConfirmPassword.BackColor = Color.White;
                cofirmacionValidadaPassword = true;
            }
        }

        private void textBoxConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.textBoxConfirmPassword_Leave(sender, e);
            }
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            textBoxConfirmPassword.Visible = false;
            textBoxEmail.Text = " ";
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            label6.Visible = true;
            textBoxConfirmPassword.Visible = true;
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.textBoxPassword_Leave(sender, e);
            }
        }
    }
}
