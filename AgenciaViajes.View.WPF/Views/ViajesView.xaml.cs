using System;
using System.Collections.Generic;
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
using AgenciaViajes.Controller.DTOs;

namespace AgenciaViajes.View.WPF.Views
{
    /// <summary>
    /// Lógica de interacción para ViajesView.xaml
    /// </summary>
    public partial class ViajesView : UserControl
    {
        private readonly ViajeAPI api;

        public ViajesView()
        {
            InitializeComponent();
            api = new ViajeAPI();
            Listar();
        }

        private void Listar()
        {
            dgViajes.ItemsSource = null;
            dgViajes.ItemsSource = api.Listar();

            if (dgViajes.Items.Count > 0)
            {
                dgViajes.SelectedItem = null;
            }
        }

        private bool Validar()
        {
            bool ok = true;

            if (string.IsNullOrWhiteSpace(txtDestino.Text))
            {
                MessageBox.Show("El destino es obligatorio.");
                ok = false;
            }

            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número mayor que 0.");
                ok = false;
            }

            int plazas;
            if (!int.TryParse(txtPlazas.Text, out plazas) || plazas < 0)
            {
                MessageBox.Show("Plazas debe ser un entero ≥ 0.");
                ok = false;
            }

            return ok;
        }

        private void LimpiarCampos()
        {
            txtDestino.Clear();
            txtPrecio.Clear();
            txtPlazas.Clear();

            txtDestino.Focus();
        }

        private void BtnCrear_Click(object sender, RoutedEventArgs e)
        {
            if (Validar())
            {
                try
                {
                    api.Crear(txtDestino.Text, decimal.Parse(txtPrecio.Text), int.Parse(txtPlazas.Text));
                    Listar();
                    LimpiarCampos();
                    MessageBox.Show("Viaje creado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (dgViajes.SelectedItem != null)
            {
                if (Validar())
                {
                    var viaje = (ViajeDTO)dgViajes.SelectedItem;

                    viaje.Destino = txtDestino.Text;
                    viaje.Precio = decimal.Parse(txtPrecio.Text);
                    viaje.PlazasDisponibles = int.Parse(txtPlazas.Text);

                    try
                    {
                        api.Modificar(viaje);
                        Listar();
                        LimpiarCampos();
                        MessageBox.Show("Viaje actualizado.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un viaje para editar.");
            }
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (dgViajes.SelectedItem != null)
            {
                var viaje = (ViajeDTO)dgViajes.SelectedItem;

                var confirmar = MessageBox.Show(
                    "¿Eliminar viaje?",
                    "Confirmación",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);

                if (confirmar == MessageBoxResult.Yes)
                {
                    try
                    {
                        api.Eliminar(viaje.IdViaje);
                        Listar();
                        LimpiarCampos();
                        MessageBox.Show("Viaje eliminado.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un viaje para eliminar.");
            }
        }

        private void dgViajes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgViajes.SelectedItem != null)
            {
                var viaje = (ViajeDTO)dgViajes.SelectedItem;
                txtDestino.Text = viaje.Destino;
                txtPrecio.Text = viaje.Precio.ToString("0.00");
                txtPlazas.Text = viaje.PlazasDisponibles.ToString();
            }
        }
    }
}
