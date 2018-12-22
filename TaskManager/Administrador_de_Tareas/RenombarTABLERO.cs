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
    public partial class RenombarTABLERO : Form
    {
        private Tablero tableroEnUso = new Tablero();
        private Usuario userLogueado = new Usuario();
        public RenombarTABLERO()
        {
            InitializeComponent();
        }

        public void recibirInfoTablero(Tablero tableroEnUso, Usuario userLogueado)
        {
            this.tableroEnUso = tableroEnUso;
            this.userLogueado = userLogueado;
        }
        private void buttonRenombrarTablero_Click(object sender, EventArgs e)
        {
            TABLERO vistaTablero = Owner as TABLERO;
            try
            {
                TableroService tableroServicio = new TableroService();
                tableroServicio.updateNombreTablero(tableroEnUso.IdTablero, textBoxRenombrarTablero.Text);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            vistaTablero.renameBoard(textBoxRenombrarTablero.Text);
            this.Close();

        }

        private void RenombarTABLERO_Load(object sender, EventArgs e)
        {
            textBoxRenombrarTablero.Text = this.tableroEnUso.Nombre;
        }
    }
}
