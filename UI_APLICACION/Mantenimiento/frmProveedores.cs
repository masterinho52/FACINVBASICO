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

namespace UI_APLICACION.Mantenimiento
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }
        Proveedor miProveedor = new Proveedor();
        ReportDocument reporte = new ReportDocument();
        //**********************************************************
        //evento de carga del formulario
        private void frmProveedores_Load(object sender, EventArgs e)
        {
            this.Size = new Size(696, 551);//tama;o original
            UtMantenimiento.mostrarDatosEnDataGrid(miProveedor.listar(), dgvDatos);
        }
        //******************************************************
        //BOTON DE NUEVO PROVEEDOR
        private void menuNuevo_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1009, 551);//formulario mas grande
            btnRegistrar.Location = new Point(132, 331);
            btnRegistrar.Visible = true;
            botonRegresar.Visible = false;
            crvReporte.Visible = false; dgvDatos.Visible = true;
        }
        //******************************************************
        //BOTON DE ACTUALIZAR PROVEEDOR
        private void menuActualizar_Click(object sender, EventArgs e)
        {
            botonRegresar.Visible = false;
            crvReporte.Visible = false; dgvDatos.Visible = true;
            if (UtMantenimiento.codigo != "")
            {
                this.Size = new Size(1009, 551);//formulario mas grande
                btnActualizar.Location = new Point(132, 331);
                btnActualizar.Visible = true;
                btnRegistrar.Visible = false;
                DataTable seleccionado = new DataTable();
                seleccionado = miProveedor.buscarProveedor(UtMantenimiento.codigo);
                txtNit.Text = seleccionado.Rows[0][0].ToString();
                txtNombre.Text = seleccionado.Rows[0][1].ToString();
                txtTelefono.Text = seleccionado.Rows[0][2].ToString();
                txtCorreo.Text = seleccionado.Rows[0][3].ToString();
                txtdireccion.Text = seleccionado.Rows[0][4].ToString();
                txtSitioWeb.Text = seleccionado.Rows[0][5].ToString();
                chkEstado.Checked = Convert.ToBoolean(seleccionado.Rows[0][6]);
                txtNombre.Focus(); txtNit.Enabled = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar previamente el registro a modificar.");
            }
        }
        //******************************************************
        //BOTON DE ACTUALIZAR PROVEEDOR(PROCESO CON DATOS)
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(696, 551);//tama;o original
            try
            {
                miProveedor.actualiza(txtNit.Text, txtNombre.Text, txtTelefono.Text, txtCorreo.Text, txtdireccion.Text, txtSitioWeb.Text, chkEstado.Checked);
                UtMantenimiento.mostrarDatosEnDataGrid(miProveedor.listar(), dgvDatos);
            }
            catch (Exception ex)
            {
                UtMantenimiento.mostrarMensaje();
                txtNit.Focus();
            }
            
        }
        //******************************************************
        //BOTON DE REGISTRAR PROVEEDOR(PROCESO CON DATOS)
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(696, 551);//tama;o original
            try
            {
                miProveedor.insertar(txtNit.Text,txtNombre.Text,txtTelefono.Text,txtCorreo.Text,txtdireccion.Text,txtSitioWeb.Text,chkEstado.Checked);
                UtMantenimiento.mostrarDatosEnDataGrid(miProveedor.listar(), dgvDatos);
            }
            catch (Exception ex)
            {
                UtMantenimiento.mostrarMensaje();
                txtNit.Focus();
            }
        }
        //************************************************************
        //EVENTO DE CIERRE DEL FORMULARIO
        private void frmProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            UtMantenimiento.cierreMantenimiento();
        }
        //************************************************************
        //EVENTO DE SELECCION DEL CODIGO
        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UtMantenimiento.codigo = dgvDatos.CurrentRow.Cells[0].Value.ToString();
        }
        //************************************************************
        //BOTON DE IMPRIMIR
        private void menuImprimir_Click(object sender, EventArgs e)
        {
            botonRegresar.Visible = true;
            dgvDatos.Visible = false;
            crvReporte.Visible = true;
            reporte.Load(@"C:\Users\david\Documents\Visual Studio 2010\Projects\CONTROL_VENTAS_MANEJO_INVENTARIO\UI_APLICACION\imprimirAdmon\crProveedor.rpt");
            crvReporte.ReportSource = reporte;
        }
        //****************************************************************
        //BOTON DE REGRESAR
        private void botonRegresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dgvDatos.Visible = true;
            crvReporte.Visible = false;
        }
        //**************************************************************
        //BOTON DE CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(696, 551);
        }
    }
}
