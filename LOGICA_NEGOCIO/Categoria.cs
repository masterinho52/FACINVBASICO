using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.ProductoTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class Categoria
    {
        CATEGORIATableAdapter categoria;

        CATEGORIATableAdapter CATEGORIA
        {
            get
            {
                if (categoria == null)
                    categoria = new CATEGORIATableAdapter();
                return categoria;
            }
        }

        public string insertar(int idCategoria,string NombreCategoria,string descripcionCategoria,bool estado)
        {
            return Utilidades.verificaAccion(CATEGORIA.pa_insertaCategoria(idCategoria,NombreCategoria,descripcionCategoria,estado));
        }
    }
}
