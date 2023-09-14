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
    public partial class FrmDocente : FrmPadre
    {
        public FrmDocente()
        {
            InitializeComponent();
            IniciarEntidad(new CDocente());
            DgvDocentes.AutoResizeColumns();
            DgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        //============ REDEFINICION DE LOS METODOS VIRTUALES ==========

        //-- Establecer los valores que irán a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodDocente.Text, TxtNombres.Text, TxtApellidos.Text, TxtDNI.Text, 
                                    CboClase.Text, TxtCategoria.Text, TxtEspecialidad.Text, TxtDepAcademico.Text,TxtEmail.Text };
        }

        //--------------------------------------------------------------
        //-- Mostrar lo datos de un registro
        public override void MostrarDatos()
        {
            //-- Muestra la informacion contenida en el dataset de CDocente
            TxtNombres.Text = aEntidad.ValorAtributo("Nombres");
            TxtApellidos.Text = aEntidad.ValorAtributo("Apellidos");
            TxtDNI.Text = aEntidad.ValorAtributo("DNI");
            CboClase.Text = aEntidad.ValorAtributo("Clase");
            TxtCategoria.Text = aEntidad.ValorAtributo("Categoria");
            TxtEspecialidad.Text = aEntidad.ValorAtributo("Especialidad");
            TxtDepAcademico.Text = aEntidad.ValorAtributo("DepartamentoAcademico");
            TxtEmail.Text = aEntidad.ValorAtributo("Email");

        }

        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributosClave()
        {
            TxtCodDocente.Text = "";
        }

        public override void InicializarAtributosNoClave()
        {
            TxtNombres.Text = "";
            TxtApellidos.Text = "";
            TxtDNI.Text = "";
            CboClase.SelectedIndex = -1;
            TxtCategoria.Text = "";
            TxtEspecialidad.Text = "";
            TxtDepAcademico.Text = "";
            TxtEmail.Text = "";
        }

        //---------------------------------------------------------------
        //-- Listar los registros y mostrarlos en el datagrid
        public override void ListarRegistros()
        {
            //-- Mostrar todos los libros de la tabla en el grid
            DgvDocentes.DataSource = aEntidad.ListaGeneral();
        }

        //-------------------------------------------------------------
        //-- Verificar los campos abligatorios (codigo y titulo) esten llenos
        public override bool EsRegistroValido()
        {
            if (TxtCodDocente.Text.Trim() != "" && TxtNombres.Text != "" && TxtApellidos.Text != "" && TxtDNI.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //======================= EVENTOS ==========================
        private void TxtCodDocente_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }

        private void FrmDocente_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }
    }
}
