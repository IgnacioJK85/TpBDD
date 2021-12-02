
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
            this.lblVolverMenú = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAñoPelicula
            // 
            this.cmbAñoPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAñoPelicula.FormattingEnabled = true;
            this.cmbAñoPelicula.Location = new System.Drawing.Point(571, 143);
            this.cmbAñoPelicula.Name = "cmbAñoPelicula";
            this.cmbAñoPelicula.Size = new System.Drawing.Size(121, 28);
            this.cmbAñoPelicula.TabIndex = 0;
            // 
            // cmbGeneroPelicula
            // 
            this.cmbGeneroPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGeneroPelicula.FormattingEnabled = true;
            this.cmbGeneroPelicula.Location = new System.Drawing.Point(571, 192);
            this.cmbGeneroPelicula.Name = "cmbGeneroPelicula";
            this.cmbGeneroPelicula.Size = new System.Drawing.Size(121, 28);
            this.cmbGeneroPelicula.TabIndex = 1;
            // 
            // txtNomPelicula
            // 
            this.txtNomPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomPelicula.Location = new System.Drawing.Point(571, 94);
            this.txtNomPelicula.Name = "txtNomPelicula";
            this.txtNomPelicula.Size = new System.Drawing.Size(121, 26);
            this.txtNomPelicula.TabIndex = 2;
            // 
            // btnAgregarPelicula
            // 
            this.btnAgregarPelicula.BackColor = System.Drawing.Color.Red;
            this.btnAgregarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPelicula.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarPelicula.Location = new System.Drawing.Point(535, 272);
            this.btnAgregarPelicula.Name = "btnAgregarPelicula";
            this.btnAgregarPelicula.Size = new System.Drawing.Size(111, 66);
            this.btnAgregarPelicula.TabIndex = 3;
            this.btnAgregarPelicula.Text = "Agregar Pelicula";
            this.btnAgregarPelicula.UseVisualStyleBackColor = false;
            this.btnAgregarPelicula.Click += new System.EventHandler(this.btnAgregarPelicula_Click);
            // 
            // lblNomPelicula
            // 
            this.lblNomPelicula.AutoSize = true;
            this.lblNomPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPelicula.Location = new System.Drawing.Point(404, 94);
            this.lblNomPelicula.Name = "lblNomPelicula";
            this.lblNomPelicula.Size = new System.Drawing.Size(161, 20);
            this.lblNomPelicula.TabIndex = 4;
            this.lblNomPelicula.Text = "Nombre de la Pelicula";
            // 
            // lblGeneroPelicula
            // 
            this.lblGeneroPelicula.AutoSize = true;
            this.lblGeneroPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroPelicula.Location = new System.Drawing.Point(408, 141);
            this.lblGeneroPelicula.Name = "lblGeneroPelicula";
            this.lblGeneroPelicula.Size = new System.Drawing.Size(159, 20);
            this.lblGeneroPelicula.TabIndex = 5;
            this.lblGeneroPelicula.Text = "Genero de la Pelicula";
            // 
            // lblAñoPelicula
            // 
            this.lblAñoPelicula.AutoSize = true;
            this.lblAñoPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoPelicula.Location = new System.Drawing.Point(418, 190);
            this.lblAñoPelicula.Name = "lblAñoPelicula";
            this.lblAñoPelicula.Size = new System.Drawing.Size(138, 20);
            this.lblAñoPelicula.TabIndex = 6;
            this.lblAñoPelicula.Text = "Año de la Pelicula:";
            // 
            // btnAgregarALosCmb
            // 
            this.btnAgregarALosCmb.BackColor = System.Drawing.Color.Red;
            this.btnAgregarALosCmb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarALosCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarALosCmb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarALosCmb.Location = new System.Drawing.Point(130, 256);
            this.btnAgregarALosCmb.Name = "btnAgregarALosCmb";
            this.btnAgregarALosCmb.Size = new System.Drawing.Size(149, 82);
            this.btnAgregarALosCmb.TabIndex = 7;
            this.btnAgregarALosCmb.Text = "Agregar información a las listas";
            this.btnAgregarALosCmb.UseVisualStyleBackColor = false;
            this.btnAgregarALosCmb.Click += new System.EventHandler(this.btnAgregarALosCmb_Click);
            // 
            // txtAñoPelicula
            // 
            this.txtAñoPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAñoPelicula.Location = new System.Drawing.Point(223, 143);
            this.txtAñoPelicula.Name = "txtAñoPelicula";
            this.txtAñoPelicula.Size = new System.Drawing.Size(100, 26);
            this.txtAñoPelicula.TabIndex = 8;
            // 
            // txtGeneroPelicula
            // 
            this.txtGeneroPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneroPelicula.Location = new System.Drawing.Point(223, 190);
            this.txtGeneroPelicula.Name = "txtGeneroPelicula";
            this.txtGeneroPelicula.Size = new System.Drawing.Size(100, 26);
            this.txtGeneroPelicula.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Genero a añadir a las listas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Año a añadir a las listas";
            // 
            // lblVolverMenú
            // 
            this.lblVolverMenú.AutoSize = true;
            this.lblVolverMenú.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolverMenú.Location = new System.Drawing.Point(12, 9);
            this.lblVolverMenú.Name = "lblVolverMenú";
            this.lblVolverMenú.Size = new System.Drawing.Size(113, 20);
            this.lblVolverMenú.TabIndex = 15;
            this.lblVolverMenú.Text = "Volver al menú";
            this.lblVolverMenú.Click += new System.EventHandler(this.lblVolverMenú_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(70, 397);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "label3";
            this.lblID.Visible = false;
            // 
            // frmAgregarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblVolverMenú);
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
            this.Text = "Añadidor De Películas";
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
        private System.Windows.Forms.Label lblVolverMenú;
        private System.Windows.Forms.Label lblID;
    }
}