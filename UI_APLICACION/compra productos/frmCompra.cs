using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LOGICA_NEGOCIO;

namespace UI_APLICACION.compra_productos
{
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }
        ProcesoIngreso compra = new ProcesoIngreso();
        DetallesCompraIngreso detallesCompra = new DetallesCompraIngreso();
        Utilidades miUtilidad = new Utilidades();
        SerieDocumento serie = new SerieDocumento();
        //***********************************************************************
        //BOTON PARA AGREGAR PRODUCTO
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmProducto productoCompra = new frmProducto();
            productoCompra.ShowDialog();
            //FormatoDataGridDetallesProductoEncontrado();
        }
        //***********************************************************************
        ////BOTON PARA CANCELAR EL PROCESO
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            terminarProceso();
        }
        //************************************************************************
        //BOTON PARA AGREGAR EL PROVEEDOR
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            compra_productos.frmProveedor proveedor = new compra_productos.frmProveedor();
            proveedor.ShowDialog();
        }
        //***********************************************************************
        //boton para calcular el cambio
        private void btnCambio_Click_1(object sender, EventArgs e)
        {
            lblCambio.Visible = true;
            lblCambio.Text = (Convert.ToDecimal(lblPagar.Text) - Convert.ToDecimal(txtPago.Text)).ToString();
        }
        //*****************************************************************************
        //BOTON PARA RETIRAR PRODUCTOS DE LA LISTA DE COMPRA
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = dgvProductosAgregados.CurrentRow.Cells[0].Value.ToString();//captura el codigo del producto a eliminar
                eliminarRegistro(codigo);//elimina el producto
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione producto a eliminar", "Producto seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        //##########################################################################3
        //metodo local que permite terminar el proceso de compra
        private void terminarProceso()
        {
            UtilidadCompra.productosCompra.Clear(); UtilidadCompra.totalCompra = 0;
            UtilidadCompra.proveedor = false; UtilidadCompra.producto = false;
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
        //********************************************************
        //BOTON PARA REGISTRAR
        private void btnRegistar_Click(object sender, EventArgs e)
        {
            try
            {
                if (UtilidadCompra.proveedor == true)
                {
                    Utilidad.numeroDocumentoProceso = miUtilidad.ultimoId("compra") + 1;
                    string idEmpleado = Utilidad.datosIngreso.Rows[0][6].ToString();//el codigo del empleado que esta registrando el proceso
                    int idSerie = serie.IdSerieDocumento(2);
                    compra.insertar(Utilidad.numeroDocumentoProceso, idEmpleado, UtilidadCompra.nitProveedor, 1, idSerie, Convert.ToDecimal(lblPagar.Text), DateTime.Now.Date, Convert.ToInt32(txtNoDocumento.Text), true);//registra la compra
                    for (int i = 0; i < dgvProductosAgregados.Rows.Count - 1; i++)//recorre todos los productos agregados para la compra
                    {
                        int idDetalle = miUtilidad.ultimoId("detalleCompra") + 1;
                        string codigo = dgvProductosAgregados.Rows[i].Cells[0].Value.ToString();
                        string producto = dgvProductosAgregados.Rows[i].Cells[1].Value.ToString();
                        string descripcion = dgvProductosAgregados.Rows[i].Cells[2].Value.ToString();
                        string costoUnidad = dgvProductosAgregados.Rows[i].Cells[3].Value.ToString();
                        string cantidad = dgvProductosAgregados.Rows[i].Cells[4].Value.ToString();
                        string subtotal = dgvProductosAgregados.Rows[i].Cells[5].Value.ToString();
                        detallesCompra.insertar(idDetalle, Utilidad.numeroDocumentoProceso, producto, Convert.ToDecimal(costoUnidad), Convert.ToInt32(cantidad), Convert.ToDecimal(subtotal), descripcion, true, codigo);
                    }
                    compra_productos.frmReciboCompra reciboCompra = new compra_productos.frmReciboCompra();
                    reciboCompra.ShowDialog();
                    terminarProceso(); this.Close();
                }
                else
                {
                    MessageBox.Show("Falta registrar al proveedor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique datos de registro previos.\n Datos del proveedor o de productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //*******************************************************************
        //evento de cierre del formulario
        private void frmCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            ContenedorPrincipal cont = new ContenedorPrincipal();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "ContenedorPrincipal")
                {
                    cont = (ContenedorPrincipal)frm;
                    cont.contenedorProcesosBasicos.Visible = true;
                    cont.pbFondo.Visible = true;
                    cont.contenedorProcesosBasicos.Controls.Add(cont.pbFondo);
                }
            }
        }

        

        
       
    }
}
