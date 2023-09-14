using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class CRequisito : CEntidad
    {
        //============================== ATRIBUTOS =======================
        //---                   Todos heredados de CRequisito           ---

        //============================= METODOS ==========================
        //------------------------- Constructores ------------------------
        public CRequisito() : base("TRequisito", false)
        {

        }

        //------------ Implementacion de métodos abstractos --------------
        public override string[] NombresAtributos()
        {

            return new string[] { "CodRequisito", "Nombre", "Descripcion" };
        }
    }
}
