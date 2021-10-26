
namespace TP_BdD
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
            this.lblBuscador = new System.Windows.Forms.Label();
            this.chckbxAño = new System.Windows.Forms.CheckBox();
            this.chckbxGenero = new System.Windows.Forms.CheckBox();
            this.dataGDMostrador = new System.Windows.Forms.DataGridView();
            this.ColumnaPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBarraBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGDMostrador)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Location = new System.Drawing.Point(127, 53);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(43, 13);
            this.lblBuscador.TabIndex = 5;
            this.lblBuscador.Text = "Buscar:";
            // 
            // chckbxAño
            // 
            this.chckbxAño.AutoSize = true;
            this.chckbxAño.Location = new System.Drawing.Point(105, 149);
            this.chckbxAño.Name = "chckbxAño";
            this.chckbxAño.Size = new System.Drawing.Size(143, 17);
            this.chckbxAño.TabIndex = 6;
            this.chckbxAño.Text = "Filtrar búsqueda por año:";
            this.chckbxAño.UseVisualStyleBackColor = true;
            this.chckbxAño.CheckedChanged += new System.EventHandler(this.chckbxAño_CheckedChanged);
            // 
            // chckbxGenero
            // 
            this.chckbxGenero.AutoSize = true;
            this.chckbxGenero.Location = new System.Drawing.Point(535, 149);
            this.chckbxGenero.Name = "chckbxGenero";
            this.chckbxGenero.Size = new System.Drawing.Size(158, 17);
            this.chckbxGenero.TabIndex = 7;
            this.chckbxGenero.Text = "Filtrar búsqueda por género:";
            this.chckbxGenero.UseVisualStyleBackColor = true;
            this.chckbxGenero.CheckedChanged += new System.EventHandler(this.chckbxGenero_CheckedChanged);
            // 
            // dataGDMostrador
            // 
            this.dataGDMostrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGDMostrador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaPelicula,
            this.ColumnaGenero,
            this.ColumnaAño});
            this.dataGDMostrador.Location = new System.Drawing.Point(190, 212);
            this.dataGDMostrador.Name = "dataGDMostrador";
            this.dataGDMostrador.Size = new System.Drawing.Size(345, 242);
            this.dataGDMostrador.TabIndex = 8;
            // 
            // ColumnaPelicula
            // 
            this.ColumnaPelicula.HeaderText = "Pelicula";
            this.ColumnaPelicula.Name = "ColumnaPelicula";
            // 
            // ColumnaGenero
            // 
            this.ColumnaGenero.HeaderText = "Genero";
            this.ColumnaGenero.Name = "ColumnaGenero";
            // 
            // ColumnaAño
            // 
            this.ColumnaAño.HeaderText = "Año";
            this.ColumnaAño.Name = "ColumnaAño";
            // 
            // txtBarraBuscador
            // 
            this.txtBarraBuscador.Location = new System.Drawing.Point(216, 53);
            this.txtBarraBuscador.Name = "txtBarraBuscador";
            this.txtBarraBuscador.Size = new System.Drawing.Size(477, 20);
            this.txtBarraBuscador.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(353, 145);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(353, 461);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(85, 13);
            this.lblMenu.TabIndex = 11;
            this.lblMenu.Text = "Cambiar al menu";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // frmBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 516);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBarraBuscador);
            this.Controls.Add(this.dataGDMostrador);
            this.Controls.Add(this.chckbxGenero);
            this.Controls.Add(this.chckbxAño);
            this.Controls.Add(this.lblBuscador);
            this.Name = "frmBuscador";
            this.Text = "frmBuscador";
            this.Load += new System.EventHandler(this.frmBuscador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGDMostrador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.CheckBox chckbxAño;
        private System.Windows.Forms.CheckBox chckbxGenero;
        private System.Windows.Forms.DataGridView dataGDMostrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaAño;
        private System.Windows.Forms.TextBox txtBarraBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblMenu;
    }
}