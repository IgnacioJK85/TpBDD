namespace TPBaseDeDatos
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.cmbbxTipo = new System.Windows.Forms.ComboBox();
            this.txtTipoDePelicula = new System.Windows.Forms.TextBox();
            this.lblCambiarForm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(336, 344);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(325, 167);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(100, 20);
            this.txtPelicula.TabIndex = 2;
            // 
            // cmbbxTipo
            // 
            this.cmbbxTipo.FormattingEnabled = true;
            this.cmbbxTipo.Location = new System.Drawing.Point(445, 255);
            this.cmbbxTipo.Name = "cmbbxTipo";
            this.cmbbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbbxTipo.TabIndex = 3;
            // 
            // txtTipoDePelicula
            // 
            this.txtTipoDePelicula.Location = new System.Drawing.Point(189, 256);
            this.txtTipoDePelicula.Name = "txtTipoDePelicula";
            this.txtTipoDePelicula.Size = new System.Drawing.Size(100, 20);
            this.txtTipoDePelicula.TabIndex = 4;
            // 
            // lblCambiarForm
            // 
            this.lblCambiarForm.AutoSize = true;
            this.lblCambiarForm.Location = new System.Drawing.Point(322, 457);
            this.lblCambiarForm.Name = "lblCambiarForm";
            this.lblCambiarForm.Size = new System.Drawing.Size(103, 13);
            this.lblCambiarForm.TabIndex = 5;
            this.lblCambiarForm.Text = "Cambiar al buscador";
            this.lblCambiarForm.Click += new System.EventHandler(this.lblCambiarForm_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(149, 303);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 13);
            this.lblAno.TabIndex = 7;
            this.lblAno.Text = "Año:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(138, 258);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 8;
            this.lblGenero.Text = "Genero:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 520);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCambiarForm);
            this.Controls.Add(this.txtTipoDePelicula);
            this.Controls.Add(this.cmbbxTipo);
            this.Controls.Add(this.txtPelicula);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.ComboBox cmbbxTipo;
        private System.Windows.Forms.TextBox txtTipoDePelicula;
        private System.Windows.Forms.Label lblCambiarForm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblGenero;
    }
}

