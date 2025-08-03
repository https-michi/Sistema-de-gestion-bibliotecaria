namespace GestionBiblioteca.Forms
{
    partial class GestionPrestamos
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
            this.panelFormPrestamo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxActualizarEstadoDePrestamo = new System.Windows.Forms.CheckBox();
            this.lblNoUsuarioEncontrado = new System.Windows.Forms.Label();
            this.lblNoLibroEncontrado = new System.Windows.Forms.Label();
            this.lblUsuarioSeleccionado = new System.Windows.Forms.Label();
            this.lblLibroSeleccionado = new System.Windows.Forms.Label();
            this.listBoxUsuarios = new System.Windows.Forms.ListBox();
            this.listBoxLibros = new System.Windows.Forms.ListBox();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.txtBuscarLibro = new System.Windows.Forms.TextBox();
            this.dtpFechaPrestamo = new System.Windows.Forms.MonthCalendar();
            this.dtpFechaDevolucion = new System.Windows.Forms.MonthCalendar();
            this.btnAsignarUsuario = new System.Windows.Forms.Button();
            this.btnAsignarLibro = new System.Windows.Forms.Button();
            this.btnDeshacerPrestamo = new System.Windows.Forms.Button();
            this.btnAcatualizarPrestamo = new System.Windows.Forms.Button();
            this.btnAgregarPrestamo = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelListaPrestamo = new System.Windows.Forms.Panel();
            this.dataGridViewListaPrestamos = new System.Windows.Forms.DataGridView();
            this.panelValidaciones = new System.Windows.Forms.Panel();
            this.lblValidaciones = new System.Windows.Forms.Label();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.panelFormPrestamo.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelListaPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPrestamos)).BeginInit();
            this.panelValidaciones.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormPrestamo
            // 
            this.panelFormPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelFormPrestamo.Controls.Add(this.label1);
            this.panelFormPrestamo.Controls.Add(this.label6);
            this.panelFormPrestamo.Controls.Add(this.checkBoxActualizarEstadoDePrestamo);
            this.panelFormPrestamo.Controls.Add(this.lblNoUsuarioEncontrado);
            this.panelFormPrestamo.Controls.Add(this.lblNoLibroEncontrado);
            this.panelFormPrestamo.Controls.Add(this.lblUsuarioSeleccionado);
            this.panelFormPrestamo.Controls.Add(this.lblLibroSeleccionado);
            this.panelFormPrestamo.Controls.Add(this.listBoxUsuarios);
            this.panelFormPrestamo.Controls.Add(this.listBoxLibros);
            this.panelFormPrestamo.Controls.Add(this.txtBuscarUsuario);
            this.panelFormPrestamo.Controls.Add(this.txtBuscarLibro);
            this.panelFormPrestamo.Controls.Add(this.dtpFechaPrestamo);
            this.panelFormPrestamo.Controls.Add(this.dtpFechaDevolucion);
            this.panelFormPrestamo.Controls.Add(this.btnAsignarUsuario);
            this.panelFormPrestamo.Controls.Add(this.btnAsignarLibro);
            this.panelFormPrestamo.Location = new System.Drawing.Point(15, 134);
            this.panelFormPrestamo.Name = "panelFormPrestamo";
            this.panelFormPrestamo.Size = new System.Drawing.Size(499, 531);
            this.panelFormPrestamo.TabIndex = 0;
            this.panelFormPrestamo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormPrestamo_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(271, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ingrese Nombre del Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label6.Location = new System.Drawing.Point(33, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ingrese Nombre del Libro";
            // 
            // checkBoxActualizarEstadoDePrestamo
            // 
            this.checkBoxActualizarEstadoDePrestamo.AutoSize = true;
            this.checkBoxActualizarEstadoDePrestamo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActualizarEstadoDePrestamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxActualizarEstadoDePrestamo.Location = new System.Drawing.Point(17, 475);
            this.checkBoxActualizarEstadoDePrestamo.Name = "checkBoxActualizarEstadoDePrestamo";
            this.checkBoxActualizarEstadoDePrestamo.Size = new System.Drawing.Size(259, 22);
            this.checkBoxActualizarEstadoDePrestamo.TabIndex = 16;
            this.checkBoxActualizarEstadoDePrestamo.Text = "Actualizar Estado De Prestamo";
            this.checkBoxActualizarEstadoDePrestamo.UseVisualStyleBackColor = true;
            // 
            // lblNoUsuarioEncontrado
            // 
            this.lblNoUsuarioEncontrado.AutoSize = true;
            this.lblNoUsuarioEncontrado.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoUsuarioEncontrado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoUsuarioEncontrado.Location = new System.Drawing.Point(271, 245);
            this.lblNoUsuarioEncontrado.Name = "lblNoUsuarioEncontrado";
            this.lblNoUsuarioEncontrado.Size = new System.Drawing.Size(154, 15);
            this.lblNoUsuarioEncontrado.TabIndex = 14;
            this.lblNoUsuarioEncontrado.Text = "Usuario no encontrado";
            this.lblNoUsuarioEncontrado.Click += new System.EventHandler(this.lblNoUsuarioEncontrado_Click);
            // 
            // lblNoLibroEncontrado
            // 
            this.lblNoLibroEncontrado.AutoSize = true;
            this.lblNoLibroEncontrado.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoLibroEncontrado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoLibroEncontrado.Location = new System.Drawing.Point(33, 245);
            this.lblNoLibroEncontrado.Name = "lblNoLibroEncontrado";
            this.lblNoLibroEncontrado.Size = new System.Drawing.Size(147, 15);
            this.lblNoLibroEncontrado.TabIndex = 13;
            this.lblNoLibroEncontrado.Text = "Libro no encontrado ";
            this.lblNoLibroEncontrado.Click += new System.EventHandler(this.lblNoLibroEncontrado_Click);
            // 
            // lblUsuarioSeleccionado
            // 
            this.lblUsuarioSeleccionado.AutoSize = true;
            this.lblUsuarioSeleccionado.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioSeleccionado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuarioSeleccionado.Location = new System.Drawing.Point(268, 129);
            this.lblUsuarioSeleccionado.Name = "lblUsuarioSeleccionado";
            this.lblUsuarioSeleccionado.Size = new System.Drawing.Size(128, 18);
            this.lblUsuarioSeleccionado.TabIndex = 12;
            this.lblUsuarioSeleccionado.Text = "No Seleccionado";
            // 
            // lblLibroSeleccionado
            // 
            this.lblLibroSeleccionado.AutoSize = true;
            this.lblLibroSeleccionado.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibroSeleccionado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLibroSeleccionado.Location = new System.Drawing.Point(33, 129);
            this.lblLibroSeleccionado.Name = "lblLibroSeleccionado";
            this.lblLibroSeleccionado.Size = new System.Drawing.Size(128, 18);
            this.lblLibroSeleccionado.TabIndex = 11;
            this.lblLibroSeleccionado.Text = "No Seleccionado";
            // 
            // listBoxUsuarios
            // 
            this.listBoxUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.listBoxUsuarios.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxUsuarios.FormattingEnabled = true;
            this.listBoxUsuarios.ItemHeight = 18;
            this.listBoxUsuarios.Location = new System.Drawing.Point(271, 150);
            this.listBoxUsuarios.Name = "listBoxUsuarios";
            this.listBoxUsuarios.Size = new System.Drawing.Size(190, 94);
            this.listBoxUsuarios.TabIndex = 8;
            this.listBoxUsuarios.SelectedIndexChanged += new System.EventHandler(this.listBoxUsuarios_SelectedIndexChanged);
            // 
            // listBoxLibros
            // 
            this.listBoxLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.listBoxLibros.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLibros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxLibros.FormattingEnabled = true;
            this.listBoxLibros.ItemHeight = 18;
            this.listBoxLibros.Location = new System.Drawing.Point(33, 150);
            this.listBoxLibros.Name = "listBoxLibros";
            this.listBoxLibros.Size = new System.Drawing.Size(190, 94);
            this.listBoxLibros.TabIndex = 7;
            this.listBoxLibros.SelectedIndexChanged += new System.EventHandler(this.listBoxLibros_SelectedIndexChanged);
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtBuscarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarUsuario.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBuscarUsuario.Location = new System.Drawing.Point(271, 44);
            this.txtBuscarUsuario.Multiline = true;
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(190, 31);
            this.txtBuscarUsuario.TabIndex = 6;
            this.txtBuscarUsuario.TextChanged += new System.EventHandler(this.txtBuscarUsuario_TextChanged);
            // 
            // txtBuscarLibro
            // 
            this.txtBuscarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtBuscarLibro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarLibro.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarLibro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBuscarLibro.Location = new System.Drawing.Point(33, 44);
            this.txtBuscarLibro.Multiline = true;
            this.txtBuscarLibro.Name = "txtBuscarLibro";
            this.txtBuscarLibro.Size = new System.Drawing.Size(190, 31);
            this.txtBuscarLibro.TabIndex = 5;
            this.txtBuscarLibro.TextChanged += new System.EventHandler(this.txtBuscarLibro_TextChanged);
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(14, 287);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.TabIndex = 4;
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(254, 287);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.TabIndex = 3;
            // 
            // btnAsignarUsuario
            // 
            this.btnAsignarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(71)))), ((int)(((byte)(227)))));
            this.btnAsignarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAsignarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarUsuario.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAsignarUsuario.Location = new System.Drawing.Point(271, 91);
            this.btnAsignarUsuario.Name = "btnAsignarUsuario";
            this.btnAsignarUsuario.Size = new System.Drawing.Size(190, 35);
            this.btnAsignarUsuario.TabIndex = 2;
            this.btnAsignarUsuario.Text = "Asignar Usuario";
            this.btnAsignarUsuario.UseVisualStyleBackColor = false;
            this.btnAsignarUsuario.Click += new System.EventHandler(this.btnAsignarUsuario_Click);
            // 
            // btnAsignarLibro
            // 
            this.btnAsignarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(71)))), ((int)(((byte)(227)))));
            this.btnAsignarLibro.FlatAppearance.BorderSize = 0;
            this.btnAsignarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarLibro.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarLibro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAsignarLibro.Location = new System.Drawing.Point(33, 91);
            this.btnAsignarLibro.Name = "btnAsignarLibro";
            this.btnAsignarLibro.Size = new System.Drawing.Size(190, 35);
            this.btnAsignarLibro.TabIndex = 1;
            this.btnAsignarLibro.Text = "Asignar Libro";
            this.btnAsignarLibro.UseVisualStyleBackColor = false;
            this.btnAsignarLibro.Click += new System.EventHandler(this.btnAsignarLibro_Click);
            // 
            // btnDeshacerPrestamo
            // 
            this.btnDeshacerPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(71)))), ((int)(((byte)(227)))));
            this.btnDeshacerPrestamo.FlatAppearance.BorderSize = 0;
            this.btnDeshacerPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshacerPrestamo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshacerPrestamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeshacerPrestamo.Location = new System.Drawing.Point(336, 15);
            this.btnDeshacerPrestamo.Name = "btnDeshacerPrestamo";
            this.btnDeshacerPrestamo.Size = new System.Drawing.Size(128, 35);
            this.btnDeshacerPrestamo.TabIndex = 17;
            this.btnDeshacerPrestamo.Text = "Deshacer Prestamo";
            this.btnDeshacerPrestamo.UseVisualStyleBackColor = false;
            this.btnDeshacerPrestamo.Click += new System.EventHandler(this.btnDeshacerPrestamo_Click);
            // 
            // btnAcatualizarPrestamo
            // 
            this.btnAcatualizarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(71)))), ((int)(((byte)(227)))));
            this.btnAcatualizarPrestamo.FlatAppearance.BorderSize = 0;
            this.btnAcatualizarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcatualizarPrestamo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcatualizarPrestamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAcatualizarPrestamo.Location = new System.Drawing.Point(186, 15);
            this.btnAcatualizarPrestamo.Name = "btnAcatualizarPrestamo";
            this.btnAcatualizarPrestamo.Size = new System.Drawing.Size(128, 35);
            this.btnAcatualizarPrestamo.TabIndex = 15;
            this.btnAcatualizarPrestamo.Text = "Actualizar Prestamo";
            this.btnAcatualizarPrestamo.UseVisualStyleBackColor = false;
            this.btnAcatualizarPrestamo.Click += new System.EventHandler(this.btnAcatualizarPrestamo_Click);
            // 
            // btnAgregarPrestamo
            // 
            this.btnAgregarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(71)))), ((int)(((byte)(227)))));
            this.btnAgregarPrestamo.FlatAppearance.BorderSize = 0;
            this.btnAgregarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPrestamo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPrestamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarPrestamo.Location = new System.Drawing.Point(33, 15);
            this.btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            this.btnAgregarPrestamo.Size = new System.Drawing.Size(128, 35);
            this.btnAgregarPrestamo.TabIndex = 10;
            this.btnAgregarPrestamo.Text = "Agregar Prestamo";
            this.btnAgregarPrestamo.UseVisualStyleBackColor = false;
            this.btnAgregarPrestamo.Click += new System.EventHandler(this.btnAgregarPrestamo_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelTitulo.Controls.Add(this.label8);
            this.panelTitulo.Location = new System.Drawing.Point(12, 30);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(499, 68);
            this.panelTitulo.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(148, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Registrar Prestamo";
            // 
            // panelListaPrestamo
            // 
            this.panelListaPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelListaPrestamo.Controls.Add(this.dataGridViewListaPrestamos);
            this.panelListaPrestamo.Location = new System.Drawing.Point(530, 12);
            this.panelListaPrestamo.Name = "panelListaPrestamo";
            this.panelListaPrestamo.Size = new System.Drawing.Size(658, 653);
            this.panelListaPrestamo.TabIndex = 2;
            // 
            // dataGridViewListaPrestamos
            // 
            this.dataGridViewListaPrestamos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.dataGridViewListaPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaPrestamos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewListaPrestamos.Name = "dataGridViewListaPrestamos";
            this.dataGridViewListaPrestamos.Size = new System.Drawing.Size(659, 662);
            this.dataGridViewListaPrestamos.TabIndex = 0;
            // 
            // panelValidaciones
            // 
            this.panelValidaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelValidaciones.Controls.Add(this.lblValidaciones);
            this.panelValidaciones.Location = new System.Drawing.Point(530, 685);
            this.panelValidaciones.Name = "panelValidaciones";
            this.panelValidaciones.Size = new System.Drawing.Size(658, 65);
            this.panelValidaciones.TabIndex = 3;
            // 
            // lblValidaciones
            // 
            this.lblValidaciones.AutoSize = true;
            this.lblValidaciones.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidaciones.Location = new System.Drawing.Point(28, 28);
            this.lblValidaciones.Name = "lblValidaciones";
            this.lblValidaciones.Size = new System.Drawing.Size(18, 19);
            this.lblValidaciones.TabIndex = 2;
            this.lblValidaciones.Text = "-";
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelAcciones.Controls.Add(this.btnDeshacerPrestamo);
            this.panelAcciones.Controls.Add(this.btnAgregarPrestamo);
            this.panelAcciones.Controls.Add(this.btnAcatualizarPrestamo);
            this.panelAcciones.Location = new System.Drawing.Point(15, 685);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(499, 65);
            this.panelAcciones.TabIndex = 4;
            // 
            // GestionPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1200, 762);
            this.Controls.Add(this.panelAcciones);
            this.Controls.Add(this.panelValidaciones);
            this.Controls.Add(this.panelListaPrestamo);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelFormPrestamo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionPrestamos";
            this.Text = "GestionPrestamos";
            this.panelFormPrestamo.ResumeLayout(false);
            this.panelFormPrestamo.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelListaPrestamo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPrestamos)).EndInit();
            this.panelValidaciones.ResumeLayout(false);
            this.panelValidaciones.PerformLayout();
            this.panelAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormPrestamo;
        private System.Windows.Forms.Button btnAsignarUsuario;
        private System.Windows.Forms.Button btnAsignarLibro;
        private System.Windows.Forms.MonthCalendar dtpFechaDevolucion;
        private System.Windows.Forms.ListBox listBoxUsuarios;
        private System.Windows.Forms.ListBox listBoxLibros;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.TextBox txtBuscarLibro;
        private System.Windows.Forms.MonthCalendar dtpFechaPrestamo;
        private System.Windows.Forms.Button btnAgregarPrestamo;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelListaPrestamo;
        private System.Windows.Forms.DataGridView dataGridViewListaPrestamos;
        private System.Windows.Forms.Panel panelValidaciones;
        private System.Windows.Forms.Label lblUsuarioSeleccionado;
        private System.Windows.Forms.Label lblLibroSeleccionado;
        private System.Windows.Forms.Label lblNoLibroEncontrado;
        private System.Windows.Forms.Label lblNoUsuarioEncontrado;
        private System.Windows.Forms.CheckBox checkBoxActualizarEstadoDePrestamo;
        private System.Windows.Forms.Button btnAcatualizarPrestamo;
        private System.Windows.Forms.Button btnDeshacerPrestamo;
        private System.Windows.Forms.Label lblValidaciones;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}