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
using AgenciaViajes.View.WPF.Views;

namespace AgenciaViajes.View.WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ClientesView _clientesView;
        private ViajesView _viajesView;
        private ReservasView _reservasView;

        public MainWindow()
        {
            InitializeComponent();

            _clientesView = new ClientesView();
            MainContent.Content = _clientesView;

            txtTitulo.Text = "Gestión de Clientes";
            rdbClientes.IsChecked = true;
        }

        private void RdbClientes_Checked(object sender, RoutedEventArgs e)
        {
            if (_clientesView == null)
            {
                _clientesView = new ClientesView();
            }

            MainContent.Content = _clientesView;
            txtTitulo.Text = "Gestión de Clientes";
        }

        private void RdbViajes_Checked(object sender, RoutedEventArgs e)
        {
            _viajesView = new ViajesView();

            MainContent.Content = _viajesView;
            txtTitulo.Text = "Gestión de Viajes";
        }

        private void RdbReservas_Checked(object sender, RoutedEventArgs e)
        {
            _reservasView = new ReservasView();

            MainContent.Content = _reservasView;
            txtTitulo.Text = "Gestión de Reservas";
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show(
                "¿Está seguro que desea salir?",
                "Confirmar salida",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
