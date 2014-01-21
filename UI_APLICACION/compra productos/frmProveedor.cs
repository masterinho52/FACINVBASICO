using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LOGICA_NEGOCIO;
namespace UI_APLICACION.compra_productos
{
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }
        Proveedor proveedor = new Proveedor();//crea un objeto del tipo proveedor
        //*********************************************************
        //BOTON PARA REGISTRAR O BUSCAR EL PROVEEDOR
        private void btnAccion_Click(object sender, EventArgs e)
        {
            try
            {
                frmCompra compra = new frmCompra();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "frmCompra")
                    {
                        compra = (frmCompra)frm;
                        if (optNuevo.Checked == true)//si se desea registrar un nuevo proveedor
                        {
                            MessageBox.Show(proveedor.insertar(txtNit.Text, txtProveedor.Text, txtTel.Text, txtCorreo.Text, txtDireccion.Text, txtSitioWeb.Text, true));
                        }
                        else
                        {
                            Buscar(proveedor.buscarProveedor(txtNit.Text));//busca el proveedor
                        }
                        compra.chkProveedorRegistrado.Checked = true;//activa opcion
                        compra.FormatoDataGridDetallesProductoEncontrado();
                        UtilidadCompra.proveedor = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //*********************************************************
        //boton de opcion de registrado
        private void optRegistrado_CheckedChanged(object sender, EventArgs e)
        {
            txtNit.Clear(); txtNit.Enabled = false;
            txtProveedor.Clear(); txtProveedor.Enabled = false;
            txtTel.Clear(); txtTel.Enabled = false;
            txtCorreo.Clear(); txtCorreo.Enabled = false;
            txtSitioWeb.Clear(); txtSitioWeb.Enabled = false;
            txtDireccion.Clear(); txtDireccion.Enabled = false;
            btnAccion.Text = "&BUSCAR"; txtNit.Focus();
        }
        //***********************************************************
        //boton de opcion cuando se desea registrar el nuevo provedor
        private void optNuevo_CheckedChanged(object sender, EventArgs e)
        {            
            txtNit.Clear(); txtNit.Enabled = true;
            txtProveedor.Clear(); txtProveedor.Enabled = true;
            txtTel.Clear(); txtTel.Enabled = true;
            txtCorreo.Clear(); txtCorreo.Enabled = true;
            txtSitioWeb.Clear(); txtSitioWeb.Enabled = true;
            txtDireccion.Clear(); txtDireccion.Enabled = true;
            btnAccion.Text = "&NUEVO"; txtNit.Focus();
        }
        //************************************************************
        //EVENTO AL CARGAR EL FORMULARIO
        private void frmProveedor_Load(object sender, EventArgs e)
        {
            txtNit.Focus(); txtNit.Clear();
        }
         //*****************************************************************
        //evento que se dispara al presionar enter
        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Buscar(proveedor.buscarProveedor(txtNit.Text));
            }
        }
        //***********************************************
       //metodo local que verifica si existe el proveedor 
        private void Buscar(DataTable tabla)
        {
            if (tabla.Rows.Count > 0)
            {
                txtNit.Text = tabla.Rows[0][0].ToString();
                txtProveedor.Text = tabla.Rows[0][1].ToString();
                txtTel.Text = tabla.Rows[0][2].ToString();
                txtCorreo.Text = tabla.Rows[0][3].ToString();
                txtDireccion.Text = tabla.Rows[0][4].ToString();
                txtSitioWeb.Text = tabla.Rows[0][5].ToString();
                btnAccion.Focus();//establece el foco de accion en el boton
                btnAccion.Text = "&BUSCAR";
                UtilidadCompra.nitProveedor = txtNit.Text;
            }
            else
            {
                txtProveedor.Focus();//establece el foco
                btnAccion.Text = "&NUEVO";
                optNuevo.Checked =true;//activa para registrar al proveedor
                MessageBox.Show("Ingrese datos del proveedor para registrarlo","Proveedor no registrado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        
        
    }
}
