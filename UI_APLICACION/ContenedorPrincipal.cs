using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LOGICA_NEGOCIO;
namespace UI_APLICACION
{
    public partial class ContenedorPrincipal : Form
    {
        public ContenedorPrincipal()
        {
            InitializeComponent();
        }
        SerieDocumento serie = new SerieDocumento();
        EncabezadoProcesoSalida encabezado = new EncabezadoProcesoSalida();
        #region OperacionesElementales
        //************************************************************************************************
        //BOTON PARA UNA NUEVA VENTA
        private void fdsfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidad.eliminarControlesPanel(contenedorProcesosBasicos);pbFondo.Visible = true; 
            contenedorProcesosBasicos.Visible = true;Utilidad.tipoProceso = "VENTA";
            ProcesosElementales.frmVenta venta = new ProcesosElementales.frmVenta();
            venta.TopLevel = false; venta.FormBorderStyle = FormBorderStyle.Fixed3D; venta.Dock = DockStyle.Fill;
            venta.lblTipoProceso.Text = "Generando una nueva venta."; venta.lblTipoProceso.Visible = true;
            venta.txtSerie.Text = serie.nombreSerieDocumento(1);int idSerie = serie.IdSerieDocumento(1);
            venta.txtNoDocumento.Text = (encabezado.ultimoDocumentoSerieProcesado(idSerie)+1).ToString();
            this.contenedorProcesosBasicos.Controls.Add(venta);
            this.contenedorProcesosBasicos.Tag = venta;
            venta.Show();
        }
        //************************************************************************************************
        //BOTON DE UNA NUEVA COTIZAICON
        private void fdsfToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Utilidad.eliminarControlesPanel(contenedorProcesosBasicos);pbFondo.Visible = false; 
            contenedorProcesosBasicos.Visible = true;Utilidad.tipoProceso = "COTIZACION";
            ProcesosElementales.frmVenta cotizacion = new ProcesosElementales.frmVenta();
            cotizacion.TopLevel = false; cotizacion.FormBorderStyle = FormBorderStyle.None; cotizacion.Dock = DockStyle.Fill;
            cotizacion.lblTipoProceso.Text = "Generando una nueva cotización."; cotizacion.lblTipoProceso.Visible = true;
            cotizacion.txtSerie.Text = serie.nombreSerieDocumento(3); int idSerie = serie.IdSerieDocumento(3);
            cotizacion.chkDetallesPago.Visible = false; cotizacion.chkPedidoRegistrado.Visible = false;
            cotizacion.txtNoDocumento.Text = (encabezado.ultimoDocumentoSerieProcesado(idSerie) + 1).ToString();
            this.contenedorProcesosBasicos.Controls.Add(cotizacion);
            this.contenedorProcesosBasicos.Tag = cotizacion;
            cotizacion.Show();           
        }
        //************************************************************************************************
        //BOTON DE UN NUEVO PEDIDO
        private void menuPedido_Click(object sender, EventArgs e)
        {
            Utilidad.eliminarControlesPanel(contenedorProcesosBasicos);//pbFondo.Visible = false; 
            contenedorProcesosBasicos.Visible = true; Utilidad.tipoProceso = "PEDIDO";
            ProcesosElementales.frmVenta pedido = new ProcesosElementales.frmVenta();
            pedido.TopLevel = false; pedido.FormBorderStyle = FormBorderStyle.None; pedido.Dock = DockStyle.Fill;
            pedido.lblTipoProceso.Text = "Generando un nuevo pedido"; pedido.lblTipoProceso.Visible = true;
            pedido.txtSerie.Text = serie.nombreSerieDocumento(2); int idSerie = serie.IdSerieDocumento(2);
            pedido.chkDetallesPago.Visible = false; pedido.chkPedidoRegistrado.Visible = true;
            pedido.txtNoDocumento.Text = (encabezado.ultimoDocumentoSerieProcesado(idSerie) + 1).ToString();
            this.contenedorProcesosBasicos.Controls.Add(pedido);
            this.contenedorProcesosBasicos.Tag = pedido;
            pedido.Show();            
        }
        //************************************************************************************************
        //evento que se dispara al cargar el formulario
        private void ContenedorPrincipal_Load(object sender, EventArgs e)
        {
            string nombre=Utilidad.datosIngreso.Rows[0][1].ToString();//almacena el nombre del usuario logueado
            string apellido=Utilidad.datosIngreso.Rows[0][2].ToString();//y su apellido
            lblEmpleado.Text = nombre +" "+ apellido;//asigna a la etiqueta el nombre completo del usuario logueado
            lblUsuario.Text = Utilidad.datosIngreso.Rows[0][3].ToString();//el usuario
            lblRol.Text = Utilidad.datosIngreso.Rows[0][5].ToString();//el rol que desempña
            lblFechaHora.Text = DateTime.Now.ToShortDateString();//la fecha
            verificarUsuario(Utilidad.datosIngreso.Rows[0][5].ToString());
            pbFondo.Visible = true;
            contenedorProcesosBasicos.Visible = true;
        }
        //************************************************************************************************
        //CORTE DE CAJA
        private void menuCorteCaja_Click(object sender, EventArgs e)
        {
            Utilidad.eliminarControlesPanel(contenedorProcesosBasicos);
            contenedorProcesosBasicos.Visible = true; Utilidad.tipoProceso = "CORTE DE CAJA";
            frmCorteDeCaja corteDeCaja = new frmCorteDeCaja();
            corteDeCaja.TopLevel = false; corteDeCaja.FormBorderStyle = FormBorderStyle.Fixed3D; corteDeCaja.Dock = DockStyle.None;
            this.contenedorProcesosBasicos.Controls.Add(corteDeCaja);
            this.contenedorProcesosBasicos.Tag = corteDeCaja;
            corteDeCaja.Show();
        }

        private void administraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAdministracion admin = new frmAdministracion();
            //admin.Show();
        }
        //***********************************************************************************************
        private void menuCompra_Click(object sender, EventArgs e)
        {
            Utilidad.eliminarControlesPanel(contenedorProcesosBasicos);//pbFondo.Visible = false; 
            contenedorProcesosBasicos.Visible = true; Utilidad.tipoProceso = "COMPRA";
            compra_productos.frmCompra compra = new compra_productos.frmCompra();
            compra.TopLevel = false; compra.FormBorderStyle = FormBorderStyle.Fixed3D; compra.Dock = DockStyle.Fill;
            compra.lblTipoProceso.Text = "Adquiriendo productos para el inventario."; compra.lblTipoProceso.Visible = true;
            compra.txtSerie.Text = serie.nombreSerieDocumento(2); int idSerie = serie.IdSerieDocumento(2);
            compra.txtNoDocumento.Text = (encabezado.ultimoDocumentoSerieProcesado(idSerie) + 1).ToString();
            this.contenedorProcesosBasicos.Controls.Add(compra);
            this.contenedorProcesosBasicos.Tag = compra;
            compra.Show();
        }
        //**********sub menu ventas por fecha-************************************
        private void ventasPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidad.reporte = "VENTAS";
            informes.frmReportes reporteFechas = new informes.frmReportes();
            reporteFechas.Text = "Ventas por fechas";
            reporteFechas.ShowDialog();
        }
        //**********sub menu ventas por fecha-************************************
        private void comprasPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidad.reporte = "COMPRAS";
            informes.frmReportes reporteFechas = new informes.frmReportes();
            reporteFechas.Text = "Compras por fechas";
            reporteFechas.ShowDialog();
        }
        //**********************************************************************
        //evento para cerrar la aplicacion
        private void ContenedorPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }    
        
        #endregion
        #region SUBMENUS_MENUS
        //*************************************************************
        //submenu de administracion
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento.frmProveedores proveedor=new Mantenimiento.frmProveedores();
            mostrarFormulario(proveedor);            
        }
        //submenu de administración
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento.frmCliente cliente = new Mantenimiento.frmCliente();
            mostrarFormulario(cliente);
        }
        //sub menu de cambio de usuario
        private void cambioDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProcesosElementales.frmInicioSesion sesion = new ProcesosElementales.frmInicioSesion();
            sesion.ShowDialog();
        }
        //creditos
        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayuda.frmCreditos creditos = new ayuda.frmCreditos();
            creditos.ShowDialog();
        }
        //ayuda
        private void verAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayuda.frmAyuda ayuda = new ayuda.frmAyuda();
            ayuda.ShowDialog();
        }
        #endregion
        #region REPORTES
        //**************************************************************************
        //REPORTE DE UTILIDADES
        private void utilidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidad.reporte = "UTILIDADES";
            informes.frmReportes reporte = new informes.frmReportes();
            reporte.Text = "Existencias de productos.";
            reporte.ShowDialog();
        }
        //************sub menu reporte de los productos mas vendidos**************
        private void artículosMásVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidad.reporte = "MASVENDIDOS";
            informes.frmReportesVarios reporte = new informes.frmReportesVarios();
            reporte.Text = "N Productos más vendidos";
            reporte.ShowDialog();
        }
        //************sub menu reporte de existencias*************************
        private void existenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidad.reporte = "EXISTENCIAS";
            informes.frmReportesVarios reporte = new informes.frmReportesVarios();
            reporte.Text = "Existencias de productos.";
            reporte.ShowDialog();
        }
        //***********sub menu de fechas de caducidad***************************
        private void fechasDeCaducidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidad.reporte = "CADUCIDAD";
            informes.frmReportesVarios reporte = new informes.frmReportesVarios();
            reporte.Text = "Fecha de vencimiento de productos.";
            reporte.ShowDialog();
        }
        #endregion
        #region METODOS LOCALES
        //metodo que permite mostrar un formulario dentro del contenedor
        private void mostrarFormulario(Form formulario)
        {
            Utilidad.eliminarControlesPanel(contenedorProcesosBasicos);//pbFondo.Visible = false; 
            formulario.TopLevel = false; formulario.FormBorderStyle = FormBorderStyle.Fixed3D; formulario.Dock = DockStyle.None;
            this.contenedorProcesosBasicos.Controls.Add(formulario);
            this.contenedorProcesosBasicos.Tag = formulario;
            formulario.Show();
        }
        //************************************************************************************************
        private void verificarUsuario(string tipo)
        {
            if (tipo.ToUpper() == "VENDEDOR")
            {
                menuCorteCaja.Enabled = true;
                opcionVenta.Enabled = true;
                menuCotizacion.Enabled = true;
                menuPedido.Enabled = true;
            }
            else if (tipo.ToUpper() == "SUPERVISOR")
            {
                menuCompra.Enabled = true;
                comprasPorFechasToolStripMenuItem.Enabled = true;
                ventasPorFechasToolStripMenuItem.Enabled = true;
                menuCorteCaja.Enabled = true;
                opcionVenta.Enabled = true;
                menuCotizacion.Enabled = true;
                menuPedido.Enabled = true;

            }
            else if (tipo.ToUpper() == "ADMINISTRADOR")
            {
                menuCompra.Enabled = true;
                comprasPorFechasToolStripMenuItem.Enabled = true;
                ventasPorFechasToolStripMenuItem.Enabled = true;
                menuCorteCaja.Enabled = true;
                opcionVenta.Enabled = true;
                empleadosToolStripMenuItem.Enabled = true;
                mercaderiaToolStripMenuItem.Enabled = true;
                clientesToolStripMenuItem.Enabled = true;
                proveedoresToolStripMenuItem.Enabled = true;
                documentosToolStripMenuItem.Enabled = true;
                ventasToolStripMenuItem.Enabled = true;
                comprasPorFechasToolStripMenuItem.Enabled = true;
                rolesToolStripMenuItem.Enabled = true;
                comprasPorFechasToolStripMenuItem.Enabled = true;
                comprasToolStripMenuItem.Enabled = true;
                menuCotizacion.Enabled = true;
                menuPedido.Enabled = true;
            }

        }
        #endregion
    }
}
