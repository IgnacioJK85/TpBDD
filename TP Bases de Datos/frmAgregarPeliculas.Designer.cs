
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
            this.cmbAñoPelicula = new System.Windows.Forms.ComboBox();
            this.cmbGeneroPelicula = new System.Windows.Forms.ComboBox();
            this.txtNomPelicula = new System.Windows.Forms.TextBox();
            this.btnAgregarPelicula = new System.Windows.Forms.Button();
            this.lblNomPelicula = new System.Windows.Forms.Label();
            this.lblGeneroPelicula = new System.Windows.Forms.Label();
            this.lblAñoPelicula = new System.Windows.Forms.Label();
            this.btnAgregarALosCmb = new System.Windows.Forms.Button();
            this.txtAñoPelicula = new System.Windows.Forms.TextBox();
            this.txtGeneroPelicula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAñoPelicula
            // 
            this.cmbAñoPelicula.FormattingEnabled = true;
            this.cmbAñoPelicula.Location = new System.Drawing.Point(495, 147);
            this.cmbAñoPelicula.Name = "cmbAñoPelicula";
            this.cmbAñoPelicula.Size = new System.Drawing.Size(121, 21);
            this.cmbAñoPelicula.TabIndex = 0;
            // 
            // cmbGeneroPelicula
            // 
            this.cmbGeneroPelicula.FormattingEnabled = true;
            this.cmbGeneroPelicula.Location = new System.Drawing.Point(495, 196);
            this.cmbGeneroPelicula.Name = "cmbGeneroPelicula";
            this.cmbGeneroPelicula.Size = new System.Drawing.Size(121, 21);
            this.cmbGeneroPelicula.TabIndex = 1;
            // 
            // txtNomPelicula
            // 
            this.txtNomPelicula.Location = new System.Drawing.Point(495, 98);
            this.txtNomPelicula.Name = "txtNomPelicula";
            this.txtNomPelicula.Size = new System.Drawing.Size(121, 20);
            this.txtNomPelicula.TabIndex = 2;
            // 
            // btnAgregarPelicula
            // 
            this.btnAgregarPelicula.Location = new System.Drawing.Point(514, 251);
            this.btnAgregarPelicula.Name = "btnAgregarPelicula";
            this.btnAgregarPelicula.Size = new System.Drawing.Size(81, 56);
            this.btnAgregarPelicula.TabIndex = 3;
            this.btnAgregarPelicula.Text = "Agregar Pelicula";
            this.btnAgregarPelicula.UseVisualStyleBackColor = true;
            this.btnAgregarPelicula.Click += new System.EventHandler(this.btnAgregarPelicula_Click);
            // 
            // lblNomPelicula
            // 
            this.lblNomPelicula.AutoSize = true;
            this.lblNomPelicula.Location = new System.Drawing.Point(381, 101);
            this.lblNomPelicula.Name = "lblNomPelicula";
            this.lblNomPelicula.Size = new System.Drawing.Size(110, 13);
            this.lblNomPelicula.TabIndex = 4;
            this.lblNomPelicula.Text = "Nombre de la Pelicula";
            // 
            // lblGeneroPelicula
            // 
            this.lblGeneroPelicula.AutoSize = true;
            this.lblGeneroPelicula.Location = new System.Drawing.Point(381, 150);
            this.lblGeneroPelicula.Name = "lblGeneroPelicula";
            this.lblGeneroPelicula.Size = new System.Drawing.Size(108, 13);
            this.lblGeneroPelicula.TabIndex = 5;
            this.lblGeneroPelicula.Text = "Genero de la Pelicula";
            // 
            // lblAñoPelicula
            // 
            this.lblAñoPelicula.AutoSize = true;
            this.lblAñoPelicula.Location = new System.Drawing.Point(381, 202);
            this.lblAñoPelicula.Name = "lblAñoPelicula";
            this.lblAñoPelicula.Size = new System.Drawing.Size(95, 13);
            this.lblAñoPelicula.TabIndex = 6;
            this.lblAñoPelicula.Text = "Año de la Pelicula:";
            // 
            // btnAgregarALosCmb
            // 
            this.btnAgregarALosCmb.Location = new System.Drawing.Point(191, 251);
            this.btnAgregarALosCmb.Name = "btnAgregarALosCmb";
            this.btnAgregarALosCmb.Size = new System.Drawing.Size(77, 56);
            this.btnAgregarALosCmb.TabIndex = 7;
            this.btnAgregarALosCmb.Text = "Agregar información a las listas";
            this.btnAgregarALosCmb.UseVisualStyleBackColor = true;
            this.btnAgregarALosCmb.Click += new System.EventHandler(this.btnAgregarALosCmb_Click);
            // 
            // txtAñoPelicula
            // 
            this.txtAñoPelicula.Location = new System.Drawing.Point(179, 150);
            this.txtAñoPelicula.Name = "txtAñoPelicula";
            this.txtAñoPelicula.Size = new System.Drawing.Size(100, 20);
            this.txtAñoPelicula.TabIndex = 8;
            // 
            // txtGeneroPelicula
            // 
            this.txtGeneroPelicula.Location = new System.Drawing.Point(179, 199);
            this.txtGeneroPelicula.Name = "txtGeneroPelicula";
            this.txtGeneroPelicula.Size = new System.Drawing.Size(100, 20);
            this.txtGeneroPelicula.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Genero a añadir a las listas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Año a añadir a las listas";
            // 
            // frmAgregarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGeneroPelicula);
            this.Controls.Add(this.txtAñoPelicula);
            this.Controls.Add(this.btnAgregarALosCmb);
            this.Controls.Add(this.lblAñoPelicula);
            this.Controls.Add(this.lblGeneroPelicula);
            this.Controls.Add(this.lblNomPelicula);
            this.Controls.Add(this.btnAgregarPelicula);
            this.Controls.Add(this.txtNomPelicula);
            this.Controls.Add(this.cmbGeneroPelicula);
            this.Controls.Add(this.cmbAñoPelicula);
            this.Name = "frmAgregarPeliculas";
            this.Text = "frmAgregarPeliculas";
            this.Load += new System.EventHandler(this.frmAgregarPeliculas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAñoPelicula;
        private System.Windows.Forms.ComboBox cmbGeneroPelicula;
        private System.Windows.Forms.TextBox txtNomPelicula;
        private System.Windows.Forms.Button btnAgregarPelicula;
        private System.Windows.Forms.Label lblNomPelicula;
        private System.Windows.Forms.Label lblGeneroPelicula;
        private System.Windows.Forms.Label lblAñoPelicula;
        private System.Windows.Forms.Button btnAgregarALosCmb;
        private System.Windows.Forms.TextBox txtAñoPelicula;
        private System.Windows.Forms.TextBox txtGeneroPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}