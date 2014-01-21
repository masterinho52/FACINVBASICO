using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LOGICA_NEGOCIO;

namespace UI_APLICACION.corte_caja
{
    public partial class frmVentasDia : Form
    {
        public frmVentasDia()
        {
            InitializeComponent();
        }
        EncabezadoProcesoSalida encabezado = new EncabezadoProcesoSalida();
        //*******************************************************************
        //EVENTO DE CARGA DEL FORMULARIO
        private void frmVentasDia_Load(object sender, EventArgs e)
        {
            dgvVentas.DataSource = encabezado.listaCorte(false, DateTime.Now.Date);//ejecuta metodo para cargar las ventas no registradas de la fecha actual
            //crea el formato de la tabla temporal
            Corte.facturaAgregada.Columns.Add("ID",typeof(string));
            Corte.facturaAgregada.Columns.Add("COD. EMPLEADO", typeof(string));
            Corte.facturaAgregada.Columns.Add("FECHA", typeof(string));
            Corte.facturaAgregada.Columns.Add("TOTAL", typeof(string));
        }
        //*******************************************************************
        //BOTON PARA AGREGAR DOCUMENTOS
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCorteDeCaja corteCaja = new frmCorteDeCaja();
            
            foreach(Form frm in Application.OpenForms)
            {
                if(frm.Name=="frmCorteDeCaja")
                {
                    corteCaja = (frmCorteDeCaja)frm;
                     DataRow fila = Corte.facturaAgregada.NewRow();//crea una nueva fila
                     //agrega al nuevo registro los datos de la fila seleccionada
                     string codigo = dgvVentas.CurrentRow.Cells[0].Value.ToString();//id
;                     fila[0] = dgvVentas.CurrentRow.Cells[0].Value.ToString();
                     fila[1] = dgvVentas.CurrentRow.Cells[1].Value.ToString();//cod empleado
                     fila[2]=dgvVentas.CurrentRow.Cells[2].Value.ToString();//fecha
                     fila[3]=dgvVentas.CurrentRow.Cells[3].Value.ToString();//total
                     decimal subTotal = Convert.ToDecimal(dgvVentas.CurrentRow.Cells[3].Value);
                     corte_caja.Corte.totalCorte = corte_caja.Corte.totalCorte + subTotal;
                     Corte.facturaAgregada.Rows.Add(fila);//se agrega la fila a la tabla temporal
                     corteCaja.dgvVentas.DataSource=Corte.facturaAgregada;
                     corteCaja.txtTotal.Text = corte_caja.Corte.totalCorte.ToString();//coloca el total en el textbox
                     DialogResult dialogo = MessageBox.Show("Factura agregada.\n ¿Desea agregar más facturas?", "Documentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                     //dgvVentas.DataSource = encabezado.listaCorte(false, DateTime.Now.Date);//actualiza datagrid 
                     eliminarRegistro(corte_caja.Corte.codigoDocumento);
                    corteCaja.txtTotal.Text=hallarTotal(corteCaja.dgvVentas,3).ToString();
                    if (dialogo == DialogResult.Yes)
                    {
                         
                    }
                    else{this.Close();}
                }
            }
        }
        //******************************************************************************
        //PARA SELECCIONAR EL DOCUMENTO A AGREGAR
        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Corte.codigoDocumento = dgvVentas.CurrentRow.Cells[0].Value.ToString();
        }

        //metodo que elimina un registro de los productos ya agregados
        private void eliminarRegistro(string codigo)
        {
            for (int i = 0; i < dgvVentas.RowCount; i++)//recorre la lista de productos agregados
            {
                if (dgvVentas.Rows[i].Cells[0].Value.ToString() == codigo)//cuando encuentra el producto a eliminar
                {
                    dgvVentas.Rows.RemoveAt(i);//elimina el registro
                    //MessageBox.Show("HA RETIRADO EL PRODUCTO: " + codigo + "DE LA LISTA DE COMPRA", "PRODUCTO RETIRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;//cuando encuentra el codigo rompe el ciclo
                }
            }
        }

        private decimal hallarTotal(DataGridView tabla, int posicion)
        {
            decimal total=0;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(tabla.Rows[i].Cells[posicion].Value);
            }
            return total;
        }
    }
}
