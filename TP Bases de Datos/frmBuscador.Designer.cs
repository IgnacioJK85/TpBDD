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
            this.txtBarraBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGVMostrador = new System.Windows.Forms.DataGridView();
            this.chckBxFiltrarGenero = new System.Windows.Forms.CheckBox();
            this.chckBxFiltrarAño = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMostrador)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarraBuscador
            // 
            this.txtBarraBuscador.Location = new System.Drawing.Point(160, 46);
            this.txtBarraBuscador.Name = "txtBarraBuscador";
            this.txtBarraBuscador.Size = new System.Drawing.Size(310, 20);
            this.txtBarraBuscador.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(524, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGVMostrador
            // 
            this.dataGVMostrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVMostrador.Location = new System.Drawing.Point(268, 188);
            this.dataGVMostrador.Name = "dataGVMostrador";
            this.dataGVMostrador.Size = new System.Drawing.Size(240, 150);
            this.dataGVMostrador.TabIndex = 2;
            // 
            // chckBxFiltrarGenero
            // 
            this.chckBxFiltrarGenero.AutoSize = true;
            this.chckBxFiltrarGenero.Location = new System.Drawing.Point(160, 108);
            this.chckBxFiltrarGenero.Name = "chckBxFiltrarGenero";
            this.chckBxFiltrarGenero.Size = new System.Drawing.Size(105, 17);
            this.chckBxFiltrarGenero.TabIndex = 3;
            this.chckBxFiltrarGenero.Text = "Filtrar por genero";
            this.chckBxFiltrarGenero.UseVisualStyleBackColor = true;
            // 
            // chckBxFiltrarAño
            // 
            this.chckBxFiltrarAño.AutoSize = true;
            this.chckBxFiltrarAño.Location = new System.Drawing.Point(519, 108);
            this.chckBxFiltrarAño.Name = "chckBxFiltrarAño";
            this.chckBxFiltrarAño.Size = new System.Drawing.Size(90, 17);
            this.chckBxFiltrarAño.TabIndex = 4;
            this.chckBxFiltrarAño.Text = "Filtrar por año";
            this.chckBxFiltrarAño.UseVisualStyleBackColor = true;
            // 
            // frmBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chckBxFiltrarAño);
            this.Controls.Add(this.chckBxFiltrarGenero);
            this.Controls.Add(this.dataGVMostrador);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBarraBuscador);
            this.Name = "frmBuscador";
            this.Text = "Buscador";
            this.Load += new System.EventHandler(this.frmBuscador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMostrador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarraBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGVMostrador;
        private System.Windows.Forms.CheckBox chckBxFiltrarGenero;
        private System.Windows.Forms.CheckBox chckBxFiltrarAño;
    }
}