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
    public partial class AddTAREA : Form
    {
        private Tablero tableroEnUso = new Tablero();
        private Usuario userLogueado = new Usuario();
        private int idEstadoTarea;
        public AddTAREA()
        {
            InitializeComponent();
        }

        public void recibirDatosDeTablero(Tablero tableroEnUso,Usuario  userLogueado,int idEstado)
        {
            this.tableroEnUso = tableroEnUso;
            this.userLogueado = userLogueado;
            this.idEstadoTarea = idEstado;
        }

        private void buttonCrearTareaEnLista_Click(object sender, EventArgs e)
        {
            try
            {
                TareaService tareaServicio = new TareaService();
                tareaServicio.createTareaToTablero(tableroEnUso.IdTablero, userLogueado.IdUsuario, idEstadoTarea, textBoxDataEntrada.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            TABLERO vistaTablero = Owner as TABLERO;
            vistaTablero.refreshTablero();
            this.Close();
        }

        private void textBoxDataEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.buttonCrearTareaEnLista_Click(sender, e);
            }
        }
    }
}
