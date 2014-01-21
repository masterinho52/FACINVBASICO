using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI_APLICACION.ProcesosElementales
{
    public partial class frmDatosReferencia : Form
    {
        public frmDatosReferencia()
        {
            InitializeComponent();
        }

        //**********************************************************************************
        //evento que se dispara al cargar el formulario
        private void frmDatosReferencia_Load(object sender, EventArgs e)
        {
            dtpFechaPedido.Value = DateTime.Now.Date;//coloca la fecha actual
        }
        //**********************************************************************************
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //**********************************************************************************
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Utilidad.datosReferenciaPedido.Add(dtpFechaPedido.ToString());
            Utilidad.datosReferenciaPedido.Add(dtpFechaPedido.ToString());
            Utilidad.datosReferenciaPedido.Add(txtNombre.Text);
            Utilidad.datosReferenciaPedido.Add(txtApellido.Text);
            Utilidad.datosReferenciaPedido.Add(txtCelular.Text);
            Utilidad.datosReferenciaPedido.Add(txtTelefono.Text);
            Utilidad.referenciaPedido = true;
        }
        //**********************************************************************************
        private void chkNuevaReferencia_CheckedChanged(object sender, EventArgs e)
        {
            btnRegistrar.Text = "&Registrar";
        }

        private void dtpFechaEntrega_ValueChanged(object sender, EventArgs e)
        {
            Utilidad.verificarFecha(dtpFechaEntrega.Value);//valida fecha seleccionada
        }
    }
}
