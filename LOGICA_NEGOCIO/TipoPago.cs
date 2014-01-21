using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.PagoTableAdapters;
namespace LOGICA_NEGOCIO
{
    public class TipoPago
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

        public string insertar(int idTipoPago, string nombre, string descripcion, bool estado1, int estado2)
        {
            return Utilidades.verificaAccion(TIPO_PAGO.pa_insertaTipoPago(idTipoPago, nombre, descripcion, estado1, estado2));
        }

        public string actualizar(int idTipoPago, string nombre, string descripcion, bool estado1, int estado2)
        {
            return Utilidades.verificaAccion(TIPO_PAGO.pa_tipoPago(idTipoPago, nombre, descripcion, estado1, estado2));
        }

    
    }
}
