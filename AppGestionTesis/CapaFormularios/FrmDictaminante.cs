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
    public partial class FrmDictaminante : CapaFormularios.FrmPadre
    {
        private CDocente aDocente;
        public FrmDictaminante()
        {
            InitializeComponent();
            IniciarEntidad(new CDictaminante());
            aDocente = new CDocente();
        }

        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================
        //-- Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            //-- recuperar el codigo del REVISOR (de la fila seleccionada en el grid)
            string Codigo = "";
            if (DgvDictaminante.Rows.Count > 0)
                Codigo = DgvDictaminante[0, DgvDictaminante.CurrentCell.RowIndex].Value.ToString();
            return new string[] { Codigo, DtpFecha.Value.ToShortDateString(), TxtCodigo.Text, TxtCodTesis.Text };

        }
        //----------------------------------------------------------
        public override void InicializarAtributosNoClave()
        {
            DtpFecha.Value = DateTime.Now;
            TxtCodTesis.Text = "";
            TxtAM.Text = "";
            TxtAP.Text = "";
            TxtCategoria.Text = "";
            TxtCodigo.Text = "";
            TxtDNI.Text = "";
            TxtEspecialidad.Text = "";
            TxtEP.Text = "";
            CboNombre.SelectedIndex = -1;
        }

        //-----------------------------------------------------------
        public override void ListarRegistros()
        { //-- Mostrar los ejemplares relacionados con el libro seleccionado
            DgvDictaminante.DataSource = (aEntidad as CDictaminante).ListaDictaminantes(TxtCodigo.Text);

        }
        //-----------------------------------------------------------
        public override bool EsRegistroValido()
        {
            if (TxtCodigo.Text != "" && TxtCodTesis.Text != "")
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
                    ListarRegistros();

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
        public void LlenarListaDictaminantes()
        { //-- muestra la lista de revisores en el combo
            CboNombre.DataSource = aDocente.ListaGeneral();
            CboNombre.DisplayMember = "Nombre";
            CboNombre.ValueMember = "CodDocente";
            //-- dejar el combo sin revisor seleccionado
            CboNombre.SelectedIndex = -1;
        }
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

        }
        // =========================== EVENTOS ==============================
        private void FrmDictaminante_Load(object sender, EventArgs e)
        {
            LlenarListaDictaminantes();
        }
        //---------------------------------------------------------------------
        private void CboLibro_SelectedIndexChanged(object sender, EventArgs e)
        { //-- mostrar informacion del libro seleccionado y de ejemplarese relacionados
            MostrarDatosDictaminantes();
            ListarRegistros();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            InicializarAtributosNoClave();
        }
    }
}
