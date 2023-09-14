
namespace CapaFormularios
{
    partial class FrmTramite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTramite));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DgvTramite = new System.Windows.Forms.DataGridView();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodTramite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.PanTitulo.SuspendLayout();
            this.PanBotones.SuspendLayout();
            this.PanContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTramite)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Location = new System.Drawing.Point(463, 23);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Size = new System.Drawing.Size(107, 25);
            this.LblTitulo.Text = "TRÁMITE";
            // 
            // PanTitulo
            // 
            this.PanTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanTitulo_Paint);
            // 
            // PanContenido
            // 
            this.PanContenido.Controls.Add(this.BtnBuscar);
            this.PanContenido.Controls.Add(this.pictureBox1);
            this.PanContenido.Controls.Add(this.DgvTramite);
            this.PanContenido.Controls.Add(this.TxtDescripcion);
            this.PanContenido.Controls.Add(this.TxtNombre);
            this.PanContenido.Controls.Add(this.TxtCodTramite);
            this.PanContenido.Controls.Add(this.label3);
            this.PanContenido.Controls.Add(this.label2);
            this.PanContenido.Controls.Add(this.label1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(731, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // DgvTramite
            // 
            this.DgvTramite.AllowUserToAddRows = false;
            this.DgvTramite.AllowUserToDeleteRows = false;
            this.DgvTramite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTramite.Location = new System.Drawing.Point(128, 251);
            this.DgvTramite.Margin = new System.Windows.Forms.Padding(4);
            this.DgvTramite.Name = "DgvTramite";
            this.DgvTramite.ReadOnly = true;
            this.DgvTramite.RowHeadersWidth = 51;
            this.DgvTramite.Size = new System.Drawing.Size(803, 185);
            this.DgvTramite.TabIndex = 14;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(271, 156);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(426, 22);
            this.TxtDescripcion.TabIndex = 13;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(271, 118);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(373, 22);
            this.TxtNombre.TabIndex = 12;
            // 
            // TxtCodTramite
            // 
            this.TxtCodTramite.Enabled = false;
            this.TxtCodTramite.Location = new System.Drawing.Point(271, 75);
            this.TxtCodTramite.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodTramite.Name = "TxtCodTramite";
            this.TxtCodTramite.Size = new System.Drawing.Size(168, 22);
            this.TxtCodTramite.TabIndex = 11;
            this.TxtCodTramite.Leave += new System.EventHandler(this.TxtCodTramite_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descripcion: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo de tramite: ";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(651, 117);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(46, 23);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.Text = "...";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FrmTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1049, 599);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmTramite";
            this.Load += new System.EventHandler(this.FrmTramite_Load);
            this.PanTitulo.ResumeLayout(false);
            this.PanTitulo.PerformLayout();
            this.PanBotones.ResumeLayout(false);
            this.PanContenido.ResumeLayout(false);
            this.PanContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTramite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DgvTramite;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodTramite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
    }
}
