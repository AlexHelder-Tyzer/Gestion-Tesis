using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaFormularios
{
    public partial class FrmBuscarTramite : Form
    {
        //------------- atribtuso ----------------
        private DataView aDatos;

        //--------------- Metodos ----------------
        public FrmBuscarTramite(DataTable Datos)
        {
            InitializeComponent();
            aDatos = new DataView(Datos);
            DgvTramites.DataSource = aDatos;
        }

        public string CodTramite
        {
            get; set;
        }

        //-----------------------------------------
        private void FiltrarDatos()
        {
            //-- Crear e filtro adecuado
            string Filtro = "";
            if (RdbBuscarNombre.Checked)
            {
                Filtro = "Nombre like '" + TxtBusqueda.Text.Trim() + "%'";
            }
            else
            {
                Filtro = "Descripcion like '" + TxtBusqueda.Text.Trim() + "%'";
            }

            //-- aplicar el filtro
            aDatos.RowFilter = Filtro;
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        private void RdbBuscarNombre_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        private void RdbBuscarDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            //-- Recueprar el código del libro seleccioando
            try
            {
                CodTramite = DgvTramites[0, DgvTramites.CurrentCell.RowIndex].Value.ToString();
            }
            catch (Exception)
            {
                CodTramite = "";
            }

            //-- Cerrar formulario
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CodTramite = "";
            //-- Cerramos el formulario
            Close();
        }

        private void FrmBuscarTramite_Load(object sender, EventArgs e)
        {

        }
    }
}
