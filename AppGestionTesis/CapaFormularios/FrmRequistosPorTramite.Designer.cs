
namespace CapaFormularios
{
    partial class FrmRequistosPorTramite
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CboListaTramites = new System.Windows.Forms.ComboBox();
            this.DgvRequisitosPorTramite = new System.Windows.Forms.DataGridView();
            this.ClbRequisitos = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CboListaRequisitos = new System.Windows.Forms.ComboBox();
            this.PanTitulo.SuspendLayout();
            this.PanBotones.SuspendLayout();
            this.PanContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequisitosPorTramite)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Location = new System.Drawing.Point(375, 21);
            this.LblTitulo.Size = new System.Drawing.Size(297, 25);
            this.LblTitulo.Text = "REQUISTIOS POR TRAMITE";
            // 
            // PanContenido
            // 
            this.PanContenido.Controls.Add(this.CboListaRequisitos);
            this.PanContenido.Controls.Add(this.label1);
            this.PanContenido.Controls.Add(this.label3);
            this.PanContenido.Controls.Add(this.label2);
            this.PanContenido.Controls.Add(this.ClbRequisitos);
            this.PanContenido.Controls.Add(this.DgvRequisitosPorTramite);
            this.PanContenido.Controls.Add(this.CboListaTramites);
            // 
            // CboListaTramites
            // 
            this.CboListaTramites.FormattingEnabled = true;
            this.CboListaTramites.Items.AddRange(new object[] {
            "PLAN DE TESIS"});
            this.CboListaTramites.Location = new System.Drawing.Point(380, 37);
            this.CboListaTramites.Name = "CboListaTramites";
            this.CboListaTramites.Size = new System.Drawing.Size(379, 24);
            this.CboListaTramites.TabIndex = 7;
            // 
            // DgvRequisitosPorTramite
            // 
            this.DgvRequisitosPorTramite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRequisitosPorTramite.Location = new System.Drawing.Point(117, 278);
            this.DgvRequisitosPorTramite.Name = "DgvRequisitosPorTramite";
            this.DgvRequisitosPorTramite.RowHeadersWidth = 51;
            this.DgvRequisitosPorTramite.RowTemplate.Height = 24;
            this.DgvRequisitosPorTramite.Size = new System.Drawing.Size(815, 150);
            this.DgvRequisitosPorTramite.TabIndex = 9;
            // 
            // ClbRequisitos
            // 
            this.ClbRequisitos.FormattingEnabled = true;
            this.ClbRequisitos.Location = new System.Drawing.Point(117, 133);
            this.ClbRequisitos.Name = "ClbRequisitos";
            this.ClbRequisitos.Size = new System.Drawing.Size(815, 123);
            this.ClbRequisitos.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Trámite: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Seleccionar los requisitos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Requisito: ";
            // 
            // CboListaRequisitos
            // 
            this.CboListaRequisitos.FormattingEnabled = true;
            this.CboListaRequisitos.Items.AddRange(new object[] {
            "PLAN DE TESIS"});
            this.CboListaRequisitos.Location = new System.Drawing.Point(380, 87);
            this.CboListaRequisitos.Name = "CboListaRequisitos";
            this.CboListaRequisitos.Size = new System.Drawing.Size(379, 24);
            this.CboListaRequisitos.TabIndex = 15;
            // 
            // FrmRequistosPorTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1049, 599);
            this.Name = "FrmRequistosPorTramite";
            this.Load += new System.EventHandler(this.FrmRequistosPorTramite_Load);
            this.PanTitulo.ResumeLayout(false);
            this.PanTitulo.PerformLayout();
            this.PanBotones.ResumeLayout(false);
            this.PanContenido.ResumeLayout(false);
            this.PanContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequisitosPorTramite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox ClbRequisitos;
        private System.Windows.Forms.DataGridView DgvRequisitosPorTramite;
        private System.Windows.Forms.ComboBox CboListaTramites;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboListaRequisitos;
        private System.Windows.Forms.Label label1;
    }
}
