using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.PagoTableAdapters;

namespace LOGICA_NEGOCIO
{
    class AsignacionPago
    {
        ASIGNACION_PAGOTableAdapter asignacionPago;

            ASIGNACION_PAGOTableAdapter ASIGNACION_PAGO
            {
                get
                {
                    if (asignacionPago == null)
                        asignacionPago = new ASIGNACION_PAGOTableAdapter();
                    return asignacionPago;
                }
            }

            public DataTable listar()
            {
                return ASIGNACION_PAGO.GetDataAsignacionPago();
            }
            //metodo que permite insertar un nuevo empleado
            public string insertar(int idEncabezado,int idTipoPago,decimal monto,bool estado)
            {
                return Utilidades.verificaAccion(ASIGNACION_PAGO.pa_insertaAsignacionPago(idEncabezado,idTipoPago,monto,estado));
            }            
            public string actualizar(int idEncabezado,int idTipoPago,decimal monto,bool estado)
            {
                return Utilidades.verificaAccion(ASIGNACION_PAGO.pa_actualizaAsignacionPago(idEncabezado,idTipoPago,monto,estado));
            }
            
        }
 }

