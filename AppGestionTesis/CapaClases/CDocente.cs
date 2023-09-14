using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaClases
{
    public class CDocente:CEntidad
    {
        //============================== ATRIBUTOS =======================
        //---                   Todos heredados de CDocente            ---

        //============================= METODOS ==========================
        //------------------------- Constructores ------------------------
        public CDocente() : base("TDocente", false)
        {

        }

        //------------ Implementacion de métodos abstractos --------------
        public override string[] NombresAtributos()
        {

            return new string[] { "CodDocente", "Nombres", "Apellidos", "DNI","Clase","Categoria","Especialidad","DepartamentoAcademico","Email" };
        }
    }
}
