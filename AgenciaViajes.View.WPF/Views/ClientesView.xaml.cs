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
    /// Lógica de interacción para ClientesView.xaml
    /// </summary>
    public partial class ClientesView : UserControl
    {
        private readonly ClienteAPI api;

        public ClientesView()
        {
            InitializeComponent();
            api = new ClienteAPI();
            Listar();
        }

        private void Listar()
        {
            //Refrescamos la lista de clientes en el DataGrid
            dgClientes.ItemsSource = null;
            dgClientes.ItemsSource = api.Listar(); //Cargamos la lista de clientes

            if (dgClientes.Items.Count > 0)
            {
                dgClientes.SelectedItem = null;
            }
        }

        private bool Validar()
        {
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                MessageBox.Show("Los apellidos son obligatorios.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("El email es obligatorio.");
                esValido = false;
            }

            return esValido;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtNombre.Focus();
        }

        private void BtnCrear_Click(object sender, RoutedEventArgs e)
        {
            if (Validar())
            {
                try
                {
                    api.Crear(txtNombre.Text, txtApellidos.Text, txtEmail.Text);
                    Listar();
                    LimpiarCampos();
                    MessageBox.Show("Cliente creado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (dgClientes.SelectedItem != null)
            {
                if (Validar())
                {
                    var cliente = (ClienteDTO)dgClientes.SelectedItem;

                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellidos = txtApellidos.Text;
                    cliente.Email = txtEmail.Text;

                    try
                    {
                        api.Editar(cliente);
                        Listar();
                        LimpiarCampos();
                        MessageBox.Show("Cliente actualizado.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente para editar.");
            }
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (dgClientes.SelectedItem != null)
            {
                var cliente = (ClienteDTO)dgClientes.SelectedItem;

                var confirmar = MessageBox.Show(
                    "¿Eliminar cliente?",
                    "Confirmación",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);

                if (confirmar == MessageBoxResult.Yes)
                {
                    try
                    {
                        api.Eliminar(cliente.IdCliente);
                        Listar();
                        LimpiarCampos();
                        MessageBox.Show("Cliente eliminado.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminar.");
            }
        }

        private void dgClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgClientes.SelectedItem != null)
            {
                var cliente = (ClienteDTO)dgClientes.SelectedItem;
                txtNombre.Text = cliente.Nombre;
                txtApellidos.Text = cliente.Apellidos;
                txtEmail.Text = cliente.Email;
            }
        }
    }
}
