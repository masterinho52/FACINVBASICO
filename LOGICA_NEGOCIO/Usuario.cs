using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.UsuarioTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class Usuario
    {
        USUARIOTableAdapter _usuario;
        loguinUsuarioTableAdapter _loguin;
        USUARIOTableAdapter USUARIO
        {
            get
            {
                if (_usuario == null)
                    _usuario = new USUARIOTableAdapter();
                return _usuario;
            }
        }

        loguinUsuarioTableAdapter LOGUIN
        {
            get
            {
                if (_loguin == null)
                    _loguin = new loguinUsuarioTableAdapter();
                return _loguin;
            }
        }

        //logueo del usuario
        public DataTable loguinUsuario(string usuario, string clave)
        {
            return LOGUIN.GetDataLoguinUsuario(usuario, clave);
        }

    }
}
