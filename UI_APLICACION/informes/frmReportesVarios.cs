using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LOGICA_NEGOCIO;
using CrystalDecisions.CrystalReports.Engine;

namespace UI_APLICACION.informes
{
    public partial class frmReportesVarios : Form
    {

        public frmReportesVarios()
        {
            InitializeComponent();
        }
        Reportes miReporte = new Reportes();//crea un objeto de la clase reportes
        //*****************************************************************
        //BOTON DE BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                crvReporte.Visible = false; dgvDatos.Visible = true;
                if (Utilidad.reporte == "EXISTENCIAS")
                {
                    if (optDescendente.Checked == true)
                    {
                        dgvDatos.DataSource = miReporte.existencias("desc");
                    }
                    else
                    {
                        dgvDatos.DataSource = miReporte.existencias("asc");
                    }
                }
                else if (Utilidad.reporte == "CADUCIDAD")
                {
                    if (optDescendente.Checked == true)
                    {
                        dgvDatos.DataSource = miReporte.productosCaducidad("desc");
                    }
                    else
                    {
                        dgvDatos.DataSource = miReporte.productosCaducidad("asc");
                    }
                }
                else if (Utilidad.reporte == "MASVENDIDOS")
                {
                    if (optDescendente.Checked == true)
                    {
                        dgvDatos.DataSource = miReporte.productoMasVendido(Convert.ToInt32(topN.Value), "desc");
                    }
                    else
                    {
                        dgvDatos.DataSource = miReporte.productoMasVendido(Convert.ToInt32(topN.Value), "asc");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, verique datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //***********************BOTON DE IMPRIMIR*******************************
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utilidad.reporte == "EXISTENCIAS")
                {
                    string direccion = @"C:\Users\david\Documents\Visual Studio 2010\Projects\CONTROL_VENTAS_MANEJO_INVENTARIO\UI_APLICACION\informes\ReporteExistencias.rpt";
                    imprimirExistencias(dgvDatos, direccion);
                }
                else if (Utilidad.reporte == "CADUCIDAD")
                {
                    string direccion = @"C:\Users\david\Documents\Visual Studio 2010\Projects\CONTROL_VENTAS_MANEJO_INVENTARIO\UI_APLICACION\informes\FechaVencimiento.rpt";
                    imprimirCaducidad(dgvDatos, direccion);
                }
                else if (Utilidad.reporte == "MASVENDIDOS")
                {
                    string direccion = @"C:\Users\david\Documents\Visual Studio 2010\Projects\CONTROL_VENTAS_MANEJO_INVENTARIO\UI_APLICACION\informes\crMasVendido.rpt";
                    imprimirProductoMasVendido(dgvDatos, direccion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, verique datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //*****metodo local para imprimir las existencias*****************
        private void imprimirExistencias(DataGridView tabla,string direccion)
        {
            dgvDatos.Visible = false; crvReporte.Visible=true;//habilita y deschabilita elementos
            informes.Existencias dsExistencia = new informes.Existencias();//crea un objeto del data set
            for (int i = 0; i < tabla.Rows.Count - 1; i++)
            {
                dsExistencia.Tables[0].Rows.Add
                    (
                        new object[]
                        {
                            tabla[0,i].Value.ToString(),
                            tabla[1,i].Value.ToString(),
                            tabla[2,i].Value.ToString(),
                            tabla[3,i].Value.ToString(),
                            tabla[4,i].Value.ToString(),
                        }

                    );
            }
            ReportDocument rDoc=new ReportDocument();
            rDoc.Load(direccion);
            rDoc.SetDataSource(dsExistencia);
            crvReporte.ReportSource = rDoc;
        }
        //*****metodo local para imprimir los productos más vendidos*****************
        private void imprimirProductoMasVendido(DataGridView tabla,string direccion)
        {
            dgvDatos.Visible = false; crvReporte.Visible = true;//habilita y deschabilita elementos
            informes.ProductoMasVendido dsmasVendido = new informes.ProductoMasVendido();//crea un objeto del data set
            for (int i = 0; i < tabla.Rows.Count - 1; i++)
            {
                dsmasVendido.Tables[0].Rows.Add
                    (
                        new object[]
                        {
                            tabla[0,i].Value.ToString(),
                            tabla[1,i].Value.ToString(),
                            tabla[2,i].Value.ToString(),
                            tabla[3,i].Value.ToString(),                           
                        }
                    );
            }
            ReportDocument rDoc = new ReportDocument();
            rDoc.Load(direccion);
            rDoc.SetDataSource(dsmasVendido);
            crvReporte.ReportSource = rDoc;
        }
        //*****metodo local para la fecha de caducidad de los productos*****************
        private void imprimirCaducidad(DataGridView tabla, string direccion)
        {
            dgvDatos.Visible = false; crvReporte.Visible = true;//habilita y deschabilita elementos
            informes.Caducidad dsFven = new informes.Caducidad();//crea un objeto del data set
            for (int i = 0; i < tabla.Rows.Count - 1; i++)
            {
                dsFven.Tables[0].Rows.Add
                    (
                        new object[]
                        {
                            tabla[0,i].Value.ToString(),
                            tabla[1,i].Value.ToString(),
                            tabla[2,i].Value.ToString(),
                            tabla[3,i].Value.ToString(),
                            tabla[4,i].Value.ToString(),
                            tabla[5,i].Value.ToString(),
                            tabla[6,i].Value.ToString(),
                            tabla[7,i].Value.ToString(),
                            tabla[8,i].Value.ToString(),
                            tabla[9,i].Value.ToString(),
                            tabla[10,i].Value.ToString(),                                                      
                        }
                    );
            }
            ReportDocument rDoc = new ReportDocument();
            rDoc.Load(direccion);
            rDoc.SetDataSource(dsFven);
            crvReporte.ReportSource = rDoc;
        }

        private void frmReportesVarios_Load(object sender, EventArgs e)
        {
            if (Utilidad.reporte == "MASVENDIDOS")
            {
                lblTpp.Visible = true; topN.Visible = true;//opciones que solo se utilizan con este reporte
            }
            
        }

       



        
    }
}
