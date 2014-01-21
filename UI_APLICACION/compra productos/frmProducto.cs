using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI_APLICACION.compra_productos
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        //**********************************************************
        //BOTON PARA AGREGAR PRODUCTOS
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarProducto();                        
        }
        //**********************************************************
        //EVENTO AL CARGAR EL FORMULARIO
        private void frmProducto_Load(object sender, EventArgs e)
        {
            //carga el formato del datatable
            UtilidadCompra.productosCompra.Columns.Add("CODIGO", typeof(string));
            UtilidadCompra.productosCompra.Columns.Add("PRODUCTO",typeof(string));
            UtilidadCompra.productosCompra.Columns.Add("DESCRIPCIÓN", typeof(string));
            UtilidadCompra.productosCompra.Columns.Add("COSTO UNIDAD", typeof(string));
            UtilidadCompra.productosCompra.Columns.Add("CANTIDAD", typeof(string));
            UtilidadCompra.productosCompra.Columns.Add("SUBTOTAL", typeof(string));            
        }
        //######################################################################
        //METODO LOCAL QUE PERMITE AGREGAR PRODUCTOS
        private void agregarProducto()
        {
            frmCompra compra = new frmCompra();

            foreach (Form frm in Application.OpenForms)
            {
                if(frm.Name=="frmCompra")
                {
                    compra=(frmCompra)frm;
                    DataRow fila = UtilidadCompra.productosCompra.NewRow();
                    fila[0] = txtCodigo.Text;
                    fila[1] = txtProducto.Text;
                    fila[2] = txtDescripción.Text;
                    fila[3] = txtCostoUnidad.Text;
                    fila[4] = txtCantidad.Text;
                    fila[5] = (Convert.ToInt32(txtCantidad.Text) * Convert.ToDecimal(txtCostoUnidad.Text)).ToString();
                    UtilidadCompra.productosCompra.Rows.Add(fila);
                    compra.dgvProductosAgregados.DataSource = UtilidadCompra.productosCompra;
                    compra.lblPagar.Text = (UtilidadCompra.totalCompra = UtilidadCompra.totalCompra + Convert.ToDecimal(fila[5])).ToString();
                    compra.chkProductosAgregados.Checked = true; UtilidadCompra.producto = true;
                    compra.FormatoDataGridDetallesProductoEncontrado();
                    DialogResult dialogo = MessageBox.Show("Desea agregar más productos?","Producto agregado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogo == DialogResult.Yes)
                    {
                        txtCodigo.Clear();
                        txtProducto.Clear(); txtCostoUnidad.Clear();
                        txtDescripción.Clear(); txtCantidad.Clear();
                        txtCodigo.Focus();                       
                    }
                    else
                    { this.Close(); }
                }
            }

        }
    }
}
