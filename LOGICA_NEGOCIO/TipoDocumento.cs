using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.DocumentosTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class TipoDocumento
    {
             TIPO_DOCUMENTOTableAdapter tipoDocumento;

            TIPO_DOCUMENTOTableAdapter TIPODOCUMENTO
            {
                get
                {
                    if (tipoDocumento == null)
                        tipoDocumento = new TIPO_DOCUMENTOTableAdapter();
                    return tipoDocumento;
                }
            }

            public DataTable listar()
            {
                return TIPODOCUMENTO.GetDataDocumento();
            }
            //metodo que permite insertar un nuevo empleado
            public string insertar(int tipoDocumento,int idestado,string nombre,string descripcion, bool estado)
            {
                return Utilidades.verificaAccion(TIPODOCUMENTO.pa_insertaTipoDocumento(tipoDocumento,idestado,nombre,descripcion,estado));
            }

            //metodo que permite actualizar los datos de un cliente
            /*public string actualizar(int idcliente, int estado, string nit, string nombre, string apellido, string tel, string direccion, Boolean estados)
            {
                return Utilidades.verificaAccion();
            }
            */
        }
    
}
