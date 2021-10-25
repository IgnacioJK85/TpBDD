
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
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(284, 203);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(100, 20);
            this.txtPelicula.TabIndex = 0;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(284, 273);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 1;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(284, 336);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 2;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(298, 390);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 3;
            this.btn.Text = "button1";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // frmBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 505);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtPelicula);
            this.Name = "frmBuscador";
            this.Text = "frmBuscador";
            this.Load += new System.EventHandler(this.frmBuscador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Button btn;
    }
}