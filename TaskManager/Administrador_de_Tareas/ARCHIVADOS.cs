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
    public partial class ARCHIVADOS : Form
    {
        private IList<Tarea> listaARCHIVADOS = new List<Tarea>();

        public ARCHIVADOS()
        {
            InitializeComponent();
        }

        private void buttonDevolverAEstadoAnterior_Click(object sender, EventArgs e)
        {

        }

        private void ARCHIVADOS_Load(object sender, EventArgs e)
        {
            try
            {
                TareaService tareaServicio = new TareaService();
              //  listaARCHIVADOS = tareaServicio.tareasPorEstadoDelTablero(tableroEnUso.IdTablero, 4);

                dgvArchivadosPorTablero.DataSource = null;
                dgvArchivadosPorTablero.DataSource = listaARCHIVADOS;
                dgvArchivadosPorTablero.Columns[0].Visible = false;
                dgvArchivadosPorTablero.Columns[1].Visible = false;
                dgvArchivadosPorTablero.Columns[2].Visible = false;
                dgvArchivadosPorTablero.Columns[3].Visible = false;
                dgvArchivadosPorTablero.Columns[5].Visible = false;
                dgvArchivadosPorTablero.Columns[6].Visible = false;
                dgvArchivadosPorTablero.Columns[7].Visible = false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
