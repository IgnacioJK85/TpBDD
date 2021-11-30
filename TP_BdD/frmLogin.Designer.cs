namespace TP_BdD
{
    partial class frmLogin
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
            this.chckBxMC = new System.Windows.Forms.CheckBox();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblCambairRegistro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chckBxMC
            // 
            this.chckBxMC.AutoSize = true;
            this.chckBxMC.Location = new System.Drawing.Point(401, 245);
            this.chckBxMC.Name = "chckBxMC";
            this.chckBxMC.Size = new System.Drawing.Size(118, 17);
            this.chckBxMC.TabIndex = 9;
            this.chckBxMC.Text = "Mostrar Contraseña";
            this.chckBxMC.UseVisualStyleBackColor = true;
            this.chckBxMC.CheckedChanged += new System.EventHandler(this.chckBxMC_CheckedChanged);
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(306, 132);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNomUsuario.TabIndex = 6;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(306, 177);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 5;
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Location = new System.Drawing.Point(201, 135);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(99, 13);
            this.lblNomUsuario.TabIndex = 10;
            this.lblNomUsuario.Text = "Nombre de usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(201, 184);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 11;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(318, 300);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 48);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblCambairRegistro
            // 
            this.lblCambairRegistro.AutoSize = true;
            this.lblCambairRegistro.Location = new System.Drawing.Point(308, 386);
            this.lblCambairRegistro.Name = "lblCambairRegistro";
            this.lblCambairRegistro.Size = new System.Drawing.Size(98, 13);
            this.lblCambairRegistro.TabIndex = 13;
            this.lblCambairRegistro.Text = "Cambiar al Registro";
            this.lblCambairRegistro.Click += new System.EventHandler(this.lblCambairRegistro_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCambairRegistro);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblNomUsuario);
            this.Controls.Add(this.chckBxMC);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chckBxMC;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblCambairRegistro;
    }
}