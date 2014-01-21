using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Transactions;//para el uso de transacciones
using LOGICA_NEGOCIO;//acceso a la logica del negocio

namespace UI_APLICACION.ProcesosElementales
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }
        //***********************************************************************************************
        //OBJETOS A UTILIZZAR
        EncabezadoProcesoSalida encabezado = new EncabezadoProcesoSalida();
        CuerpoProceso detallesProceso = new CuerpoProceso();
        Utilidades miUtilidad = new Utilidades();
        Producto producto = new Producto();
        SerieDocumento miSerie = new SerieDocumento();
        //***********************************************************************************************
        //BOTON PARA AÑADIR PRODUCTO
        private void productoF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcesosElementales.frmBusquedaProducto buscarProducto = new ProcesosElementales.frmBusquedaProducto();//crea el objto form
            buscarProducto.ShowDialog();//y lo muestra
        }
        //***********************************************************************************************
        //BOTON PARA AÑADIR CLIENTE
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            ProcesosElementales.frmRegistroCliente registroCliente = new ProcesosElementales.frmRegistroCliente();
            registroCliente.ShowDialog();
        }
        //***********************************************************************************************
        //BOTON PARA AÑADIR PAGO
        private void btnDetallesPago_Click(object sender, EventArgs e)
        {
            if (dgvProductosAgregados.Rows.Count > 0)//para añadir pago es necesario que se hayan añadido productos
            {
                ProcesosElementales.frmDetallesPago detallesPago = new ProcesosElementales.frmDetallesPago();
                detallesPago.ShowDialog();
            }
            else//de lo contrario muestra mensaje
            {
                MessageBox.Show("DEBE AGREGAR PRODUCTOS", "SIN PRODUCTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //************************************************************************************************
        //BOTON PARA CANCELAR EL PROCESO QUE SE ESTA REALIZANDO
        private void btnCancelarProceso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EL PROCESO HA SIDO CANCELADO", "CANCELADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            terminarProceso();
        }
        //************************************************************************************************
        //BOTON PARA RETIRAR UN PRODUCTO AGREGADO
        private void btnRetirarProductoAgregado_Click(object sender, EventArgs e)
        {
            if (Utilidad.codigo != "")
            {
                eliminarRegistro(Utilidad.codigo);
            }
            else
            {
                MessageBox.Show("Debe seleccionar producto a retirar de la compra");
            }
        }
        //************************************************************************************************
        //PARA SELECCIONAR PRODUCTO
        private void dgvProductosAgregados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Utilidad.codigo = dgvProductosAgregados.CurrentRow.Cells[0].Value.ToString();
        }
        //************************************************************************************************
        //BOTON PARA REGISRAR EL PROCESO
        private void btnRegistar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductosAgregados.Rows.Count > 0)//para registrarlo es necesario que se hayan añadido productos
                {
                    if (Utilidad.tipoProceso.ToUpper() == "VENTA")//si el proceso es una venta
                    {
                        if ((Utilidad.datosCliente == true) && (Utilidad.datosPago == true))
                        {
                            generarProceso(miSerie.IdSerieDocumento(1));//ejecuta el metodo
                        }
                        else//caso contrario muestra mensaje con los posibles errores
                        {
                            MessageBox.Show("Verifique registro de: Datos del cliente \n Tipo de Pago", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else if (Utilidad.tipoProceso.ToUpper() == "PEDIDO")//si es un pedido
                    {
                        if ((Utilidad.datosCliente == true) && (Utilidad.referenciaPedido == true))
                        {
                            generarProceso(miSerie.IdSerieDocumento(2));//ejecuta el metodo
                        }
                        else//caso contrario muestra mensaje con los posibles errores
                        {
                            MessageBox.Show("Verifique registro de: Datos del cliente \n Tipo de Pago \nReferencia de Pedido", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else if (Utilidad.tipoProceso.ToUpper() == "COTIZACION")//si es una cotizacion
                    {
                        if (Utilidad.datosCliente == true)
                        {
                            generarProceso(miSerie.IdSerieDocumento(3));
                        }
                        else
                        {
                            MessageBox.Show("Verifique registro de: Datos del cliente.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
                else//si la tabla de datos no tiene datos agregados
                {
                    MessageBox.Show("Debe de agregar productos para gener documento", "No hay datos.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, verifique datos", "Error en el proceso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //*****************************************************************************************
        //opcion para registrar la referencia del pedido
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProcesosElementales.frmDatosReferencia referencia = new ProcesosElementales.frmDatosReferencia();
            referencia.ShowDialog();
        }
        //##############################################################################################
        //METODOS LOCALES
        //metodo local que define el formato del dataGrid especificamente la alineacion y el ancho de cada columna
        public void FormatoDataGridDetallesProductoEncontrado()
        {
            this.dgvProductosAgregados.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvProductosAgregados.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvProductosAgregados.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvProductosAgregados.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvProductosAgregados.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvProductosAgregados.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvProductosAgregados.Columns[0].Width = 100;
            this.dgvProductosAgregados.Columns[1].Width = 220;
            this.dgvProductosAgregados.Columns[2].Width = 300;
            this.dgvProductosAgregados.Columns[3].Width = 140;
            this.dgvProductosAgregados.Columns[4].Width = 100;
            this.dgvProductosAgregados.Columns[5].Width = 150;
        }
        //***********************************************************************************************
        //metodo util al terminar un proceso o al cancelarlo, principalmente lo que hace es reiniciar todos los valores
        private void terminarProceso()
        {
            Utilidad.productosAgregados.Clear();Utilidad.datoscliente.Clear();
            Utilidad.datosCliente = false; Utilidad.datosPago = false;
            Utilidad.totalPagar = 0;
            chkClienteRegistrado.Checked = false;chkDetallesPago.Checked = false;
            chkPedidoRegistrado.Checked = false;chkProductosAgregados.Checked = false;
            this.Close();//cierra el formulario
        }
        //***********************************************************************************************
        //metodo que elimina un registro de los productos ya agregados
        private void eliminarRegistro(string codigo)
        {
            for (int i = 0; i < dgvProductosAgregados.RowCount; i++)//recorre la lista de productos agregados
            {
                if (dgvProductosAgregados.Rows[i].Cells[0].Value.ToString() == codigo)//cuando encuentra el producto a eliminar
                {
                    dgvProductosAgregados.Rows.RemoveAt(i);//elimina el registro
                    MessageBox.Show("HA RETIRADO EL PRODUCTO: " + codigo + "DE LA LISTA DE COMPRA", "PRODUCTO RETIRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblPagar.Text = actualizarTotal().ToString();//ejecuta el metodo para actualizar el totoal
                    break;//cuando encuentra el codigo rompe el ciclo
                }
            }
        }
        //***********************************************************************************************
        //metodo que actualiza el total
        private decimal actualizarTotal()
        {
            decimal total = 0;
            for (int i = 0; i < dgvProductosAgregados.RowCount; i++)
            {
                decimal subTotal = Convert.ToDecimal(dgvProductosAgregados.Rows[i].Cells[5].Value);
                total = total + subTotal;
            }
            return total;
        }
        //***********************************************************************************************
        //metodo que registra el proceso
        private void generarProceso(int idSerie)
        {
            //using (TransactionScope transaccion = new TransactionScope())
            //{
                try
                {
                    Utilidad.numeroDocumentoProceso = miUtilidad.ultimoId("encabezado") + 1;//encuentra el id del proceso actual
                    string idEmpleado = Utilidad.datosIngreso.Rows[0][6].ToString();//el codigo del empleado que esta registrando el proceso
                    int idCliente = Convert.ToInt32(Utilidad.datoscliente[0]);//el codigo del cliente
                    encabezado.insertar(Utilidad.numeroDocumentoProceso, 1, idCliente, idEmpleado, DateTime.Now.Date, Convert.ToDecimal(lblPagar.Text), Utilidad.tipoConsumidor, Convert.ToInt32(txtNoDocumento.Text),true, idSerie);//inserta el encabezado
                    for (int i = 0; i < dgvProductosAgregados.Rows.Count-1; i++)//recorre la tabla de productos agregados
                    {
                        string codigo = dgvProductosAgregados.Rows[i].Cells[0].Value.ToString();//captura el codigo
                        string nombre = dgvProductosAgregados.Rows[i].Cells[1].Value.ToString();//captura el nombre
                        string descripcion = dgvProductosAgregados.Rows[i].Cells[2].Value.ToString();//captura la descripcion
                        string punidad = dgvProductosAgregados.Rows[i].Cells[3].Value.ToString();//captura el precio unidad
                        string cantidad = dgvProductosAgregados.Rows[i].Cells[4].Value.ToString();//captura la cntidad
                        string subTotal = dgvProductosAgregados.Rows[i].Cells[5].Value.ToString();//captura el subtotal
                        detallesProceso.insertar(codigo, Utilidad.numeroDocumentoProceso, Convert.ToDecimal(punidad), Convert.ToInt32(cantidad), Convert.ToDecimal(subTotal), nombre + descripcion, true);//inserta el detalle
                        if (Utilidad.tipoProceso.ToUpper() == "VENTA")
                        {
                            producto.actualizaStock(codigo, Convert.ToInt32(cantidad));//actualiza el stock
                        }
                    }
                    //transaccion.Complete();//finaliza la transaccion                                
                    MessageBox.Show("TRANSACCIÓN REALIZADA CON ÉXITO!!", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    informes.frmComprobante factura = new informes.frmComprobante();
                    factura.Show();
                    terminarProceso();//ejecuta el metodo para reinicar variables
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            //}
        }

        private void frmVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            ContenedorPrincipal cont = new ContenedorPrincipal();
            foreach(Form frm in Application.OpenForms)
            {
                if(frm.Name=="ContenedorPrincipal")
                {
                    cont = (ContenedorPrincipal)frm;
                    cont.contenedorProcesosBasicos.Visible = true;
                    cont.pbFondo.Visible = true;
                    cont.contenedorProcesosBasicos.Controls.Add(cont.pbFondo);
                }
                
            }
        }

        private void frmVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContenedorPrincipal cont = new ContenedorPrincipal();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "ContenedorPrincipal")
                {
                    cont = (ContenedorPrincipal)frm;
                    cont.contenedorProcesosBasicos.Visible = true;
                    cont.pbFondo.Visible = true;
                }

            }
        }
        

    }
}
