using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TP_BdD
{
    public partial class frmBuscador : Form
    {
        OleDbConnection con = new OleDbConnection();

        public frmBuscador()
        {
            InitializeComponent();
        }

        private void frmBuscador_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\db_TPBdD.accdb;";
            con.Open();

        }

        private void btn_Click(object sender, EventArgs e)
        {
             string sql = "SELECT * FROM Tabla1 WHERE Pelicula = '" + txtPelicula.Text + "' and Genero = '" + txtGenero.Text + "'";
        }
    }
}
