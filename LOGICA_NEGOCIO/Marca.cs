using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.ProductoTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class Marca
    {
         MARCATableAdapter marca;

         MARCATableAdapter MARCA
         {
               get
               {
                    if (marca == null)
                        marca = new MARCATableAdapter();
                    return marca;
               }
         }

        public DataTable listar()
        {
                return MARCA.GetDataMarca();
        }
            //metodo que permite insertar un nuevo empleado
        public string insertar(int idMarca,string nombre,bool estado)
        {
                return Utilidades.verificaAccion(MARCA.pa_insertaMarca(idMarca,nombre,estado));
        }

            //metodo que permite actualizar los datos de un cliente
            /*public string actualizar(int idcliente, int estado, string nit, string nombre, string apellido, string tel, string direccion, Boolean estados)
            {
                return Utilidades.verificaAccion();
            }
            */
    }
}

