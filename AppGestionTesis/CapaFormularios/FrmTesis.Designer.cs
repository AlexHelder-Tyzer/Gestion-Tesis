
namespace CapaFormularios
{
    partial class FrmTesis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtAnio = new System.Windows.Forms.TextBox();
            this.TxtCalificacion = new System.Windows.Forms.TextBox();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtCodTesis = new System.Windows.Forms.TextBox();
            this.DgvTesis = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanTitulo.SuspendLayout();
            this.PanBotones.SuspendLayout();
            this.PanContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Location = new System.Drawing.Point(296, 22);
            this.LblTitulo.Size = new System.Drawing.Size(227, 25);
            this.LblTitulo.Text = "REGISTRO DE TESIS";
            // 
            // PanTitulo
            // 
            this.PanTitulo.Size = new System.Drawing.Size(841, 66);
            // 
            // PanBotones
            // 
            this.PanBotones.Location = new System.Drawing.Point(0, 434);
            this.PanBotones.Size = new System.Drawing.Size(841, 73);
            // 
            // PanContenido
            // 
            this.PanContenido.Controls.Add(this.TxtAnio);
            this.PanContenido.Controls.Add(this.TxtCalificacion);
            this.PanContenido.Controls.Add(this.TxtTitulo);
            this.PanContenido.Controls.Add(this.TxtCodTesis);
            this.PanContenido.Controls.Add(this.DgvTesis);
            this.PanContenido.Controls.Add(this.label4);
            this.PanContenido.Controls.Add(this.label3);
            this.PanContenido.Controls.Add(this.label2);
            this.PanContenido.Controls.Add(this.label1);
            this.PanContenido.Size = new System.Drawing.Size(841, 368);
            // 
            // TxtAnio
            // 
            this.TxtAnio.Location = new System.Drawing.Point(345, 116);
            this.TxtAnio.Name = "TxtAnio";
            this.TxtAnio.Size = new System.Drawing.Size(166, 22);
            this.TxtAnio.TabIndex = 29;
            // 
            // TxtCalificacion
            // 
            this.TxtCalificacion.Location = new System.Drawing.Point(345, 81);
            this.TxtCalificacion.Name = "TxtCalificacion";
            this.TxtCalificacion.Size = new System.Drawing.Size(166, 22);
            this.TxtCalificacion.TabIndex = 28;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(345, 49);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(354, 22);
            this.TxtTitulo.TabIndex = 27;
            // 
            // TxtCodTesis
            // 
            this.TxtCodTesis.Location = new System.Drawing.Point(345, 14);
            this.TxtCodTesis.Name = "TxtCodTesis";
            this.TxtCodTesis.Size = new System.Drawing.Size(166, 22);
            this.TxtCodTesis.TabIndex = 26;
            this.TxtCodTesis.Leave += new System.EventHandler(this.TxtCodTesis_Leave);
            // 
            // DgvTesis
            // 
            this.DgvTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTesis.Location = new System.Drawing.Point(12, 144);
            this.DgvTesis.Name = "DgvTesis";
            this.DgvTesis.RowHeadersWidth = 51;
            this.DgvTesis.RowTemplate.Height = 24;
            this.DgvTesis.Size = new System.Drawing.Size(815, 203);
            this.DgvTesis.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Año: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Calificación: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Titulo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Codigo Tesis: ";
            // 
            // FrmTesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 507);
            this.Name = "FrmTesis";
            this.Text = "FrmTesis";
            this.Load += new System.EventHandler(this.FrmTesis_Load);
            this.PanTitulo.ResumeLayout(false);
            this.PanTitulo.PerformLayout();
            this.PanBotones.ResumeLayout(false);
            this.PanContenido.ResumeLayout(false);
            this.PanContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAnio;
        private System.Windows.Forms.TextBox TxtCalificacion;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtCodTesis;
        private System.Windows.Forms.DataGridView DgvTesis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}