namespace GestionBiblioteca.Forms
{
    partial class GestionLibro
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
            this.panelRegistroLibro = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAsignarCategoria = new System.Windows.Forms.Label();
            this.lblAsignarAutor = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarAutor = new System.Windows.Forms.Button();
            this.txtUbicacionFisica = new System.Windows.Forms.TextBox();
            this.dtpFechaPublicacion = new System.Windows.Forms.MonthCalendar();
            this.txtCopias = new System.Windows.Forms.TextBox();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.panelListaLibro = new System.Windows.Forms.Panel();
            this.dataGridViewListaLibros = new System.Windows.Forms.DataGridView();
            this.panelBusquedaLibro = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelValidaciones = new System.Windows.Forms.Panel();
            this.lblValidaciones = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.btnGuardarLibro = new System.Windows.Forms.Button();
            this.btnEditarLibro = new System.Windows.Forms.Button();
            this.panelRegistroLibro.SuspendLayout();
            this.panelListaLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaLibros)).BeginInit();
            this.panelValidaciones.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRegistroLibro
            // 
            this.panelRegistroLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelRegistroLibro.Controls.Add(this.label8);
            this.panelRegistroLibro.Controls.Add(this.label7);
            this.panelRegistroLibro.Controls.Add(this.label5);
            this.panelRegistroLibro.Controls.Add(this.label4);
            this.panelRegistroLibro.Controls.Add(this.label3);
            this.panelRegistroLibro.Controls.Add(this.label2);
            this.panelRegistroLibro.Controls.Add(this.label6);
            this.panelRegistroLibro.Controls.Add(this.label1);
            this.panelRegistroLibro.Controls.Add(this.lblAsignarCategoria);
            this.panelRegistroLibro.Controls.Add(this.lblAsignarAutor);
            this.panelRegistroLibro.Controls.Add(this.btnAgregarCategoria);
            this.panelRegistroLibro.Controls.Add(this.btnAgregarAutor);
            this.panelRegistroLibro.Controls.Add(this.txtUbicacionFisica);
            this.panelRegistroLibro.Controls.Add(this.dtpFechaPublicacion);
            this.panelRegistroLibro.Controls.Add(this.txtCopias);
            this.panelRegistroLibro.Controls.Add(this.txtEdicion);
            this.panelRegistroLibro.Controls.Add(this.txtEditorial);
            this.panelRegistroLibro.Controls.Add(this.txtISBN);
            this.panelRegistroLibro.Controls.Add(this.txtTitulo);
            this.panelRegistroLibro.Location = new System.Drawing.Point(15, 12);
            this.panelRegistroLibro.Name = "panelRegistroLibro";
            this.panelRegistroLibro.Size = new System.Drawing.Size(290, 656);
            this.panelRegistroLibro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Registrar Libro";
            // 
            // lblAsignarCategoria
            // 
            this.lblAsignarCategoria.AutoSize = true;
            this.lblAsignarCategoria.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignarCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAsignarCategoria.Location = new System.Drawing.Point(160, 604);
            this.lblAsignarCategoria.Name = "lblAsignarCategoria";
            this.lblAsignarCategoria.Size = new System.Drawing.Size(84, 15);
            this.lblAsignarCategoria.TabIndex = 19;
            this.lblAsignarCategoria.Text = "Categoria :";
            this.lblAsignarCategoria.Click += new System.EventHandler(this.AsignarCategoria_Click);
            // 
            // lblAsignarAutor
            // 
            this.lblAsignarAutor.AutoSize = true;
            this.lblAsignarAutor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignarAutor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAsignarAutor.Location = new System.Drawing.Point(160, 556);
            this.lblAsignarAutor.Name = "lblAsignarAutor";
            this.lblAsignarAutor.Size = new System.Drawing.Size(56, 15);
            this.lblAsignarAutor.TabIndex = 18;
            this.lblAsignarAutor.Text = "Autor :";
            this.lblAsignarAutor.Click += new System.EventHandler(this.lblAsignarAutor_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(71)))), ((int)(((byte)(227)))));
            this.btnAgregarCategoria.FlatAppearance.BorderSize = 0;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(23, 596);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(131, 35);
            this.btnAgregarCategoria.TabIndex = 17;
            this.btnAgregarCategoria.Text = "Asignar Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnAgregarAutor
            // 
            this.btnAgregarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(71)))), ((int)(((byte)(227)))));
            this.btnAgregarAutor.FlatAppearance.BorderSize = 0;
            this.btnAgregarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAutor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAutor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarAutor.Location = new System.Drawing.Point(23, 548);
            this.btnAgregarAutor.Name = "btnAgregarAutor";
            this.btnAgregarAutor.Size = new System.Drawing.Size(131, 35);
            this.btnAgregarAutor.TabIndex = 16;
            this.btnAgregarAutor.Text = "Asignar Autor";
            this.btnAgregarAutor.UseVisualStyleBackColor = false;
            this.btnAgregarAutor.Click += new System.EventHandler(this.btnAgregarAutor_Click);
            // 
            // txtUbicacionFisica
            // 
            this.txtUbicacionFisica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtUbicacionFisica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUbicacionFisica.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacionFisica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUbicacionFisica.Location = new System.Drawing.Point(23, 451);
            this.txtUbicacionFisica.Multiline = true;
            this.txtUbicacionFisica.Name = "txtUbicacionFisica";
            this.txtUbicacionFisica.Size = new System.Drawing.Size(190, 31);
            this.txtUbicacionFisica.TabIndex = 6;
            this.txtUbicacionFisica.Text = "txtUbicacionFisica";
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.dtpFechaPublicacion.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPublicacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(23, 261);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.TabIndex = 5;
            // 
            // txtCopias
            // 
            this.txtCopias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtCopias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCopias.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCopias.Location = new System.Drawing.Point(23, 499);
            this.txtCopias.Multiline = true;
            this.txtCopias.Name = "txtCopias";
            this.txtCopias.Size = new System.Drawing.Size(190, 31);
            this.txtCopias.TabIndex = 4;
            this.txtCopias.Text = "txtCopias";
            // 
            // txtEdicion
            // 
            this.txtEdicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtEdicion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdicion.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdicion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEdicion.Location = new System.Drawing.Point(23, 204);
            this.txtEdicion.Multiline = true;
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(190, 31);
            this.txtEdicion.TabIndex = 3;
            this.txtEdicion.Text = "txtEdicion";
            // 
            // txtEditorial
            // 
            this.txtEditorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtEditorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditorial.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEditorial.Location = new System.Drawing.Point(23, 154);
            this.txtEditorial.Multiline = true;
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(190, 31);
            this.txtEditorial.TabIndex = 2;
            this.txtEditorial.Text = "txtEditorial";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtISBN.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtISBN.Location = new System.Drawing.Point(23, 106);
            this.txtISBN.Multiline = true;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(190, 31);
            this.txtISBN.TabIndex = 1;
            this.txtISBN.Text = "txtISBN";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTitulo.Location = new System.Drawing.Point(23, 58);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(190, 31);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "txtTitulo";
            // 
            // panelListaLibro
            // 
            this.panelListaLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelListaLibro.Controls.Add(this.dataGridViewListaLibros);
            this.panelListaLibro.Location = new System.Drawing.Point(325, 90);
            this.panelListaLibro.Name = "panelListaLibro";
            this.panelListaLibro.Size = new System.Drawing.Size(863, 578);
            this.panelListaLibro.TabIndex = 1;
            // 
            // dataGridViewListaLibros
            // 
            this.dataGridViewListaLibros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.dataGridViewListaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaLibros.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewListaLibros.Name = "dataGridViewListaLibros";
            this.dataGridViewListaLibros.Size = new System.Drawing.Size(872, 589);
            this.dataGridViewListaLibros.TabIndex = 0;
            // 
            // panelBusquedaLibro
            // 
            this.panelBusquedaLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelBusquedaLibro.Location = new System.Drawing.Point(325, 12);
            this.panelBusquedaLibro.Name = "panelBusquedaLibro";
            this.panelBusquedaLibro.Size = new System.Drawing.Size(863, 60);
            this.panelBusquedaLibro.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.panel4.Location = new System.Drawing.Point(504, 827);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(715, 40);
            this.panel4.TabIndex = 3;
            // 
            // panelValidaciones
            // 
            this.panelValidaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelValidaciones.Controls.Add(this.lblValidaciones);
            this.panelValidaciones.Location = new System.Drawing.Point(325, 685);
            this.panelValidaciones.Name = "panelValidaciones";
            this.panelValidaciones.Size = new System.Drawing.Size(863, 65);
            this.panelValidaciones.TabIndex = 4;
            // 
            // lblValidaciones
            // 
            this.lblValidaciones.AutoSize = true;
            this.lblValidaciones.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidaciones.Location = new System.Drawing.Point(18, 19);
            this.lblValidaciones.Name = "lblValidaciones";
            this.lblValidaciones.Size = new System.Drawing.Size(18, 19);
            this.lblValidaciones.TabIndex = 1;
            this.lblValidaciones.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label6.Location = new System.Drawing.Point(20, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label3.Location = new System.Drawing.Point(20, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Editorial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label4.Location = new System.Drawing.Point(20, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Edicion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label5.Location = new System.Drawing.Point(20, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Publicacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label7.Location = new System.Drawing.Point(20, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ubicacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label8.Location = new System.Drawing.Point(20, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Observacion";
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelAcciones.Controls.Add(this.btnEliminarLibro);
            this.panelAcciones.Controls.Add(this.btnGuardarLibro);
            this.panelAcciones.Controls.Add(this.btnEditarLibro);
            this.panelAcciones.Location = new System.Drawing.Point(15, 685);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(290, 65);
            this.panelAcciones.TabIndex = 5;
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.FlatAppearance.BorderSize = 0;
            this.btnEliminarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLibro.Image = global::GestionBiblioteca.Properties.Resources.Eliminar2;
            this.btnEliminarLibro.Location = new System.Drawing.Point(190, 5);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(60, 49);
            this.btnEliminarLibro.TabIndex = 23;
            this.btnEliminarLibro.UseVisualStyleBackColor = true;
            this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarLibro_Click);
            // 
            // btnGuardarLibro
            // 
            this.btnGuardarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.btnGuardarLibro.FlatAppearance.BorderSize = 0;
            this.btnGuardarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarLibro.Image = global::GestionBiblioteca.Properties.Resources.Agregar2;
            this.btnGuardarLibro.Location = new System.Drawing.Point(33, 5);
            this.btnGuardarLibro.Name = "btnGuardarLibro";
            this.btnGuardarLibro.Size = new System.Drawing.Size(60, 49);
            this.btnGuardarLibro.TabIndex = 20;
            this.btnGuardarLibro.UseVisualStyleBackColor = false;
            this.btnGuardarLibro.Click += new System.EventHandler(this.btnGuardarLibro_Click);
            // 
            // btnEditarLibro
            // 
            this.btnEditarLibro.FlatAppearance.BorderSize = 0;
            this.btnEditarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarLibro.Image = global::GestionBiblioteca.Properties.Resources.Editar2;
            this.btnEditarLibro.Location = new System.Drawing.Point(115, 5);
            this.btnEditarLibro.Name = "btnEditarLibro";
            this.btnEditarLibro.Size = new System.Drawing.Size(60, 49);
            this.btnEditarLibro.TabIndex = 22;
            this.btnEditarLibro.UseVisualStyleBackColor = true;
            this.btnEditarLibro.Click += new System.EventHandler(this.btnEditarLibro_Click);
            // 
            // GestionLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1200, 762);
            this.Controls.Add(this.panelAcciones);
            this.Controls.Add(this.panelValidaciones);
            this.Controls.Add(this.panelRegistroLibro);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelBusquedaLibro);
            this.Controls.Add(this.panelListaLibro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionLibro";
            this.Text = "GestionLibro";
            this.panelRegistroLibro.ResumeLayout(false);
            this.panelRegistroLibro.PerformLayout();
            this.panelListaLibro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaLibros)).EndInit();
            this.panelValidaciones.ResumeLayout(false);
            this.panelValidaciones.PerformLayout();
            this.panelAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegistroLibro;
        private System.Windows.Forms.TextBox txtUbicacionFisica;
        private System.Windows.Forms.MonthCalendar dtpFechaPublicacion;
        private System.Windows.Forms.TextBox txtCopias;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Panel panelListaLibro;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelBusquedaLibro;
        private System.Windows.Forms.Label lblAsignarCategoria;
        private System.Windows.Forms.Label lblAsignarAutor;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnAgregarAutor;
        private System.Windows.Forms.Button btnGuardarLibro;
        private System.Windows.Forms.DataGridView dataGridViewListaLibros;
        private System.Windows.Forms.Panel panelValidaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditarLibro;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.Label lblValidaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelAcciones;
    }
}