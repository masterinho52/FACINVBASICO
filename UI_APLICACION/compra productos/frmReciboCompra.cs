using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace UI_APLICACION.compra_productos
{
    public partial class frmReciboCompra : Form
    {
        public frmReciboCompra()
        {
            InitializeComponent();
        }
        ReportDocument repDoc = new ReportDocument();//para el trabajo con los reportes de crystal
        //funcion que ejecuta el crystal reportes al buscar una factura
        public void VerNumeroCompra()
        {
            repDoc.Load(@"C:\Users\david\Documents\Visual Studio 2010\Projects\CONTROL_VENTAS_MANEJO_INVENTARIO\UI_APLICACION\crystal\reciboCompra.rpt");
            repDoc.SetParameterValue("@@idIngreso", Utilidad.numeroDocumentoProceso);
            crvCompras.ReportSource = repDoc;
        }

        private void frmReciboCompra_Load(object sender, EventArgs e)
        {
            VerNumeroCompra();   
        }
    }
}
