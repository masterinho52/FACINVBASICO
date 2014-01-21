using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ACCESO_DATOS.ClienteTableAdapters;
using System.Data;

namespace LOGICA_NEGOCIO
{
    public class Cliente
    {
        CLIENTETableAdapter _cliente;
        busquedaClienteTableAdapter _busquedaCliente;

        CLIENTETableAdapter CLIENTE
        {
            get
            {
                if (_cliente == null)
                    _cliente = new CLIENTETableAdapter();
                return _cliente;
            }
        }

        busquedaClienteTableAdapter BUSQUEDA
        {
            get 
            {
                if (_busquedaCliente == null)
                    _busquedaCliente = new busquedaClienteTableAdapter();
                return _busquedaCliente;
            }
        }

        public DataTable listar()
        {
            return CLIENTE.GetDataCliente();
        }
        //metodo que permite insertar un nuevo cliente
        public string insertar(int idcliente, int estado, string nit, string nombre, string apellido, string tel, string direccion, Boolean estados)
        {
            return Utilidades.verificaAccion(CLIENTE.pa_insertaCliente(idcliente, estado, nit, nombre, apellido, tel, direccion, estados));
   
        }
        //metodo que permite actualizar los datos de un cliente
        public string actualizar(int idcliente, int estado, string nit, string nombre, string apellido, string tel, string direccion, Boolean estados)
        {
            return Utilidades.verificaAccion(CLIENTE.pa_actualizaCliente(idcliente,estado,nit,nombre,apellido,tel,direccion,estados));
        }
        
        //metodo que busca el cliente por su nit
        public DataTable buscarCliente(string nit)
        {
            return BUSQUEDA.GetDataBusquedaCliente(1, nit, "", "", "");
        }

        //metodo que busca al cliente, cuando no se tiene el nit y se desea verificar si el cliente ya existe en la BD
        public DataTable buscarCliente(string nombre,string apellido,string tel)
        {
            return BUSQUEDA.GetDataBusquedaCliente(2, "", nombre, apellido, tel);
        }
        //metodo que retorna el cliente por su id
        public DataTable buscarCliente(int id)
        {
            return CLIENTE.GetDataByClientePorid(id);
        }
        

    }
}
