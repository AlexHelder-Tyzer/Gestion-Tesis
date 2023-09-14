using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaClases
{
    public class CEvaluador : CEntidad
    {
        //============================== ATRIBUTOS =======================
        //---                   Todos heredados de CDocente            ---

        //============================= METODOS ==========================
        //------------------------- Constructores ------------------------
        public CEvaluador() : base("TEvaluador", true)
        {

        }

        //------------ Implementacion de métodos abstractos --------------
        public override string[] NombresAtributos()
        {

            return new string[] { "CodEvaluador", "FechaAsignacion", "CodDocente","CodTesis" };
        }

        //----------------- Metodos especificos de Evaluadores ------------------
        public DataTable ListaEvaluadores(string pCodDocente)
        {
            //-- Lista los evaluadoren a una tesis
            string Consulta = "select * from TEvaluador where CodDocente= '" + pCodDocente + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
    }
}


