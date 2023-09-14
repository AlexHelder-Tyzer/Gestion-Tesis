using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class CTesis:CEntidad
    {
        //============================== ATRIBUTOS =======================
        //---                   Todos heredados de CTesis              ---

        //============================= METODOS ==========================
        //------------------------- Constructores ------------------------
        public CTesis() : base("TTesis", false)
        {

        }

        //------------ Implementacion de métodos abstractos --------------
        public override string[] NombresAtributos()
        {

            return new string[] { "CodTesis", "Titulo", "Calificacion", "Anio" };
        }
    }
}
