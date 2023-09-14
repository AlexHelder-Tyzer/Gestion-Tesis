using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaClases;

namespace CapaClases
{
    public class CTramite:CEntidad
    {
        //============================== ATRIBUTOS =======================
        //---                   Todos heredados de CRequisito           ---

        //============================= METODOS ==========================
        //------------------------- Constructores ------------------------
        public CTramite() : base("TTramite", true)
        {

        }

        //------------ Implementacion de métodos abstractos --------------
        public override string[] NombresAtributos()
        {

            return new string[] { "CodTramite", "Nombre", "Descripcion" };
        }
    }
}
