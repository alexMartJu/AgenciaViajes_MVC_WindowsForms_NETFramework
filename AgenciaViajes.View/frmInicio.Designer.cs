namespace AgenciaViajes.View
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.menuStripInicio = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripInicio = new System.Windows.Forms.ToolStrip();
            this.btnClientesToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnViajesToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReservasToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCerrarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnAbrirClientes = new System.Windows.Forms.Button();
            this.btnAbrirViajes = new System.Windows.Forms.Button();
            this.btnAbrirReservas = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.menuStripInicio.SuspendLayout();
            this.toolStripInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripInicio
            // 
            this.menuStripInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.agenciaToolStripMenuItem});
            this.menuStripInicio.Location = new System.Drawing.Point(0, 0);
            this.menuStripInicio.Name = "menuStripInicio";
            this.menuStripInicio.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStripInicio.Size = new System.Drawing.Size(831, 25);
            this.menuStripInicio.TabIndex = 0;
            this.menuStripInicio.Text = "menuStripInicio";
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
            // agenciaToolStripMenuItem
            // 
            this.agenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.viajesToolStripMenuItem,
            this.reservasToolStripMenuItem});
            this.agenciaToolStripMenuItem.Name = "agenciaToolStripMenuItem";
            this.agenciaToolStripMenuItem.Size = new System.Drawing.Size(62, 19);
            this.agenciaToolStripMenuItem.Text = "Agencia";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // viajesToolStripMenuItem
            // 
            this.viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            this.viajesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.viajesToolStripMenuItem.Text = "Viajes";
            this.viajesToolStripMenuItem.Click += new System.EventHandler(this.viajesToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // toolStripInicio
            // 
            this.toolStripInicio.AutoSize = false;
            this.toolStripInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientesToolStrip,
            this.toolStripSeparator1,
            this.btnViajesToolStrip,
            this.toolStripSeparator2,
            this.btnReservasToolStrip,
            this.toolStripSeparator3,
            this.btnCerrarToolStrip});
            this.toolStripInicio.Location = new System.Drawing.Point(0, 25);
            this.toolStripInicio.Name = "toolStripInicio";
            this.toolStripInicio.Size = new System.Drawing.Size(831, 52);
            this.toolStripInicio.TabIndex = 8;
            this.toolStripInicio.Text = "toolStripInicio";
            // 
            // btnClientesToolStrip
            // 
            this.btnClientesToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClientesToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnClientesToolStrip.Image")));
            this.btnClientesToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClientesToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClientesToolStrip.Name = "btnClientesToolStrip";
            this.btnClientesToolStrip.Size = new System.Drawing.Size(36, 49);
            this.btnClientesToolStrip.Text = "Abrir Formulario de Clientes";
            this.btnClientesToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientesToolStrip.Click += new System.EventHandler(this.btnClientesToolStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // btnViajesToolStrip
            // 
            this.btnViajesToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnViajesToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnViajesToolStrip.Image")));
            this.btnViajesToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnViajesToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViajesToolStrip.Name = "btnViajesToolStrip";
            this.btnViajesToolStrip.Size = new System.Drawing.Size(36, 49);
            this.btnViajesToolStrip.Text = "Abrir Formulario de Viajes";
            this.btnViajesToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViajesToolStrip.Click += new System.EventHandler(this.btnViajesToolStrip_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // btnReservasToolStrip
            // 
            this.btnReservasToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReservasToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnReservasToolStrip.Image")));
            this.btnReservasToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReservasToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReservasToolStrip.Name = "btnReservasToolStrip";
            this.btnReservasToolStrip.Size = new System.Drawing.Size(36, 49);
            this.btnReservasToolStrip.Text = "Abrir Formulario de Reservas";
            this.btnReservasToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReservasToolStrip.Click += new System.EventHandler(this.btnReservasToolStrip_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 52);
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
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(23, 155);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(350, 350);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnAbrirClientes
            // 
            this.btnAbrirClientes.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAbrirClientes.FlatAppearance.BorderSize = 0;
            this.btnAbrirClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirClientes.ForeColor = System.Drawing.Color.White;
            this.btnAbrirClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirClientes.Image")));
            this.btnAbrirClientes.Location = new System.Drawing.Point(416, 202);
            this.btnAbrirClientes.Name = "btnAbrirClientes";
            this.btnAbrirClientes.Size = new System.Drawing.Size(322, 62);
            this.btnAbrirClientes.TabIndex = 10;
            this.btnAbrirClientes.Text = " Abrir Formulario de Clientes";
            this.btnAbrirClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirClientes.UseVisualStyleBackColor = false;
            this.btnAbrirClientes.Click += new System.EventHandler(this.btnAbrirClientes_Click);
            // 
            // btnAbrirViajes
            // 
            this.btnAbrirViajes.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAbrirViajes.FlatAppearance.BorderSize = 0;
            this.btnAbrirViajes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirViajes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirViajes.ForeColor = System.Drawing.Color.White;
            this.btnAbrirViajes.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirViajes.Image")));
            this.btnAbrirViajes.Location = new System.Drawing.Point(416, 302);
            this.btnAbrirViajes.Name = "btnAbrirViajes";
            this.btnAbrirViajes.Size = new System.Drawing.Size(322, 62);
            this.btnAbrirViajes.TabIndex = 11;
            this.btnAbrirViajes.Text = " Abrir Formulario de Viajes";
            this.btnAbrirViajes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirViajes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirViajes.UseVisualStyleBackColor = false;
            this.btnAbrirViajes.Click += new System.EventHandler(this.btnAbrirViajes_Click);
            // 
            // btnAbrirReservas
            // 
            this.btnAbrirReservas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAbrirReservas.FlatAppearance.BorderSize = 0;
            this.btnAbrirReservas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirReservas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirReservas.ForeColor = System.Drawing.Color.White;
            this.btnAbrirReservas.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirReservas.Image")));
            this.btnAbrirReservas.Location = new System.Drawing.Point(416, 394);
            this.btnAbrirReservas.Name = "btnAbrirReservas";
            this.btnAbrirReservas.Size = new System.Drawing.Size(322, 62);
            this.btnAbrirReservas.TabIndex = 12;
            this.btnAbrirReservas.Text = " Abrir Formulario de Reservas";
            this.btnAbrirReservas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirReservas.UseVisualStyleBackColor = false;
            this.btnAbrirReservas.Click += new System.EventHandler(this.btnAbrirReservas_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(0, 99);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(831, 65);
            this.lblMenu.TabIndex = 13;
            this.lblMenu.Text = "Menú Principal";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(831, 497);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnAbrirReservas);
            this.Controls.Add(this.btnAbrirViajes);
            this.Controls.Add(this.btnAbrirClientes);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.toolStripInicio);
            this.Controls.Add(this.menuStripInicio);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripInicio;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TravelWorld - Menu";
            this.menuStripInicio.ResumeLayout(false);
            this.menuStripInicio.PerformLayout();
            this.toolStripInicio.ResumeLayout(false);
            this.toolStripInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripInicio;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripInicio;
        private System.Windows.Forms.ToolStripButton btnClientesToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnViajesToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnReservasToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnCerrarToolStrip;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnAbrirClientes;
        private System.Windows.Forms.Button btnAbrirViajes;
        private System.Windows.Forms.Button btnAbrirReservas;
        private System.Windows.Forms.Label lblMenu;
    }
}