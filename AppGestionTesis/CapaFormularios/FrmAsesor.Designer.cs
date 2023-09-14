
namespace CapaFormularios
{
    partial class FrmAsesor
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
            this.label11 = new System.Windows.Forms.Label();
            this.DgvAsesor = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtCodTesis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboNombre = new System.Windows.Forms.ComboBox();
            this.TxtEP = new System.Windows.Forms.TextBox();
            this.TxtEspecialidad = new System.Windows.Forms.TextBox();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.TxtAM = new System.Windows.Forms.TextBox();
            this.TxtAP = new System.Windows.Forms.TextBox();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanTitulo.SuspendLayout();
            this.PanBotones.SuspendLayout();
            this.PanContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsesor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // PanTitulo
            // 
            this.PanTitulo.Size = new System.Drawing.Size(840, 66);
            // 
            // PanBotones
            // 
            this.PanBotones.Location = new System.Drawing.Point(0, 557);
            this.PanBotones.Size = new System.Drawing.Size(840, 73);
            // 
            // PanContenido
            // 
            this.PanContenido.Controls.Add(this.label11);
            this.PanContenido.Controls.Add(this.DgvAsesor);
            this.PanContenido.Controls.Add(this.groupBox2);
            this.PanContenido.Controls.Add(this.groupBox1);
            this.PanContenido.Size = new System.Drawing.Size(840, 491);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(282, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Lista de revisiones de tesis de un docente: ";
            // 
            // DgvAsesor
            // 
            this.DgvAsesor.AllowUserToAddRows = false;
            this.DgvAsesor.AllowUserToDeleteRows = false;
            this.DgvAsesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAsesor.Location = new System.Drawing.Point(94, 341);
            this.DgvAsesor.Name = "DgvAsesor";
            this.DgvAsesor.ReadOnly = true;
            this.DgvAsesor.RowHeadersWidth = 51;
            this.DgvAsesor.RowTemplate.Height = 24;
            this.DgvAsesor.Size = new System.Drawing.Size(655, 145);
            this.DgvAsesor.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtCodTesis);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.DtpFecha);
            this.groupBox2.Location = new System.Drawing.Point(94, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 73);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingreso de datos del Revisor: ";
            // 
            // TxtCodTesis
            // 
            this.TxtCodTesis.Location = new System.Drawing.Point(463, 29);
            this.TxtCodTesis.Name = "TxtCodTesis";
            this.TxtCodTesis.Size = new System.Drawing.Size(174, 22);
            this.TxtCodTesis.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(353, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Codigo de tesis: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Fecha: ";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(87, 32);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(253, 22);
            this.DtpFecha.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboNombre);
            this.groupBox1.Controls.Add(this.TxtEP);
            this.groupBox1.Controls.Add(this.TxtEspecialidad);
            this.groupBox1.Controls.Add(this.TxtDNI);
            this.groupBox1.Controls.Add(this.TxtAM);
            this.groupBox1.Controls.Add(this.TxtAP);
            this.groupBox1.Controls.Add(this.TxtCategoria);
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(94, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 217);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione un Docente: ";
            // 
            // CboNombre
            // 
            this.CboNombre.FormattingEnabled = true;
            this.CboNombre.Location = new System.Drawing.Point(105, 55);
            this.CboNombre.Name = "CboNombre";
            this.CboNombre.Size = new System.Drawing.Size(210, 24);
            this.CboNombre.TabIndex = 16;
            this.CboNombre.SelectedIndexChanged += new System.EventHandler(this.CboNombre_SelectedIndexChanged);
            // 
            // TxtEP
            // 
            this.TxtEP.Location = new System.Drawing.Point(173, 176);
            this.TxtEP.Name = "TxtEP";
            this.TxtEP.Size = new System.Drawing.Size(464, 22);
            this.TxtEP.TabIndex = 15;
            // 
            // TxtEspecialidad
            // 
            this.TxtEspecialidad.Location = new System.Drawing.Point(426, 142);
            this.TxtEspecialidad.Name = "TxtEspecialidad";
            this.TxtEspecialidad.Size = new System.Drawing.Size(211, 22);
            this.TxtEspecialidad.TabIndex = 14;
            // 
            // TxtDNI
            // 
            this.TxtDNI.Location = new System.Drawing.Point(71, 147);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(223, 22);
            this.TxtDNI.TabIndex = 13;
            // 
            // TxtAM
            // 
            this.TxtAM.Location = new System.Drawing.Point(154, 112);
            this.TxtAM.Name = "TxtAM";
            this.TxtAM.Size = new System.Drawing.Size(483, 22);
            this.TxtAM.TabIndex = 12;
            // 
            // TxtAP
            // 
            this.TxtAP.Location = new System.Drawing.Point(154, 84);
            this.TxtAP.Name = "TxtAP";
            this.TxtAP.Size = new System.Drawing.Size(483, 22);
            this.TxtAP.TabIndex = 11;
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(414, 40);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(223, 22);
            this.TxtCategoria.TabIndex = 9;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(105, 27);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(210, 22);
            this.TxtCodigo.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Escuela Profesional: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Especialidad: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Categoria: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "DNI: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Materno: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Paterno: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código: ";
            // 
            // FrmAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(840, 630);
            this.Name = "FrmAsesor";
            this.Load += new System.EventHandler(this.FrmEvaluador_Load);
            this.PanTitulo.ResumeLayout(false);
            this.PanTitulo.PerformLayout();
            this.PanBotones.ResumeLayout(false);
            this.PanContenido.ResumeLayout(false);
            this.PanContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsesor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DgvAsesor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtCodTesis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CboNombre;
        private System.Windows.Forms.TextBox TxtEP;
        private System.Windows.Forms.TextBox TxtEspecialidad;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.TextBox TxtAM;
        private System.Windows.Forms.TextBox TxtAP;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
