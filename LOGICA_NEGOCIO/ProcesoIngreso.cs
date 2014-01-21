using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.IngresoProductoTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class ProcesoIngreso
    {
        PROCESO_INGRESOTableAdapter ingreso;

        PROCESO_INGRESOTableAdapter INGRESO
        {
            get
            {
                if (ingreso == null)
                    ingreso = new PROCESO_INGRESOTableAdapter();
                return ingreso;
            }
        }

        public string insertar(int idIngreso,string idEmpleado,string nitProveedor,int estado,int serie,decimal total,DateTime fecha,int NoDoc,bool estados)
        {
            return Utilidades.verificaAccion(INGRESO.pa_insertaProcesoIngreso(idIngreso,idEmpleado,nitProveedor,estado,serie,total,fecha,NoDoc,estados));
        }
    }
}
