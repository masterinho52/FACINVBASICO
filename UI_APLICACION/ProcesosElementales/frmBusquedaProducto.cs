using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using LOGICA_NEGOCIO;//accede a toda la programacion de la logica del negocio

namespace UI_APLICACION.ProcesosElementales
{
    public partial class frmBusquedaProducto : Form
    {
        public frmBusquedaProducto()
        {
            InitializeComponent();
        }
        Producto producto = new Producto();//instancia la clase producto

        //**************************************************************************************************
        //**busqueda segun especificaciones que se vayan ingresando
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            dgvSugerencias.DataSource = Utilidad.busquedaProducto(txtBusqueda.Text);//ejecuta el metodo que realiza la busqueda
            FormatoDataGridDetallesProductoEncontrado();
        }
        //**************************************************************************************************
        //para verificar otras caracteristicas del producto que se desee elegir
        private void dgvSugerencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCantidad.Focus();
                Utilidad.codigo = dgvSugerencias.CurrentRow.Cells[0].Value.ToString();//captura el codigo del registro seleccionado
                string fecha = dgvSugerencias.CurrentRow.Cells[5].Value.ToString();
                mostrarUbicacionProducto(producto.ubicacionProducto(Utilidad.codigo, Convert.ToDateTime(fecha)));//ejecuta el metodo local para mostrar la ubicacion del producto
                mostrarDetallesProducto(producto.detallesEspecificosProducto(Utilidad.codigo));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha existido un error, verifique datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //**************************************************************************************************
        //metodo local para mostrar la ubicacion del producto
        private void mostrarUbicacionProducto(DataTable ubicacion)
        {
            txtBodega.Text = ubicacion.Rows[0][0].ToString();
            txtCuarto.Text = ubicacion.Rows[0][1].ToString();
            txtEstanteria.Text = ubicacion.Rows[0][2].ToString();
            txtFila.Text = ubicacion.Rows[0][3].ToString();
            txtColumna.Text = ubicacion.Rows[0][4].ToString();
        }
        //**************************************************************************************************
        //metodo que muestra los detalles del producto
        private void mostrarDetallesProducto(DataTable detalles)
        {
            txtCodigo.Text=detalles.Rows[0][6].ToString();
            txtNombre.Text = detalles.Rows[0][0].ToString();
            txtPrecioUnidad.Text = detalles.Rows[0][1].ToString();
            txtPrecioMayor.Text = detalles.Rows[0][2].ToString();
            txtExistencias.Text = detalles.Rows[0][3].ToString();
            txtDescripcion.Text = detalles.Rows[0][4].ToString();
            txtDescuento.Text = detalles.Rows[0][5].ToString();            
        }
        //**************************************************************************************************
        //boton que agrega a compras
        private void btnAgregarACompra_Click(object sender, EventArgs e)
        {
            try
            {
                //si la cantidad a ingresar es menor a las existencias
                if ((Convert.ToInt32(txtCantidad.Text) <= (Convert.ToInt32(txtExistencias.Text))) && (Convert.ToInt32(txtCantidad.Text) > 0))
                {
                    if (Utilidad.validarDatos("INT", txtCantidad.Text) != "")
                    {
                        if (Convert.ToInt32(txtCantidad.Text) < (Convert.ToInt32(txtDescuento.Text)))//la cantidad agregada no cumple para tomar Precio por Mayor
                        {
                            agregarProducto(txtPrecioUnidad);
                        }
                        else//si cumple la cnatidad para tomar el precio como mayorista
                        {
                            agregarProducto(txtPrecioMayor);
                        }
                        DialogResult dialogo = MessageBox.Show("Producto agregado.\n ¿Desea agregar más productos?", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogo == DialogResult.Yes)
                        {
                            txtBusqueda.Focus(); txtBusqueda.Clear();
                            txtCantidad.Clear();
                            txtBodega.Clear(); txtCuarto.Clear(); txtEstanteria.Clear(); txtFila.Clear(); txtColumna.Clear();
                            txtNombre.Clear(); txtCodigo.Clear(); txtPrecioMayor.Clear(); txtPrecioUnidad.Clear(); txtDescripcion.Clear(); txtDescuento.Clear(); txtExistencias.Clear();
                        }
                        else
                        { this.Close(); }
                    }
                    else
                    {
                        MessageBox.Show("Verifique la cantidad a agregar.", "Formato no Reconocido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("No esta en existencia la cantidad del producto que necesita.\nVerifique existencia o stock de productos", "Existencias insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCantidad.Focus();//establece el foco en las existencias
                    txtCantidad.Clear();//borra la cantidad previa establecida
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique datos, ha ocurrido un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
        //**************************************************************************************************
        //evento al cargar el formulario
        private void frmBusquedaProducto_Load(object sender, EventArgs e)
        {
            txtBusqueda.Focus();//establece el foco en la busqueda
            //se crea la estructura de la tabla que almacenara los detalles del producto que se deseee agregar
            Utilidad.productosAgregados.Columns.Add("CODIGO", typeof(string));
            Utilidad.productosAgregados.Columns.Add("NOMBRE", typeof(string));
            Utilidad.productosAgregados.Columns.Add("DESCRIPCION", typeof(string));
            Utilidad.productosAgregados.Columns.Add("P. UNIDAD", typeof(string));
            Utilidad.productosAgregados.Columns.Add("CANTIDAD", typeof(string));
            Utilidad.productosAgregados.Columns.Add("SUB TOTAL", typeof(string));
        }
        //**************************************************************************************************
        //metodo local que agrega productos
        private void agregarProducto(TextBox txtPrecioUnidad)
        {
            frmVenta venta = new frmVenta();
            
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "frmVenta")
                {
                    venta = (frmVenta)frm;
                    DataRow fila = Utilidad.productosAgregados.NewRow();//crea una nueva fila para agregar un nuevo producto
                           
                     //en esta parte se verifica que el formulario este abierto
                    int retorno = Utilidad.verificaDatosIgualesEnDataGrid(Utilidad.productosAgregados, 0, 4, txtCodigo.Text);
                    if (retorno != 0)
                    {
                        fila[0] = txtCodigo.Text;
                        fila[1] = txtNombre.Text;
                        fila[2] = txtDescripcion.Text;
                        fila[3] = txtPrecioUnidad.Text;
                        decimal nuevoValor = Convert.ToInt32(txtCantidad.Text) + retorno;
                        fila[4] = Convert.ToInt32(txtCantidad.Text) + retorno;
                        Utilidad.actualizarDatosEnDataGrid(Utilidad.productosAgregados, 0, 4, txtCodigo.Text, Convert.ToString(nuevoValor));
                        decimal devuelto = Utilidad.actualizarTotal(venta.dgvProductosAgregados);
                        venta.lblPagar.Text = Utilidad.actualizarTotal(venta.dgvProductosAgregados).ToString();
                        break;
                    }
                    else
                    {
                        fila[0] = txtCodigo.Text; 
                        fila[1] = txtNombre.Text;
                        fila[2] = txtDescripcion.Text;
                        fila[3] = txtPrecioUnidad.Text; 
                        fila[4] = txtCantidad.Text;
                        fila[5] = Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecioUnidad.Text); 
                    }                   
                    Utilidad.productosAgregados.Rows.Add(fila);
                    
                    venta.dgvProductosAgregados.DataSource = Utilidad.productosAgregados;//carga en el DataGrid el producto seleccionado
                    Utilidad.totalPagar = Utilidad.hallarElTotal(Utilidad.productosAgregados, 5);
                    venta.lblPagar.Text = Utilidad.totalPagar.ToString();//muestra el total a pagar
                    venta.chkProductosAgregados.Checked = true;
                    
                    venta.FormatoDataGridDetallesProductoEncontrado();//coloca el formato
                    //this.Close();
                    break;
                }
            } 
        }
        //**************************************************************************************************

        //**************************************************************************************************
        //metodo local que define el formato del dataGrid especificamente la alineacion y el ancho de cada columna
        private void FormatoDataGridDetallesProductoEncontrado()
        {
            this.dgvSugerencias.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvSugerencias.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvSugerencias.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvSugerencias.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvSugerencias.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvSugerencias.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvSugerencias.Columns[0].Width = 100;
            this.dgvSugerencias.Columns[1].Width = 200;
            this.dgvSugerencias.Columns[2].Width = 170;
            this.dgvSugerencias.Columns[3].Width = 170;
            this.dgvSugerencias.Columns[4].Width = 200;
            this.dgvSugerencias.Columns[5].Width = 150;
        }
        //****************************************************************************************************
        //chek que permite al vendedor agregarle descripcion o no al producto a agregar
        private void chkAgregarDescripción_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAgregarDescripción.Checked == true)
            {
                txtDescripcion.Enabled = true;
                txtDescripcion.Focus();
            }
            else
            {
                txtDescripcion.Enabled = false;
                txtCantidad.Focus();
            }            
        }

        
    }
}
