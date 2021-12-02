
namespace TP_Bases_de_Datos
{
    partial class frmBuscador
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
            this.rbAñoPelicula = new System.Windows.Forms.RadioButton();
            this.rbGeneroPelicula = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVolverMenú = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbAñoPelicula
            // 
            this.rbAñoPelicula.AutoSize = true;
            this.rbAñoPelicula.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbAñoPelicula.Location = new System.Drawing.Point(34, 39);
            this.rbAñoPelicula.Name = "rbAñoPelicula";
            this.rbAñoPelicula.Size = new System.Drawing.Size(44, 17);
            this.rbAñoPelicula.TabIndex = 1;
            this.rbAñoPelicula.TabStop = true;
            this.rbAñoPelicula.Text = "Año";
            this.rbAñoPelicula.UseVisualStyleBackColor = false;
            // 
            // rbGeneroPelicula
            // 
            this.rbGeneroPelicula.AutoSize = true;
            this.rbGeneroPelicula.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbGeneroPelicula.Location = new System.Drawing.Point(171, 39);
            this.rbGeneroPelicula.Name = "rbGeneroPelicula";
            this.rbGeneroPelicula.Size = new System.Drawing.Size(60, 17);
            this.rbGeneroPelicula.TabIndex = 2;
            this.rbGeneroPelicula.TabStop = true;
            this.rbGeneroPelicula.Text = "Género";
            this.rbGeneroPelicula.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Controls.Add(this.rbAñoPelicula);
            this.groupBox1.Controls.Add(this.rbGeneroPelicula);
            this.groupBox1.Location = new System.Drawing.Point(241, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 98);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por...";
            // 
            // lblVolverMenú
            // 
            this.lblVolverMenú.AutoSize = true;
            this.lblVolverMenú.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolverMenú.Location = new System.Drawing.Point(12, 9);
            this.lblVolverMenú.Name = "lblVolverMenú";
            this.lblVolverMenú.Size = new System.Drawing.Size(113, 20);
            this.lblVolverMenú.TabIndex = 6;
            this.lblVolverMenú.Text = "Volver al Menú";
            this.lblVolverMenú.Click += new System.EventHandler(this.lblVolverMenú_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Gold;
            this.btnBuscar.Location = new System.Drawing.Point(586, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 31);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(196, 39);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(347, 20);
            this.txtSearchBar.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(196, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 249);
            this.dataGridView1.TabIndex = 10;
            // 
            // frmBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblVolverMenú);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBuscador";
            this.Text = "Visualizador de Películas";
            this.Load += new System.EventHandler(this.frmBuscador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbAñoPelicula;
        private System.Windows.Forms.RadioButton rbGeneroPelicula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVolverMenú;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}