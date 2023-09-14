
namespace CapaFormularios
{
    partial class FrmPadre
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
            this.PanTitulo = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PanBotones = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanContenido = new System.Windows.Forms.Panel();
            this.PanTitulo.SuspendLayout();
            this.PanBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanTitulo
            // 
            this.PanTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PanTitulo.Controls.Add(this.LblTitulo);
            this.PanTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.PanTitulo.Name = "PanTitulo";
            this.PanTitulo.Size = new System.Drawing.Size(787, 54);
            this.PanTitulo.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(253, 18);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(288, 20);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "SISTEMA DE GESTIÓN DE TESIS";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanBotones
            // 
            this.PanBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PanBotones.Controls.Add(this.BtnEliminar);
            this.PanBotones.Controls.Add(this.BtnGuardar);
            this.PanBotones.Controls.Add(this.BtnNuevo);
            this.PanBotones.Controls.Add(this.BtnSalir);
            this.PanBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBotones.Location = new System.Drawing.Point(0, 428);
            this.PanBotones.Margin = new System.Windows.Forms.Padding(2);
            this.PanBotones.Name = "PanBotones";
            this.PanBotones.Size = new System.Drawing.Size(787, 59);
            this.PanBotones.TabIndex = 1;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnEliminar.Location = new System.Drawing.Point(633, 15);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(65, 29);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnGuardar.Location = new System.Drawing.Point(711, 15);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(65, 29);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnNuevo.Location = new System.Drawing.Point(554, 15);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(65, 29);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnSalir.Location = new System.Drawing.Point(9, 15);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(65, 29);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // PanContenido
            // 
            this.PanContenido.BackColor = System.Drawing.SystemColors.Info;
            this.PanContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanContenido.Location = new System.Drawing.Point(0, 54);
            this.PanContenido.Margin = new System.Windows.Forms.Padding(2);
            this.PanContenido.Name = "PanContenido";
            this.PanContenido.Size = new System.Drawing.Size(787, 374);
            this.PanContenido.TabIndex = 2;
            // 
            // FrmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(787, 487);
            this.Controls.Add(this.PanContenido);
            this.Controls.Add(this.PanBotones);
            this.Controls.Add(this.PanTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gesion de Tesis";
            this.PanTitulo.ResumeLayout(false);
            this.PanTitulo.PerformLayout();
            this.PanBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label LblTitulo;
        protected System.Windows.Forms.Button BtnEliminar;
        protected System.Windows.Forms.Button BtnGuardar;
        protected System.Windows.Forms.Button BtnNuevo;
        protected System.Windows.Forms.Button BtnSalir;
        protected System.Windows.Forms.Panel PanTitulo;
        protected System.Windows.Forms.Panel PanBotones;
        protected System.Windows.Forms.Panel PanContenido;
    }
}