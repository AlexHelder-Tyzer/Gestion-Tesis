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
    public partial class FrmTesis : FrmPadre
    {
        public FrmTesis()
        {
            InitializeComponent();
            IniciarEntidad(new CTesis());
        }

        //============ REDEFINICION DE LOS METODOS VIRTUALES ==========

        //-- Establecer los valores que irán a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodTesis.Text, TxtTitulo.Text, TxtCalificacion.Text, TxtAnio.Text };
        }

        //--------------------------------------------------------------
        //-- Mostrar lo datos de un registro
        public override void MostrarDatos()
        {
            //-- Muestra la informacion contenida en el dataset de CLibro
            TxtTitulo.Text = aEntidad.ValorAtributo("Nombres");
            TxtCalificacion.Text = aEntidad.ValorAtributo("ApPaterno");
            TxtAnio.Text = aEntidad.ValorAtributo("ApMaterno");
        }

        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributosClave()
        {
            TxtCodTesis.Text = "";
        }

        public override void InicializarAtributosNoClave()
        {
            TxtTitulo.Text = "";
            TxtCalificacion.Text = "";
            TxtAnio.Text = "";
        }

        //---------------------------------------------------------------
        //-- Listar los registros y mostrarlos en el datagrid
        public override void ListarRegistros()
        {
            //-- Mostrar todos los libros de la tabla en el grid
            DgvTesis.DataSource = aEntidad.ListaGeneral();
        }

        //-------------------------------------------------------------
        //-- Verificar los campos abligatorios (codigo y titulo) esten llenos
        public override bool EsRegistroValido()
        {
            if (TxtCodTesis.Text.Trim() != "" && TxtCalificacion.Text != "" && TxtAnio.Text != "" && TxtTitulo.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //============================== EVENTOS ========================
        private void TxtCodTesis_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }

        private void FrmTesis_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }
    }
}
