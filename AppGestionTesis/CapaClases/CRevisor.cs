using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaClases
{
    public class CRevisor:CEntidad
    {
        //============================== ATRIBUTOS =======================
        //---                   Todos heredados de CDocente            ---

        //============================= METODOS ==========================
        //------------------------- Constructores ------------------------
        public CRevisor() : base("TRevisor", true)
        {

        }

        //------------ Implementacion de métodos abstractos --------------
        public override string[] NombresAtributos()
        {

            return new string[] { "CodRevisor", "FechaAsignacion", "CodDocente", "CodTesis" };
        }

        //----------------- Metodos especificos de Evaluadores ------------------
        public DataTable ListaRevisores(string pCodDocente)
        {
            //-- Lista los evaluadoren a una tesis
            string Consulta = "select * from TRevisor where CodDocente= '" + pCodDocente + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
