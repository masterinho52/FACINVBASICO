using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace UI_APLICACION
{
    public class UtilidadCompra
    {
        public static string codigoProducto;//variable temporal para almacenar el codigo
        public static DataTable productosCompra = new DataTable();//variable temporal para almacenar los productos que se agregar para la compra
        public static bool proveedor, producto, referencia;
        public static decimal totalCompra;
        public static string nitProveedor;
    }
}
