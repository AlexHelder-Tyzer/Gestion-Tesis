
namespace CapaFormularios
{
    partial class FrmRequisitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRequisitos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodRequisito = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.DgvRequisitos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.PanTitulo.SuspendLayout();
            this.PanBotones.SuspendLayout();
            this.PanContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequisitos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Location = new System.Drawing.Point(463, 25);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Size = new System.Drawing.Size(145, 25);
            this.LblTitulo.Text = "REQUISITOS";
            // 
            // PanTitulo
            // 
            this.PanTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanTitulo_Paint);
            // 
            // PanContenido
            // 
            this.PanContenido.Controls.Add(this.BtnBuscar);
            this.PanContenido.Controls.Add(this.pictureBox1);
            this.PanContenido.Controls.Add(this.DgvRequisitos);
            this.PanContenido.Controls.Add(this.TxtDescripcion);
            this.PanContenido.Controls.Add(this.TxtNombre);
            this.PanContenido.Controls.Add(this.TxtCodRequisito);
            this.PanContenido.Controls.Add(this.label3);
            this.PanContenido.Controls.Add(this.label2);
            this.PanContenido.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Requisito: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion: ";
            // 
            // TxtCodRequisito
            // 
            this.TxtCodRequisito.Enabled = false;
            this.TxtCodRequisito.Location = new System.Drawing.Point(245, 81);
            this.TxtCodRequisito.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodRequisito.Name = "TxtCodRequisito";
            this.TxtCodRequisito.Size = new System.Drawing.Size(141, 22);
            this.TxtCodRequisito.TabIndex = 3;
            this.TxtCodRequisito.Leave += new System.EventHandler(this.TxtCodRequisito_Leave);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(245, 124);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(405, 22);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(245, 162);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(503, 22);
            this.TxtDescripcion.TabIndex = 5;
            // 
            // DgvRequisitos
            // 
            this.DgvRequisitos.AllowUserToAddRows = false;
            this.DgvRequisitos.AllowUserToDeleteRows = false;
            this.DgvRequisitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRequisitos.Location = new System.Drawing.Point(88, 245);
            this.DgvRequisitos.Margin = new System.Windows.Forms.Padding(4);
            this.DgvRequisitos.Name = "DgvRequisitos";
            this.DgvRequisitos.ReadOnly = true;
            this.DgvRequisitos.RowHeadersWidth = 51;
            this.DgvRequisitos.Size = new System.Drawing.Size(878, 185);
            this.DgvRequisitos.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(793, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(673, 123);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 8;
            this.BtnBuscar.Text = "...";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FrmRequisitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1049, 599);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmRequisitos";
            this.Load += new System.EventHandler(this.FrmRequisitos_Load);
            this.PanTitulo.ResumeLayout(false);
            this.PanTitulo.PerformLayout();
            this.PanBotones.ResumeLayout(false);
            this.PanContenido.ResumeLayout(false);
            this.PanContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequisitos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodRequisito;
        private System.Windows.Forms.DataGridView DgvRequisitos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnBuscar;
    }
}
