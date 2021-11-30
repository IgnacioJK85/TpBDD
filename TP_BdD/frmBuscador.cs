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
        DataSet ds = new DataSet();

        public frmBuscador()
        {
            InitializeComponent();
        }

        private void frmBuscador_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\dbTPBdD.accdb;";
            con.Open();

        }
     

        private void chckbxAño_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chckbxGenero_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chckbxGenero.Checked)
            {
                string sql = "SELECT * FROM tblPeliculas WHERE GeneroPelicula  = '" + txtBarraBuscador.Text + "'";

                OleDbCommand cmd = new OleDbCommand(sql, con);

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(ds, "tblPeliculas");

                con.Close();

                dataGDMostrador.DataSource = ds.Tables["tblPeliculas"];
            }

            if (chckbxAño.Checked)
            {
                string sql = "SELECT * FROM tblPeliculas WHERE AñoPelicula = '" + txtBarraBuscador.Text + "'";

                OleDbCommand cmd = new OleDbCommand(sql, con);

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(ds, "tblPeliculas");

                con.Close();

                dataGDMostrador.DataSource = ds.Tables["tblPeliculas"];       
            }       
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}