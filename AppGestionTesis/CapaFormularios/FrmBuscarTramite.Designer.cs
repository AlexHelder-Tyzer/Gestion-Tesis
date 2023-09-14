
namespace CapaFormularios
{
    partial class FrmBuscarTramite
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
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbBuscarNombre = new System.Windows.Forms.RadioButton();
            this.RdbBuscarDescripcion = new System.Windows.Forms.RadioButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvTramites = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTramites)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(640, 407);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(99, 31);
            this.BtnOk.TabIndex = 13;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(62, 407);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(99, 31);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbBuscarNombre);
            this.groupBox1.Controls.Add(this.RdbBuscarDescripcion);
            this.groupBox1.Location = new System.Drawing.Point(65, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 80);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por: ";
            // 
            // RdbBuscarNombre
            // 
            this.RdbBuscarNombre.AutoSize = true;
            this.RdbBuscarNombre.Checked = true;
            this.RdbBuscarNombre.Location = new System.Drawing.Point(6, 38);
            this.RdbBuscarNombre.Name = "RdbBuscarNombre";
            this.RdbBuscarNombre.Size = new System.Drawing.Size(159, 21);
            this.RdbBuscarNombre.TabIndex = 0;
            this.RdbBuscarNombre.TabStop = true;
            this.RdbBuscarNombre.Text = "Buscar por Nombres";
            this.RdbBuscarNombre.UseVisualStyleBackColor = true;
            this.RdbBuscarNombre.CheckedChanged += new System.EventHandler(this.RdbBuscarNombre_CheckedChanged);
            // 
            // RdbBuscarDescripcion
            // 
            this.RdbBuscarDescripcion.AutoSize = true;
            this.RdbBuscarDescripcion.Location = new System.Drawing.Point(414, 38);
            this.RdbBuscarDescripcion.Name = "RdbBuscarDescripcion";
            this.RdbBuscarDescripcion.Size = new System.Drawing.Size(176, 21);
            this.RdbBuscarDescripcion.TabIndex = 1;
            this.RdbBuscarDescripcion.Text = "Buscar por Descripcion";
            this.RdbBuscarDescripcion.UseVisualStyleBackColor = true;
            this.RdbBuscarDescripcion.CheckedChanged += new System.EventHandler(this.RdbBuscarDescripcion_CheckedChanged);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(65, 138);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(674, 22);
            this.TxtBusqueda.TabIndex = 10;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Digitar el texto de búsqueda: ";
            // 
            // DgvTramites
            // 
            this.DgvTramites.AllowUserToAddRows = false;
            this.DgvTramites.AllowUserToDeleteRows = false;
            this.DgvTramites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTramites.Location = new System.Drawing.Point(62, 184);
            this.DgvTramites.Name = "DgvTramites";
            this.DgvTramites.ReadOnly = true;
            this.DgvTramites.RowHeadersWidth = 51;
            this.DgvTramites.RowTemplate.Height = 24;
            this.DgvTramites.Size = new System.Drawing.Size(677, 206);
            this.DgvTramites.TabIndex = 8;
            // 
            // FrmBuscarTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvTramites);
            this.Name = "FrmBuscarTramite";
            this.Text = "FrmBuscarTramite";
            this.Load += new System.EventHandler(this.FrmBuscarTramite_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTramites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbBuscarNombre;
        private System.Windows.Forms.RadioButton RdbBuscarDescripcion;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvTramites;
    }
}