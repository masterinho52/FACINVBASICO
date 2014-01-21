using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace UI_APLICACION.corte_caja
{
    public class Corte
    {
        public static DataTable facturaAgregada = new DataTable();//para almacenar las facturas que se ingresar para hacer corte
        public static DataTable detalles = new DataTable();//para ir almacenando los detalles de cada idEncabezado
        public static string codigoDocumento;//para almacenar el documento a retirar
        public static int numeroDoc;
        public static decimal totalCorte=0;

        public decimal hallarElTotal(DataGridView tabla, int posicionCalcular)
        {
            decimal total = 0;

            for (int i = 0; i < tabla.RowCount; i++)
            {
                total = total + Convert.ToDecimal(tabla.Rows[i].Cells[posicionCalcular].Value);
            }
            return total;
        }
    }
}
