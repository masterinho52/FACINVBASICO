using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.EMPLEADOTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class Empleado
    {
        EMPLEADOTableAdapter _empleado;

        EMPLEADOTableAdapter EMPLEADO
        {
            get
            {
                if (_empleado == null)
                    _empleado = new EMPLEADOTableAdapter();
                return _empleado;
            }
        }

        public DataTable listar()
        {
            return EMPLEADO.GetDataEmpleado();
        }
        //metodo que permite insertar un nuevo empleado
        public string insertar(string idEmpleado,int tipoEmpleado,string nombre,string apellido,DateTime fechaNac,string direccion,string tel,string correo,bool estado)
        {
            return Utilidades.verificaAccion(EMPLEADO.pa_insertaEmpleado(idEmpleado, tipoEmpleado, nombre, apellido, fechaNac, direccion, tel, correo, estado));
        }
        //metodo que permite actualizar los datos de un cliente
        /*public string actualizar(int idcliente, int estado, string nit, string nombre, string apellido, string tel, string direccion, Boolean estados)
        {
            return Utilidades.verificaAccion(EMPLEADO.pa_actualizaEmpleado(idclientel));
        }*/
        
    }
}
