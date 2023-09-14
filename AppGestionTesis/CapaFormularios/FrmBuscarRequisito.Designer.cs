
namespace CapaFormularios
{
    partial class FrmBuscarRequisito
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
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvBuscarRequisito = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuscarRequisito)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(640, 407);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(99, 31);
            this.BtnOk.TabIndex = 19;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(62, 407);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(99, 31);
            this.BtnCancelar.TabIndex = 18;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbBuscarNombre);
            this.groupBox1.Location = new System.Drawing.Point(65, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 80);
            this.groupBox1.TabIndex = 17;
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
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(65, 138);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(674, 22);
            this.TxtBusqueda.TabIndex = 16;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Digitar el texto de búsqueda: ";
            // 
            // DgvBuscarRequisito
            // 
            this.DgvBuscarRequisito.AllowUserToAddRows = false;
            this.DgvBuscarRequisito.AllowUserToDeleteRows = false;
            this.DgvBuscarRequisito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBuscarRequisito.Location = new System.Drawing.Point(62, 184);
            this.DgvBuscarRequisito.Name = "DgvBuscarRequisito";
            this.DgvBuscarRequisito.ReadOnly = true;
            this.DgvBuscarRequisito.RowHeadersWidth = 51;
            this.DgvBuscarRequisito.RowTemplate.Height = 24;
            this.DgvBuscarRequisito.Size = new System.Drawing.Size(677, 206);
            this.DgvBuscarRequisito.TabIndex = 14;
            // 
            // FrmBuscarRequisito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvBuscarRequisito);
            this.Name = "FrmBuscarRequisito";
            this.Text = "FrmBuscarRequisito";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuscarRequisito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbBuscarNombre;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvBuscarRequisito;
    }
}