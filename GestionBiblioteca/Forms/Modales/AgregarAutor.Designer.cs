namespace GestionBiblioteca.Forms.Modales
{
    partial class AgregarAutor
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
            this.btnRegistrarAutor = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.MonthCalendar();
            this.txtBiografia = new System.Windows.Forms.TextBox();
            this.listBoxResultados = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblNoEncontrado = new System.Windows.Forms.Label();
            this.panelAgregarAutor = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.btnAsignarAutor = new System.Windows.Forms.Button();
            this.panelAsignarAutor = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelAsignarTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAgregarTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarModalAgregarAutor = new System.Windows.Forms.Button();
            this.lblValidaciones = new System.Windows.Forms.Label();
            this.panelAgregarAutor.SuspendLayout();
            this.panelAsignarAutor.SuspendLayout();
            this.panelAsignarTitulo.SuspendLayout();
            this.panelAgregarTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrarAutor
            // 
            this.btnRegistrarAutor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegistrarAutor.FlatAppearance.BorderSize = 0;
            this.btnRegistrarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarAutor.Location = new System.Drawing.Point(232, 268);
            this.btnRegistrarAutor.Name = "btnRegistrarAutor";
            this.btnRegistrarAutor.Size = new System.Drawing.Size(76, 31);
            this.btnRegistrarAutor.TabIndex = 1;
            this.btnRegistrarAutor.Text = "Registrar";
            this.btnRegistrarAutor.UseVisualStyleBackColor = false;
            this.btnRegistrarAutor.Click += new System.EventHandler(this.btnRegistrarAutor_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(30, 32);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(275, 31);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(23, 31);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 31);
            this.txtNombre.TabIndex = 3;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(23, 81);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.TabIndex = 4;
            // 
            // txtBiografia
            // 
            this.txtBiografia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBiografia.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBiografia.Location = new System.Drawing.Point(23, 268);
            this.txtBiografia.Multiline = true;
            this.txtBiografia.Name = "txtBiografia";
            this.txtBiografia.Size = new System.Drawing.Size(190, 31);
            this.txtBiografia.TabIndex = 5;
            // 
            // listBoxResultados
            // 
            this.listBoxResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxResultados.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResultados.FormattingEnabled = true;
            this.listBoxResultados.ItemHeight = 18;
            this.listBoxResultados.Location = new System.Drawing.Point(30, 93);
            this.listBoxResultados.Name = "listBoxResultados";
            this.listBoxResultados.Size = new System.Drawing.Size(190, 18);
            this.listBoxResultados.TabIndex = 6;
            this.listBoxResultados.SelectedIndexChanged += new System.EventHandler(this.listBoxResultados_SelectedIndexChanged);
            // 
            // lblNoEncontrado
            // 
            this.lblNoEncontrado.AutoSize = true;
            this.lblNoEncontrado.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoEncontrado.Location = new System.Drawing.Point(14, 181);
            this.lblNoEncontrado.Name = "lblNoEncontrado";
            this.lblNoEncontrado.Size = new System.Drawing.Size(265, 13);
            this.lblNoEncontrado.TabIndex = 7;
            this.lblNoEncontrado.Text = "No se encontró el autor. ¿Deseas agregarlo?";
            this.lblNoEncontrado.Click += new System.EventHandler(this.lblNoEncontrado_Click);
            // 
            // panelAgregarAutor
            // 
            this.panelAgregarAutor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelAgregarAutor.Controls.Add(this.label6);
            this.panelAgregarAutor.Controls.Add(this.label5);
            this.panelAgregarAutor.Controls.Add(this.label4);
            this.panelAgregarAutor.Controls.Add(this.label3);
            this.panelAgregarAutor.Controls.Add(this.txtNacionalidad);
            this.panelAgregarAutor.Controls.Add(this.txtNombre);
            this.panelAgregarAutor.Controls.Add(this.dtpFechaNacimiento);
            this.panelAgregarAutor.Controls.Add(this.txtBiografia);
            this.panelAgregarAutor.Controls.Add(this.btnRegistrarAutor);
            this.panelAgregarAutor.Location = new System.Drawing.Point(387, 27);
            this.panelAgregarAutor.Name = "panelAgregarAutor";
            this.panelAgregarAutor.Size = new System.Drawing.Size(329, 313);
            this.panelAgregarAutor.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Biografia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nacionalidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre Completo";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNacionalidad.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidad.Location = new System.Drawing.Point(179, 31);
            this.txtNacionalidad.Multiline = true;
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(129, 31);
            this.txtNacionalidad.TabIndex = 6;
            // 
            // btnAsignarAutor
            // 
            this.btnAsignarAutor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAsignarAutor.FlatAppearance.BorderSize = 0;
            this.btnAsignarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarAutor.Location = new System.Drawing.Point(236, 93);
            this.btnAsignarAutor.Name = "btnAsignarAutor";
            this.btnAsignarAutor.Size = new System.Drawing.Size(69, 31);
            this.btnAsignarAutor.TabIndex = 9;
            this.btnAsignarAutor.Text = "Asignar";
            this.btnAsignarAutor.UseVisualStyleBackColor = false;
            this.btnAsignarAutor.Click += new System.EventHandler(this.btnAsignarAutor_Click);
            // 
            // panelAsignarAutor
            // 
            this.panelAsignarAutor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelAsignarAutor.Controls.Add(this.label7);
            this.panelAsignarAutor.Controls.Add(this.txtBuscar);
            this.panelAsignarAutor.Controls.Add(this.btnAsignarAutor);
            this.panelAsignarAutor.Controls.Add(this.lblNoEncontrado);
            this.panelAsignarAutor.Controls.Add(this.listBoxResultados);
            this.panelAsignarAutor.Location = new System.Drawing.Point(25, 114);
            this.panelAsignarAutor.Name = "panelAsignarAutor";
            this.panelAsignarAutor.Size = new System.Drawing.Size(332, 226);
            this.panelAsignarAutor.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ingrese Nombre del Autor";
            // 
            // panelAsignarTitulo
            // 
            this.panelAsignarTitulo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelAsignarTitulo.Controls.Add(this.label1);
            this.panelAsignarTitulo.Location = new System.Drawing.Point(25, 27);
            this.panelAsignarTitulo.Name = "panelAsignarTitulo";
            this.panelAsignarTitulo.Size = new System.Drawing.Size(332, 54);
            this.panelAsignarTitulo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Asignar Autor";
            // 
            // panelAgregarTitulo
            // 
            this.panelAgregarTitulo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelAgregarTitulo.Controls.Add(this.label2);
            this.panelAgregarTitulo.Location = new System.Drawing.Point(387, 352);
            this.panelAgregarTitulo.Name = "panelAgregarTitulo";
            this.panelAgregarTitulo.Size = new System.Drawing.Size(329, 51);
            this.panelAgregarTitulo.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(84, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Agregar Autor";
            // 
            // btnCerrarModalAgregarAutor
            // 
            this.btnCerrarModalAgregarAutor.FlatAppearance.BorderSize = 0;
            this.btnCerrarModalAgregarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarModalAgregarAutor.Image = global::GestionBiblioteca.Properties.Resources.Volver;
            this.btnCerrarModalAgregarAutor.Location = new System.Drawing.Point(25, 363);
            this.btnCerrarModalAgregarAutor.Name = "btnCerrarModalAgregarAutor";
            this.btnCerrarModalAgregarAutor.Size = new System.Drawing.Size(47, 39);
            this.btnCerrarModalAgregarAutor.TabIndex = 13;
            this.btnCerrarModalAgregarAutor.UseVisualStyleBackColor = false;
            this.btnCerrarModalAgregarAutor.Click += new System.EventHandler(this.btnCerrarModalAgregarAutor_Click);
            // 
            // lblValidaciones
            // 
            this.lblValidaciones.AutoSize = true;
            this.lblValidaciones.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidaciones.Location = new System.Drawing.Point(88, 371);
            this.lblValidaciones.Name = "lblValidaciones";
            this.lblValidaciones.Size = new System.Drawing.Size(144, 19);
            this.lblValidaciones.TabIndex = 14;
            this.lblValidaciones.Text = "lblValidaciones";
            // 
            // AgregarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(744, 432);
            this.Controls.Add(this.lblValidaciones);
            this.Controls.Add(this.btnCerrarModalAgregarAutor);
            this.Controls.Add(this.panelAgregarTitulo);
            this.Controls.Add(this.panelAsignarTitulo);
            this.Controls.Add(this.panelAsignarAutor);
            this.Controls.Add(this.panelAgregarAutor);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarAutor";
            this.panelAgregarAutor.ResumeLayout(false);
            this.panelAgregarAutor.PerformLayout();
            this.panelAsignarAutor.ResumeLayout(false);
            this.panelAsignarAutor.PerformLayout();
            this.panelAsignarTitulo.ResumeLayout(false);
            this.panelAsignarTitulo.PerformLayout();
            this.panelAgregarTitulo.ResumeLayout(false);
            this.panelAgregarTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrarAutor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MonthCalendar dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtBiografia;
        private System.Windows.Forms.ListBox listBoxResultados;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblNoEncontrado;
        private System.Windows.Forms.Panel panelAgregarAutor;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Button btnAsignarAutor;
        private System.Windows.Forms.Panel panelAsignarAutor;
        private System.Windows.Forms.Panel panelAsignarTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAgregarTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrarModalAgregarAutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblValidaciones;
    }
}