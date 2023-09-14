using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaClases
{
    public class CAsesor:CEntidad
    {
        //============================== ATRIBUTOS =======================
        //---                   Todos heredados de CDocente            ---

        //============================= METODOS ==========================
        //------------------------- Constructores ------------------------
        public CAsesor() : base("TAsesor", true)
        {

        }

        //------------ Implementacion de métodos abstractos --------------
        public override string[] NombresAtributos()
        {

            return new string[] { "CodAsesor", "FechaAsignacion", "CodDocente", "CodTesis" };
        }

        //----------------- Metodos especificos de Evaluadores ------------------
        public DataTable ListaAsesores(string pCodDocente)
        {
            //-- Lista los evaluadoren a una tesis
            string Consulta = "select * from TAsesor where CodDocente= '" + pCodDocente + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
