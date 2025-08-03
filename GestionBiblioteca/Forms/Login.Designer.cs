namespace GestionBiblioteca
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblValidarLogin = new System.Windows.Forms.Label();
            this.pbxVerContrasena = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoginSistema = new System.Windows.Forms.Button();
            this.txtCrearCuenta = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.panelImgLogin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerContrasena)).BeginInit();
            this.panelImgLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblValidarLogin);
            this.panel1.Controls.Add(this.pbxVerContrasena);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLoginSistema);
            this.panel1.Controls.Add(this.txtCrearCuenta);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.txtContrasena);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 441);
            this.panel1.TabIndex = 0;
            // 
            // lblValidarLogin
            // 
            this.lblValidarLogin.AutoSize = true;
            this.lblValidarLogin.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblValidarLogin.Location = new System.Drawing.Point(50, 249);
            this.lblValidarLogin.Name = "lblValidarLogin";
            this.lblValidarLogin.Size = new System.Drawing.Size(43, 13);
            this.lblValidarLogin.TabIndex = 9;
            this.lblValidarLogin.Text = "label5";
            // 
            // pbxVerContrasena
            // 
            this.pbxVerContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.pbxVerContrasena.Image = global::GestionBiblioteca.Properties.Resources.VerContrasena;
            this.pbxVerContrasena.Location = new System.Drawing.Point(214, 209);
            this.pbxVerContrasena.Name = "pbxVerContrasena";
            this.pbxVerContrasena.Size = new System.Drawing.Size(20, 19);
            this.pbxVerContrasena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxVerContrasena.TabIndex = 7;
            this.pbxVerContrasena.TabStop = false;
            this.pbxVerContrasena.Click += new System.EventHandler(this.pbxVerContrasena_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(50, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contrasena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(50, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usurio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(46, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Iniciar Sesion";
            // 
            // btnLoginSistema
            // 
            this.btnLoginSistema.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLoginSistema.FlatAppearance.BorderSize = 0;
            this.btnLoginSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginSistema.Location = new System.Drawing.Point(50, 276);
            this.btnLoginSistema.Name = "btnLoginSistema";
            this.btnLoginSistema.Size = new System.Drawing.Size(190, 31);
            this.btnLoginSistema.TabIndex = 3;
            this.btnLoginSistema.Text = "btnLoginSistema";
            this.btnLoginSistema.UseVisualStyleBackColor = false;
            this.btnLoginSistema.Click += new System.EventHandler(this.btnLoginSistema_Click);
            // 
            // txtCrearCuenta
            // 
            this.txtCrearCuenta.AutoSize = true;
            this.txtCrearCuenta.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtCrearCuenta.Location = new System.Drawing.Point(74, 339);
            this.txtCrearCuenta.Name = "txtCrearCuenta";
            this.txtCrearCuenta.Size = new System.Drawing.Size(138, 13);
            this.txtCrearCuenta.TabIndex = 2;
            this.txtCrearCuenta.Text = "Registro usuario del sistema";
            this.txtCrearCuenta.Click += new System.EventHandler(this.txtCrearCuenta_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUsuario.Location = new System.Drawing.Point(50, 139);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(190, 31);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtContrasena.Location = new System.Drawing.Point(50, 203);
            this.txtContrasena.Multiline = true;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(190, 31);
            this.txtContrasena.TabIndex = 0;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // panelImgLogin
            // 
            this.panelImgLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.panelImgLogin.Controls.Add(this.pictureBox1);
            this.panelImgLogin.Location = new System.Drawing.Point(322, 21);
            this.panelImgLogin.Name = "panelImgLogin";
            this.panelImgLogin.Size = new System.Drawing.Size(361, 441);
            this.panelImgLogin.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-26, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 478);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(699, 483);
            this.Controls.Add(this.panelImgLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerContrasena)).EndInit();
            this.panelImgLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtCrearCuenta;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnLoginSistema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelImgLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxVerContrasena;
        private System.Windows.Forms.Label lblValidarLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}