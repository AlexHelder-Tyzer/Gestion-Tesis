using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class CTesista: CEntidad
    {
        //============================== ATRIBUTOS =======================
        //---                   Todos heredados de CTesista            ---

        //============================= METODOS ==========================
        //------------------------- Constructores ------------------------
        public CTesista() : base("TTesista", false)
        {

        }

        //------------ Implementacion de métodos abstractos --------------
        public override string[] NombresAtributos()
        {

            return new string[] {"CodTesista", "Nombres", "Apellidos", "DNI","EscuelaProfesional","Celular","Email"};
        }
    }
}
