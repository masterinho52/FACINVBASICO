using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.IngresoProductoTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class ReferenciaPedidoIngreso
    {
        REFERENCIAS_PEDIDO_PRODUCTOTableAdapter referenciaPedidoIngreso;

        REFERENCIAS_PEDIDO_PRODUCTOTableAdapter REFERENCIA_PEDIDO_INGRESO
        {
            get
            {
                if (referenciaPedidoIngreso == null)
                    referenciaPedidoIngreso = new REFERENCIAS_PEDIDO_PRODUCTOTableAdapter();
                return referenciaPedidoIngreso;
            }
        }

        public string insertar(int pedido,int ingreso,DateTime fechaPedido,DateTime fechaEntrega,string referenciaPersona,string direccion,string tel,string cel,bool estado)
        {
            return Utilidades.verificaAccion(REFERENCIA_PEDIDO_INGRESO.pa_insertaReferenciaPedidoProducto(pedido,ingreso,fechaPedido,fechaEntrega,referenciaPersona,direccion,tel,cel,estado));
        }
    }
}
