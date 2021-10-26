
namespace TP_BdD
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
            this.btnAgregarInfoFinal = new System.Windows.Forms.Button();
            this.lblNomPelicula = new System.Windows.Forms.Label();
            this.lblGeneroPelicula = new System.Windows.Forms.Label();
            this.lblAñoPelicula = new System.Windows.Forms.Label();
            this.cmbBxGeneroPelicula = new System.Windows.Forms.ComboBox();
            this.txtAñoPelicula = new System.Windows.Forms.TextBox();
            this.txtGeneroPelicula = new System.Windows.Forms.TextBox();
            this.cmbBxAñoPelicula = new System.Windows.Forms.ComboBox();
            this.txtNomPelicula = new System.Windows.Forms.TextBox();
            this.btnAñadirAlosCmbbx = new System.Windows.Forms.Button();
            this.lblCambiarForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarInfoFinal
            // 
            this.btnAgregarInfoFinal.Location = new System.Drawing.Point(321, 361);
            this.btnAgregarInfoFinal.Name = "btnAgregarInfoFinal";
            this.btnAgregarInfoFinal.Size = new System.Drawing.Size(93, 55);
            this.btnAgregarInfoFinal.TabIndex = 0;
            this.btnAgregarInfoFinal.Text = "Agregar la información\r\n";
            this.btnAgregarInfoFinal.UseVisualStyleBackColor = true;
            this.btnAgregarInfoFinal.Click += new System.EventHandler(this.btnAgregarInfoFinal_Click);
            // 
            // lblNomPelicula
            // 
            this.lblNomPelicula.AutoSize = true;
            this.lblNomPelicula.Location = new System.Drawing.Point(266, 108);
            this.lblNomPelicula.Name = "lblNomPelicula";
            this.lblNomPelicula.Size = new System.Drawing.Size(49, 13);
            this.lblNomPelicula.TabIndex = 2;
            this.lblNomPelicula.Text = "Película:";
            // 
            // lblGeneroPelicula
            // 
            this.lblGeneroPelicula.AutoSize = true;
            this.lblGeneroPelicula.Location = new System.Drawing.Point(85, 200);
            this.lblGeneroPelicula.Name = "lblGeneroPelicula";
            this.lblGeneroPelicula.Size = new System.Drawing.Size(112, 13);
            this.lblGeneroPelicula.TabIndex = 3;
            this.lblGeneroPelicula.Text = "Género de la película:";
            // 
            // lblAñoPelicula
            // 
            this.lblAñoPelicula.AutoSize = true;
            this.lblAñoPelicula.Location = new System.Drawing.Point(101, 226);
            this.lblAñoPelicula.Name = "lblAñoPelicula";
            this.lblAñoPelicula.Size = new System.Drawing.Size(96, 13);
            this.lblAñoPelicula.TabIndex = 4;
            this.lblAñoPelicula.Text = "Año de la película:";
            // 
            // cmbBxGeneroPelicula
            // 
            this.cmbBxGeneroPelicula.FormattingEnabled = true;
            this.cmbBxGeneroPelicula.Location = new System.Drawing.Point(494, 185);
            this.cmbBxGeneroPelicula.Name = "cmbBxGeneroPelicula";
            this.cmbBxGeneroPelicula.Size = new System.Drawing.Size(121, 21);
            this.cmbBxGeneroPelicula.TabIndex = 5;
            // 
            // txtAñoPelicula
            // 
            this.txtAñoPelicula.Location = new System.Drawing.Point(203, 223);
            this.txtAñoPelicula.Name = "txtAñoPelicula";
            this.txtAñoPelicula.Size = new System.Drawing.Size(100, 20);
            this.txtAñoPelicula.TabIndex = 6;
            // 
            // txtGeneroPelicula
            // 
            this.txtGeneroPelicula.Location = new System.Drawing.Point(203, 197);
            this.txtGeneroPelicula.Name = "txtGeneroPelicula";
            this.txtGeneroPelicula.Size = new System.Drawing.Size(100, 20);
            this.txtGeneroPelicula.TabIndex = 7;
            // 
            // cmbBxAñoPelicula
            // 
            this.cmbBxAñoPelicula.FormattingEnabled = true;
            this.cmbBxAñoPelicula.Location = new System.Drawing.Point(494, 230);
            this.cmbBxAñoPelicula.Name = "cmbBxAñoPelicula";
            this.cmbBxAñoPelicula.Size = new System.Drawing.Size(121, 21);
            this.cmbBxAñoPelicula.TabIndex = 8;
            // 
            // txtNomPelicula
            // 
            this.txtNomPelicula.Location = new System.Drawing.Point(321, 105);
            this.txtNomPelicula.Name = "txtNomPelicula";
            this.txtNomPelicula.Size = new System.Drawing.Size(100, 20);
            this.txtNomPelicula.TabIndex = 9;
            // 
            // btnAñadirAlosCmbbx
            // 
            this.btnAñadirAlosCmbbx.Location = new System.Drawing.Point(494, 258);
            this.btnAñadirAlosCmbbx.Name = "btnAñadirAlosCmbbx";
            this.btnAñadirAlosCmbbx.Size = new System.Drawing.Size(128, 36);
            this.btnAñadirAlosCmbbx.TabIndex = 10;
            this.btnAñadirAlosCmbbx.Text = "(Añadir género y año de las peliculas)";
            this.btnAñadirAlosCmbbx.UseVisualStyleBackColor = true;
            this.btnAñadirAlosCmbbx.Click += new System.EventHandler(this.btnAñadirAlosCmbbx_Click);
            // 
            // lblCambiarForm
            // 
            this.lblCambiarForm.AutoSize = true;
            this.lblCambiarForm.Location = new System.Drawing.Point(318, 419);
            this.lblCambiarForm.Name = "lblCambiarForm";
            this.lblCambiarForm.Size = new System.Drawing.Size(106, 13);
            this.lblCambiarForm.TabIndex = 11;
            this.lblCambiarForm.Text = "Cambiar al buscador:";
            this.lblCambiarForm.Click += new System.EventHandler(this.lblCambiarForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 516);
            this.Controls.Add(this.lblCambiarForm);
            this.Controls.Add(this.btnAñadirAlosCmbbx);
            this.Controls.Add(this.txtNomPelicula);
            this.Controls.Add(this.cmbBxAñoPelicula);
            this.Controls.Add(this.txtGeneroPelicula);
            this.Controls.Add(this.txtAñoPelicula);
            this.Controls.Add(this.cmbBxGeneroPelicula);
            this.Controls.Add(this.lblAñoPelicula);
            this.Controls.Add(this.lblGeneroPelicula);
            this.Controls.Add(this.lblNomPelicula);
            this.Controls.Add(this.btnAgregarInfoFinal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarInfoFinal;
        private System.Windows.Forms.Label lblNomPelicula;
        private System.Windows.Forms.Label lblGeneroPelicula;
        private System.Windows.Forms.Label lblAñoPelicula;
        private System.Windows.Forms.ComboBox cmbBxGeneroPelicula;
        private System.Windows.Forms.TextBox txtAñoPelicula;
        private System.Windows.Forms.TextBox txtGeneroPelicula;
        private System.Windows.Forms.ComboBox cmbBxAñoPelicula;
        private System.Windows.Forms.TextBox txtNomPelicula;
        private System.Windows.Forms.Button btnAñadirAlosCmbbx;
        private System.Windows.Forms.Label lblCambiarForm;
    }
}

