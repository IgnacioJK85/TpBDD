namespace TP_Bases_de_Datos
{
    partial class frmAgregarPeliculas
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
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.txtGeneroPelicula = new System.Windows.Forms.TextBox();
            this.btnAñadirCmbBx = new System.Windows.Forms.Button();
            this.txtAñoPelicula = new System.Windows.Forms.TextBox();
            this.cmbBxGeneroPelicula = new System.Windows.Forms.ComboBox();
            this.cmbBxAñoPelicula = new System.Windows.Forms.ComboBox();
            this.txtNomPelicula = new System.Windows.Forms.TextBox();
            this.btnAñadirPeliculas = new System.Windows.Forms.Button();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Location = new System.Drawing.Point(30, 40);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblNomUsuario.TabIndex = 0;
            this.lblNomUsuario.Text = "label1";
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Location = new System.Drawing.Point(374, 397);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(52, 13);
            this.lblBuscador.TabIndex = 1;
            this.lblBuscador.Text = "Buscador";
            this.lblBuscador.Click += new System.EventHandler(this.lblBuscador_Click);
            // 
            // txtGeneroPelicula
            // 
            this.txtGeneroPelicula.Location = new System.Drawing.Point(612, 40);
            this.txtGeneroPelicula.Name = "txtGeneroPelicula";
            this.txtGeneroPelicula.Size = new System.Drawing.Size(100, 20);
            this.txtGeneroPelicula.TabIndex = 2;
            // 
            // btnAñadirCmbBx
            // 
            this.btnAñadirCmbBx.Location = new System.Drawing.Point(612, 128);
            this.btnAñadirCmbBx.Name = "btnAñadirCmbBx";
            this.btnAñadirCmbBx.Size = new System.Drawing.Size(100, 36);
            this.btnAñadirCmbBx.TabIndex = 4;
            this.btnAñadirCmbBx.Text = "Añadir a las listas";
            this.btnAñadirCmbBx.UseVisualStyleBackColor = true;
            this.btnAñadirCmbBx.Click += new System.EventHandler(this.btnAñadirCmbBx_Click);
            // 
            // txtAñoPelicula
            // 
            this.txtAñoPelicula.Location = new System.Drawing.Point(612, 83);
            this.txtAñoPelicula.Name = "txtAñoPelicula";
            this.txtAñoPelicula.Size = new System.Drawing.Size(100, 20);
            this.txtAñoPelicula.TabIndex = 5;
            // 
            // cmbBxGeneroPelicula
            // 
            this.cmbBxGeneroPelicula.FormattingEnabled = true;
            this.cmbBxGeneroPelicula.Location = new System.Drawing.Point(249, 196);
            this.cmbBxGeneroPelicula.Name = "cmbBxGeneroPelicula";
            this.cmbBxGeneroPelicula.Size = new System.Drawing.Size(121, 21);
            this.cmbBxGeneroPelicula.TabIndex = 8;
            // 
            // cmbBxAñoPelicula
            // 
            this.cmbBxAñoPelicula.FormattingEnabled = true;
            this.cmbBxAñoPelicula.Location = new System.Drawing.Point(249, 246);
            this.cmbBxAñoPelicula.Name = "cmbBxAñoPelicula";
            this.cmbBxAñoPelicula.Size = new System.Drawing.Size(121, 21);
            this.cmbBxAñoPelicula.TabIndex = 9;
            // 
            // txtNomPelicula
            // 
            this.txtNomPelicula.Location = new System.Drawing.Point(249, 144);
            this.txtNomPelicula.Name = "txtNomPelicula";
            this.txtNomPelicula.Size = new System.Drawing.Size(121, 20);
            this.txtNomPelicula.TabIndex = 10;
            // 
            // btnAñadirPeliculas
            // 
            this.btnAñadirPeliculas.Location = new System.Drawing.Point(260, 290);
            this.btnAñadirPeliculas.Name = "btnAñadirPeliculas";
            this.btnAñadirPeliculas.Size = new System.Drawing.Size(99, 37);
            this.btnAñadirPeliculas.TabIndex = 11;
            this.btnAñadirPeliculas.Text = "Añadir peliculas";
            this.btnAñadirPeliculas.UseVisualStyleBackColor = true;
            this.btnAñadirPeliculas.Click += new System.EventHandler(this.btnAñadirPeliculas_Click);
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(510, 86);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 12;
            this.lblAño.Text = "Año";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(510, 43);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 13;
            this.lblGenero.Text = "Genero";
            // 
            // frmAgregarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.btnAñadirPeliculas);
            this.Controls.Add(this.txtNomPelicula);
            this.Controls.Add(this.cmbBxAñoPelicula);
            this.Controls.Add(this.cmbBxGeneroPelicula);
            this.Controls.Add(this.txtAñoPelicula);
            this.Controls.Add(this.btnAñadirCmbBx);
            this.Controls.Add(this.txtGeneroPelicula);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.lblNomUsuario);
            this.Name = "frmAgregarPeliculas";
            this.Text = "Agregar Peliculas";
            this.Load += new System.EventHandler(this.frmAgregarPeliculas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.TextBox txtGeneroPelicula;
        private System.Windows.Forms.Button btnAñadirCmbBx;
        private System.Windows.Forms.TextBox txtAñoPelicula;
        private System.Windows.Forms.ComboBox cmbBxGeneroPelicula;
        private System.Windows.Forms.ComboBox cmbBxAñoPelicula;
        private System.Windows.Forms.TextBox txtNomPelicula;
        private System.Windows.Forms.Button btnAñadirPeliculas;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblGenero;
    }
}