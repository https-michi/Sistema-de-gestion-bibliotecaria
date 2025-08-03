namespace GestionBiblioteca.Forms
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.logoBiblioteca = new System.Windows.Forms.PictureBox();
            this.btnSolicitudLibro = new System.Windows.Forms.Button();
            this.btnPrestamoLibro = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGestionLibros = new System.Windows.Forms.Button();
            this.btnGestionUsuario = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMultiuso = new System.Windows.Forms.Panel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBiblioteca)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnSolicitudLibro);
            this.panelMenu.Controls.Add(this.btnPrestamoLibro);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnGestionLibros);
            this.panelMenu.Controls.Add(this.btnGestionUsuario);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Location = new System.Drawing.Point(18, 18);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(210, 835);
            this.panelMenu.TabIndex = 1;
            // 
            // logoBiblioteca
            // 
            this.logoBiblioteca.Image = ((System.Drawing.Image)(resources.GetObject("logoBiblioteca.Image")));
            this.logoBiblioteca.Location = new System.Drawing.Point(-14, -40);
            this.logoBiblioteca.Name = "logoBiblioteca";
            this.logoBiblioteca.Size = new System.Drawing.Size(215, 191);
            this.logoBiblioteca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBiblioteca.TabIndex = 5;
            this.logoBiblioteca.TabStop = false;
            this.logoBiblioteca.Tag = "Logo";
            this.logoBiblioteca.Click += new System.EventHandler(this.logoBiblioteca_Click);
            // 
            // btnSolicitudLibro
            // 
            this.btnSolicitudLibro.FlatAppearance.BorderSize = 0;
            this.btnSolicitudLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitudLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnSolicitudLibro.Image = ((System.Drawing.Image)(resources.GetObject("btnSolicitudLibro.Image")));
            this.btnSolicitudLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolicitudLibro.Location = new System.Drawing.Point(23, 466);
            this.btnSolicitudLibro.Name = "btnSolicitudLibro";
            this.btnSolicitudLibro.Size = new System.Drawing.Size(165, 42);
            this.btnSolicitudLibro.TabIndex = 9;
            this.btnSolicitudLibro.Tag = "Libro";
            this.btnSolicitudLibro.Text = "Solicitud";
            this.btnSolicitudLibro.UseVisualStyleBackColor = true;
            this.btnSolicitudLibro.Click += new System.EventHandler(this.btnSolicitudLibro_Click);
            // 
            // btnPrestamoLibro
            // 
            this.btnPrestamoLibro.FlatAppearance.BorderSize = 0;
            this.btnPrestamoLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamoLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnPrestamoLibro.Image = global::GestionBiblioteca.Properties.Resources.Prestamoo;
            this.btnPrestamoLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamoLibro.Location = new System.Drawing.Point(23, 402);
            this.btnPrestamoLibro.Name = "btnPrestamoLibro";
            this.btnPrestamoLibro.Size = new System.Drawing.Size(165, 42);
            this.btnPrestamoLibro.TabIndex = 8;
            this.btnPrestamoLibro.Tag = "Libro";
            this.btnPrestamoLibro.Text = "Prestamo";
            this.btnPrestamoLibro.UseVisualStyleBackColor = true;
            this.btnPrestamoLibro.Click += new System.EventHandler(this.btnPrestamoLibro_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.btnMenu.Image = global::GestionBiblioteca.Properties.Resources.Hamburguesa;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(23, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(165, 36);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Tag = "";
            this.btnMenu.Text = "x";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnSalir.Image = global::GestionBiblioteca.Properties.Resources.Salir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(23, 718);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(165, 47);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Tag = "Salir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGestionLibros
            // 
            this.btnGestionLibros.FlatAppearance.BorderSize = 0;
            this.btnGestionLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionLibros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnGestionLibros.Image = global::GestionBiblioteca.Properties.Resources.Libro;
            this.btnGestionLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionLibros.Location = new System.Drawing.Point(23, 341);
            this.btnGestionLibros.Name = "btnGestionLibros";
            this.btnGestionLibros.Size = new System.Drawing.Size(165, 42);
            this.btnGestionLibros.TabIndex = 2;
            this.btnGestionLibros.Tag = "Libro";
            this.btnGestionLibros.Text = "Libro";
            this.btnGestionLibros.UseVisualStyleBackColor = true;
            this.btnGestionLibros.Click += new System.EventHandler(this.btnGestionLibros_Click);
            // 
            // btnGestionUsuario
            // 
            this.btnGestionUsuario.FlatAppearance.BorderSize = 0;
            this.btnGestionUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnGestionUsuario.Image = global::GestionBiblioteca.Properties.Resources.Usuario;
            this.btnGestionUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionUsuario.Location = new System.Drawing.Point(23, 283);
            this.btnGestionUsuario.Name = "btnGestionUsuario";
            this.btnGestionUsuario.Size = new System.Drawing.Size(165, 38);
            this.btnGestionUsuario.TabIndex = 1;
            this.btnGestionUsuario.Tag = "Usuario";
            this.btnGestionUsuario.Text = "Usuario";
            this.btnGestionUsuario.UseVisualStyleBackColor = true;
            this.btnGestionUsuario.Click += new System.EventHandler(this.btnGestionUsuario_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnHome.Image = global::GestionBiblioteca.Properties.Resources.Home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(23, 230);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(165, 36);
            this.btnHome.TabIndex = 0;
            this.btnHome.Tag = "Home";
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Location = new System.Drawing.Point(1285, 18);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(163, 57);
            this.panelBarraTitulo.TabIndex = 2;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::GestionBiblioteca.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(127, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::GestionBiblioteca.Properties.Resources.minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(19, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Image = global::GestionBiblioteca.Properties.Resources.maximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(74, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.panelContenedor.Location = new System.Drawing.Point(248, 91);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1200, 762);
            this.panelContenedor.TabIndex = 3;
            // 
            // panelMultiuso
            // 
            this.panelMultiuso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.panelMultiuso.Location = new System.Drawing.Point(248, 18);
            this.panelMultiuso.Name = "panelMultiuso";
            this.panelMultiuso.Size = new System.Drawing.Size(1018, 57);
            this.panelMultiuso.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoBiblioteca);
            this.panel1.Location = new System.Drawing.Point(23, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 109);
            this.panel1.TabIndex = 10;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1466, 872);
            this.Controls.Add(this.panelMultiuso);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBiblioteca)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnGestionUsuario;
        private System.Windows.Forms.Button btnGestionLibros;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox logoBiblioteca;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelMultiuso;
        private System.Windows.Forms.Button btnPrestamoLibro;
        private System.Windows.Forms.Button btnSolicitudLibro;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel1;
    }
}