using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.ProductoTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class Producto
    {
        PRODUCTOTableAdapter _producto;
        busquedaUbicacionProductoTableAdapter _ubicacion;
        busquedaEspecificosProductoTableAdapter _especificos;


        PRODUCTOTableAdapter PRODUCTO
        {
            get
            {
                if (_producto == null)
                    _producto = new PRODUCTOTableAdapter();
                return _producto;
            }
        }
        busquedaUbicacionProductoTableAdapter UBICACION
        {
            get
            {
                if (_ubicacion == null)
                    _ubicacion = new busquedaUbicacionProductoTableAdapter();
                return _ubicacion;
            }
        }
        busquedaEspecificosProductoTableAdapter ESPECIFICOS
        {
            get
            {
                if (_especificos == null)
                    _especificos = new busquedaEspecificosProductoTableAdapter();
                return _especificos;
            }
        }

        public DataTable listar()
        {
            return PRODUCTO.GetDataProducto();
        }
        //metodo que permite insertar un nuevo empleado
        public string insertar(string idProducto,int marca,int Categoria,string nitProveedor,int idCompra,string nombre,decimal pu,decimal pum,decimal pcosto,int existencias,string descripcionProducto,float des,float descMayor,int diasAntelacion,DateTime fechaVen,bool estado)
        {
            return Utilidades.verificaAccion(PRODUCTO.pa_insertaProducto(idProducto,marca,Categoria,nitProveedor,idCompra,nombre,pu,pum,pcosto,existencias,descripcionProducto,des,diasAntelacion,fechaVen,estado));
        }
        //metodo que permite actualizar los datos de un cliente
        /*public string actualizar(int idcliente, int estado, string nit, string nombre, string apellido, string tel, string direccion, Boolean estados)
        {
            return Utilidades.verificaAccion();
        }
        */
        //metodo que busca los datos especificos de un producto
        public DataTable detallesEspecificosProducto(string codigoProducto)
        {
            return ESPECIFICOS.GetDataDetalles(codigoProducto);
        }
        //metodo que busca la ubicacion del producto
        public DataTable ubicacionProducto(string codigoProducto,DateTime fecha)
        {
            return UBICACION.GetDataUbicacionProducto(codigoProducto,fecha);
        }

        public void actualizaStock(string codigoProducto, int cantidad)
        {
            PRODUCTO.paActualizaStock(codigoProducto, cantidad);
        }
    }
}
