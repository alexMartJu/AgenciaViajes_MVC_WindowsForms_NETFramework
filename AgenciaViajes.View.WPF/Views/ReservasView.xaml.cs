using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AgenciaViajes.Controller.APIs;

namespace AgenciaViajes.View.WPF.Views
{
    /// <summary>
    /// Lógica de interacción para ReservasView.xaml
    /// </summary>
    public partial class ReservasView : UserControl
    {
        private readonly ReservaAPI reservaApi;
        private readonly ClienteAPI clienteApi;
        private readonly ViajeAPI viajeApi;

        public ReservasView()
        {
            InitializeComponent();

            reservaApi = new ReservaAPI();
            clienteApi = new ClienteAPI();
            viajeApi = new ViajeAPI();

            CargarCombos();
            Listar();

            dpFecha.DisplayDateStart = DateTime.Today;
            dpFecha.SelectedDate = DateTime.Today;
        }

        private void CargarCombos()
        {
            cmbClientes.ItemsSource = clienteApi.Listar();
            cmbViajes.ItemsSource = viajeApi.Listar();
        }

        private void Listar()
        {
            dgReservas.ItemsSource = null;
            dgReservas.ItemsSource = reservaApi.Listar()
                .Select(r => new
                {
                    r.IdReserva,
                    r.IdCliente,
                    r.IdViaje,
                    r.FechaReserva
                })
                .ToList();

            if (dgReservas.Items.Count > 0)
            {
                dgReservas.SelectedItem = null;
            }
        }

        private void BtnCrear_Click(object sender, RoutedEventArgs e)
        {
            if (cmbClientes.SelectedValue == null || cmbViajes.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar cliente y viaje.");
            }
            else
            {
                int idCliente = (int)cmbClientes.SelectedValue;
                int idViaje = (int)cmbViajes.SelectedValue;
                DateTime fecha = dpFecha.SelectedDate ?? DateTime.Today;

                try
                {
                    reservaApi.Crear(idCliente, idViaje, fecha);
                    Listar();
                    CargarCombos();
                    MessageBox.Show("Reserva creada. Se ha decrementado 1 plaza.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            if (dgReservas.SelectedItem != null)
            {
                var item = dgReservas.SelectedItem;

                //Obtenemos el IdReserva del item seleccionado
                int idReserva = (int)TypeDescriptor
                    .GetProperties(item)["IdReserva"]
                    .GetValue(item);

                var confirmar = MessageBox.Show(
                    "¿Cancelar reserva?",
                    "Confirmación",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);

                if (confirmar == MessageBoxResult.Yes)
                {
                    try
                    {
                        reservaApi.Cancelar(idReserva);
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

        private void BtnPorCliente_Click(object sender, RoutedEventArgs e)
        {
            if (cmbClientes.SelectedValue != null)
            {
                int idCliente = (int)cmbClientes.SelectedValue;

                dgReservas.ItemsSource = reservaApi.PorCliente(idCliente)
                    .Select(r => new { r.IdReserva, r.IdCliente, r.IdViaje, r.FechaReserva })
                    .ToList();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente.");
            }
        }

        private void BtnPorViaje_Click(object sender, RoutedEventArgs e)
        {
            if (cmbViajes.SelectedValue != null)
            {
                int idViaje = (int)cmbViajes.SelectedValue;

                dgReservas.ItemsSource = reservaApi.PorViaje(idViaje)
                    .Select(r => new { r.IdReserva, r.IdCliente, r.IdViaje, r.FechaReserva })
                    .ToList();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un viaje.");
            }
        }

        private void BtnMostrarTodas_Click(object sender, RoutedEventArgs e)
        {
            Listar();
        }

        private void dgReservas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgReservas.SelectedItem != null)
            {
                var item = dgReservas.SelectedItem;
                //Obtenemos los valores del item seleccionado
                int idCliente = (int)TypeDescriptor
                    .GetProperties(item)["IdCliente"]
                    .GetValue(item);
                
                int idViaje = (int)TypeDescriptor
                    .GetProperties(item)["IdViaje"]
                    .GetValue(item);

                DateTime fecha = (DateTime)TypeDescriptor
                    .GetProperties(item)["FechaReserva"]
                    .GetValue(item);

                cmbClientes.SelectedValue = idCliente;
                cmbViajes.SelectedValue = idViaje;
                dpFecha.SelectedDate = fecha;
            }
        }
    }
}
