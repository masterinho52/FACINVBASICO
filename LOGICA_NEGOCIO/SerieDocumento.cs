using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ACCESO_DATOS.DocumentosTableAdapters;

namespace LOGICA_NEGOCIO
{
    public class SerieDocumento
    {
        SERIE_DOCUMENTOTableAdapter serieDocumento;
        datosSerieTableAdapter _datosSerie;

        datosSerieTableAdapter DATOS_SERIE
        {
            get 
            {
                if (_datosSerie == null)
                    _datosSerie = new datosSerieTableAdapter();
                return _datosSerie;
            }
        }

            SERIE_DOCUMENTOTableAdapter SERIE_DOCUMENTO
            {
                get
                {
                    if (serieDocumento == null)
                        serieDocumento = new SERIE_DOCUMENTOTableAdapter();
                    return serieDocumento;
                }
            }

            public DataTable listar()
            {
                return SERIE_DOCUMENTO.GetDataSerie();
            }
            //metodo que permite insertar un nuevo tipo de accion del documento
            public string insertar(int serie,int tipoDocumento,string nombre,DateTime fechaRegistro,int totalDocs,bool estado)
            {
                return Utilidades.verificaAccion(SERIE_DOCUMENTO.pa_insertaSerieDocumento(serie,tipoDocumento,nombre,fechaRegistro,totalDocs,estado));
            }

            //metodo que permite actualizar los datos de un cliente
            /*public string actualizar(int idcliente, int estado, string nit, string nombre, string apellido, string tel, string direccion, Boolean estados)
            {
                return Utilidades.verificaAccion();
            }
            */
            //metodo que retorna el nombre de la serie de acuerdo al tipo de documento
            public string nombreSerieDocumento(int tipoDocumento)
            {
                return DATOS_SERIE.GetDataDatosSerie(tipoDocumento).Rows[0][2].ToString();
            }
            //metodo que retorna la id de la serie de acuerdo al tipo de documento
            public int IdSerieDocumento(int tipoDocumento)
            {
                return (int)DATOS_SERIE.GetDataDatosSerie(tipoDocumento).Rows[0][0];
            }    
            //metodo que retorna la cantidad de documentos asignados a esta serie
            public int  TotalDocsSerieDocumento(int tipoDocumento)
            {
                return (int)DATOS_SERIE.GetDataDatosSerie(tipoDocumento).Rows[0][4];
            }

        }
    }

