using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.ReportesTableAdapters;
namespace LOGICA_NEGOCIO
{
    public class Reportes
    {
        ventasPorFechaTableAdapter _ventas;
        comprasPorFechaTableAdapter _compras;
        productoMasVendidoTableAdapter _masVendido;
        productoExistenciasTableAdapter _existencias;
        fechasCaducidadTableAdapter _fechasCaducidad;
        UtilidadesTableAdapter _utilidad;

        //****************************************************************
        UtilidadesTableAdapter UTILIDAD
        {
            get
            {
                if (_utilidad == null)
                    _utilidad = new UtilidadesTableAdapter();
                return _utilidad;
            }
        }

        //****************************************************************
        ventasPorFechaTableAdapter VENTAS
        {
            get
            {
                if (_ventas == null)
                    _ventas = new ventasPorFechaTableAdapter();
                return _ventas;
            }
        }
        //****************************************************************
        comprasPorFechaTableAdapter COMPRAS
        {
            get
            {
                if (_compras == null)
                    _compras = new comprasPorFechaTableAdapter();
                return _compras;
            }
        }
        //****************************************************************
        productoMasVendidoTableAdapter MASVENDIDO
        {
            get 
            {
                if (_masVendido == null)
                    _masVendido = new productoMasVendidoTableAdapter();
                return _masVendido;
            }
        }
        //****************************************************************
        productoExistenciasTableAdapter EXISTENCIAS 
        {
            get
            {
                if (_existencias == null)
                    _existencias = new productoExistenciasTableAdapter();
                return _existencias;
            }
        }
        //****************************************************************
        fechasCaducidadTableAdapter CADUCIDAD
        {
            get
            {
                if (_fechasCaducidad == null)
                    _fechasCaducidad = new fechasCaducidadTableAdapter();
                return _fechasCaducidad;
            }
        }
        //****************************************************************
        //metodo que lista las ventas por fecha
        public DataTable ventasPorFecha(int tipoDoc, DateTime fInicio, DateTime fFinal)
        {
            return VENTAS.GetDataVentasPorFecha(tipoDoc, fInicio, fFinal);
        }
        //****************************************************************
        //metodo que lista las compras por fecha
        public DataTable comprasPorFecha(int tipoDoc,DateTime fInicio,DateTime fFinal)
        {
            return COMPRAS.GetDataComprasPorFecha(tipoDoc,fInicio,fFinal);
        }
        //****************************************************************
        //metodo que lista las n productos más vendidos
        public DataTable productoMasVendido(int n, string orden)
        {
            return MASVENDIDO.GetDataProductoMasVendido(n, orden);
        }
        //****************************************************************
        //metodo que lista las existencias en el orden especificado
        public DataTable existencias(string orden)
        {
            return EXISTENCIAS.GetDataExistencias(orden);
        }
        //****************************************************************
        //metodo que lista las fechas de caducidad en el orden especificado
        public DataTable productosCaducidad(string orden)
        {
            return CADUCIDAD.GetDataFechasCaducidad(orden);
        }
        //****************************************************************
        //metodo que determina las utilidades
        public DataTable utilidades(DateTime fInicio, DateTime fFinal, string orden)
        {
            return UTILIDAD.GetDataUtilidades(fInicio, fFinal, orden);
        }
            
    }
}
