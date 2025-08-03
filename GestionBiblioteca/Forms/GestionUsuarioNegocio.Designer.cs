namespace GestionBiblioteca.Forms
{
    partial class GestionUsuarioNegocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarioNegocio));
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNumeroContacto = new System.Windows.Forms.TextBox();
            this.txtTipoUsuario = new System.Windows.Forms.TextBox();
            this.panelBuscarDni = new System.Windows.Forms.Panel();
            this.txtBuscarDni = new System.Windows.Forms.TextBox();
            this.panelFormRegistro = new System.Windows.Forms.Panel();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.panelContenedorLista = new System.Windows.Forms.Panel();
            this.dataGridViewListaUsuarioNegocio = new System.Windows.Forms.DataGridView();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.panelValidaciones = new System.Windows.Forms.Panel();
            this.lblValidaciones = new System.Windows.Forms.Label();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscarDni = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelBuscarDni.SuspendLayout();
            this.panelFormRegistro.SuspendLayout();
            this.panelContenedorLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaUsuarioNegocio)).BeginInit();
            this.panelValidaciones.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDni.Location = new System.Drawing.Point(15, 41);
            this.txtDni.Multiline = true;
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(190, 31);
            this.txtDni.TabIndex = 0;
            this.txtDni.Text = "txtDni";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNombre.Location = new System.Drawing.Point(15, 91);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(190, 31);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "txtNombre";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(15, 141);
            this.txtApellidoPaterno.Multiline = true;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.ReadOnly = true;
            this.txtApellidoPaterno.Size = new System.Drawing.Size(190, 31);
            this.txtApellidoPaterno.TabIndex = 2;
            this.txtApellidoPaterno.Text = "txtApellidoPaterno";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCorreo.Location = new System.Drawing.Point(15, 241);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(190, 31);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.Text = "txtCorreo";
            // 
            // txtNumeroContacto
            // 
            this.txtNumeroContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtNumeroContacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroContacto.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroContacto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNumeroContacto.Location = new System.Drawing.Point(15, 291);
            this.txtNumeroContacto.Multiline = true;
            this.txtNumeroContacto.Name = "txtNumeroContacto";
            this.txtNumeroContacto.Size = new System.Drawing.Size(190, 31);
            this.txtNumeroContacto.TabIndex = 4;
            this.txtNumeroContacto.Text = "txtNumeroContacto";
            // 
            // txtTipoUsuario
            // 
            this.txtTipoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtTipoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoUsuario.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTipoUsuario.Location = new System.Drawing.Point(15, 344);
            this.txtTipoUsuario.Multiline = true;
            this.txtTipoUsuario.Name = "txtTipoUsuario";
            this.txtTipoUsuario.Size = new System.Drawing.Size(190, 31);
            this.txtTipoUsuario.TabIndex = 5;
            this.txtTipoUsuario.Text = "txtTipoUsuario";
            // 
            // panelBuscarDni
            // 
            this.panelBuscarDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelBuscarDni.Controls.Add(this.btnBuscarDni);
            this.panelBuscarDni.Controls.Add(this.txtBuscarDni);
            this.panelBuscarDni.Location = new System.Drawing.Point(18, 86);
            this.panelBuscarDni.Name = "panelBuscarDni";
            this.panelBuscarDni.Size = new System.Drawing.Size(222, 69);
            this.panelBuscarDni.TabIndex = 6;
            // 
            // txtBuscarDni
            // 
            this.txtBuscarDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtBuscarDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarDni.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarDni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBuscarDni.Location = new System.Drawing.Point(12, 20);
            this.txtBuscarDni.Multiline = true;
            this.txtBuscarDni.Name = "txtBuscarDni";
            this.txtBuscarDni.Size = new System.Drawing.Size(154, 31);
            this.txtBuscarDni.TabIndex = 0;
            this.txtBuscarDni.Text = "txtBuscarDni";
            // 
            // panelFormRegistro
            // 
            this.panelFormRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelFormRegistro.Controls.Add(this.label7);
            this.panelFormRegistro.Controls.Add(this.label6);
            this.panelFormRegistro.Controls.Add(this.label5);
            this.panelFormRegistro.Controls.Add(this.label4);
            this.panelFormRegistro.Controls.Add(this.label3);
            this.panelFormRegistro.Controls.Add(this.label2);
            this.panelFormRegistro.Controls.Add(this.label1);
            this.panelFormRegistro.Controls.Add(this.txtApellidoMaterno);
            this.panelFormRegistro.Controls.Add(this.txtDni);
            this.panelFormRegistro.Controls.Add(this.txtNombre);
            this.panelFormRegistro.Controls.Add(this.txtTipoUsuario);
            this.panelFormRegistro.Controls.Add(this.txtApellidoPaterno);
            this.panelFormRegistro.Controls.Add(this.txtNumeroContacto);
            this.panelFormRegistro.Controls.Add(this.txtCorreo);
            this.panelFormRegistro.Location = new System.Drawing.Point(15, 170);
            this.panelFormRegistro.Name = "panelFormRegistro";
            this.panelFormRegistro.Size = new System.Drawing.Size(225, 390);
            this.panelFormRegistro.TabIndex = 7;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(71)))), ((int)(((byte)(227)))));
            this.btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(18, 121);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(190, 35);
            this.btnEliminarUsuario.TabIndex = 9;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(71)))), ((int)(((byte)(227)))));
            this.btnEditarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarUsuario.Location = new System.Drawing.Point(18, 67);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(190, 35);
            this.btnEditarUsuario.TabIndex = 8;
            this.btnEditarUsuario.Text = "Editar Usuario";
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(15, 191);
            this.txtApellidoMaterno.Multiline = true;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.ReadOnly = true;
            this.txtApellidoMaterno.Size = new System.Drawing.Size(190, 31);
            this.txtApellidoMaterno.TabIndex = 7;
            this.txtApellidoMaterno.Text = "txtApellidoMaterno";
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(71)))), ((int)(((byte)(227)))));
            this.btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            this.btnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(18, 17);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(190, 35);
            this.btnRegistrarUsuario.TabIndex = 6;
            this.btnRegistrarUsuario.Text = "Registrar Usuario";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // panelContenedorLista
            // 
            this.panelContenedorLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelContenedorLista.Controls.Add(this.dataGridViewListaUsuarioNegocio);
            this.panelContenedorLista.Location = new System.Drawing.Point(252, 86);
            this.panelContenedorLista.Name = "panelContenedorLista";
            this.panelContenedorLista.Size = new System.Drawing.Size(936, 582);
            this.panelContenedorLista.TabIndex = 8;
            // 
            // dataGridViewListaUsuarioNegocio
            // 
            this.dataGridViewListaUsuarioNegocio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.dataGridViewListaUsuarioNegocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaUsuarioNegocio.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewListaUsuarioNegocio.Name = "dataGridViewListaUsuarioNegocio";
            this.dataGridViewListaUsuarioNegocio.Size = new System.Drawing.Size(954, 593);
            this.dataGridViewListaUsuarioNegocio.TabIndex = 0;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelBusqueda.Location = new System.Drawing.Point(252, 12);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(936, 60);
            this.panelBusqueda.TabIndex = 9;
            // 
            // panelValidaciones
            // 
            this.panelValidaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelValidaciones.Controls.Add(this.lblValidaciones);
            this.panelValidaciones.Location = new System.Drawing.Point(252, 685);
            this.panelValidaciones.Name = "panelValidaciones";
            this.panelValidaciones.Size = new System.Drawing.Size(936, 65);
            this.panelValidaciones.TabIndex = 10;
            // 
            // lblValidaciones
            // 
            this.lblValidaciones.AutoSize = true;
            this.lblValidaciones.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidaciones.Location = new System.Drawing.Point(22, 20);
            this.lblValidaciones.Name = "lblValidaciones";
            this.lblValidaciones.Size = new System.Drawing.Size(18, 19);
            this.lblValidaciones.TabIndex = 0;
            this.lblValidaciones.Text = "-";
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelAcciones.Controls.Add(this.btnEliminarUsuario);
            this.panelAcciones.Controls.Add(this.btnRegistrarUsuario);
            this.panelAcciones.Controls.Add(this.btnEditarUsuario);
            this.panelAcciones.Location = new System.Drawing.Point(13, 580);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(225, 170);
            this.panelAcciones.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(15, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipo usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(15, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Celular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label3.Location = new System.Drawing.Point(15, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label4.Location = new System.Drawing.Point(15, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ape Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label5.Location = new System.Drawing.Point(15, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ape Paterno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label6.Location = new System.Drawing.Point(15, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label7.Location = new System.Drawing.Point(15, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "DNI";
            // 
            // btnBuscarDni
            // 
            this.btnBuscarDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.btnBuscarDni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarDni.BackgroundImage")));
            this.btnBuscarDni.FlatAppearance.BorderSize = 0;
            this.btnBuscarDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDni.Location = new System.Drawing.Point(172, 20);
            this.btnBuscarDni.Name = "btnBuscarDni";
            this.btnBuscarDni.Size = new System.Drawing.Size(33, 31);
            this.btnBuscarDni.TabIndex = 1;
            this.btnBuscarDni.UseVisualStyleBackColor = false;
            this.btnBuscarDni.Click += new System.EventHandler(this.btnBuscarDni_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Registrar Usurio";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.panelTitulo.Controls.Add(this.label8);
            this.panelTitulo.Location = new System.Drawing.Point(18, 12);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(222, 60);
            this.panelTitulo.TabIndex = 23;
            // 
            // GestionUsuarioNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1200, 762);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelAcciones);
            this.Controls.Add(this.panelValidaciones);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelContenedorLista);
            this.Controls.Add(this.panelFormRegistro);
            this.Controls.Add(this.panelBuscarDni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionUsuarioNegocio";
            this.Text = "UsuarioGestion";
            this.panelBuscarDni.ResumeLayout(false);
            this.panelBuscarDni.PerformLayout();
            this.panelFormRegistro.ResumeLayout(false);
            this.panelFormRegistro.PerformLayout();
            this.panelContenedorLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaUsuarioNegocio)).EndInit();
            this.panelValidaciones.ResumeLayout(false);
            this.panelValidaciones.PerformLayout();
            this.panelAcciones.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNumeroContacto;
        private System.Windows.Forms.TextBox txtTipoUsuario;
        private System.Windows.Forms.Panel panelBuscarDni;
        private System.Windows.Forms.Button btnBuscarDni;
        private System.Windows.Forms.TextBox txtBuscarDni;
        private System.Windows.Forms.Panel panelFormRegistro;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Panel panelContenedorLista;
        private System.Windows.Forms.DataGridView dataGridViewListaUsuarioNegocio;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Panel panelValidaciones;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Label lblValidaciones;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelTitulo;
    }
}