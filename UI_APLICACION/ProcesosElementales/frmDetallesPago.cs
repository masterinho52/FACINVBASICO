using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LOGICA_NEGOCIO;

namespace UI_APLICACION.ProcesosElementales
{
    public partial class frmDetallesPago : Form
    {
        public frmDetallesPago()
        {
            InitializeComponent();
        }
        TipoDePago tipoPago = new TipoDePago();//crea una instancia de la clase de tipo de pago
        //*************************************************************************************************************
        //evento al cargar el formulario, inicializa ciertas caracteristicas
        private void frmDetallesPago_Load(object sender, EventArgs e)
        {
            Utilidad.cargarDatos(cbTipoPago, tipoPago.listar(), 1, 0);//carga los distintos tipos de pago que cubre la empresa
            cbTipoPago.SelectedValue = 1;//predeterminadamene es el efectivo
            cbTipoPago.Enabled = false;//por los requerimientos d ela empresa, se deshabilita el tipo de pago que no sea efectivo
            txtEfectivo.Focus(); txtEfectivo.Enabled = true;
        }
        //*************************************************************************************************************
        private void cbTipoPago_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbTipoPago.Text.ToUpper() == "EFECTIVO")
            {
                txtEfectivo.Enabled = true; txtEfectivo.Focus();
            }
            else if (cbTipoPago.Text.ToUpper() == "CREDITO")
            {
                txtCambio.Enabled = true; txtCambio.Focus();
            }
            else
            {
                txtCambio.Enabled = true; txtEfectivo.Enabled = true;
                txtEfectivo.Focus();                
            }
        }
        //*************************************************************************************************
        //boton para registrar el tipo de pago
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            verificarRegistroPago();   
        }
        //***************************************************************************************************
        //boton para cancelar la opcion
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //***************************************************************************************************
        //el presionar enter luego de haber registrado el efectivo
        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) verificarRegistroPago();//cuando se preiona ENTER se verifica el registro del pago
        }
        //***************************************************************************************************
        //METODO LOCAL PARA REALIZAR EL REGISTRO DEL PAGO
        private void verificarRegistroPago()
        {
            if (Utilidad.validarDatos("DECIMAL", txtEfectivo.Text) != "")
            {
                frmVenta venta = new frmVenta();//se crea un objeto del formulario venta
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "frmVenta")
                    {
                        venta = (frmVenta)frm;
                        if (Convert.ToDecimal(venta.lblPagar.Text) <= (Convert.ToDecimal(txtEfectivo.Text)))
                        {
                            Utilidad.datosPago = true;//bandera que determina que los detalles de pago han sido agregados
                            agregarEtiquetaEnFormulario();
                            decimal cambio = (Convert.ToDecimal(txtEfectivo.Text) - Convert.ToDecimal(venta.lblPagar.Text));
                            MessageBox.Show("SU CAMBIO:" + cambio.ToString(), "CAMBIO", MessageBoxButtons.OK, MessageBoxIcon.Information);//genera el cambio que se le debe de dar al cliente                     
                            //Utilidad.efectivo = Convert.ToDecimal(txtEfectivo.Text)-Convert.ToDecimal(txtCambio.Text);//asigna el valor total
                            this.Close();
                            venta.chkDetallesPago.Checked = true;
                        }
                        else
                        {
                            txtEfectivo.Focus(); MessageBox.Show("El efectivo registrado no es suficiente para cancelar la venta");
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Verifique formato de ingreso", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEfectivo.Focus();
            }
        }
        //************************************************************************************
        private void agregarEtiquetaEnFormulario()
        {
            frmVenta venta = new frmVenta();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "frmVenta")
                {
                    venta = (frmVenta)frm;
                    venta.chkDetallesPago.Checked=true;
                    break;
                }
            }
        }
    }
}
