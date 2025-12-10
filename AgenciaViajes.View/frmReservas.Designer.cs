namespace AgenciaViajes.View
{
    partial class frmReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripReservas = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porViajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripClientes = new System.Windows.Forms.ToolStrip();
            this.btnCrearToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPorClienteToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPorViajeToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMostrarTodasToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCerrarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.splitContainerReservas = new System.Windows.Forms.SplitContainer();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.grpDatosReserva = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbViajes = new System.Windows.Forms.ComboBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblViaje = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnMostrarTodas = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPorViaje = new System.Windows.Forms.Button();
            this.btnPorCliente = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.menuStripReservas.SuspendLayout();
            this.toolStripClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReservas)).BeginInit();
            this.splitContainerReservas.Panel1.SuspendLayout();
            this.splitContainerReservas.Panel2.SuspendLayout();
            this.splitContainerReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.grpDatosReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripReservas
            // 
            this.menuStripReservas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reservasToolStripMenuItem});
            this.menuStripReservas.Location = new System.Drawing.Point(0, 0);
            this.menuStripReservas.Name = "menuStripReservas";
            this.menuStripReservas.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStripReservas.Size = new System.Drawing.Size(933, 25);
            this.menuStripReservas.TabIndex = 3;
            this.menuStripReservas.Text = "menuStripClientes";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.cancelarToolStripMenuItem,
            this.porClienteToolStripMenuItem,
            this.porViajeToolStripMenuItem,
            this.mostrarTodasToolStripMenuItem});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(64, 19);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            this.cancelarToolStripMenuItem.Click += new System.EventHandler(this.cancelarToolStripMenuItem_Click);
            // 
            // porClienteToolStripMenuItem
            // 
            this.porClienteToolStripMenuItem.Name = "porClienteToolStripMenuItem";
            this.porClienteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.porClienteToolStripMenuItem.Text = "Por Cliente";
            this.porClienteToolStripMenuItem.Click += new System.EventHandler(this.porClienteToolStripMenuItem_Click);
            // 
            // porViajeToolStripMenuItem
            // 
            this.porViajeToolStripMenuItem.Name = "porViajeToolStripMenuItem";
            this.porViajeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.porViajeToolStripMenuItem.Text = "Por Viaje";
            this.porViajeToolStripMenuItem.Click += new System.EventHandler(this.porViajeToolStripMenuItem_Click);
            // 
            // mostrarTodasToolStripMenuItem
            // 
            this.mostrarTodasToolStripMenuItem.Name = "mostrarTodasToolStripMenuItem";
            this.mostrarTodasToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.mostrarTodasToolStripMenuItem.Text = "Mostrar Todas";
            this.mostrarTodasToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodasToolStripMenuItem_Click);
            // 
            // toolStripClientes
            // 
            this.toolStripClientes.AutoSize = false;
            this.toolStripClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCrearToolStrip,
            this.toolStripSeparator1,
            this.btnCancelarToolStrip,
            this.toolStripSeparator3,
            this.btnPorClienteToolStrip,
            this.toolStripSeparator2,
            this.btnPorViajeToolStrip,
            this.toolStripSeparator4,
            this.btnMostrarTodasToolStrip,
            this.toolStripSeparator5,
            this.btnCerrarToolStrip});
            this.toolStripClientes.Location = new System.Drawing.Point(0, 25);
            this.toolStripClientes.Name = "toolStripClientes";
            this.toolStripClientes.Size = new System.Drawing.Size(933, 52);
            this.toolStripClientes.TabIndex = 11;
            this.toolStripClientes.Text = "toolStripClientes";
            // 
            // btnCrearToolStrip
            // 
            this.btnCrearToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCrearToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearToolStrip.Image")));
            this.btnCrearToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCrearToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCrearToolStrip.Name = "btnCrearToolStrip";
            this.btnCrearToolStrip.Size = new System.Drawing.Size(36, 49);
            this.btnCrearToolStrip.Text = "Crear Reserva";
            this.btnCrearToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCrearToolStrip.Click += new System.EventHandler(this.btnCrearToolStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // btnCancelarToolStrip
            // 
            this.btnCancelarToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelarToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarToolStrip.Image")));
            this.btnCancelarToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelarToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelarToolStrip.Name = "btnCancelarToolStrip";
            this.btnCancelarToolStrip.Size = new System.Drawing.Size(36, 49);
            this.btnCancelarToolStrip.Text = "Cancelar Reserva";
            this.btnCancelarToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelarToolStrip.Click += new System.EventHandler(this.btnCancelarToolStrip_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 52);
            // 
            // btnPorClienteToolStrip
            // 
            this.btnPorClienteToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPorClienteToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnPorClienteToolStrip.Image")));
            this.btnPorClienteToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPorClienteToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPorClienteToolStrip.Name = "btnPorClienteToolStrip";
            this.btnPorClienteToolStrip.Size = new System.Drawing.Size(36, 49);
            this.btnPorClienteToolStrip.Text = "Filtrar Por Cliente";
            this.btnPorClienteToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPorClienteToolStrip.Click += new System.EventHandler(this.btnPorClienteToolStrip_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // btnPorViajeToolStrip
            // 
            this.btnPorViajeToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPorViajeToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnPorViajeToolStrip.Image")));
            this.btnPorViajeToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPorViajeToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPorViajeToolStrip.Name = "btnPorViajeToolStrip";
            this.btnPorViajeToolStrip.Size = new System.Drawing.Size(36, 49);
            this.btnPorViajeToolStrip.Text = "Filtrar Por Viaje";
            this.btnPorViajeToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPorViajeToolStrip.Click += new System.EventHandler(this.btnPorViajeToolStrip_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 52);
            // 
            // btnMostrarTodasToolStrip
            // 
            this.btnMostrarTodasToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMostrarTodasToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarTodasToolStrip.Image")));
            this.btnMostrarTodasToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMostrarTodasToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMostrarTodasToolStrip.Name = "btnMostrarTodasToolStrip";
            this.btnMostrarTodasToolStrip.Size = new System.Drawing.Size(36, 49);
            this.btnMostrarTodasToolStrip.Text = "Mostrar Todas las Reservas";
            this.btnMostrarTodasToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMostrarTodasToolStrip.Click += new System.EventHandler(this.btnMostrarTodasToolStrip_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 52);
            // 
            // btnCerrarToolStrip
            // 
            this.btnCerrarToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCerrarToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarToolStrip.Image")));
            this.btnCerrarToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCerrarToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrarToolStrip.Name = "btnCerrarToolStrip";
            this.btnCerrarToolStrip.Size = new System.Drawing.Size(36, 49);
            this.btnCerrarToolStrip.Text = "Salir del Formulario";
            this.btnCerrarToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrarToolStrip.Click += new System.EventHandler(this.btnCerrarToolStrip_Click);
            // 
            // splitContainerReservas
            // 
            this.splitContainerReservas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerReservas.Location = new System.Drawing.Point(0, 77);
            this.splitContainerReservas.Name = "splitContainerReservas";
            this.splitContainerReservas.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerReservas.Panel1
            // 
            this.splitContainerReservas.Panel1.Controls.Add(this.dgvReservas);
            this.splitContainerReservas.Panel1.Controls.Add(this.grpDatosReserva);
            this.splitContainerReservas.Panel1.Controls.Add(this.lblInfo);
            // 
            // splitContainerReservas.Panel2
            // 
            this.splitContainerReservas.Panel2.Controls.Add(this.btnMostrarTodas);
            this.splitContainerReservas.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainerReservas.Panel2.Controls.Add(this.btnPorViaje);
            this.splitContainerReservas.Panel2.Controls.Add(this.btnPorCliente);
            this.splitContainerReservas.Panel2.Controls.Add(this.btnCrear);
            this.splitContainerReservas.Size = new System.Drawing.Size(933, 511);
            this.splitContainerReservas.SplitterDistance = 413;
            this.splitContainerReservas.TabIndex = 12;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvReservas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservas.EnableHeadersVisualStyles = false;
            this.dgvReservas.Location = new System.Drawing.Point(3, 146);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvReservas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(923, 260);
            this.dgvReservas.TabIndex = 12;
            this.dgvReservas.SelectionChanged += new System.EventHandler(this.dgvReservas_SelectionChanged);
            // 
            // grpDatosReserva
            // 
            this.grpDatosReserva.Controls.Add(this.dtpFecha);
            this.grpDatosReserva.Controls.Add(this.cmbViajes);
            this.grpDatosReserva.Controls.Add(this.cmbClientes);
            this.grpDatosReserva.Controls.Add(this.lblViaje);
            this.grpDatosReserva.Controls.Add(this.lblClientes);
            this.grpDatosReserva.Controls.Add(this.lblFecha);
            this.grpDatosReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDatosReserva.Location = new System.Drawing.Point(315, 7);
            this.grpDatosReserva.Name = "grpDatosReserva";
            this.grpDatosReserva.Size = new System.Drawing.Size(604, 131);
            this.grpDatosReserva.TabIndex = 11;
            this.grpDatosReserva.TabStop = false;
            this.grpDatosReserva.Text = "Datos de la Reserva";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(15, 93);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(276, 25);
            this.dtpFecha.TabIndex = 8;
            // 
            // cmbViajes
            // 
            this.cmbViajes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViajes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbViajes.FormattingEnabled = true;
            this.cmbViajes.Location = new System.Drawing.Point(313, 40);
            this.cmbViajes.Name = "cmbViajes";
            this.cmbViajes.Size = new System.Drawing.Size(276, 23);
            this.cmbViajes.TabIndex = 7;
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(15, 40);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(276, 23);
            this.cmbClientes.TabIndex = 6;
            // 
            // lblViaje
            // 
            this.lblViaje.AutoSize = true;
            this.lblViaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViaje.Location = new System.Drawing.Point(310, 25);
            this.lblViaje.Name = "lblViaje";
            this.lblViaje.Size = new System.Drawing.Size(40, 15);
            this.lblViaje.TabIndex = 5;
            this.lblViaje.Text = "Viajes:";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(12, 25);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(52, 15);
            this.lblClientes.TabIndex = 4;
            this.lblClientes.Text = "Clientes:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 74);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 15);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha de Reserva:";
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(-2, 49);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(282, 47);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Reservas";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMostrarTodas
            // 
            this.btnMostrarTodas.BackColor = System.Drawing.Color.Goldenrod;
            this.btnMostrarTodas.FlatAppearance.BorderSize = 0;
            this.btnMostrarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarTodas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodas.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTodas.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarTodas.Image")));
            this.btnMostrarTodas.Location = new System.Drawing.Point(380, 16);
            this.btnMostrarTodas.Name = "btnMostrarTodas";
            this.btnMostrarTodas.Size = new System.Drawing.Size(171, 62);
            this.btnMostrarTodas.TabIndex = 17;
            this.btnMostrarTodas.Text = " Mostrar Todas";
            this.btnMostrarTodas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarTodas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostrarTodas.UseVisualStyleBackColor = false;
            this.btnMostrarTodas.Click += new System.EventHandler(this.btnMostrarTodas_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(734, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(171, 62);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = " Cancelar Reserva";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPorViaje
            // 
            this.btnPorViaje.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPorViaje.FlatAppearance.BorderSize = 0;
            this.btnPorViaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPorViaje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorViaje.ForeColor = System.Drawing.Color.White;
            this.btnPorViaje.Image = ((System.Drawing.Image)(resources.GetObject("btnPorViaje.Image")));
            this.btnPorViaje.Location = new System.Drawing.Point(557, 16);
            this.btnPorViaje.Name = "btnPorViaje";
            this.btnPorViaje.Size = new System.Drawing.Size(171, 62);
            this.btnPorViaje.TabIndex = 15;
            this.btnPorViaje.Text = " Filtrar Por Viaje";
            this.btnPorViaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPorViaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPorViaje.UseVisualStyleBackColor = false;
            this.btnPorViaje.Click += new System.EventHandler(this.btnPorViaje_Click);
            // 
            // btnPorCliente
            // 
            this.btnPorCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPorCliente.FlatAppearance.BorderSize = 0;
            this.btnPorCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPorCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorCliente.ForeColor = System.Drawing.Color.White;
            this.btnPorCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnPorCliente.Image")));
            this.btnPorCliente.Location = new System.Drawing.Point(203, 16);
            this.btnPorCliente.Name = "btnPorCliente";
            this.btnPorCliente.Size = new System.Drawing.Size(171, 62);
            this.btnPorCliente.TabIndex = 14;
            this.btnPorCliente.Text = " Filtrar Por Cliente";
            this.btnPorCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPorCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPorCliente.UseVisualStyleBackColor = false;
            this.btnPorCliente.Click += new System.EventHandler(this.btnPorCliente_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Image = ((System.Drawing.Image)(resources.GetObject("btnCrear.Image")));
            this.btnCrear.Location = new System.Drawing.Point(26, 16);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(171, 62);
            this.btnCrear.TabIndex = 13;
            this.btnCrear.Text = " Crear Reserva";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.splitContainerReservas);
            this.Controls.Add(this.toolStripClientes);
            this.Controls.Add(this.menuStripReservas);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TravelWorld - Reservas";
            this.Load += new System.EventHandler(this.frmReservas_Load);
            this.menuStripReservas.ResumeLayout(false);
            this.menuStripReservas.PerformLayout();
            this.toolStripClientes.ResumeLayout(false);
            this.toolStripClientes.PerformLayout();
            this.splitContainerReservas.Panel1.ResumeLayout(false);
            this.splitContainerReservas.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReservas)).EndInit();
            this.splitContainerReservas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.grpDatosReserva.ResumeLayout(false);
            this.grpDatosReserva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripReservas;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripClientes;
        private System.Windows.Forms.ToolStripButton btnCrearToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCancelarToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.SplitContainer splitContainerReservas;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox grpDatosReserva;
        private System.Windows.Forms.Label lblViaje;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox cmbViajes;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnPorCliente;
        private System.Windows.Forms.Button btnPorViaje;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnMostrarTodas;
        private System.Windows.Forms.ToolStripMenuItem porClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porViajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnPorClienteToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnPorViajeToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnMostrarTodasToolStrip;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnCerrarToolStrip;
    }
}