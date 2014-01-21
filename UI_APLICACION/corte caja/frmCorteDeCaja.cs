using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LOGICA_NEGOCIO;
using System.Transactions;
using CrystalDecisions.CrystalReports.Engine;

namespace UI_APLICACION
{
    public partial class frmCorteDeCaja : Form
    {
        public frmCorteDeCaja()
        {
            InitializeComponent();
        }
        //******************************************************************************
        //OBJETOS
        SerieDocumento serie = new SerieDocumento();//objeto de tipo serie de documento
        Utilidades miUtilidad=new Utilidades();
        EncabezadoProcesoSalida encabezado = new EncabezadoProcesoSalida();
        CuerpoProceso detalles = new CuerpoProceso();//objeto de detalles de los procesos
        corte_caja.Corte utilidadCorte = new corte_caja.Corte();
        //*******************************************************************************
        //EVENTO DE CARGA DEL FORMULARIO
        private void frmCorteDeCaja_Load(object sender, EventArgs e)
        {
            txtSerie.Text = serie.nombreSerieDocumento(1); 
            int idSerie = serie.IdSerieDocumento(1);
            txtNoDocumento.Text = (encabezado.ultimoDocumentoSerieProcesado(idSerie) + 1).ToString();
            datosEstandarCliente();
            btnAgregar.Enabled = false; btnRetirar.Enabled = false;
            dgvVentas.DataSource = encabezado.listaCorte(false, DateTime.Now.Date);
            txtTotal.Text = utilidadCorte.hallarElTotal(dgvVentas, 3).ToString();//halla el total y lo muestra
        }
        //******************************************************************************
        //CORTE PARCIAL
        private void optCorteParcial_CheckedChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;//habilita boton para agregar datos
            btnRetirar.Enabled = true;//habilita boton para retirar productos agregados            
        }
        //******************************************************************************
        //CORTE TOTAL
        private void optCorteTotal_CheckedChanged(object sender, EventArgs e)
        {
            dgvVentas.DataSource=encabezado.listaCorte(false, DateTime.Now.Date);
        }
        //******************************************************************************
        //BOTON PARA AGREGAR DOCUMENTOS EN UN CORTE PARCIAL
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();//borra el total
            corte_caja.Corte.totalCorte = 0;//reinicia el total
            corte_caja.frmVentasDia ventasDia = new corte_caja.frmVentasDia();//carga el formulario en donde se seleccionaran los documentos a agregar
            ventasDia.ShowDialog();//muestra el formulario
        }
        //******************************************************************************
        //BOTON PARA RETIRAR DOCUMENTOS EN UN CORTE PARCIAL
        private void btnRetirar_Click(object sender, EventArgs e)
        {
            eliminarRegistro(corte_caja.Corte.codigoDocumento);//ejecuta el metodo para eliminar registro
        }
        //******************************************************************************
        //CHEK PARA INSERTAR DATOS NO PREDETERMINADOS
        private void chkDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDatos.Checked == true)
            {
                txtNit.Enabled = true; txtNit.Clear(); txtNit.Focus();
                txtNombre.Enabled = true; txtNombre.Clear();
                txtApellido.Enabled = true;txtApellido.Clear();
                txtDireccion.Enabled = true; txtDireccion.Clear();
            }
            else
            {
                txtNit.Enabled = false; txtNombre.Enabled = false; 
                txtApellido.Enabled = false;txtDireccion.Enabled = false;
                datosEstandarCliente();//carga los datos estandar del cliente
                btnRegistrar.Focus();//estable el foco en el boton de registrar
            }
        }
        //******************************************************************************
        //BOTON PARA CANCELAR EL CORTE DE CAJA
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            corte_caja.Corte.facturaAgregada.Clear();//borra los datos
            this.Close();//cierra el formulario
        }
        //******************************************************************************
        //evento que se dispara al hacer clic sobre un registro de la lista
        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            corte_caja.Corte.codigoDocumento = dgvVentas.CurrentRow.Cells[0].Value.ToString();//se almacena el codigo almacenado
        }
        //******************************************************************************
        //BOTON REGISTRAR
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                btnAgregar.Enabled = false; btnCancelar.Enabled = false; btnRetirar.Enabled = false;
                optCorteParcial.Enabled = false; optCorteTotal.Enabled = false;
                cargaFormatoDetalles();//ejecuta el metodo local que carga el formato del datatable
                int idSerie = serie.IdSerieDocumento(1);//busca la id actual de las facturas
                corte_caja.Corte.numeroDoc = miUtilidad.ultimoId("encabezado") + 1;//encuentra el numero de documento
                encabezado.insertar(corte_caja.Corte.numeroDoc, 1, 2, txtNit.Text, DateTime.Now.Date, Convert.ToDecimal(txtTotal.Text), true, Convert.ToInt32(txtNoDocumento.Text), true, idSerie);
                actualizarEstados();//actualiza el estado de cada documento agregado al corte de caja
                //se recorre el data grid y va agregando los detalles de cada documento agregado
                for (int i = 0; i < dgvVentas.Rows.Count; i++)
                {
                    int idEncabezado = Convert.ToInt32(dgvVentas.Rows[i].Cells[0].Value);//captura el encabezado del id del documento
                    DataTable detallesEncabezado = new DataTable();//tabla temporal
                    detallesEncabezado = detalles.detallesVenta(idEncabezado);//busca los detalles de cada encabezado
                    for (int j = 0; j < detallesEncabezado.Rows.Count; j++)//recorre los detalles y los agrega
                    {
                        corte_caja.Corte.detalles.Rows.Add(new object[]{
                    detallesEncabezado.Rows[j][0].ToString(),
                    detallesEncabezado.Rows[j][1].ToString(),
                    detallesEncabezado.Rows[j][2].ToString(),
                    detallesEncabezado.Rows[j][3].ToString(),
                    });
                    }
                }
                exportar();//ejecuta el metodo de exportar o imprimir
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique datos, existe un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }            
        }
        //#############################################################################
        //METODOS LOCALES
        //metodo que elimina un registro de los productos ya agregados
        private void eliminarRegistro(string codigo)
        {
            for (int i = 0; i <dgvVentas.RowCount; i++)//recorre la lista de productos agregados
            {
                if (dgvVentas.Rows[i].Cells[0].Value.ToString() == codigo)//cuando encuentra el producto a eliminar
                {                    
                    decimal subTotal=Convert.ToDecimal(dgvVentas.Rows[i].Cells[3].Value);
                    corte_caja.Corte.totalCorte = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(dgvVentas.Rows[i].Cells[3].Value);//actualiza el total
                    txtTotal.Text = corte_caja.Corte.totalCorte.ToString();
                    dgvVentas.Rows.RemoveAt(i);//elimina el registro
                    MessageBox.Show("HA RETIRADO EL PRODUCTO: " + codigo + "DE LA LISTA DE COMPRA", "PRODUCTO RETIRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;//cuando encuentra el codigo rompe el ciclo
                }
            }
        }
        //*****************************************************************************
        //metodo que coloca los datos generales del cliente al que se le va a registrar la factura
        private void datosEstandarCliente()
        {
            txtNombre.Text = "Clientes"; txtApellido.Text = "Varios";
            txtNit.Text = "C/F"; txtDireccion.Text = "Ciudad";
        }
        //*****************************************************************************
        //actualiza el estado de cada documento agregado al corte de caja
        private void actualizarEstados()
        {
            for (int i = 0; i < dgvVentas.RowCount; i++)
            {
                int id = Convert.ToInt32(dgvVentas.Rows[i].Cells[0].Value);
                encabezado.actualizaEstadoEncabezado(id, true);//actualiza el estado de cada documento agregado para el corte de caja
            }
        }
        //******************************************************************************
        private void exportar()
        {
            crystalReportViewer1.Visible = true;
            dgvVentas.Visible = false;
            corte_caja.corte dsDoc = new corte_caja.corte();//crea una variable del dataset creado
            for (int i = 0; i < corte_caja.Corte.detalles.Rows.Count; i++)
            {
                dsDoc.Tables[0].Rows.Add(new object[]
                { 
                    corte_caja.Corte.detalles.Rows[i][0].ToString(),
                    corte_caja.Corte.detalles.Rows[i][1].ToString(),
                    corte_caja.Corte.detalles.Rows[i][2].ToString(),
                    corte_caja.Corte.detalles.Rows[i][3].ToString(),
                });
            }
            ReportDocument rDoc = new ReportDocument();
            rDoc.Load(@"C:\Users\david\Documents\Visual Studio 2010\Projects\CONTROL_VENTAS_MANEJO_INVENTARIO\UI_APLICACION\corte caja\crCorte.rpt");
            rDoc.SetDataSource(dsDoc);
            crystalReportViewer1.ReportSource = rDoc;            
        }
        //*******************************************************************
        private void cargaFormatoDetalles()
        {
            corte_caja.Corte.detalles.Columns.Add("PRODUCTO", typeof(string));
            corte_caja.Corte.detalles.Columns.Add("CANTIDAD", typeof(string));
            corte_caja.Corte.detalles.Columns.Add("P. UNIDAD", typeof(string));
            corte_caja.Corte.detalles.Columns.Add("TOTAL", typeof(string));
        }
        //********************************************************************
        //evento de cierre del formulario
        private void frmCorteDeCaja_FormClosing(object sender, FormClosingEventArgs e)
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
