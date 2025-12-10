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
    public partial class frmClientes : Form
    {
        private readonly ClienteAPI api; //Objeto para llamar a la API de clientes

        public frmClientes()
        {
            InitializeComponent(); //Inicializamos los componentes del formulario
            api = new ClienteAPI(); //Creamos la API de clientes
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            Listar(); //Cuando se carga el formulario, se listan los clientes
        }


        //Metodos reutilizables
        //Listar() --> Método para mostrar los clientes en la tabla (DataGridView)
        private void Listar()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = api.Listar(); //Cargamos la lista de clientes

            if (dgvClientes.Rows.Count > 0)
            {
                dgvClientes.ClearSelection(); //Quitamos la selección
                dgvClientes.CurrentCell = null; //Aseguramos que no haya celda activa
            }
        }

        //Validar() --> Método para validar que los campos no estén vacíos
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

            return esValido; //Devuelve true si todo está correcto
        }

        //LimpiarCampos() --> Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();

            txtNombre.Focus(); //Ponemos el cursor en el campo nombre
        }

        //CrearCliente() --> Método para crear un cliente nuevo
        private void CrearCliente()
        {
            if (Validar()) //Validamos los campos
            {
                try
                {
                    api.Crear(txtNombre.Text, txtApellidos.Text, txtEmail.Text); //Llamamos a la API para crear el cliente
                    Listar(); //Refrescamos la lista
                    LimpiarCampos(); //Limpiamos los campos
                    MessageBox.Show("Cliente creado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); //Mostramos el error si ocurre
                }
            }
        }

        //EditarCliente() --> Método para editar un cliente existente
        private void EditarCliente()
        {
            if (Validar()) //Validamos los campos
            {
                if (dgvClientes.CurrentRow != null) //Comprobamos que hay una fila seleccionada
                {
                    var cliente = (ClienteDTO)dgvClientes.CurrentRow.DataBoundItem; //Obtenemos el cliente seleccionado
                    //Actualizamos los datos del cliente
                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellidos = txtApellidos.Text;
                    cliente.Email = txtEmail.Text;

                    try
                    {
                        api.Editar(cliente); //Llamamos a la API para editar el cliente
                        Listar();
                        LimpiarCampos();
                        MessageBox.Show("Cliente actualizado.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente para editar.");
                }
            }
        }

        //EliminarCliente() --> Método para eliminar un cliente
        private void EliminarCliente()
        {
            if (dgvClientes.CurrentRow != null) //Comprobamos que hay una fila seleccionada
            {
                var cliente = (ClienteDTO)dgvClientes.CurrentRow.DataBoundItem; //Obtenemos el cliente seleccionado
                //Pedimos confirmación antes de eliminar
                var confirmar = MessageBox.Show("¿Eliminar cliente?", "Confirmación", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes) //Si confirma
                {
                    try
                    {
                        api.Eliminar(cliente.IdCliente); //Llamamos a la API para eliminar el cliente
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

        //dgvClientes_SelectionChanged() --> Cuando cambia la selección en el DataGridView, se muestran los datos en los campos
        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                var cliente = (ClienteDTO)dgvClientes.CurrentRow.DataBoundItem;
                txtNombre.Text = cliente.Nombre;
                txtApellidos.Text = cliente.Apellidos;
                txtEmail.Text = cliente.Email;
            }
        }


        //Eventos del Formulario
        private void btnCrear_Click(object sender, EventArgs e) => CrearCliente();

        private void btnEditar_Click(object sender, EventArgs e) => EditarCliente();

        private void btnEliminar_Click(object sender, EventArgs e) => EliminarCliente();


        //Eventos del MenuStrip
        private void crearToolStripMenuItem_Click(object sender, EventArgs e) => CrearCliente();

        private void editarToolStripMenuItem_Click(object sender, EventArgs e) => EditarCliente();

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e) => EliminarCliente();

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();


        //Eventos del ToolStrip
        private void btnCrearToolStrip_Click(object sender, EventArgs e) => CrearCliente();

        private void btnEditarToolStrip_Click(object sender, EventArgs e) => EditarCliente();

        private void btnEliminarToolStrip_Click(object sender, EventArgs e) => EliminarCliente();

        private void btnCerrarToolStrip_Click(object sender, EventArgs e) => this.Close();

    }
}
