namespace GestionBiblioteca.Forms
{
    partial class GestionSolicitudes
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
            this.btnEnviarSolicitud = new System.Windows.Forms.Button();
            this.panelFormSolicitudes = new System.Windows.Forms.Panel();
            this.checkBoxActualizarEsrtadoSolicitud = new System.Windows.Forms.CheckBox();
            this.lblUsuarioSeleccionado = new System.Windows.Forms.Label();
            this.lblLibroSeleccionado = new System.Windows.Forms.Label();
            this.btnAsignarUsuario = new System.Windows.Forms.Button();
            this.btnAsignarLibro = new System.Windows.Forms.Button();
            this.listBoxUsuarios = new System.Windows.Forms.ListBox();
            this.listBoxLibros = new System.Windows.Forms.ListBox();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.txtBuscarLibro = new System.Windows.Forms.TextBox();
            this.btnProcesarSolicitud = new System.Windows.Forms.Button();
            this.btnActualizarSolicitud = new System.Windows.Forms.Button();
            this.panelListaSolicicitudes = new System.Windows.Forms.Panel();
            this.dataGridViewListaSolicitudes = new System.Windows.Forms.DataGridView();
            this.panelValidaciones = new System.Windows.Forms.Panel();
            this.lblValidaciones = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.panelTitulo2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNoLibroEncontrado = new System.Windows.Forms.Label();
            this.lblNoUsuarioEncontrado = new System.Windows.Forms.Label();
            this.panelFormSolicitudes.SuspendLayout();
            this.panelListaSolicicitudes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaSolicitudes)).BeginInit();
            this.panelValidaciones.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.panelTitulo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviarSolicitud
            // 
            this.btnEnviarSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(71)))), ((int)(((byte)(227)))));
            this.btnEnviarSolicitud.FlatAppearance.BorderSize = 0;
            this.btnEnviarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarSolicitud.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarSolicitud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnviarSolicitud.Location = new System.Drawing.Point(51, 14);
            this.btnEnviarSolicitud.Name = "btnEnviarSolicitud";
            this.btnEnviarSolicitud.Size = new System.Drawing.Size(190, 35);
            this.btnEnviarSolicitud.TabIndex = 0;
            this.btnEnviarSolicitud.Text = "Enviar Solicitud";
            this.btnEnviarSolicitud.UseVisualStyleBackColor = false;
            this.btnEnviarSolicitud.Click += new System.EventHandler(this.btnEnviarSolicitud_Click);
            // 
            // panelFormSolicitudes
            // 
            this.panelFormSolicitudes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelFormSolicitudes.Controls.Add(this.lblNoUsuarioEncontrado);
            this.panelFormSolicitudes.Controls.Add(this.lblNoLibroEncontrado);
            this.panelFormSolicitudes.Controls.Add(this.label1);
            this.panelFormSolicitudes.Controls.Add(this.label6);
            this.panelFormSolicitudes.Controls.Add(this.checkBoxActualizarEsrtadoSolicitud);
            this.panelFormSolicitudes.Controls.Add(this.lblUsuarioSeleccionado);
            this.panelFormSolicitudes.Controls.Add(this.lblLibroSeleccionado);
            this.panelFormSolicitudes.Controls.Add(this.btnAsignarUsuario);
            this.panelFormSolicitudes.Controls.Add(this.btnAsignarLibro);
            this.panelFormSolicitudes.Controls.Add(this.listBoxUsuarios);
            this.panelFormSolicitudes.Controls.Add(this.listBoxLibros);
            this.panelFormSolicitudes.Controls.Add(this.txtBuscarUsuario);
            this.panelFormSolicitudes.Controls.Add(this.txtBuscarLibro);
            this.panelFormSolicitudes.Location = new System.Drawing.Point(12, 88);
            this.panelFormSolicitudes.Name = "panelFormSolicitudes";
            this.panelFormSolicitudes.Size = new System.Drawing.Size(298, 484);
            this.panelFormSolicitudes.TabIndex = 1;
            // 
            // checkBoxActualizarEsrtadoSolicitud
            // 
            this.checkBoxActualizarEsrtadoSolicitud.AutoSize = true;
            this.checkBoxActualizarEsrtadoSolicitud.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActualizarEsrtadoSolicitud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxActualizarEsrtadoSolicitud.Location = new System.Drawing.Point(20, 446);
            this.checkBoxActualizarEsrtadoSolicitud.Name = "checkBoxActualizarEsrtadoSolicitud";
            this.checkBoxActualizarEsrtadoSolicitud.Size = new System.Drawing.Size(267, 22);
            this.checkBoxActualizarEsrtadoSolicitud.TabIndex = 15;
            this.checkBoxActualizarEsrtadoSolicitud.Text = "Actualizar Estado De Solicitud";
            this.checkBoxActualizarEsrtadoSolicitud.UseVisualStyleBackColor = true;
            // 
            // lblUsuarioSeleccionado
            // 
            this.lblUsuarioSeleccionado.AutoSize = true;
            this.lblUsuarioSeleccionado.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioSeleccionado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuarioSeleccionado.Location = new System.Drawing.Point(23, 342);
            this.lblUsuarioSeleccionado.Name = "lblUsuarioSeleccionado";
            this.lblUsuarioSeleccionado.Size = new System.Drawing.Size(128, 18);
            this.lblUsuarioSeleccionado.TabIndex = 14;
            this.lblUsuarioSeleccionado.Text = "No Seleccionado";
            // 
            // lblLibroSeleccionado
            // 
            this.lblLibroSeleccionado.AutoSize = true;
            this.lblLibroSeleccionado.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibroSeleccionado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLibroSeleccionado.Location = new System.Drawing.Point(23, 115);
            this.lblLibroSeleccionado.Name = "lblLibroSeleccionado";
            this.lblLibroSeleccionado.Size = new System.Drawing.Size(128, 18);
            this.lblLibroSeleccionado.TabIndex = 13;
            this.lblLibroSeleccionado.Text = "No Seleccionado";
            // 
            // btnAsignarUsuario
            // 
            this.btnAsignarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(71)))), ((int)(((byte)(227)))));
            this.btnAsignarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAsignarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarUsuario.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAsignarUsuario.Location = new System.Drawing.Point(26, 295);
            this.btnAsignarUsuario.Name = "btnAsignarUsuario";
            this.btnAsignarUsuario.Size = new System.Drawing.Size(190, 35);
            this.btnAsignarUsuario.TabIndex = 6;
            this.btnAsignarUsuario.Text = "Asignar Usuario";
            this.btnAsignarUsuario.UseVisualStyleBackColor = false;
            this.btnAsignarUsuario.Click += new System.EventHandler(this.btnAsignarUsuario_Click);
            // 
            // btnAsignarLibro
            // 
            this.btnAsignarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(71)))), ((int)(((byte)(227)))));
            this.btnAsignarLibro.FlatAppearance.BorderSize = 0;
            this.btnAsignarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarLibro.Location = new System.Drawing.Point(26, 77);
            this.btnAsignarLibro.Name = "btnAsignarLibro";
            this.btnAsignarLibro.Size = new System.Drawing.Size(190, 35);
            this.btnAsignarLibro.TabIndex = 5;
            this.btnAsignarLibro.Text = "btnAsignarLibro";
            this.btnAsignarLibro.UseVisualStyleBackColor = false;
            this.btnAsignarLibro.Click += new System.EventHandler(this.btnAsignarLibro_Click);
            // 
            // listBoxUsuarios
            // 
            this.listBoxUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.listBoxUsuarios.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.listBoxUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxUsuarios.FormattingEnabled = true;
            this.listBoxUsuarios.ItemHeight = 18;
            this.listBoxUsuarios.Location = new System.Drawing.Point(26, 363);
            this.listBoxUsuarios.Name = "listBoxUsuarios";
            this.listBoxUsuarios.Size = new System.Drawing.Size(190, 58);
            this.listBoxUsuarios.TabIndex = 4;
            this.listBoxUsuarios.SelectedIndexChanged += new System.EventHandler(this.listBoxUsuarios_SelectedIndexChanged);
            // 
            // listBoxLibros
            // 
            this.listBoxLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.listBoxLibros.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.listBoxLibros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxLibros.FormattingEnabled = true;
            this.listBoxLibros.ItemHeight = 18;
            this.listBoxLibros.Location = new System.Drawing.Point(26, 136);
            this.listBoxLibros.Name = "listBoxLibros";
            this.listBoxLibros.Size = new System.Drawing.Size(190, 58);
            this.listBoxLibros.TabIndex = 3;
            this.listBoxLibros.SelectedIndexChanged += new System.EventHandler(this.listBoxLibros_SelectedIndexChanged);
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtBuscarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarUsuario.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtBuscarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBuscarUsuario.Location = new System.Drawing.Point(26, 249);
            this.txtBuscarUsuario.Multiline = true;
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(190, 31);
            this.txtBuscarUsuario.TabIndex = 2;
            this.txtBuscarUsuario.TextChanged += new System.EventHandler(this.txtBuscarUsuario_TextChanged);
            // 
            // txtBuscarLibro
            // 
            this.txtBuscarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtBuscarLibro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarLibro.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtBuscarLibro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBuscarLibro.Location = new System.Drawing.Point(26, 31);
            this.txtBuscarLibro.Multiline = true;
            this.txtBuscarLibro.Name = "txtBuscarLibro";
            this.txtBuscarLibro.Size = new System.Drawing.Size(190, 31);
            this.txtBuscarLibro.TabIndex = 1;
            this.txtBuscarLibro.TextChanged += new System.EventHandler(this.txtBuscarLibro_TextChanged);
            // 
            // btnProcesarSolicitud
            // 
            this.btnProcesarSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(71)))), ((int)(((byte)(227)))));
            this.btnProcesarSolicitud.FlatAppearance.BorderSize = 0;
            this.btnProcesarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesarSolicitud.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesarSolicitud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProcesarSolicitud.Location = new System.Drawing.Point(51, 115);
            this.btnProcesarSolicitud.Name = "btnProcesarSolicitud";
            this.btnProcesarSolicitud.Size = new System.Drawing.Size(190, 35);
            this.btnProcesarSolicitud.TabIndex = 17;
            this.btnProcesarSolicitud.Text = "Procesar Solicitud";
            this.btnProcesarSolicitud.UseVisualStyleBackColor = false;
            this.btnProcesarSolicitud.Click += new System.EventHandler(this.btnProcesarSolicitud_Click);
            // 
            // btnActualizarSolicitud
            // 
            this.btnActualizarSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(71)))), ((int)(((byte)(227)))));
            this.btnActualizarSolicitud.FlatAppearance.BorderSize = 0;
            this.btnActualizarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarSolicitud.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarSolicitud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizarSolicitud.Location = new System.Drawing.Point(51, 65);
            this.btnActualizarSolicitud.Name = "btnActualizarSolicitud";
            this.btnActualizarSolicitud.Size = new System.Drawing.Size(190, 35);
            this.btnActualizarSolicitud.TabIndex = 16;
            this.btnActualizarSolicitud.Text = "Actualizar Solicitud";
            this.btnActualizarSolicitud.UseVisualStyleBackColor = false;
            this.btnActualizarSolicitud.Click += new System.EventHandler(this.btnActualizarSolicitud_Click);
            // 
            // panelListaSolicicitudes
            // 
            this.panelListaSolicicitudes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelListaSolicicitudes.Controls.Add(this.dataGridViewListaSolicitudes);
            this.panelListaSolicicitudes.Location = new System.Drawing.Point(324, 88);
            this.panelListaSolicicitudes.Name = "panelListaSolicicitudes";
            this.panelListaSolicicitudes.Size = new System.Drawing.Size(864, 580);
            this.panelListaSolicicitudes.TabIndex = 2;
            // 
            // dataGridViewListaSolicitudes
            // 
            this.dataGridViewListaSolicitudes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.dataGridViewListaSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaSolicitudes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewListaSolicitudes.Name = "dataGridViewListaSolicitudes";
            this.dataGridViewListaSolicitudes.Size = new System.Drawing.Size(874, 585);
            this.dataGridViewListaSolicitudes.TabIndex = 0;
            // 
            // panelValidaciones
            // 
            this.panelValidaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelValidaciones.Controls.Add(this.lblValidaciones);
            this.panelValidaciones.Location = new System.Drawing.Point(324, 685);
            this.panelValidaciones.Name = "panelValidaciones";
            this.panelValidaciones.Size = new System.Drawing.Size(864, 65);
            this.panelValidaciones.TabIndex = 3;
            // 
            // lblValidaciones
            // 
            this.lblValidaciones.AutoSize = true;
            this.lblValidaciones.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidaciones.Location = new System.Drawing.Point(20, 27);
            this.lblValidaciones.Name = "lblValidaciones";
            this.lblValidaciones.Size = new System.Drawing.Size(18, 19);
            this.lblValidaciones.TabIndex = 3;
            this.lblValidaciones.Text = "-";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelTitulo.Location = new System.Drawing.Point(324, 12);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(864, 60);
            this.panelTitulo.TabIndex = 4;
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelAcciones.Controls.Add(this.btnProcesarSolicitud);
            this.panelAcciones.Controls.Add(this.btnEnviarSolicitud);
            this.panelAcciones.Controls.Add(this.btnActualizarSolicitud);
            this.panelAcciones.Location = new System.Drawing.Point(12, 590);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(298, 160);
            this.panelAcciones.TabIndex = 5;
            // 
            // panelTitulo2
            // 
            this.panelTitulo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelTitulo2.Controls.Add(this.label8);
            this.panelTitulo2.Location = new System.Drawing.Point(12, 12);
            this.panelTitulo2.Name = "panelTitulo2";
            this.panelTitulo2.Size = new System.Drawing.Size(298, 60);
            this.panelTitulo2.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(22, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Registrar Solicitud";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label6.Location = new System.Drawing.Point(23, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ingrese Nombre del Libro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(23, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ingrese Nombre del Usuario";
            // 
            // lblNoLibroEncontrado
            // 
            this.lblNoLibroEncontrado.AutoSize = true;
            this.lblNoLibroEncontrado.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoLibroEncontrado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoLibroEncontrado.Location = new System.Drawing.Point(27, 207);
            this.lblNoLibroEncontrado.Name = "lblNoLibroEncontrado";
            this.lblNoLibroEncontrado.Size = new System.Drawing.Size(147, 15);
            this.lblNoLibroEncontrado.TabIndex = 27;
            this.lblNoLibroEncontrado.Text = "Libro no encontrado ";
            this.lblNoLibroEncontrado.Click += new System.EventHandler(this.lblNoLibroEncontrado_Click);
            // 
            // lblNoUsuarioEncontrado
            // 
            this.lblNoUsuarioEncontrado.AutoSize = true;
            this.lblNoUsuarioEncontrado.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoUsuarioEncontrado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoUsuarioEncontrado.Location = new System.Drawing.Point(27, 424);
            this.lblNoUsuarioEncontrado.Name = "lblNoUsuarioEncontrado";
            this.lblNoUsuarioEncontrado.Size = new System.Drawing.Size(154, 15);
            this.lblNoUsuarioEncontrado.TabIndex = 28;
            this.lblNoUsuarioEncontrado.Text = "Usuario no encontrado";
            this.lblNoUsuarioEncontrado.Click += new System.EventHandler(this.lblNoUsuarioEncontrado_Click);
            // 
            // GestionSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1200, 762);
            this.Controls.Add(this.panelTitulo2);
            this.Controls.Add(this.panelAcciones);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelValidaciones);
            this.Controls.Add(this.panelListaSolicicitudes);
            this.Controls.Add(this.panelFormSolicitudes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionSolicitudes";
            this.Text = "Solicitudes";
            this.panelFormSolicitudes.ResumeLayout(false);
            this.panelFormSolicitudes.PerformLayout();
            this.panelListaSolicicitudes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaSolicitudes)).EndInit();
            this.panelValidaciones.ResumeLayout(false);
            this.panelValidaciones.PerformLayout();
            this.panelAcciones.ResumeLayout(false);
            this.panelTitulo2.ResumeLayout(false);
            this.panelTitulo2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnviarSolicitud;
        private System.Windows.Forms.Panel panelFormSolicitudes;
        private System.Windows.Forms.ListBox listBoxLibros;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.TextBox txtBuscarLibro;
        private System.Windows.Forms.Panel panelListaSolicicitudes;
        private System.Windows.Forms.Panel panelValidaciones;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.DataGridView dataGridViewListaSolicitudes;
        private System.Windows.Forms.Button btnAsignarUsuario;
        private System.Windows.Forms.Button btnAsignarLibro;
        private System.Windows.Forms.ListBox listBoxUsuarios;
        private System.Windows.Forms.Label lblUsuarioSeleccionado;
        private System.Windows.Forms.Label lblLibroSeleccionado;
        private System.Windows.Forms.CheckBox checkBoxActualizarEsrtadoSolicitud;
        private System.Windows.Forms.Button btnActualizarSolicitud;
        private System.Windows.Forms.Button btnProcesarSolicitud;
        private System.Windows.Forms.Label lblValidaciones;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Panel panelTitulo2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNoLibroEncontrado;
        private System.Windows.Forms.Label lblNoUsuarioEncontrado;
    }
}