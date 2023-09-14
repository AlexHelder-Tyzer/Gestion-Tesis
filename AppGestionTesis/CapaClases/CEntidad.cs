using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaClases
{
    public abstract class CEntidad
    {
        //======================= ATRIBUTOS ===========================
        protected CConexion aConexion;
        protected string aNombreTabla;
        string[] aNombres = null; //-- Nombres campos de la tabla
        string[] aValores = null; //-- Valores de los campos de la tabla
        private bool aNuevo;
        private bool aClaveAutonumerica;

        //======================== METODOS ============================
        //---------------------- Constructores ------------------------
        public CEntidad(string pNombreTabla, bool pClaveAutonumerica)
        {
            // Inicializar los atributos
            aNuevo = true;
            aNombreTabla = pNombreTabla;
            aConexion = new CConexion();
            aNombres = NombresAtributos();
            aValores = null;
            aClaveAutonumerica = pClaveAutonumerica;
        }

        //------------------------ Propiedades -----------------------
        public bool Nuevo
        {
            get { return aNuevo; }
            set { aNuevo = value; }
        }

        //--------------------- Metodos de soporte de BD -------------
        //------------------------------------------------------------
        /* Metodo abstracto encargado de establecer la nombres de los campos
        (atributos) de la tabla. Se deben implementar necesariamente en los
        herederos como arreglos de cadenas.
        Estos atributos deben coincidir con los existentes en la Base de Datos*/
        public abstract string[] NombresAtributos();

        //------------------------------------------------------------
        //-- Metodos para el mantenimiento de la tabla
        //------------------------------------------------------------

        //----------- Insercion de nuevos registros ------------------
        public virtual void Insertar(params string[] Atributos)
        {
            //-- Permite insertar informacion de un regitro en la tabla

            //-- Recuperar loa valores de los atributos;
            aValores = Atributos;
            //-- Formar una cadena de insercion 
            string CadenaInsertar = "insert into " + aNombreTabla + " values ('";
            int IndiceInicial = (aClaveAutonumerica == true ? 1 : 0);
            for (int k = IndiceInicial; k < aValores.Length; k++)
            {
                //-- Incluir los atributos en la consulta
                CadenaInsertar += aValores[k];
                if (k == aValores.Length - 1)
                {
                    //-- Se concatenó el ultimo atributo, Terminar la consulta
                    CadenaInsertar += "')";
                }
                else
                {
                    //-- Se deja la consulta lista para el sguiente atributo
                    CadenaInsertar += "', '";
                }
            }

            // Ejecutar la consulta para insertar el registro
            aConexion.EjecutarComando(CadenaInsertar);
            aNuevo = false;
        }

        //---------------------- nActualizar registros ------------------------
        public void Actualizar(params string[] Atributos)
        {
            //-- Permite actualizar la informacion de un registro de la tabla

            //-- Recuperar los nombres y valores de los atributos de la tabla.
            aNombres = NombresAtributos();
            aValores = Atributos;

            //-- Formar la cadena de actualizacion
            //-- Se asume que la clave principal es el primer atributo (posicion 0)
            string CadenaActualizar = "update " + aNombreTabla + " set ";
            for (int k = 1; k < aValores.Length; k++)
            {
                //-- Incluir los atributos en la consulta
                CadenaActualizar += aNombres[k] + "= '" + aValores[k];
                if (k == aValores.Length - 1)
                {
                    //-- Se concatenó el ultimo atributo. Terminar la asignacion de valores
                    CadenaActualizar += "'";
                }
                else
                {
                    //-- Dejar la consulta lista para el siguiente atributo
                    CadenaActualizar += "', ";
                }
            }

            //-- Agregar a la consulta la cláusula WHERE
            CadenaActualizar += " where " + aNombres[0] + "= '" + aValores[0] + "'";

            //-- Ejecutar la consulta para actualizar el registro
            aConexion.EjecutarComando(CadenaActualizar);
        }

        //------------------------- ELiminacion de un registro -----------------
        public void Eliminar(params string[] Atributos)
        {
            //-- Permite eliminar un registro

            //-- Recuperar los nombres y valores de los atributos de la tabla
            aNombres = NombresAtributos();
            aValores = Atributos;

            //-- Formar la cadena de eliminacion
            string CadenaEliminar = "delete from " + aNombreTabla + " where " + aNombres[0] + "= '" + aValores[0] + "'";
            //-- Ejecutar la consulta para eliminar el registro
            aConexion.EjecutarComando(CadenaEliminar);
        }

        //----------------------------------------------------------------------
        public bool ExisteClavePrimaria(params string[] Atributos)
        {
            //-- Verifica si un registro específico existe

            //-- Recuperar los nombre y valores de los atributos de la tabla
            aNombres = NombresAtributos();
            aValores = Atributos;

            //-- Formar la consulta
            string CadenaConsulta = "select * from " + aNombreTabla + " where " + aNombres[0] + "= '" + aValores[0] + "'";

            //-- Ejecutar la consulta
            aConexion.EjecutarSelect(CadenaConsulta);

            //-- Si existen registros en la tabla 0 del dataset, la clave primaria existe
            return (aConexion.Datos.Tables[0].Rows.Count > 0);
        }

        //----------------------------------------------------------------------
        public DataTable Registro(params string[] Atributos)
        {
            //-- Recupera la informacion de un registro

            //-- Recuperar los nombres y valores de los atributos de la tabla
            aNombres = NombresAtributos();
            aValores = Atributos;

            //-- Formar la consulta
            string CadenaConsulta = "select * from " + aNombreTabla + " where " + aNombres[0] + "= '" + aValores[0] + "'";

            //-- Ejecutar la consulta y devolver el resultado
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }

        //----------------------------------------------------------------------
        public string ValorAtributo(string pNombreCampo)
        {//-- Recupera el valor de un atributo del dataset
            if(aConexion.Datos.Tables[0].Rows.Count > 0)
            {
                return aConexion.Datos.Tables[0].Rows[0][pNombreCampo].ToString();
            }
            else
            {
                return "";
            }
            
        }

        //----------------------------------------------------------------------
        public virtual DataTable ListaGeneral()
        {
            //-- Retorna una tabla con la lista comleta de libros
            string Consulta = "select * from " + aNombreTabla;
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
