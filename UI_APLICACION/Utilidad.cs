//esta clase tiene una serie de metodos y campos utiles al momento de estar interactuando con el programa
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace UI_APLICACION
{
    class Utilidad
    {
        #region CAMPOS_IMPORTANTES
        //variables para el cliente
        public static DataTable datosIngreso = new DataTable();
        public static List<string> datoscliente = new List<string>();//lista que almacena temporalmente los datos del cliente registrado en el proceso
        public static List<string> datosReferenciaPedido = new List<string>();//lista que almacena los datos de la referencia del pedido
        public static DataTable productosAgregados = new DataTable();//la tabla que almacena temporalmente el producto a a gregar
        public static decimal efectivo;//para el registro del pago
        public static string codigo,tipoProceso,codigoEmpleado,reporte;//codigo del producto que se seleccione
        public static string cadenaConexion = "Data Source=(local);Initial Catalog=TiendaFarmaciaSanMartin;Integrated Security=True";
        public static decimal totalPagar=0;//para el total a pagar de acuerdo  a los productos agregados
        public static bool datosCliente, datosPago,referenciaPedido,tipoConsumidor;
        public static int numeroDocumentoProceso;
        #endregion
        //************************************************************************************************************
        //verifica si ya existen controles dentro del panel (en este caso solo puede existir uno a la vez (funcion basica que se este realizando))
        //y elimina el control si existe
        public static void eliminarControlesPanel(Panel panel)
        {
            if (panel.Controls.Count > 0) panel.Controls.RemoveAt(0);
        }
        //************************************************************************************************************
        //permite buscar un producto de acuerdo al texto que se vaya ingresando.
        public static DataTable busquedaProducto(string busqueda)
        {
            string consulta = "Select p.IDProducto as CODIGO,p.NombreProducto as NOMBRE,c.NombreCategoria AS CATEGORIA,m.NombreMarca AS MARCA,prov.NombreProveedor AS PROVEEDOR, u.FechaVencimiento as [FECHA VENC]   from PRODUCTO as p inner join CATEGORIA as c on c.IDCategoria=p.IDCategoria inner join MARCA as m on m.IDMarca=p.IDMarca inner join Proveedor as prov on prov.NITProveedor=p.NITProveedor  inner join UBICACION_PRODUCTO as u on u.IDProducto=p.IDProducto  where p.NombreProducto LIKE '%" + busqueda + "%' or p.DescripcionProducto LIKE '%" + busqueda + "%'  order by u.FechaVencimiento asc";
            string consulta2 = "Select p.IDProducto as CODIGO,p.NombreProducto as NOMBRE,c.NombreCategoria AS CATEGORIA,m.NombreMarca AS MARCA,prov.NombreProveedor AS PROVEEDOR, u.FechaVencimiento as [FECHA VENC]   from PRODUCTO as p inner join CATEGORIA as c on c.IDCategoria=p.IDCategoria inner join MARCA as m on m.IDMarca=p.IDMarca inner join Proveedor as prov on prov.NITProveedor=p.NITProveedor  inner join UBICACION_PRODUCTO as u on u.IDProducto=p.IDProducto  where p.NombreProducto LIKE '%" + busqueda + "%' order by u.FechaVencimiento asc";
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta2, Utilidad.cadenaConexion);
            adaptador.Fill(tabla);
            return tabla; 
        }
        //************************************************************************************************************
        //permite cargar datos dentro de un combo box
        public static void cargarDatos(ComboBox combo,DataTable tabla,int mostrar,int valor)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[mostrar].ToString();
            combo.ValueMember = tabla.Columns[valor].ToString();
        }
        //************************************************************************************************************
        //metodo que determina si la fecha seleccionada es mayor a la fecha actual
        public static void verificarFecha(DateTime fechaIngreso)
        {
            if (fechaIngreso.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Debe de seleccionar una fecha mayor a la actual!!", "Fecha Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //************************************************************************************************************
        //metodo para validar datos
        public static string validarDatos(string tipoDato, string ingreso)
        {
            int nentero;
            decimal ndecimal;
            float nflaot;
            string resultado="";

            if (tipoDato.ToUpper() == "INT")
            {
                if (int.TryParse(ingreso, out nentero) == false)
                {
                    resultado = "";
                }
                else 
                {
                    resultado = nentero.ToString();
                }
            }
            else if (tipoDato.ToUpper() == "DECIMAL")
            {
                if (decimal.TryParse(ingreso, out ndecimal) == false)
                {
                    resultado ="";
                }
                else
                {
                    resultado = ndecimal.ToString();
                }
            }
            else if (tipoDato.ToUpper() == "FLOAT")
            {
                if (float.TryParse(ingreso, out nflaot) == false)
                {
                      resultado = "";
                }
                else
                {
                    resultado = nflaot.ToString();
                } 
            }
            return resultado;
        }
        //************************************************************************************************************
        public static int verificaDatosIgualesEnDataGrid(DataTable tabla, int posicionComparar, int posicionRetornar,string comparar)
        {
            int retorno=0;
            for(int j=0;j<tabla.Rows.Count;j++)
            {
                if (tabla.Rows[j][posicionComparar].ToString() == comparar)
                {
                    retorno = Convert.ToInt32(tabla.Rows[j][posicionRetornar]);
                    break;//corto el recorrido
                }
            }
            return retorno;
        }
        public static void actualizarDatosEnDataGrid(DataTable tabla, int posicionComparar,int posicionInsertar,string comparar,string valor)
        {
            for (int j = 0; j < tabla.Rows.Count; j++)
            {
                if (tabla.Rows[j][posicionComparar].ToString() == comparar)
                {
                    tabla.Rows[j][posicionInsertar] = valor;//actualiza la cantidad
                    tabla.Rows[j][5] = Convert.ToDecimal(tabla.Rows[j][3]) * Convert.ToDecimal(tabla.Rows[j][4]);
                    break;//corto el recorrido
                }
            }
        }

        public static decimal actualizarTotal(DataGridView tabla)
        {
            decimal total = 0;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                 total = total + Convert.ToDecimal(tabla.Rows[i].Cells[5].Value);                 
            }
            return total;
        }
        public static decimal hallarElTotal(DataTable tabla, int posicion)
        {
            decimal sumaColumna=0;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                sumaColumna = sumaColumna + Convert.ToDecimal(tabla.Rows[i][posicion]);
            }
            return sumaColumna;
        }
        //************************************************************************************************************
        //para mostrar mensaje estandar
        public static void desplegarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Nueva accion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
