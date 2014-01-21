using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.EMPLEADOTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class TipoEmpleado
    {
          TIPO_EMPLEADOTableAdapter tipoEmpleado;

           TIPO_EMPLEADOTableAdapter TIPO_EMPLEADO
            {
                get
                {
                    if (tipoEmpleado == null)
                        tipoEmpleado = new TIPO_EMPLEADOTableAdapter();
                    return tipoEmpleado;
                }
            }

            public DataTable listar()
            {
                return TIPO_EMPLEADO.GetDataTipoEmpleado();
            }
            //metodo que permite insertar un nuevo empleado
            public string insertar(int tipoEmpleado,string nombre,string descripcion,bool estado)
            {
                return Utilidades.verificaAccion(TIPO_EMPLEADO.pa_insertaTipoEmpleado(tipoEmpleado, nombre, descripcion, estado));
            }

            //metodo que permite actualizar los datos de un cliente
            public string actualizar(int tipoEmpleado, string nombre, string descripcion, bool estado)
            {
                return Utilidades.verificaAccion(TIPO_EMPLEADO.pa_actualizaTipoEmpleado(tipoEmpleado,nombre,descripcion,estado));
            }
            
        }
    
}
