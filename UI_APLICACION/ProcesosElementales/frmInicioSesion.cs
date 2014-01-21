using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using LOGICA_NEGOCIO;
namespace UI_APLICACION.ProcesosElementales
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }
        Usuario usuario = new Usuario();//crea un objeto de la clase usuario

        //********************************************************************************
        //boton para ingreso del usuario
        private void button1_Click(object sender, EventArgs e)
        {
            Utilidad.datosIngreso=usuario.loguinUsuario(txtUsuario.Text,txtClave.Text);
            if (Utilidad.datosIngreso.Rows.Count > 0)//si el usuario es el correcto
            {
                Utilidad.codigoEmpleado = Utilidad.datosIngreso.Rows[0][6].ToString();//almacena el codigo del empleado
                this.Hide();//oculta este formulario y muestra el contenedor princpal
                ContenedorPrincipal contenedor = new ContenedorPrincipal();
                contenedor.ShowDialog();
            }
            else//caso contrario
            {
                lblMensajes.Text = "Verifique usuario o clave de ingreso.";
                lblMensajes.Visible = true;
                txtUsuario.Focus();  
            }
        }
        //********************************************************************************
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtClave.Focus();
            }
        }
        //********************************************************************************
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnIngresar.Focus();
            }
        }
        //********************************************************************************

        
    }
}
