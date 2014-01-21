using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;
using LOGICA_NEGOCIO;

namespace UI_APLICACION.informes
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }
        TipoDocumento documento = new TipoDocumento();//crea un objeto
        Reportes reporte = new Reportes();//crea un objeto de tipo reporte
        //*******************************************************************
        //EVENTO DE CARGA DEL FORMULARIO
        private void frmReportes_Load(object sender, EventArgs e)
        {
            Utilidad.cargarDatos(cbTipoDocumento, documento.listar(), 2, 0);
            if (Utilidad.reporte == "UTILIDADES")
            {
                lblDocumento.Text = "Orden:"; cbTipoDocumento.Visible = false;
                optAscendente.Visible = true;
                optDescendente.Visible = true;
            }
        }
        //*******************************************************
        //BOTON DE BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                crvReporte.Visible = false; dgvDatos.Visible = true;
                if (Utilidad.reporte == "VENTAS")
                {
                    dgvDatos.DataSource = reporte.ventasPorFecha(Convert.ToInt32(cbTipoDocumento.SelectedValue), dtpFechaInicio.Value, dtpFechaFinal.Value);//ejecuta el metodo para cargar las ventas
                }
                else if (Utilidad.reporte == "COMPRAS")
                {
                    dgvDatos.DataSource = reporte.comprasPorFecha(Convert.ToInt32(cbTipoDocumento.SelectedValue), dtpFechaInicio.Value, dtpFechaFinal.Value);//busca las compras
                }
                else if (Utilidad.reporte == "UTILIDADES")
                {
                    if (optAscendente.Checked == true)
                    {
                        dgvDatos.DataSource = reporte.utilidades(dtpFechaInicio.Value.Date, dtpFechaFinal.Value.Date, "asc");
                    }
                    else
                    {
                        dgvDatos.DataSource = reporte.utilidades(dtpFechaInicio.Value.Date, dtpFechaFinal.Value.Date, "desc");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, verique datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //*************************************************************************
        //BOTON DE IMPRIMIR
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utilidad.reporte == "VENTAS")
                {
                    informes.Reporte dsRep = new Reporte();
                    string direccion = @"C:\Users\david\Documents\Visual Studio 2010\Projects\CONTROL_VENTAS_MANEJO_INVENTARIO\UI_APLICACION\informes\Ventas.rpt";
                    exportar(dgvDatos, direccion, dsRep);
                }
                else if (Utilidad.reporte == "COMPRAS")
                {
                    informes.ReporteCompras dsCompras = new informes.ReporteCompras();
                    string direccion = @"C:\Users\david\Documents\Visual Studio 2010\Projects\CONTROL_VENTAS_MANEJO_INVENTARIO\UI_APLICACION\informes\Compras.rpt";
                    exportar(dgvDatos, direccion, dsCompras);
                }
                else if (Utilidad.reporte == "UTILIDADES")
                {
                    informes.Utilidades dsUtilidades = new informes.Utilidades();
                    string direccion = @"C:\Users\david\Documents\Visual Studio 2010\Projects\CONTROL_VENTAS_MANEJO_INVENTARIO\UI_APLICACION\informes\crUtilidades.rpt";
                    imprimirUtilidades(dgvDatos, direccion, dsUtilidades);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, verique datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //*******************************************************
        //metodo local para exportar
        private void exportar(DataGridView tabla,string direccion,DataSet datos)
        {   
            crvReporte.Visible = true;//para que se muestre el reporte
            tabla.Visible = false;//oculta los datos de la tabla
            for (int i = 0; i < tabla.Rows.Count - 1; i++)
            {
                datos.Tables[0].Rows.Add(new object[]{
                    tabla[0,i].Value.ToString(),
                    tabla[1,i].Value.ToString(),
                    tabla[2,i].Value.ToString(),
                    tabla[3,i].Value.ToString(),
                    tabla[4,i].Value.ToString(),
                    tabla[5,i].Value.ToString(),
                });
            }
            ReportDocument rDoc = new ReportDocument();
            rDoc.Load(direccion);
            rDoc.SetDataSource(datos);
            crvReporte.ReportSource = rDoc;
        }
        //*********************************************************
        private void imprimirUtilidades(DataGridView tabla, string direccion, DataSet datos)
        {
            crvReporte.Visible = true;//para que se muestre el reporte
            tabla.Visible = false;//oculta los datos de la tabla
            for (int i = 0; i < tabla.Rows.Count - 1; i++)
            {
                datos.Tables[0].Rows.Add(new object[]{
                    tabla[0,i].Value.ToString(),
                    tabla[1,i].Value.ToString(),
                    tabla[2,i].Value.ToString(),
                    tabla[3,i].Value.ToString(),
                    tabla[4,i].Value.ToString(),
                    tabla[5,i].Value.ToString(),
                    tabla[6,i].Value.ToString(),
                    tabla[7,i].Value.ToString(),
                });
            }
            ReportDocument rDoc = new ReportDocument();
            rDoc.Load(direccion);
            rDoc.SetDataSource(datos);
            crvReporte.ReportSource = rDoc;
        }
       
        
    }
}
