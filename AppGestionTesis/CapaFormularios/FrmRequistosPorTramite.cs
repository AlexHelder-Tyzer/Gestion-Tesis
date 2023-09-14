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
    public partial class FrmRequistosPorTramite : CapaFormularios.FrmPadre
    {
        private CTramite aTramite;
        private CRequisito aRequisito;
        private CRequisitosPorTramite aRequisitosPorTramite;
        public FrmRequistosPorTramite()
        {
            InitializeComponent();
            IniciarEntidad(new CRequisitosPorTramite());
            aTramite = new CTramite();
            aRequisito = new CRequisito();
        }

        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================
        //-- Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            //-- recuperar el codigo del REVISOR (de la fila seleccionada en el grid)
            return new string[] {CboListaTramites.SelectedValue.ToString(), CboListaRequisitos.SelectedValue.ToString()};

        }
        //----------------------------------------------------------
        public override void InicializarAtributosNoClave()
        {
            CboListaTramites.SelectedIndex = -1;
            CboListaRequisitos.SelectedIndex = -1;
        }
        /*
        //-----------------------------------------------------------
        public override void ListarRegistros()
        { //-- Mostrar los ejemplares relacionados con el docente seleccionado
            DgvRequisitosPorTramite.DataSource = (aEntidad as CRequisitosPorTramite).ListaRequisitosPorTramite(TxtCodigo.Text);
        }*/
        //-----------------------------------------------------------
        public override bool EsRegistroValido()
        {
            if (CboListaRequisitos.SelectedIndex != -1 && CboListaTramites.SelectedIndex != -1)
                return true;
            else
                return false;
        }
        //-----------------------------------------------------------
        public override void Grabar()
        { //-- al grabar un nuevo ejemplar, el formulario queda listo para

            //-- INSERTAR el siguiente registro

            try
            {
                if (EsRegistroValido())
                { //-- Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();

                    //-- Se realiza la inserciòn sin verificar si existe la clave
                    //-- primaria, ya que en este caso la clave es autonumerica.
                    aEntidad.Insertar(Atributos);
                    //-- Inicializar el formulario

                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicializarAtributos();
                    //ListarRegistros();

                }
                else
                    MessageBox.Show("DEBE COMPLETAR EL LLENADO DEL FORMULARIO", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ===== METODOS PARA MANEJAR LA INFORMACION DEL LIBRO ==========
        public void LlenarListaTramites()
        { //-- muestra la lista de tramites en el combo
            aRequisitosPorTramite = new CRequisitosPorTramite();
            CboListaTramites.DataSource = aRequisitosPorTramite.ListarTramites();
            CboListaTramites.DisplayMember = "Nombre";
            CboListaTramites.ValueMember = "CodTramite";
            //-- dejar el combo sin revisor seleccionado
            CboListaTramites.SelectedIndex = -1;
        }

        public void LlenarListaRequisitos()
        { //-- muestra la lista de tramites en el combo
            aRequisitosPorTramite = new CRequisitosPorTramite();
            CboListaRequisitos.DataSource = aRequisitosPorTramite.ListarRequisitos();
            CboListaRequisitos.DisplayMember = "Nombre";
            CboListaRequisitos.ValueMember = "CodRequisito";
            //-- dejar el combo sin revisor seleccionado
            CboListaRequisitos.SelectedIndex = -1;
        }
        /*
        // --------------------------------------------------------------------
        public void MostrarDatosDictaminantes()
        { //-- al seleccionar un libro en el combo, mostrar el resto de datos
          //-- recuperar el codigo del revisor seleccionado
            string CodDocente = (CboNombre.SelectedValue == null ? "" :

            CboNombre.SelectedValue.ToString());

            //-- solicitar a la base de datos la informacion del revisor
            aDocente.Registro(new string[] { CodDocente });
            //-- mostrar el resto de informacion
            TxtCodigo.Text = aDocente.ValorAtributo("CodDocente");
            TxtAP.Text = aDocente.ValorAtributo("ApPaterno");
            TxtAM.Text = aDocente.ValorAtributo("ApMaterno");
            TxtDNI.Text = aDocente.ValorAtributo("DNI");
            TxtCategoria.Text = aDocente.ValorAtributo("Categoria");
            TxtEspecialidad.Text = aDocente.ValorAtributo("Especialidad");
            TxtEP.Text = aDocente.ValorAtributo("EscuelaProfesional");

        }*/
        // =========================== EVENTOS ==============================
        
        /*
        //---------------------------------------------------------------------
        private void CboLibro_SelectedIndexChanged(object sender, EventArgs e)
        { //-- mostrar informacion del libro seleccionado y de ejemplarese relacionados
            MostrarDatosDictaminantes();
            ListarRegistros();
        }*/

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            InicializarAtributosNoClave();
        }

        private void FrmRequistosPorTramite_Load(object sender, EventArgs e)
        {
            LlenarListaRequisitos();
            LlenarListaTramites();
        }
    }
}
