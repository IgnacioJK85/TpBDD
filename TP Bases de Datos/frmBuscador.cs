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

namespace TP_Bases_de_Datos
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
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\dbTPBdD.accdb;";
            con.Open();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtSearchBar.Text == "")
            {
                MessageBox.Show("No ha escrito nada en la barra de búsqueda");
            }
            else
            {
                if (rbAñoPelicula.Checked)
                {
                    string sql2 = "SELECT NomPelicula, GeneroPelicula, AñoPelicula FROM tblPeliculas WHERE AñoPelicula = '" + txtSearchBar.Text + "'";
                    OleDbCommand cmd2 = new OleDbCommand(sql2, con);
                    OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    dataGridView1.DataSource = dt2;
                }
                else if (rbGeneroPelicula.Checked)
                {
                    string sql1 = "SELECT NomPelicula, AñoPelicula, GeneroPelicula FROM tblPeliculas WHERE GeneroPelicula = '" + txtSearchBar.Text + "'";
                    OleDbCommand cmd1 = new OleDbCommand(sql1, con);
                    OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    dataGridView1.DataSource = dt1;                   
                }
            }
        }

        private void lblVolverMenú_Click(object sender, EventArgs e)
        {
            con.Close();
            new frmMenu().Show();
            this.Hide();
        }
    }
}
