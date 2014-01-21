using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.IngresoProductoTableAdapters;


namespace LOGICA_NEGOCIO
{
    public class DetallesCompraIngreso
    {
        DETALLES_COMPRATableAdapter detalle;

        DETALLES_COMPRATableAdapter DETALLE
        {
            get
            {
                if (detalle == null)
                    detalle = new DETALLES_COMPRATableAdapter();
                return detalle;
            }
        }

        public string insertar(int detalle,int ingreso,string nombreProducto,decimal costo,int cantidad,decimal subTotal,string descripcion,bool estado,string codigo)
        {
            return Utilidades.verificaAccion(DETALLE.pa_insertaDetalleCompra(detalle,ingreso,nombreProducto,costo,cantidad,subTotal,descripcion,estado,codigo));
        }

        public string actualizar(int detalle, int ingreso, string nombreProducto, decimal costo, int cantidad, decimal subTotal, string descripcion, bool estado, string codigo)
        {
            return Utilidades.verificaAccion(DETALLE.pa_actualizaDetallesCompra(detalle, ingreso, nombreProducto, costo, cantidad, subTotal, descripcion, estado, codigo));
        }
    }
}
