using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LOGICA_NEGOCIO;//accede a la logica del negocio

namespace UI_APLICACION.ProcesosElementales
{
    public partial class frmRegistroCliente : Form
    {
        public frmRegistroCliente()
        {
            InitializeComponent();
        }
        Cliente cliente = new Cliente();//instancia un objeto de la clase cliente
        //**********************************************************************************************************
        //evento que se dispara al presionar enter
        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//al presionar enter
            {
                if (chkConsumidorFinal.Checked == false)//si el cliente ha dado su nit
                {
                    buscaCliente(cliente.buscarCliente(txtNit.Text));//busqueda de cliente por nit
                }
                else//si el cliente no tiene nit 
                {
                    buscaCliente(cliente.buscarCliente(txtNombre.Text, txtApellido.Text, txtTelefono.Text));//busqueda de cliente sin nit
                }
            }
        }
        //**********************************************************************************************************
       
        //**********************************************************************************************************
        //cuando se seleccione el check de nuevo cliente
        private void chkNuevoCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNuevoCliente.Checked == true)
            {
                btnNuevoCliente.Enabled = true;
                btnNuevoCliente.Text ="&REGISTRAR";
                txtNit.Enabled = true; txtNombre.Enabled = true; txtApellido.Enabled = true;
                txtTelefono.Enabled = true; txtDireccion.Enabled=true;
            }
            else
            {
                btnNuevoCliente.Text = "&BUSCAR";
            }
        }
        //**********************************************************************************************************
        //cuando se trabaje con el check de consumidor final(este es el predeterminado)
        private void chkConsumidorFinal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConsumidorFinal.Checked == true)//si es un consumidor final
            {
                chkConsumidorFinal.Text = "Consumidor Final";
                txtNombre.Focus(); txtNit.Enabled = false; txtNit.Text = "C/F";
                txtNombre.Enabled= true; txtApellido.Enabled = true;
                txtTelefono.Enabled = true; txtDireccion.Enabled = true;
            }
            else //si no es un consumidor final
            {
                chkConsumidorFinal.Text = "Cliente con NIT";
                txtNit.Enabled = true; txtNit.Clear(); txtNit.Focus();
                txtNombre.Enabled = false; txtApellido.Enabled = false; txtNombre.Clear(); txtApellido.Clear();
                txtTelefono.Enabled = false; txtDireccion.Enabled = false; txtTelefono.Clear(); txtDireccion.Clear();
            }
        }
        //**********************************************************************************************************
        //evento al cargar el formulario
        private void frmRegistroCliente_Load(object sender, EventArgs e)
        {
            btnNuevoCliente.Text = "&BUSCAR"; btnNuevoCliente.Enabled = true;
            txtNit.Enabled = false; txtNit.Text = "C/F";
            txtNombre.Enabled = true; txtApellido.Enabled = true;
            txtTelefono.Enabled = true; txtDireccion.Enabled = true;
        }
        //**********************************************************************************************************
        //boton de nuevo registro de cliente
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Utilidades util=new Utilidades();
            if (chkNuevoCliente.Checked == true)
            {
                int ultimoID = util.ultimoId("cliente") + 1;
                cliente.insertar(ultimoID, 1, txtNit.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtDireccion.Text, true);
                almacenarDatosCliente(ultimoID.ToString());//almacenar temporalmente los datos del cliente
                Utilidad.datosCliente = true;//bandera que determina que el cliente ya tiene registrados sus datos
                agregarEtiquetaEnFormulario();
                if (txtNit.Text == "C/F")
                    Utilidad.tipoConsumidor = false;
                else
                    Utilidad.tipoConsumidor = true;
                this.Close();
                MessageBox.Show("NOMBRE CLIENTE:" + txtNombre.Text + " " + txtApellido.Text, "Cliente registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (chkConsumidorFinal.Checked == false)//si el cliente ha dado su nit
                {
                    buscaCliente(cliente.buscarCliente(txtNit.Text));//busqueda de cliente por nit
                    Utilidad.tipoConsumidor = true;//permite verificar el tipo de factura que se le va a dar
                }
                else//si el cliente no tiene nit 
                {
                    buscaCliente(cliente.buscarCliente(txtNombre.Text, txtApellido.Text, txtTelefono.Text));//busqueda de cliente sin nit
                    Utilidad.tipoConsumidor = false;
                }
            }
        }

        //**********************************************************************************************************
        #region METODOS_LOCALES
        //METODOS LOCALES
        private void buscaCliente(DataTable datos)
        {
            if (datos.Rows.Count > 0)
            {
                txtNombre.Text = datos.Rows[0][2].ToString();
                txtApellido.Text = datos.Rows[0][3].ToString();
                txtTelefono.Text = datos.Rows[0][4].ToString();
                txtDireccion.Text = datos.Rows[0][5].ToString();
                almacenarDatosCliente(datos.Rows[0][0].ToString());
                Utilidad.datosCliente = true;
                agregarEtiquetaEnFormulario();
                MessageBox.Show("NOMBRE CLIENTE:" + txtNombre.Text + " " + txtApellido.Text,"Cliente encontrado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (txtNit.Text != "C/F")
                {
                    Utilidad.tipoConsumidor = true;
                }
                else { Utilidad.tipoConsumidor = false; }
                this.Close();//cierra la aplicacion
            }
            else//de lo contrario el cliente no existe en la BD
            {
                MessageBox.Show("Cliente no registrado en la BD.", "Nuevo Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNit.Enabled = true;
                txtNombre.Enabled = true; txtApellido.Enabled = true;
                txtTelefono.Enabled = true; txtDireccion.Enabled = true;
                chkNuevoCliente.Checked = true;//habilita la opcion de registro de un nuevo cliente
            }
        }
        //metodo que almace los datos del cliente
        private void almacenarDatosCliente(string codigo)
        {
            //almacena los datos temporalmente
            Utilidad.datoscliente.Add(codigo);
            Utilidad.datoscliente.Add(txtNit.Text);
            Utilidad.datoscliente.Add(txtNombre.Text);
            Utilidad.datoscliente.Add(txtApellido.Text);
            Utilidad.datoscliente.Add(txtTelefono.Text);
            Utilidad.datoscliente.Add(txtDireccion.Text);
        }
        private void agregarEtiquetaEnFormulario()
        {
            frmVenta venta = new frmVenta();
            
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "frmVenta")
                {
                    venta = (frmVenta)frm;
                    venta.chkClienteRegistrado.Checked = true;
                    break;
                }
            }
        }
        #endregion
    }
}
