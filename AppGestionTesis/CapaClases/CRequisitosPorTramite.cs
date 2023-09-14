using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaClases;
using System.Data;
using System.Data.SqlClient;
namespace CapaClases
{
    public class CRequisitosPorTramite : CEntidad
    {
        //============================== ATRIBUTOS =======================
        //---                   Todos heredados de CRequisito           ---

        //============================= METODOS ==========================
        //------------------------- Constructores ------------------------
        public CRequisitosPorTramite() : base("TRequisitos_Tramite", true)
        {

        }

        //------------ Implementacion de métodos abstractos --------------
        public override string[] NombresAtributos()
        {

            return new string[] { "CodReqTramite", "NroTramite", "NroRequisito" };
        }

        public DataTable ListarTramites()
        {
            //-- Lista los evaluadoren a una tesis
            string Consulta = "exec proListarTramites";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

        public DataTable ListarRequisitos()
        {
            //-- Lista los evaluadoren a una tesis
            string Consulta = "exec proListarRequisitos";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }


    }
}
