using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace UI_APLICACION.informes
{
    public partial class frmComprobante : Form
    {
        public frmComprobante()
        {
            InitializeComponent();
        }
        ReportDocument repDoc = new ReportDocument();//para el trabajo con los reportes de crystal
        //funcion que ejecuta el crystal reportes al buscar una factura
        public void VerNumeroFactura()
        {
            repDoc.Load(@"C:\Users\david\Documents\Visual Studio 2010\Projects\CONTROL_VENTAS_MANEJO_INVENTARIO\UI_APLICACION\crystal\crFactura.rpt");
            repDoc.SetParameterValue("@@idEncabezado", Utilidad.numeroDocumentoProceso);
            crystalDocumentos.ReportSource = repDoc;            
        }
        private void frmComprobante_Load(object sender, EventArgs e)
        {
            VerNumeroFactura();
        }
    }
}
