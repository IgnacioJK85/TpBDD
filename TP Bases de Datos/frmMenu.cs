using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Bases_de_Datos
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblNomUsuario.Text = frmLogin.nomUser; 
        }

        private void btnAñadidorPeliculas_Click(object sender, EventArgs e)
        {
            new frmAgregarPeliculas().Show();
            this.Hide();
        }

        private void btnVisualizadorPeliculas_Click(object sender, EventArgs e)
        {
            new frmBuscador().Show();
            this.Hide();
        }

        private void lblSignOut_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
