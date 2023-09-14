
namespace CapaFormularios
{
    partial class FrmDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvDocentes = new System.Windows.Forms.DataGridView();
            this.TxtCodDocente = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.TxtEspecialidad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtDepAcademico = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.CboClase = new System.Windows.Forms.ComboBox();
            this.PanTitulo.SuspendLayout();
            this.PanBotones.SuspendLayout();
            this.PanContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Location = new System.Drawing.Point(352, 22);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Size = new System.Drawing.Size(283, 25);
            this.LblTitulo.Text = "REGISTRO DE DOCENTES";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(839, 18);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(947, 18);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(727, 18);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // PanContenido
            // 
            this.PanContenido.Controls.Add(this.CboClase);
            this.PanContenido.Controls.Add(this.TxtEmail);
            this.PanContenido.Controls.Add(this.TxtDepAcademico);
            this.PanContenido.Controls.Add(this.label9);
            this.PanContenido.Controls.Add(this.label8);
            this.PanContenido.Controls.Add(this.pictureBox1);
            this.PanContenido.Controls.Add(this.TxtEspecialidad);
            this.PanContenido.Controls.Add(this.TxtCategoria);
            this.PanContenido.Controls.Add(this.TxtDNI);
            this.PanContenido.Controls.Add(this.TxtApellidos);
            this.PanContenido.Controls.Add(this.TxtNombres);
            this.PanContenido.Controls.Add(this.TxtCodDocente);
            this.PanContenido.Controls.Add(this.DgvDocentes);
            this.PanContenido.Controls.Add(this.label7);
            this.PanContenido.Controls.Add(this.label6);
            this.PanContenido.Controls.Add(this.label5);
            this.PanContenido.Controls.Add(this.label4);
            this.PanContenido.Controls.Add(this.label3);
            this.PanContenido.Controls.Add(this.label2);
            this.PanContenido.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Docente: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clase: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Especialidad: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Departamento académico: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Correo electronico: ";
            // 
            // DgvDocentes
            // 
            this.DgvDocentes.AllowUserToAddRows = false;
            this.DgvDocentes.AllowUserToDeleteRows = false;
            this.DgvDocentes.AllowUserToOrderColumns = true;
            this.DgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDocentes.Location = new System.Drawing.Point(13, 262);
            this.DgvDocentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvDocentes.Name = "DgvDocentes";
            this.DgvDocentes.ReadOnly = true;
            this.DgvDocentes.RowHeadersWidth = 51;
            this.DgvDocentes.RowTemplate.Height = 24;
            this.DgvDocentes.Size = new System.Drawing.Size(1021, 174);
            this.DgvDocentes.TabIndex = 8;
            // 
            // TxtCodDocente
            // 
            this.TxtCodDocente.Location = new System.Drawing.Point(158, 11);
            this.TxtCodDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodDocente.Name = "TxtCodDocente";
            this.TxtCodDocente.Size = new System.Drawing.Size(172, 22);
            this.TxtCodDocente.TabIndex = 9;
            this.TxtCodDocente.Leave += new System.EventHandler(this.TxtCodDocente_Leave);
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(158, 42);
            this.TxtNombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(172, 22);
            this.TxtNombres.TabIndex = 10;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(425, 44);
            this.TxtApellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(353, 22);
            this.TxtApellidos.TabIndex = 11;
            // 
            // TxtDNI
            // 
            this.TxtDNI.Location = new System.Drawing.Point(158, 78);
            this.TxtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(172, 22);
            this.TxtDNI.TabIndex = 12;
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(425, 115);
            this.TxtCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(353, 22);
            this.TxtCategoria.TabIndex = 14;
            // 
            // TxtEspecialidad
            // 
            this.TxtEspecialidad.Location = new System.Drawing.Point(158, 151);
            this.TxtEspecialidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtEspecialidad.Name = "TxtEspecialidad";
            this.TxtEspecialidad.Size = new System.Drawing.Size(620, 22);
            this.TxtEspecialidad.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(814, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Apellidos: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Categoria: ";
            // 
            // TxtDepAcademico
            // 
            this.TxtDepAcademico.Location = new System.Drawing.Point(229, 186);
            this.TxtDepAcademico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDepAcademico.Name = "TxtDepAcademico";
            this.TxtDepAcademico.Size = new System.Drawing.Size(549, 22);
            this.TxtDepAcademico.TabIndex = 20;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(229, 219);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(549, 22);
            this.TxtEmail.TabIndex = 21;
            // 
            // CboClase
            // 
            this.CboClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboClase.FormattingEnabled = true;
            this.CboClase.Items.AddRange(new object[] {
            "CONTRATADO",
            "NOMBRADO"});
            this.CboClase.Location = new System.Drawing.Point(158, 109);
            this.CboClase.Name = "CboClase";
            this.CboClase.Size = new System.Drawing.Size(172, 24);
            this.CboClase.TabIndex = 22;
            // 
            // FrmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 599);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmDocente";
            this.Text = "FrmDocente";
            this.Load += new System.EventHandler(this.FrmDocente_Load);
            this.PanTitulo.ResumeLayout(false);
            this.PanTitulo.PerformLayout();
            this.PanBotones.ResumeLayout(false);
            this.PanContenido.ResumeLayout(false);
            this.PanContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEspecialidad;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.TextBox TxtCodDocente;
        protected System.Windows.Forms.DataGridView DgvDocentes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CboClase;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtDepAcademico;
    }
}