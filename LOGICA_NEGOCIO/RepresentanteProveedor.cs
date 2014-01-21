using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.ProveedorTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class RepresentanteProveedor
    {
        REPRESENTANTETableAdapter representante;
        REPRESENTANTETableAdapter REPRESENTANTE
        {
            get
            {
                if (representante == null)
                    representante = new REPRESENTANTETableAdapter();
                return representante;
            }
        }

        public string insertar(int idRepresentante,string nitProveedor,string nombre,string apellido,string correo,string tel,bool estado)
        {
            return Utilidades.verificaAccion(REPRESENTANTE.pa_insertaRepresentante(idRepresentante,nitProveedor,nombre,apellido,correo,tel,estado));
        }

        public string actualiza(int idRepresentante, string nitProveedor, string nombre, string apellido, string correo, string tel, bool estado)
        {
            return Utilidades.verificaAccion(REPRESENTANTE.pa_actualizaRepresentante(idRepresentante, nitProveedor, nombre, apellido, correo, tel, estado));
        }
    }
}
