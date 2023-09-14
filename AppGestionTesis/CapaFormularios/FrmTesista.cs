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
    public partial class FrmTesista : FrmPadre
    {
        public FrmTesista()
        {
            InitializeComponent();
            IniciarEntidad(new CTesista());
            DgvTesista.AutoResizeColumns();
            DgvTesista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        //============ REDEFINICION DE LOS METODOS VIRTUALES ==========

        //-- Establecer los valores que irán a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodTesista.Text, TxtNombres.Text, TxtApellidos.Text, TxtDNI.Text,
                                    TxtEP.Text, TxtNroCelular.Text,TxtEmail.Text };
        }

        //--------------------------------------------------------------
        //-- Mostrar lo datos de un registro
        public override void MostrarDatos()
        {
            //-- Muestra la informacion contenida en el dataset de CLibro
            TxtNombres.Text = aEntidad.ValorAtributo("Nombres");
            TxtApellidos.Text = aEntidad.ValorAtributo("Apellidos");
            TxtDNI.Text = aEntidad.ValorAtributo("DNI");
            TxtEP.Text = aEntidad.ValorAtributo("EscuelaProfesional");
            TxtNroCelular.Text = aEntidad.ValorAtributo("Celular");
            TxtEmail.Text = aEntidad.ValorAtributo("Email");

        }

        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributosClave()
        {
            TxtCodTesista.Text = "";
        }

        public override void InicializarAtributosNoClave()
        {
            TxtNombres.Text = "";
            TxtApellidos.Text = "";
            TxtDNI.Text = "";
            TxtEP.Text = "";
            TxtNroCelular.Text = "";
            TxtEmail.Text = "";
        }

        //---------------------------------------------------------------
        //-- Listar los registros y mostrarlos en el datagrid
        public override void ListarRegistros()
        {
            //-- Mostrar todos los libros de la tabla en el grid
            DgvTesista.DataSource = aEntidad.ListaGeneral();
        }

        //-------------------------------------------------------------
        //-- Verificar los campos abligatorios (codigo y titulo) esten llenos
        public override bool EsRegistroValido()
        {
            if (TxtCodTesista.Text.Trim() != "" && TxtNombres.Text != "" && TxtApellidos.Text != "" && TxtDNI.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //=========================== EVENTOS ================================

        private void TxtCodTesista_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }

        private void FrmTesista_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }

    }
}
