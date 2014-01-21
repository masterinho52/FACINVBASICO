using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.ClienteTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class ReferenciaPedidoVenta
    {
        REFERENCIAS_PEDIDOTableAdapter _referencia;

        REFERENCIAS_PEDIDOTableAdapter REFERENCIA
        {
            get
            {
                if (_referencia == null)
                    _referencia = new REFERENCIAS_PEDIDOTableAdapter();
                return _referencia;
            }
        }

        public DataTable listar()
        {
            return REFERENCIA.GetDataReferenciaPedido();
        }
        //metodo que permite insertar una nueva referencia
        public string insertar(int idpedido,int idEncabezado,DateTime fpedido,DateTime fentrega,string personaReferencia,string direccion,string tel,string cel,bool estado)
        {
            return Utilidades.verificaAccion(REFERENCIA.pa_insertaReferenciaPedido(idpedido,idEncabezado,fpedido,fentrega,personaReferencia,direccion,tel,cel,estado));
        }
        //metodo que permite actualizar los datos de un cliente
        /*public string actualizar(int idcliente, int estado, string nit, string nombre, string apellido, string tel, string direccion, Boolean estados)
        {
            return Utilidades.verificaAccion();
        }
        */      
    }
}
