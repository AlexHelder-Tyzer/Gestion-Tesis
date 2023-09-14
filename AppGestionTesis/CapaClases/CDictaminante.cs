using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaClases
{
    public class CDictaminante:CEntidad
    {
        //============================== ATRIBUTOS =======================
        //---                   Todos heredados de CDocente            ---

        //============================= METODOS ==========================
        //------------------------- Constructores ------------------------
        public CDictaminante() : base("TDictaminante", true)
        {

        }

        //------------ Implementacion de métodos abstractos --------------
        public override string[] NombresAtributos()
        {

            return new string[] { "CodDictaminante", "FechaAsignacion", "CodDocente", "CodTesis" };
        }

        //----------------- Metodos especificos de Evaluadores ------------------
        public DataTable ListaDictaminantes(string pCodDocente)
        {
            //-- Lista los evaluadoren a una tesis
            string Consulta = "select * from TDictaminante where CodDocente= '" + pCodDocente + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
