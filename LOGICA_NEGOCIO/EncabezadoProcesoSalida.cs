using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.SalidaProductoTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class EncabezadoProcesoSalida
    {
            ENCABEZADO_PROCESOTableAdapter _encabezado;
            busquedaVentasTableAdapter _ventas;
            busquedaVentasTableAdapter B_VENTAS
            {
                get
                {
                    if (_ventas == null)
                        _ventas = new busquedaVentasTableAdapter();
                    return _ventas;
                }
            }
            ENCABEZADO_PROCESOTableAdapter ENCABEZADO
            {
                get
                {
                    if (_encabezado == null)
                        _encabezado = new ENCABEZADO_PROCESOTableAdapter();
                    return _encabezado;
                }
            }

            public DataTable listar()
            {
                return ENCABEZADO.GetDataEncabezadoProceso();
            }
            //metodo que permite insertar un nuevo empleado
            public string insertar(int idEncabezado,int idEstado,int idCliente,string idEmpleado,DateTime fechaProceso,decimal total,bool registrado,int numDoc,bool estado,int serie)
            {
                return Utilidades.verificaAccion(ENCABEZADO.pa_insertaEncabezadoProceso(idEncabezado,idEstado,idCliente,idEmpleado,fechaProceso,total,registrado,numDoc,estado,serie));
            }

            //metodo que permite actualizar los datos de un cliente
            /*public string actualizar(int idcliente, int estado, string nit, string nombre, string apellido, string tel, string direccion, Boolean estados)
            {
                return Utilidades.verificaAccion();
            }
            */
            public int ultimoDocumentoSerieProcesado(int idSerie)
            {
                return Convert.ToInt32(ENCABEZADO.f_ultimoNoDocumento(idSerie));
            }

            public DataTable listaCorte(bool estado, DateTime fecha)
            {
                return B_VENTAS.GetDataCorte(estado, fecha);
            }

            public void actualizaEstadoEncabezado(int codigo, bool estado)
            {
                ENCABEZADO.actualizaStadoVenta(codigo, estado);
            }

        }
    
}
