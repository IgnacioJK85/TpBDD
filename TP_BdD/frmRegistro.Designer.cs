namespace TP_BdD
{
    partial class frmRegistro
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
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.txtConfContraseña = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.chckBxMC = new System.Windows.Forms.CheckBox();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblConfContraseña = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(344, 178);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 0;
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(344, 119);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNomUsuario.TabIndex = 1;
            // 
            // txtConfContraseña
            // 
            this.txtConfContraseña.Location = new System.Drawing.Point(344, 238);
            this.txtConfContraseña.Name = "txtConfContraseña";
            this.txtConfContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtConfContraseña.TabIndex = 2;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(354, 328);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarse.TabIndex = 3;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // chckBxMC
            // 
            this.chckBxMC.AutoSize = true;
            this.chckBxMC.Location = new System.Drawing.Point(465, 278);
            this.chckBxMC.Name = "chckBxMC";
            this.chckBxMC.Size = new System.Drawing.Size(118, 17);
            this.chckBxMC.TabIndex = 4;
            this.chckBxMC.Text = "Mostrar Contraseña";
            this.chckBxMC.UseVisualStyleBackColor = true;
            this.chckBxMC.CheckedChanged += new System.EventHandler(this.chckBxMC_CheckedChanged);
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Location = new System.Drawing.Point(228, 122);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(99, 13);
            this.lblNomUsuario.TabIndex = 5;
            this.lblNomUsuario.Text = "Nombre de usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(228, 181);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 6;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblConfContraseña
            // 
            this.lblConfContraseña.AutoSize = true;
            this.lblConfContraseña.Location = new System.Drawing.Point(228, 241);
            this.lblConfContraseña.Name = "lblConfContraseña";
            this.lblConfContraseña.Size = new System.Drawing.Size(110, 13);
            this.lblConfContraseña.TabIndex = 7;
            this.lblConfContraseña.Text = "Confirmar contraseña:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(351, 389);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(83, 13);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Cambiar a Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblConfContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblNomUsuario);
            this.Controls.Add(this.chckBxMC);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.txtConfContraseña);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Name = "frmRegistro";
            this.Text = "frmRegistro";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.TextBox txtConfContraseña;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.CheckBox chckBxMC;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblConfContraseña;
        private System.Windows.Forms.Label lblLogin;
    }
}