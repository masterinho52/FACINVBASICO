using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.ProductoTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class UbicacionProducto
    {
        UBICACION_PRODUCTOTableAdapter ubicacion;

        UBICACION_PRODUCTOTableAdapter UBICACION
        {
            get
            {
                if (ubicacion == null)
                    ubicacion = new UBICACION_PRODUCTOTableAdapter();
                return ubicacion;
            }
        }

        public string insertar(int idUbicacion,string producto,int bodega,int cuarto,int estanteria,int fila,int columna,bool estado)
        {
            return Utilidades.verificaAccion(UBICACION.pa_insertaUbicacionProducto(idUbicacion,producto,bodega,cuarto,estanteria,fila,columna,estado));
        }
    }
}
