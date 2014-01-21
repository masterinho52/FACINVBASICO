using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.ProveedorTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class Proveedor
    {
        PROVEEDORTableAdapter proveedor;

        PROVEEDORTableAdapter PROVEEDOR
        {
            get
            {
                if (proveedor == null)
                    proveedor = new PROVEEDORTableAdapter();
                return proveedor;
            }
        }
        public DataTable listar()
        {
            return PROVEEDOR.GetDataProveedor();
        }
        public string insertar(string nitProveedor,string nombre,string tel,string correo,string direccion,string web,bool estado)
        {
            return Utilidades.verificaAccion(PROVEEDOR.pa_insertaProveedor(nitProveedor,nombre,tel,correo,direccion,web,estado));
        }

        public string actualiza(string nitProveedor, string nombre, string tel, string correo, string direccion, string web, bool estado)
        {
            return Utilidades.verificaAccion(PROVEEDOR.pa_actualizaProveedor(nitProveedor, nombre, tel, correo, direccion, web, estado));
        }

        public DataTable buscarProveedor(string nit)
        {
            return PROVEEDOR.GetDataByProveedor(nit);
        }

    }
}
