
namespace TP_Bases_de_Datos
{
    partial class frmMenu
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
            this.btnVisualizadorPeliculas = new System.Windows.Forms.Button();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.lblNomTP = new System.Windows.Forms.Label();
            this.btnAñadidorPeliculas = new System.Windows.Forms.Button();
            this.lblSignOut = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVisualizadorPeliculas
            // 
            this.btnVisualizadorPeliculas.BackColor = System.Drawing.Color.DimGray;
            this.btnVisualizadorPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizadorPeliculas.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVisualizadorPeliculas.Location = new System.Drawing.Point(771, 285);
            this.btnVisualizadorPeliculas.Name = "btnVisualizadorPeliculas";
            this.btnVisualizadorPeliculas.Size = new System.Drawing.Size(243, 154);
            this.btnVisualizadorPeliculas.TabIndex = 1;
            this.btnVisualizadorPeliculas.Text = "Visualizador de Peliculas";
            this.btnVisualizadorPeliculas.UseVisualStyleBackColor = false;
            this.btnVisualizadorPeliculas.Click += new System.EventHandler(this.btnVisualizadorPeliculas_Click);
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNomUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUsuario.Location = new System.Drawing.Point(65, 70);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(87, 25);
            this.lblNomUsuario.TabIndex = 2;
            this.lblNomUsuario.Text = "Nombre";
            // 
            // lblNomTP
            // 
            this.lblNomTP.AutoSize = true;
            this.lblNomTP.BackColor = System.Drawing.Color.Transparent;
            this.lblNomTP.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomTP.ForeColor = System.Drawing.Color.Azure;
            this.lblNomTP.Location = new System.Drawing.Point(478, 200);
            this.lblNomTP.Name = "lblNomTP";
            this.lblNomTP.Size = new System.Drawing.Size(292, 40);
            this.lblNomTP.TabIndex = 3;
            this.lblNomTP.Text = "MoviesStatistics";
            // 
            // btnAñadidorPeliculas
            // 
            this.btnAñadidorPeliculas.BackColor = System.Drawing.Color.DimGray;
            this.btnAñadidorPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadidorPeliculas.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAñadidorPeliculas.Location = new System.Drawing.Point(197, 285);
            this.btnAñadidorPeliculas.Name = "btnAñadidorPeliculas";
            this.btnAñadidorPeliculas.Size = new System.Drawing.Size(240, 154);
            this.btnAñadidorPeliculas.TabIndex = 4;
            this.btnAñadidorPeliculas.Text = "Añadidor de Peliculas";
            this.btnAñadidorPeliculas.UseVisualStyleBackColor = false;
            this.btnAñadidorPeliculas.Click += new System.EventHandler(this.btnAñadidorPeliculas_Click);
            // 
            // lblSignOut
            // 
            this.lblSignOut.AutoSize = true;
            this.lblSignOut.BackColor = System.Drawing.Color.Transparent;
            this.lblSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignOut.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSignOut.Location = new System.Drawing.Point(1048, 49);
            this.lblSignOut.Name = "lblSignOut";
            this.lblSignOut.Size = new System.Drawing.Size(106, 20);
            this.lblSignOut.TabIndex = 5;
            this.lblSignOut.Text = "Cerrar Sesión";
            this.lblSignOut.Click += new System.EventHandler(this.lblSignOut_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Azure;
            this.lblDescripcion.Location = new System.Drawing.Point(354, 249);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(525, 20);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Elabora y visualiza distintos datos y estadisticas de tus peliculas favoritas!";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP_Bases_de_Datos.Properties.Resources.pelisexo;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblSignOut);
            this.Controls.Add(this.btnAñadidorPeliculas);
            this.Controls.Add(this.lblNomTP);
            this.Controls.Add(this.lblNomUsuario);
            this.Controls.Add(this.btnVisualizadorPeliculas);
            this.Name = "frmMenu";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVisualizadorPeliculas;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.Label lblNomTP;
        private System.Windows.Forms.Button btnAñadidorPeliculas;
        private System.Windows.Forms.Label lblSignOut;
        private System.Windows.Forms.Label lblDescripcion;
    }
}