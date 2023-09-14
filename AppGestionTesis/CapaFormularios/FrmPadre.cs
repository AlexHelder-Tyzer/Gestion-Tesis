using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaClases;

namespace CapaFormularios
{
    public partial class FrmPadre : Form
    {
        //============================== ATRIBUTOS ==========================
        protected CEntidad aEntidad;

        //=========================== METODOS ===============================
        //-------------------------- COnstructor ----------------------------

        public FrmPadre()
        {
            InitializeComponent();
        }

        //------------------------ Metodos Base ------------------------------
        /// <summary>
        /// Metodo virtual que permite indicar que valores del formulario
        /// deben ir a la tabla relacionada. Los valores deben ser definidos
        /// en el mismo orden en que están considerados en la base de datos.
        /// Es obligatorio redefinir este método en todos los herederos de FrmPadre. 
        /// </summary>
        /// <returns> Arreglo de strings con los valores que deben ir a la tabla</returns>
        public virtual string[] AsignarValoresAtributos()
        {
            return null;
        }

        //--------------------------------------------------------------------
        public void IniciarEntidad(CEntidad pEntidad)
        {
            //-- Indicar con que entidad trabajará el formulario
            aEntidad = pEntidad;
        }

        //--------------------------------------------------------------------
        public virtual void InicializarAtributosClave()
        {
            //-- Dar valores a los controles relacionados a los atributo clave
        }

        //--------------------------------------------------------------------
        public virtual void InicializarAtributosNoClave()
        {
            //-- Dar valores a los controles relacionados a los atributos no clave
        }

        //---------------------------------------------------------------------
        public virtual void InicializarAtributos()
        {
            //-- Dar valor inicial a todos los atributos del formulario
            InicializarAtributosClave();
            InicializarAtributosNoClave();
        }

        //--------------------------------------------------------------------
        public virtual void MostrarDatos()
        {
            //-- Visualiza la informacion de un registro en el formulario
        }

        //--------------------------------------------------------------------
        public virtual void ListarRegistros()
        {
            //-- Lista todos los registros de la tabla relacionada
        }

        //--------------------------------------------------------------------
        public virtual bool EsRegistroValido()
        {
            //-- Verifica que los datos esten completos en el formulario
            return true;
        }

        //--------------------------------------------------------------------
        public virtual void ProcesarClave()
        {
            //-- Recuperar atributos, el primer atributo es la clave
            string[] Atributos = AsignarValoresAtributos();
            //----- Verificar si existe la clave primaria
            if (aEntidad.ExisteClavePrimaria(Atributos))
            {
                //-- Registro existente, recuperar atributos y mostrarlos
                MostrarDatos();
                aEntidad.Nuevo = false;
            }
            else
            {
                //-- Registro nuevo, inicializar atributos no clave
                InicializarAtributosNoClave();
            }
        }

        //--------------------------------------------------------------------
        public virtual void Grabar()
        {
            try
            {
                if (EsRegistroValido())
                { //-- Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();
                    //-- Verificar si existe clave primaria
                    if (aEntidad.ExisteClavePrimaria(Atributos))
                        aEntidad.Actualizar(Atributos);
                    else
                        aEntidad.Insertar(Atributos);
                    //-- Inicializar el formulario
                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");
                    InicializarAtributos();
                    ListarRegistros();

                }
                else
                    MessageBox.Show("DEBE COMPLETAR EL LLENADO DEL FORMULARIO",
                    "ALERTA");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }

        //---------------------------------------------------------------------
        public void Eliminar()
        {
            try
            {
                if (EsRegistroValido())
                { //-- Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();
                    //-- Verificar si existe clave primaria
                    if (aEntidad.ExisteClavePrimaria(Atributos))
                    {
                        //-- Confirmar la eliminación
                        DialogResult Resultado = MessageBox.Show("¿Está seguro que desea eliminar? ", "ATENCION", MessageBoxButtons.OKCancel);
                        if (Resultado == DialogResult.OK)
                        { //-- Eliminar registro
                            aEntidad.Eliminar(Atributos);
                            //-- Inicializar el formulario
                            MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");
                            InicializarAtributos();
                            ListarRegistros();
                        }
                    }
                    else
                    {
                        MessageBox.Show("EL REGISTRO NO EXISTE", "ALERTA");
                    }
                }
                else
                    MessageBox.Show("DEBE COMPLETAR EL LLENADO DEL FORMULARIO", "ALERTA");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }


        //--------------------------- EVENTOS ---------------------------------
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            InicializarAtributos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Grabar();
        }
    }
}
