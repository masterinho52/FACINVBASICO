namespace UI_APLICACION
{
    partial class ContenedorPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContenedorPrincipal));
            this.menuArchivo = new System.Windows.Forms.MenuStrip();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mercaderiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosMásVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechasDeCaducidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesYPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contenedorProcesosBasicos = new System.Windows.Forms.Panel();
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEmpleado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.reloj = new System.Windows.Forms.Timer(this.components);
            this.opcionVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCotizacion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCorteCaja = new System.Windows.Forms.ToolStripMenuItem();
            this.OperacionesBasicas = new System.Windows.Forms.MenuStrip();
            this.menuArchivo.SuspendLayout();
            this.contenedorProcesosBasicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.OperacionesBasicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuArchivo
            // 
            this.menuArchivo.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuArchivo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuArchivo.Location = new System.Drawing.Point(148, 0);
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(1113, 29);
            this.menuArchivo.TabIndex = 1;
            this.menuArchivo.Text = "menuStrip2";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.mercaderiaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.documentosToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.comprasToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(132, 25);
            this.administraciónToolStripMenuItem.Text = "&Administración";
            this.administraciónToolStripMenuItem.Click += new System.EventHandler(this.administraciónToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem1,
            this.usuariosToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.permisosToolStripMenuItem});
            this.empleadosToolStripMenuItem.Enabled = false;
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(160, 26);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.permisosToolStripMenuItem.Text = "Permisos";
            // 
            // mercaderiaToolStripMenuItem
            // 
            this.mercaderiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.mercaderiaToolStripMenuItem.Enabled = false;
            this.mercaderiaToolStripMenuItem.Name = "mercaderiaToolStripMenuItem";
            this.mercaderiaToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.mercaderiaToolStripMenuItem.Text = "Mercaderia";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Enabled = false;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Enabled = false;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // documentosToolStripMenuItem
            // 
            this.documentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentosToolStripMenuItem1,
            this.seriesToolStripMenuItem});
            this.documentosToolStripMenuItem.Enabled = false;
            this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            this.documentosToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.documentosToolStripMenuItem.Text = "Documentos";
            // 
            // documentosToolStripMenuItem1
            // 
            this.documentosToolStripMenuItem1.Name = "documentosToolStripMenuItem1";
            this.documentosToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.documentosToolStripMenuItem1.Text = "Documentos";
            // 
            // seriesToolStripMenuItem
            // 
            this.seriesToolStripMenuItem.Name = "seriesToolStripMenuItem";
            this.seriesToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.seriesToolStripMenuItem.Text = "Series";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Enabled = false;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Enabled = false;
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasPorFechasToolStripMenuItem,
            this.artículosMásVendidosToolStripMenuItem,
            this.comprasPorFechasToolStripMenuItem,
            this.fechasDeCaducidadToolStripMenuItem,
            this.existenciasToolStripMenuItem,
            this.utilidadesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.reportesToolStripMenuItem.Text = "&Reportes";
            // 
            // ventasPorFechasToolStripMenuItem
            // 
            this.ventasPorFechasToolStripMenuItem.Enabled = false;
            this.ventasPorFechasToolStripMenuItem.Name = "ventasPorFechasToolStripMenuItem";
            this.ventasPorFechasToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.ventasPorFechasToolStripMenuItem.Text = "Ventas por fechas";
            this.ventasPorFechasToolStripMenuItem.Click += new System.EventHandler(this.ventasPorFechasToolStripMenuItem_Click);
            // 
            // artículosMásVendidosToolStripMenuItem
            // 
            this.artículosMásVendidosToolStripMenuItem.Name = "artículosMásVendidosToolStripMenuItem";
            this.artículosMásVendidosToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.artículosMásVendidosToolStripMenuItem.Text = "Artículos más vendidos";
            this.artículosMásVendidosToolStripMenuItem.Click += new System.EventHandler(this.artículosMásVendidosToolStripMenuItem_Click);
            // 
            // comprasPorFechasToolStripMenuItem
            // 
            this.comprasPorFechasToolStripMenuItem.Enabled = false;
            this.comprasPorFechasToolStripMenuItem.Name = "comprasPorFechasToolStripMenuItem";
            this.comprasPorFechasToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.comprasPorFechasToolStripMenuItem.Text = "Compras por fechas";
            this.comprasPorFechasToolStripMenuItem.Click += new System.EventHandler(this.comprasPorFechasToolStripMenuItem_Click);
            // 
            // fechasDeCaducidadToolStripMenuItem
            // 
            this.fechasDeCaducidadToolStripMenuItem.Name = "fechasDeCaducidadToolStripMenuItem";
            this.fechasDeCaducidadToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.fechasDeCaducidadToolStripMenuItem.Text = "Fechas de caducidad";
            this.fechasDeCaducidadToolStripMenuItem.Click += new System.EventHandler(this.fechasDeCaducidadToolStripMenuItem_Click);
            // 
            // existenciasToolStripMenuItem
            // 
            this.existenciasToolStripMenuItem.Name = "existenciasToolStripMenuItem";
            this.existenciasToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.existenciasToolStripMenuItem.Text = "Existencias";
            this.existenciasToolStripMenuItem.Click += new System.EventHandler(this.existenciasToolStripMenuItem_Click);
            // 
            // utilidadesToolStripMenuItem
            // 
            this.utilidadesToolStripMenuItem.Name = "utilidadesToolStripMenuItem";
            this.utilidadesToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.utilidadesToolStripMenuItem.Text = "Utilidades";
            this.utilidadesToolStripMenuItem.Click += new System.EventHandler(this.utilidadesToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesYPermisosToolStripMenuItem,
            this.cambioDeUsuarioToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(125, 25);
            this.configuraciónToolStripMenuItem.Text = "&Configuración";
            // 
            // rolesYPermisosToolStripMenuItem
            // 
            this.rolesYPermisosToolStripMenuItem.Enabled = false;
            this.rolesYPermisosToolStripMenuItem.Name = "rolesYPermisosToolStripMenuItem";
            this.rolesYPermisosToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.rolesYPermisosToolStripMenuItem.Text = "Roles y Permisos";
            // 
            // cambioDeUsuarioToolStripMenuItem
            // 
            this.cambioDeUsuarioToolStripMenuItem.Name = "cambioDeUsuarioToolStripMenuItem";
            this.cambioDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.cambioDeUsuarioToolStripMenuItem.Text = "Cambio de Usuario";
            this.cambioDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cambioDeUsuarioToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAyudaToolStripMenuItem,
            this.créditosToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // verAyudaToolStripMenuItem
            // 
            this.verAyudaToolStripMenuItem.Name = "verAyudaToolStripMenuItem";
            this.verAyudaToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.verAyudaToolStripMenuItem.Text = "Ver Ayuda";
            this.verAyudaToolStripMenuItem.Click += new System.EventHandler(this.verAyudaToolStripMenuItem_Click);
            // 
            // créditosToolStripMenuItem
            // 
            this.créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            this.créditosToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.créditosToolStripMenuItem.Text = "Créditos";
            this.créditosToolStripMenuItem.Click += new System.EventHandler(this.créditosToolStripMenuItem_Click);
            // 
            // contenedorProcesosBasicos
            // 
            this.contenedorProcesosBasicos.Controls.Add(this.pbFondo);
            this.contenedorProcesosBasicos.Location = new System.Drawing.Point(166, 32);
            this.contenedorProcesosBasicos.Name = "contenedorProcesosBasicos";
            this.contenedorProcesosBasicos.Size = new System.Drawing.Size(1083, 593);
            this.contenedorProcesosBasicos.TabIndex = 2;
            this.contenedorProcesosBasicos.Visible = false;
            // 
            // pbFondo
            // 
            this.pbFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFondo.BackgroundImage")));
            this.pbFondo.Location = new System.Drawing.Point(-15, -9);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(1110, 602);
            this.pbFondo.TabIndex = 0;
            this.pbFondo.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblEmpleado,
            this.toolStripStatusLabel3,
            this.lblUsuario,
            this.toolStripStatusLabel2,
            this.lblRol,
            this.lblFechaHora});
            this.statusStrip1.Location = new System.Drawing.Point(148, 628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1113, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(78, 17);
            this.toolStripStatusLabel1.Text = "EMPLEADO:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(86, 17);
            this.lblEmpleado.Text = "@EMPLEADO";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel3.Text = "USUARIO:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 17);
            this.lblUsuario.Text = "@USUARIO";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel2.Text = "ROL:";
            // 
            // lblRol
            // 
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(38, 17);
            this.lblRol.Text = "@Rol";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(98, 17);
            this.lblFechaHora.Text = "@FECHA HORA";
            // 
            // opcionVenta
            // 
            this.opcionVenta.Enabled = false;
            this.opcionVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionVenta.Image = ((System.Drawing.Image)(resources.GetObject("opcionVenta.Image")));
            this.opcionVenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opcionVenta.Name = "opcionVenta";
            this.opcionVenta.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.opcionVenta.Size = new System.Drawing.Size(135, 135);
            this.opcionVenta.Text = "Venta [F8]";
            this.opcionVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.opcionVenta.Click += new System.EventHandler(this.fdsfToolStripMenuItem_Click);
            // 
            // menuCotizacion
            // 
            this.menuCotizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuCotizacion.Enabled = false;
            this.menuCotizacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("menuCotizacion.Image")));
            this.menuCotizacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCotizacion.Name = "menuCotizacion";
            this.menuCotizacion.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.menuCotizacion.Size = new System.Drawing.Size(135, 117);
            this.menuCotizacion.Text = "Cotización [F9]";
            this.menuCotizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuCotizacion.Click += new System.EventHandler(this.fdsfToolStripMenuItem1_Click);
            // 
            // menuPedido
            // 
            this.menuPedido.Enabled = false;
            this.menuPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPedido.Image = ((System.Drawing.Image)(resources.GetObject("menuPedido.Image")));
            this.menuPedido.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuPedido.Name = "menuPedido";
            this.menuPedido.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.menuPedido.Size = new System.Drawing.Size(135, 130);
            this.menuPedido.Text = "Pedido [F10]";
            this.menuPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuPedido.Click += new System.EventHandler(this.menuPedido_Click);
            // 
            // menuCompra
            // 
            this.menuCompra.Enabled = false;
            this.menuCompra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCompra.Image = ((System.Drawing.Image)(resources.GetObject("menuCompra.Image")));
            this.menuCompra.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCompra.Name = "menuCompra";
            this.menuCompra.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.menuCompra.Size = new System.Drawing.Size(135, 138);
            this.menuCompra.Text = "Compra [F11]";
            this.menuCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuCompra.Click += new System.EventHandler(this.menuCompra_Click);
            // 
            // menuCorteCaja
            // 
            this.menuCorteCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuCorteCaja.Enabled = false;
            this.menuCorteCaja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCorteCaja.Image = ((System.Drawing.Image)(resources.GetObject("menuCorteCaja.Image")));
            this.menuCorteCaja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCorteCaja.Name = "menuCorteCaja";
            this.menuCorteCaja.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.menuCorteCaja.Size = new System.Drawing.Size(135, 125);
            this.menuCorteCaja.Text = "Corte Caja [F12]";
            this.menuCorteCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuCorteCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuCorteCaja.Click += new System.EventHandler(this.menuCorteCaja_Click);
            // 
            // OperacionesBasicas
            // 
            this.OperacionesBasicas.BackColor = System.Drawing.SystemColors.Highlight;
            this.OperacionesBasicas.Dock = System.Windows.Forms.DockStyle.Left;
            this.OperacionesBasicas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionVenta,
            this.menuCotizacion,
            this.menuPedido,
            this.menuCompra,
            this.menuCorteCaja});
            this.OperacionesBasicas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.OperacionesBasicas.Location = new System.Drawing.Point(0, 0);
            this.OperacionesBasicas.Name = "OperacionesBasicas";
            this.OperacionesBasicas.Size = new System.Drawing.Size(148, 650);
            this.OperacionesBasicas.TabIndex = 3;
            this.OperacionesBasicas.Text = "menuStrip1";
            // 
            // ContenedorPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1261, 650);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.contenedorProcesosBasicos);
            this.Controls.Add(this.menuArchivo);
            this.Controls.Add(this.OperacionesBasicas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.OperacionesBasicas;
            this.MaximizeBox = false;
            this.Name = "ContenedorPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Ventas e Inventario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContenedorPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.ContenedorPrincipal_Load);
            this.menuArchivo.ResumeLayout(false);
            this.menuArchivo.PerformLayout();
            this.contenedorProcesosBasicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.OperacionesBasicas.ResumeLayout(false);
            this.OperacionesBasicas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículosMásVendidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechasDeCaducidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesYPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créditosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblEmpleado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaHora;
        public System.Windows.Forms.Panel contenedorProcesosBasicos;
        public System.Windows.Forms.Timer reloj;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblRol;
        private System.Windows.Forms.ToolStripMenuItem opcionVenta;
        private System.Windows.Forms.ToolStripMenuItem menuCotizacion;
        private System.Windows.Forms.ToolStripMenuItem menuPedido;
        private System.Windows.Forms.ToolStripMenuItem menuCompra;
        private System.Windows.Forms.ToolStripMenuItem menuCorteCaja;
        private System.Windows.Forms.MenuStrip OperacionesBasicas;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mercaderiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        public System.Windows.Forms.PictureBox pbFondo;

    }
}

