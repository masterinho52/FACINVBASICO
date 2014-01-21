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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        Utilidades miUtilidad = new Utilidades();
        Cliente miCliente = new Cliente();
        ReportDocument reporte = new ReportDocument();
        //********BOTON NUEVO*****************************
        private void menuNuevo_Click(object sender, EventArgs e)
        {
            txtID.Text = (miUtilidad.ultimoId("cliente") + 1).ToString();//ell siguiente id del cliente
            this.Size = new Size(1009, 551);//formulario mas grande
            btnRegistrar.Location = new Point(132, 331);
            btnRegistrar.Visible = true;
            botonRegresar.Visible = false;
            crvReporte.Visible = false; dgvDatos.Visible = true;
        }
        //********************BOTON DE ACTUALIZAR****************
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
                seleccionado = miCliente.buscarCliente(Convert.ToInt32(UtMantenimiento.codigo));
                txtID.Text=seleccionado.Rows[0][0].ToString();
                txtNit.Text = seleccionado.Rows[0][2].ToString();
                txtNombre.Text = seleccionado.Rows[0][3].ToString();
                txtApellido.Text = seleccionado.Rows[0][4].ToString();
                txtdireccion.Text = seleccionado.Rows[0][6].ToString();
                txtTelefono.Text = seleccionado.Rows[0][5].ToString();
                chkEstado.Checked = Convert.ToBoolean(seleccionado.Rows[0][7]);
                txtNit.Focus(); txtNit.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar previamente el registro a modificar.");
            }
        }
        //*******************BOTON DE IMPRIMIR**********************
        private void menuImprimir_Click(object sender, EventArgs e)
        {
            botonRegresar.Visible = true;
            dgvDatos.Visible = false;
            crvReporte.Visible = true;
            reporte.Load(@"C:\Users\david\Documents\Visual Studio 2010\Projects\CONTROL_VENTAS_MANEJO_INVENTARIO\UI_APLICACION\imprimirAdmon\crCliente.rpt");
            crvReporte.ReportSource = reporte;
        }
        //***********CARGA DEL FORMULARIO*********************
        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.Size = new Size(696, 551);//tama;o original
            UtMantenimiento.mostrarDatosEnDataGrid(miCliente.listar(), dgvDatos);
        }
        //***************seleccion del codigo**************
        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UtMantenimiento.codigo = dgvDatos.CurrentRow.Cells[0].Value.ToString();
        }
        //************BOTON DE REGRESAR*******************
        private void botonRegresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dgvDatos.Visible = true;
            crvReporte.Visible = false;
        }
        //**************BOTON DE CANCELAR**********************
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(696, 551);
        }
        //***********REGISTRANDO NUEVO CLIENTE***********
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(696, 551);//tama;o original
            try
            {
                miCliente.insertar(Convert.ToInt32(txtID.Text),1,txtNit.Text,txtNombre.Text,txtApellido.Text,txtTelefono.Text,txtdireccion.Text,chkEstado.Checked);
                UtMantenimiento.mostrarDatosEnDataGrid(miCliente.listar(), dgvDatos);
            }
            catch (Exception ex)
            {
                UtMantenimiento.mostrarMensaje();
                txtNit.Focus();
            }
        }
        //**********actualizando cliente**************
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(696, 551);//tama;o original
            try
            {
                miCliente.actualizar(Convert.ToInt32(txtID.Text),1,txtNit.Text,txtNombre.Text,txtApellido.Text,txtTelefono.Text,txtdireccion.Text,chkEstado.Checked);
                UtMantenimiento.mostrarDatosEnDataGrid(miCliente.listar(), dgvDatos);
            }
            catch (Exception ex)
            {
                UtMantenimiento.mostrarMensaje();
                txtNit.Focus();
            }
        }
    }
}
