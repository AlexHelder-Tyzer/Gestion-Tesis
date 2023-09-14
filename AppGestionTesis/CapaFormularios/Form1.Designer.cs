
namespace CapaFormularios
{
    partial class Form1
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
            this.PanTitulo.SuspendLayout();
            this.PanBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Location = new System.Drawing.Point(369, 19);
            this.LblTitulo.Size = new System.Drawing.Size(298, 25);
            this.LblTitulo.Text = "REGISTRO DE EXPEDIENTE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1049, 599);
            this.Name = "Form1";
            this.PanTitulo.ResumeLayout(false);
            this.PanTitulo.PerformLayout();
            this.PanBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
