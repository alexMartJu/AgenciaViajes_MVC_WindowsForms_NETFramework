using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaViajes.Controller.APIs;
using AgenciaViajes.Controller.DTOs;

namespace AgenciaViajes.View
{
    public partial class frmReservas : Form
    {
        //Objetos para llamar a las APIs de reservas, clientes y viajes
        private readonly ReservaAPI reservaApi;
        private readonly ClienteAPI clienteApi;
        private readonly ViajeAPI viajeApi;

        public frmReservas()
        {
            InitializeComponent(); //Inicializamos los componentes del formulario
            //Creamos las APIs
            reservaApi = new ReservaAPI();
            clienteApi = new ClienteAPI();
            viajeApi = new ViajeAPI();
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            CargarCombos(); //Cargamos los combos de clientes y viajes
            Listar(); //Listamos las reservas
            dtpFecha.MinDate = DateTime.Today; //La fecha mínima es hoy
            dtpFecha.Value = DateTime.Today; //Valor por defecto es hoy
        }


        //Metodos reutilizables
        //CargarCombos() --> Método para llenar los combos de clientes y viajes
        private void CargarCombos()
        {
            var clientes = clienteApi.Listar(); //Lista de clientes --> List<ClienteDTO>
            var viajes = viajeApi.Listar(); //Lista de viajes --> List<ViajeDTO>

            //Asignamos las listas a los combos
            cmbClientes.DataSource = clientes;
            cmbClientes.DisplayMember = "NombreCompleto"; //Usamos la propiedad NombreCompleto para mostrar
            cmbClientes.ValueMember = "IdCliente";

            cmbViajes.DataSource = viajes;
            cmbViajes.DisplayMember = "Destino"; //Usamos la propiedad Destino para mostrar
            cmbViajes.ValueMember = "IdViaje";
        }

        //Listar() --> Método para mostrar todas las reservas en la tabla
        private void Listar()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = reservaApi.Listar() //Cargamos la lista de reservas
                .Select(r => new
                {
                    r.IdReserva,
                    r.IdCliente,
                    r.IdViaje,
                    r.FechaReserva
                }).ToList();
        }

        //CrearReserva() --> Método para crear una nueva reserva
        private void CrearReserva()
        {
            //Validamos que se haya seleccionado un cliente y un viaje
            if (cmbClientes.SelectedValue == null || cmbViajes.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar cliente y viaje.");
            }
            else //Si están seleccionados
            {
                //Obtenemos los valores seleccionados
                var idCliente = (int)cmbClientes.SelectedValue;
                var idViaje = (int)cmbViajes.SelectedValue;
                var fecha = dtpFecha.Value.Date;

                try
                {
                    reservaApi.Crear(idCliente, idViaje, fecha); //Llamamos a la API para crear la reserva
                    Listar(); //Refrescamos la lista
                    CargarCombos(); //Refrescamos los combos
                    MessageBox.Show("Reserva creada. Se ha decrementado 1 plaza.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //CancelarReserva() --> Método para cancelar una reserva seleccionada
        private void CancelarReserva()
        {
            if (dgvReservas.CurrentRow != null) //Comprobamos que hay una fila seleccionada
            {
                var idReserva = (int)dgvReservas.CurrentRow.Cells["IdReserva"].Value; //Obtenemos el IdReserva
                //Pedimos confirmación
                var confirmar = MessageBox.Show("¿Cancelar reserva?", "Confirmación", MessageBoxButtons.YesNo);

                if (confirmar == DialogResult.Yes) //Si confirma
                {
                    try
                    {
                        reservaApi.Cancelar(idReserva); //Llamamos a la API para cancelar la reserva
                        Listar();
                        CargarCombos();
                        MessageBox.Show("Reserva cancelada. Se ha devuelto 1 plaza al viaje.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una reserva para cancelar.");
            }
        }

        //FiltrarPorCliente() --> Método para filtrar reservas por cliente seleccionado
        private void FiltrarPorCliente()
        {
            if (cmbClientes.SelectedValue != null) //Comprobamos que hay un cliente seleccionado
            {
                var idCliente = (int)cmbClientes.SelectedValue; //Obtenemos el IdCliente
                //Filtramos las reservas por cliente
                dgvReservas.DataSource = reservaApi.PorCliente(idCliente)
                    .Select(r => new { r.IdReserva, r.IdCliente, r.IdViaje, r.FechaReserva }).ToList();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente para filtrar.");
            }
        }

        //FiltrarPorViaje() --> Método para filtrar reservas por viaje seleccionado
        private void FiltrarPorViaje()
        {
            if (cmbViajes.SelectedValue != null)
            {
                var idViaje = (int)cmbViajes.SelectedValue; //Obtenemos el IdViaje
                //Filtramos las reservas por viaje
                dgvReservas.DataSource = reservaApi.PorViaje(idViaje)
                    .Select(r => new { r.IdReserva, r.IdCliente, r.IdViaje, r.FechaReserva }).ToList();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un viaje para filtrar.");
            }
        }

        //dgvReservas_SelectionChanged() --> Cuando cambia la selección en el DataGridView, se muestran los datos en los combos y DateTimePicker
        private void dgvReservas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow != null)
            {
                //Obtenemos los valores de la fila seleccionada
                int idCliente = (int)dgvReservas.CurrentRow.Cells["IdCliente"].Value;
                int idViaje = (int)dgvReservas.CurrentRow.Cells["IdViaje"].Value;
                DateTime fecha = (DateTime)dgvReservas.CurrentRow.Cells["FechaReserva"].Value;

                //Asignamos a los combos y al DateTimePicker
                cmbClientes.SelectedValue = idCliente;
                cmbViajes.SelectedValue = idViaje;
                dtpFecha.Value = fecha;
            }
        }


        //Eventos del Formulario
        private void btnCrear_Click(object sender, EventArgs e) => CrearReserva();

        private void btnCancelar_Click(object sender, EventArgs e) => CancelarReserva();

        private void btnPorCliente_Click(object sender, EventArgs e) => FiltrarPorCliente();

        private void btnPorViaje_Click(object sender, EventArgs e) => FiltrarPorViaje();

        private void btnMostrarTodas_Click(object sender, EventArgs e) => Listar();


        //Eventos del MenuStrip
        private void crearToolStripMenuItem_Click(object sender, EventArgs e) => CrearReserva();

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e) => CancelarReserva();

        private void porClienteToolStripMenuItem_Click(object sender, EventArgs e) => FiltrarPorCliente();

        private void porViajeToolStripMenuItem_Click(object sender, EventArgs e) => FiltrarPorViaje();

        private void mostrarTodasToolStripMenuItem_Click(object sender, EventArgs e) => Listar();

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();


        //Eventos del ToolStrip
        private void btnCrearToolStrip_Click(object sender, EventArgs e) => CrearReserva();

        private void btnCancelarToolStrip_Click(object sender, EventArgs e) => CancelarReserva();

        private void btnPorClienteToolStrip_Click(object sender, EventArgs e) => FiltrarPorCliente();

        private void btnPorViajeToolStrip_Click(object sender, EventArgs e) => FiltrarPorViaje();

        private void btnMostrarTodasToolStrip_Click(object sender, EventArgs e) => Listar();

        private void btnCerrarToolStrip_Click(object sender, EventArgs e) => this.Close();

    }
}
