using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;


namespace UI_APLICACION
{
    public class UtMantenimiento
    {
        public static string codigo="";

        public static void mostrarDatosEnDataGrid(DataTable datos, DataGridView tabla)
        {
            tabla.DataSource = datos;
        }

        public static void cierreMantenimiento()
        {
            ContenedorPrincipal cont = new ContenedorPrincipal();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "ContenedorPrincipal")
                {
                    cont = (ContenedorPrincipal)frm;
                    cont.contenedorProcesosBasicos.Visible = true;
                    cont.pbFondo.Visible = true;
                    cont.contenedorProcesosBasicos.Controls.Add(cont.pbFondo);
                }
            }
        }

        public static void mostrarMensaje()
        {
            MessageBox.Show("Verifique datos de ingreso", "Error en operación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        
    }
}
