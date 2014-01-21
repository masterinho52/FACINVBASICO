using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.SalidaProductoTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class CuerpoProceso
    {
        CUERPO_PROCESOTableAdapter cuerpo;
        detallesVentaTableAdapter _detalles;

        detallesVentaTableAdapter DETALLES
        {
            get 
            {
                if (_detalles == null)
                    _detalles = new detallesVentaTableAdapter();
                return _detalles;
            }
        }
          CUERPO_PROCESOTableAdapter CUERPO
          {
                get
                {
                    if (cuerpo == null)
                        cuerpo = new CUERPO_PROCESOTableAdapter();
                    return cuerpo;
                }
            }

            public DataTable listar()
            {
                return CUERPO.GetDataCuerpoProceso();
            }
            //metodo que permite insertar un nuevo detalle
            public string insertar(string idProducto,int encabezado,decimal pu,int cantidad,decimal subtotal,string descripcionDetalle,bool estado)
            {
                return Utilidades.verificaAccion(CUERPO.pa_insertaCuerpoProceso(idProducto,encabezado,pu,cantidad,subtotal,descripcionDetalle,estado));
            }

            //metodo que permite actualizar los datos de un cliente
            /*public string actualizar(int idcliente, int estado, string nit, string nombre, string apellido, string tel, string direccion, Boolean estados)
            {
                return Utilidades.verificaAccion();
            }
            */
            public DataTable detallesVenta(int idEncabezado)
            {
                return DETALLES.GetData(idEncabezado);
            }
        }
    }

