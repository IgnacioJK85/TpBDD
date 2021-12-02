
namespace TP_Bases_de_Datos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblConfContraseña = new System.Windows.Forms.Label();
            this.txtConfContraseña = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.chckBxMC = new System.Windows.Forms.CheckBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNomUsuario.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUsuario.Location = new System.Drawing.Point(152, 66);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(178, 24);
            this.lblNomUsuario.TabIndex = 1;
            this.lblNomUsuario.Text = "Nombre de usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContraseña.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(152, 103);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(113, 24);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(358, 103);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '●';
            this.txtContraseña.Size = new System.Drawing.Size(100, 26);
            this.txtContraseña.TabIndex = 2;
            // 
            // lblConfContraseña
            // 
            this.lblConfContraseña.AutoSize = true;
            this.lblConfContraseña.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfContraseña.Location = new System.Drawing.Point(152, 142);
            this.lblConfContraseña.Name = "lblConfContraseña";
            this.lblConfContraseña.Size = new System.Drawing.Size(200, 24);
            this.lblConfContraseña.TabIndex = 5;
            this.lblConfContraseña.Text = "Confirmar contraseña:";
            // 
            // txtConfContraseña
            // 
            this.txtConfContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfContraseña.Location = new System.Drawing.Point(358, 142);
            this.txtConfContraseña.Name = "txtConfContraseña";
            this.txtConfContraseña.PasswordChar = '●';
            this.txtConfContraseña.Size = new System.Drawing.Size(100, 26);
            this.txtConfContraseña.TabIndex = 4;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.Maroon;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.SystemColors.Info;
            this.btnRegistrarse.Location = new System.Drawing.Point(262, 213);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(125, 76);
            this.btnRegistrarse.TabIndex = 6;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomUsuario.Location = new System.Drawing.Point(358, 66);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(100, 26);
            this.txtNomUsuario.TabIndex = 7;
            // 
            // chckBxMC
            // 
            this.chckBxMC.AutoSize = true;
            this.chckBxMC.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chckBxMC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chckBxMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBxMC.ForeColor = System.Drawing.SystemColors.Info;
            this.chckBxMC.Location = new System.Drawing.Point(439, 196);
            this.chckBxMC.Name = "chckBxMC";
            this.chckBxMC.Size = new System.Drawing.Size(164, 24);
            this.chckBxMC.TabIndex = 8;
            this.chckBxMC.Text = "Mostrar contraseña";
            this.chckBxMC.UseVisualStyleBackColor = true;
            this.chckBxMC.CheckedChanged += new System.EventHandler(this.chckBxMC_CheckedChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Yellow;
            this.lblLogin.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(258, 324);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(129, 20);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "Cambiar a Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(660, 401);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.chckBxMC);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.lblConfContraseña);
            this.Controls.Add(this.txtConfContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblNomUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Regístrese";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblConfContraseña;
        private System.Windows.Forms.TextBox txtConfContraseña;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.CheckBox chckBxMC;
        private System.Windows.Forms.Label lblLogin;
    }
}

