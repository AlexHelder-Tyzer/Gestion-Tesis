using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaClases;

namespace CapaFormularios
{
    public partial class FrmRequisitos : CapaFormularios.FrmPadre
    {
        CRequisito aRequisito = new CRequisito();
        public FrmRequisitos()
        {
            InitializeComponent();
            IniciarEntidad(new CRequisito());
            DgvRequisitos.AutoResizeColumns();
            DgvRequisitos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        //============ REDEFINICION DE LOS METODOS VIRTUALES ==========

        //-- Establecer los valores que irán a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodRequisito.Text, TxtNombre.Text, TxtDescripcion.Text };
        }

        //--------------------------------------------------------------
        //-- Mostrar lo datos de un registro
        public override void MostrarDatos()
        {
            //-- Muestra la informacion contenida en el dataset de CLibro
            TxtNombre.Text = aEntidad.ValorAtributo("Nombre");
            TxtDescripcion.Text = aEntidad.ValorAtributo("Descripcion");
        }

        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributosClave()
        {
            TxtCodRequisito.Text = "";
        }

        public override void InicializarAtributosNoClave()
        {
            TxtNombre.Text = "";
            TxtDescripcion.Text = "";
        }

        //---------------------------------------------------------------
        //-- Listar los registros y mostrarlos en el datagrid
        public override void ListarRegistros()
        {
            //-- Mostrar todos los libros de la tabla en el grid
            DgvRequisitos.DataSource = aEntidad.ListaGeneral();
        }

        //-------------------------------------------------------------
        //-- Verificar los campos abligatorios (codigo y titulo) esten llenos
        public override bool EsRegistroValido()
        {
            if (TxtCodRequisito.Text.Trim() != "" && TxtNombre.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //======================= EVENTOS ==========================
        private void TxtCodRequisito_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }

        private void FrmRequisitos_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //-- Visualizar buscador de libros
            FrmBuscarRequisito Buscador = new FrmBuscarRequisito(aRequisito.ListaGeneral());
            Buscador.ShowDialog();
            //-- Consultar el valor devuelto
            if (Buscador.CodRequisito != "")
            {
                TxtCodRequisito.Text = Buscador.CodRequisito;
                MostrarDatos();
                ListarRegistros();
            }
        }

        private void PanTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
