using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.DocumentosTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class AccionDocumento
    {
            TIPO_ACCION_DOCUMENTOTableAdapter accionDocumento;

            TIPO_ACCION_DOCUMENTOTableAdapter ACCIONDOCUMENTO
            {
                get
                {
                    if (accionDocumento == null)
                        accionDocumento = new TIPO_ACCION_DOCUMENTOTableAdapter();
                    return accionDocumento;
                }
            }

            public DataTable listar()
            {
                return ACCIONDOCUMENTO.GetDataAccion();
            }
            //metodo que permite insertar un nuevo tipo de accion del documento
            public string insertar(int idAccion,int tipoDocumento,string nombre,string descripcion,bool estado)
            {
                return Utilidades.verificaAccion(ACCIONDOCUMENTO.pa_insertaTipoAccionDocumento(idAccion,tipoDocumento,nombre,descripcion,estado));
            }

            //metodo que permite actualizar los datos de un cliente
            /*public string actualizar(int idcliente, int estado, string nit, string nombre, string apellido, string tel, string direccion, Boolean estados)
            {
                return Utilidades.verificaAccion();
            }
            */
        }

    }

