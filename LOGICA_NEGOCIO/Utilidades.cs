using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ACCESO_DATOS.ClienteTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class Utilidades
    {
        public static string mensajeError = "Error en la operación, verifique datos.";
        public static string mensajeCorrecto = "Operación realizada correctamente.";
        CLIENTETableAdapter _cliente;
        
        CLIENTETableAdapter ID
        {
            get
            {
                if (_cliente == null)
                    _cliente = new CLIENTETableAdapter();
                return _cliente;
            }
        }
        //metodo que permite dar un mensaje de acuerdo al resultado de la accion realizada
        public static string verificaAccion(int opcion)
        {
            if (opcion == 1)
            {
                return mensajeCorrecto;
            }
            else
            {
                return mensajeError;
            }
        }
        //metodo que permite devolver el ultimo id de la entidad especificada
        public  int ultimoId(string tabla)
        {
            return Convert.ToInt16(ID.f_ultimoAutoIncrementable(tabla));
        }
    }
}
