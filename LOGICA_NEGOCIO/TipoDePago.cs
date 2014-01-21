using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.PagoTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class TipoDePago
    {
            TIPO_DE_PAGOTableAdapter tipoPago;

            TIPO_DE_PAGOTableAdapter TIPO_PAGO
            {
                get
                {
                    if (tipoPago == null)
                        tipoPago = new TIPO_DE_PAGOTableAdapter();
                    return tipoPago;
                }
            }

            public DataTable listar()
            {
                return TIPO_PAGO.GetDataTipoPago();
            }
            //metodo que permite insertar un nuevo empleado
            public string insertar(int tipoPago,string nombrePago,string descripcion,bool estado,int estados)
            {
                return Utilidades.verificaAccion(TIPO_PAGO.pa_insertaTipoPago(tipoPago,nombrePago,descripcion,estado,estados));
            }

            //metodo que permite actualizar los datos de un cliente
            /*public string actualizar(int idcliente, int estado, string nit, string nombre, string apellido, string tel, string direccion, Boolean estados)
            {
                return Utilidades.verificaAccion();
            }
            */
        
    }
}
