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
    public partial class frmViajes : Form
    {
        private readonly ViajeAPI api; //Objeto para llamar a la API de viajes

        public frmViajes()
        {
            InitializeComponent(); //Inicializamos los componentes del formulario
            api = new ViajeAPI(); //Creamos la API de viajes
        }

        private void frmViajes_Load(object sender, EventArgs e)
        {
            Listar(); //Cuando se carga el formulario, se listan los viajes
        }


        //Metodos reutilizables
        //Listar() --> Método para mostrar los viajes en la tabla (DataGridView)
        private void Listar()
        {
            dgvViajes.DataSource = null;
            dgvViajes.DataSource = api.Listar(); //Cargamos la lista de viajes

            if (dgvViajes.Rows.Count > 0) //Si hay filas
            {
                dgvViajes.ClearSelection(); //Quitamos la selección
                dgvViajes.CurrentCell = null; //Aseguramos que no haya celda activa
            }
        }

        //Validar() --> Método para validar que los campos no estén vacíos y sean correctos
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

            return ok; //Devuelve true si todo está correcto
        }

        //LimpiarCampos() --> Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtDestino.Clear();
            txtPrecio.Clear();
            txtPlazas.Clear();

            txtDestino.Focus(); //Ponemos el cursor en el campo nombre
        }

        //CrearViaje() --> Método para crear un viaje nuevo
        private void CrearViaje()
        {
            if (Validar()) //Si los datos son válidos
            {
                try
                {
                    //Llamamos a la API para crear el viaje
                    api.Crear(txtDestino.Text, decimal.Parse(txtPrecio.Text), int.Parse(txtPlazas.Text));
                    Listar(); //Refrescamos la lista
                    LimpiarCampos(); //Limpiamos los campos
                    MessageBox.Show("Viaje creado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); //Mostramos el error si ocurre
                }
            }
        }

        //EditarViaje() --> Método para editar un viaje existente
        private void EditarViaje()
        {
            if (Validar()) //Si los datos son válidos
            {
                if (dgvViajes.CurrentRow != null) //Comprobamos que hay una fila seleccionada
                {
                    var viaje = (ViajeDTO)dgvViajes.CurrentRow.DataBoundItem; //Obtenemos el viaje seleccionado
                    viaje.Destino = txtDestino.Text;
                    viaje.Precio = decimal.Parse(txtPrecio.Text);
                    viaje.PlazasDisponibles = int.Parse(txtPlazas.Text);

                    try
                    {
                        api.Modificar(viaje); //Llamamos a la API para modificar el viaje
                        Listar();
                        LimpiarCampos();
                        MessageBox.Show("Viaje actualizado.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un viaje para editar.");
                }
            }
        }

        //EliminarViaje() --> Método para eliminar un viaje existente
        private void EliminarViaje()
        {
            if (dgvViajes.CurrentRow != null) //Comprobamos que hay una fila seleccionada
            {
                var viaje = (ViajeDTO)dgvViajes.CurrentRow.DataBoundItem; //Obtenemos el viaje seleccionado
                //Pedimos confirmación antes de eliminar
                var confirmar = MessageBox.Show("¿Eliminar viaje?", "Confirmación", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes) //Si confirma
                {
                    try
                    {
                        api.Eliminar(viaje.IdViaje); //Llamamos a la API para eliminar el viaje
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

        //dgvViajes_SelectionChanged --> Cuando cambia la selección en el DataGridView, se muestran los datos en los campos
        private void dgvViajes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvViajes.CurrentRow != null)
            {
                var viaje = (ViajeDTO)dgvViajes.CurrentRow.DataBoundItem;
                txtDestino.Text = viaje.Destino;
                txtPrecio.Text = viaje.Precio.ToString("0.00");
                txtPlazas.Text = viaje.PlazasDisponibles.ToString();
            }
        }


        //Eventos del Formulario
        private void btnCrear_Click(object sender, EventArgs e) => CrearViaje();

        private void btnEditar_Click(object sender, EventArgs e) => EditarViaje();

        private void btnEliminar_Click(object sender, EventArgs e) => EliminarViaje();


        //Eventos del MenuStrip
        private void crearToolStripMenuItem_Click(object sender, EventArgs e) => CrearViaje();

        private void editarToolStripMenuItem_Click(object sender, EventArgs e) => EditarViaje();

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e) => EliminarViaje();

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();


        //Eventos del ToolStrip
        private void btnCrearToolStrip_Click(object sender, EventArgs e) => CrearViaje();

        private void btnEditarToolStrip_Click(object sender, EventArgs e) => EditarViaje();

        private void btnEliminarToolStrip_Click(object sender, EventArgs e) => EliminarViaje();

        private void btnCerrarToolStrip_Click(object sender, EventArgs e) => this.Close();

    }
}
