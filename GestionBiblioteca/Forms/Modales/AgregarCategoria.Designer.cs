namespace GestionBiblioteca.Forms.Modales
{
    partial class AgregarCategoria
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.listBoxResultados = new System.Windows.Forms.ListBox();
            this.lblNoEncontrado = new System.Windows.Forms.Label();
            this.panelAgregarCategoria = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrarCategoria = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAsignarCategoria = new System.Windows.Forms.Button();
            this.panelAsignarCategoria = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelAsignarTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAgregarTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarModalAgregarCategoria = new System.Windows.Forms.Button();
            this.lblValidaciones = new System.Windows.Forms.Label();
            this.panelAgregarCategoria.SuspendLayout();
            this.panelAsignarCategoria.SuspendLayout();
            this.panelAsignarTitulo.SuspendLayout();
            this.panelAgregarTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(24, 26);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(275, 31);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // listBoxResultados
            // 
            this.listBoxResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxResultados.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResultados.FormattingEnabled = true;
            this.listBoxResultados.ItemHeight = 18;
            this.listBoxResultados.Location = new System.Drawing.Point(24, 83);
            this.listBoxResultados.Name = "listBoxResultados";
            this.listBoxResultados.Size = new System.Drawing.Size(190, 18);
            this.listBoxResultados.TabIndex = 4;
            this.listBoxResultados.SelectedIndexChanged += new System.EventHandler(this.listBoxResultados_SelectedIndexChanged);
            // 
            // lblNoEncontrado
            // 
            this.lblNoEncontrado.AutoSize = true;
            this.lblNoEncontrado.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoEncontrado.Location = new System.Drawing.Point(21, 163);
            this.lblNoEncontrado.Name = "lblNoEncontrado";
            this.lblNoEncontrado.Size = new System.Drawing.Size(301, 13);
            this.lblNoEncontrado.TabIndex = 5;
            this.lblNoEncontrado.Text = "\"No se encontró la categoría. ¿Deseas agregarla?\"\n";
            this.lblNoEncontrado.Click += new System.EventHandler(this.lblNoEncontrado_Click);
            // 
            // panelAgregarCategoria
            // 
            this.panelAgregarCategoria.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelAgregarCategoria.Controls.Add(this.label4);
            this.panelAgregarCategoria.Controls.Add(this.label3);
            this.panelAgregarCategoria.Controls.Add(this.btnRegistrarCategoria);
            this.panelAgregarCategoria.Controls.Add(this.txtDescripcion);
            this.panelAgregarCategoria.Controls.Add(this.txtNombre);
            this.panelAgregarCategoria.Location = new System.Drawing.Point(387, 27);
            this.panelAgregarCategoria.Name = "panelAgregarCategoria";
            this.panelAgregarCategoria.Size = new System.Drawing.Size(329, 270);
            this.panelAgregarCategoria.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // btnRegistrarCategoria
            // 
            this.btnRegistrarCategoria.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegistrarCategoria.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCategoria.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCategoria.Location = new System.Drawing.Point(162, 191);
            this.btnRegistrarCategoria.Name = "btnRegistrarCategoria";
            this.btnRegistrarCategoria.Size = new System.Drawing.Size(95, 31);
            this.btnRegistrarCategoria.TabIndex = 3;
            this.btnRegistrarCategoria.Text = "Registrar";
            this.btnRegistrarCategoria.UseVisualStyleBackColor = false;
            this.btnRegistrarCategoria.Click += new System.EventHandler(this.btnRegistrarCategoria_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(67, 132);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(190, 31);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(67, 53);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 31);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAsignarCategoria
            // 
            this.btnAsignarCategoria.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAsignarCategoria.FlatAppearance.BorderSize = 0;
            this.btnAsignarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarCategoria.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarCategoria.Location = new System.Drawing.Point(220, 83);
            this.btnAsignarCategoria.Name = "btnAsignarCategoria";
            this.btnAsignarCategoria.Size = new System.Drawing.Size(79, 31);
            this.btnAsignarCategoria.TabIndex = 7;
            this.btnAsignarCategoria.Text = "Asignar";
            this.btnAsignarCategoria.UseVisualStyleBackColor = false;
            this.btnAsignarCategoria.Click += new System.EventHandler(this.btnAsignarCategoria_Click);
            // 
            // panelAsignarCategoria
            // 
            this.panelAsignarCategoria.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelAsignarCategoria.Controls.Add(this.label6);
            this.panelAsignarCategoria.Controls.Add(this.txtBuscar);
            this.panelAsignarCategoria.Controls.Add(this.btnAsignarCategoria);
            this.panelAsignarCategoria.Controls.Add(this.listBoxResultados);
            this.panelAsignarCategoria.Controls.Add(this.lblNoEncontrado);
            this.panelAsignarCategoria.Location = new System.Drawing.Point(25, 105);
            this.panelAsignarCategoria.Name = "panelAsignarCategoria";
            this.panelAsignarCategoria.Size = new System.Drawing.Size(332, 192);
            this.panelAsignarCategoria.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ingrese Nombre de la Categoria";
            // 
            // panelAsignarTitulo
            // 
            this.panelAsignarTitulo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelAsignarTitulo.Controls.Add(this.label1);
            this.panelAsignarTitulo.Location = new System.Drawing.Point(25, 27);
            this.panelAsignarTitulo.Name = "panelAsignarTitulo";
            this.panelAsignarTitulo.Size = new System.Drawing.Size(332, 60);
            this.panelAsignarTitulo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(46, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Asignar Categoria";
            // 
            // panelAgregarTitulo
            // 
            this.panelAgregarTitulo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelAgregarTitulo.Controls.Add(this.label2);
            this.panelAgregarTitulo.Location = new System.Drawing.Point(387, 328);
            this.panelAgregarTitulo.Name = "panelAgregarTitulo";
            this.panelAgregarTitulo.Size = new System.Drawing.Size(329, 60);
            this.panelAgregarTitulo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(48, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Agregar Categoria";
            // 
            // btnCerrarModalAgregarCategoria
            // 
            this.btnCerrarModalAgregarCategoria.FlatAppearance.BorderSize = 0;
            this.btnCerrarModalAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarModalAgregarCategoria.Image = global::GestionBiblioteca.Properties.Resources.Volver;
            this.btnCerrarModalAgregarCategoria.Location = new System.Drawing.Point(25, 364);
            this.btnCerrarModalAgregarCategoria.Name = "btnCerrarModalAgregarCategoria";
            this.btnCerrarModalAgregarCategoria.Size = new System.Drawing.Size(47, 39);
            this.btnCerrarModalAgregarCategoria.TabIndex = 11;
            this.btnCerrarModalAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnCerrarModalAgregarCategoria.Click += new System.EventHandler(this.btnCerrarModalAgregarCategoria_Click);
            // 
            // lblValidaciones
            // 
            this.lblValidaciones.AutoSize = true;
            this.lblValidaciones.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidaciones.Location = new System.Drawing.Point(78, 373);
            this.lblValidaciones.Name = "lblValidaciones";
            this.lblValidaciones.Size = new System.Drawing.Size(144, 19);
            this.lblValidaciones.TabIndex = 15;
            this.lblValidaciones.Text = "lblValidaciones";
            // 
            // AgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(744, 432);
            this.Controls.Add(this.lblValidaciones);
            this.Controls.Add(this.btnCerrarModalAgregarCategoria);
            this.Controls.Add(this.panelAgregarTitulo);
            this.Controls.Add(this.panelAsignarTitulo);
            this.Controls.Add(this.panelAsignarCategoria);
            this.Controls.Add(this.panelAgregarCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCategoria";
            this.panelAgregarCategoria.ResumeLayout(false);
            this.panelAgregarCategoria.PerformLayout();
            this.panelAsignarCategoria.ResumeLayout(false);
            this.panelAsignarCategoria.PerformLayout();
            this.panelAsignarTitulo.ResumeLayout(false);
            this.panelAsignarTitulo.PerformLayout();
            this.panelAgregarTitulo.ResumeLayout(false);
            this.panelAgregarTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ListBox listBoxResultados;
        private System.Windows.Forms.Label lblNoEncontrado;
        private System.Windows.Forms.Panel panelAgregarCategoria;
        private System.Windows.Forms.Button btnRegistrarCategoria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAsignarCategoria;
        private System.Windows.Forms.Panel panelAsignarCategoria;
        private System.Windows.Forms.Panel panelAsignarTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAgregarTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrarModalAgregarCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblValidaciones;
    }
}