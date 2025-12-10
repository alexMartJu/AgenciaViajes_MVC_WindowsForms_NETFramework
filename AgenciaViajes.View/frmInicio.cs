using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViajes.View
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void AbrirFormularioClientes()
        {
            var frm = new frmClientes();
            frm.ShowDialog();
        }

        private void AbrirFormularioViajes()
        {
            var frm = new frmViajes();
            frm.ShowDialog();
        }

        private void AbrirFormularioReservas()
        {
            var frm = new frmReservas();
            frm.ShowDialog();
        }


        //Eventos del Formulario
        private void btnAbrirClientes_Click(object sender, EventArgs e) => AbrirFormularioClientes();

        private void btnAbrirViajes_Click(object sender, EventArgs e) => AbrirFormularioViajes();

        private void btnAbrirReservas_Click(object sender, EventArgs e) => AbrirFormularioReservas();


        //Eventos del MenuStrip
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e) => AbrirFormularioClientes();

        private void viajesToolStripMenuItem_Click(object sender, EventArgs e) => AbrirFormularioViajes();

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e) => AbrirFormularioReservas();

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();


        //Eventos del ToolStrip
        private void btnClientesToolStrip_Click(object sender, EventArgs e) => AbrirFormularioClientes();

        private void btnViajesToolStrip_Click(object sender, EventArgs e) => AbrirFormularioViajes();

        private void btnReservasToolStrip_Click(object sender, EventArgs e) => AbrirFormularioReservas();

        private void btnCerrarToolStrip_Click(object sender, EventArgs e) => this.Close();

    }
}
