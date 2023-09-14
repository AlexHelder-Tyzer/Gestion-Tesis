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
    public partial class FrmBuscarRequisito : Form
    {
        //------------- atribtuso ----------------
        private DataView aDatos;

        //--------------- Metodos ----------------
        public FrmBuscarRequisito(DataTable Datos)
        {
            InitializeComponent();
            aDatos = new DataView(Datos);
            DgvBuscarRequisito.DataSource = aDatos;
        }

        public string CodRequisito
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CodRequisito = "";
            //-- Cerramos el formulario
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            //-- Recueprar el código del libro seleccioando
            try
            {
                CodRequisito = DgvBuscarRequisito[0, DgvBuscarRequisito.CurrentCell.RowIndex].Value.ToString();
            }
            catch (Exception)
            {
                CodRequisito = "";
            }

            //-- Cerrar formulario
            Close();
        }
    }
}
