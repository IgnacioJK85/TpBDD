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
        OleDbCommand cmd = new OleDbCommand();
        DataSet ds = new DataSet();

        public frmBuscador()
        {
            InitializeComponent();
        }

        private void frmBuscador_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\db_TPBasesDeDatos.accdb;";
            con.Open();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chckBxFiltrarGenero.Checked)
            {
                string sql = "SELECT * FROM tblPeliculas WHERE Genero  = '" + txtBarraBuscador.Text + "'";

                OleDbCommand cmd = new OleDbCommand(sql, con);

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(ds, "Pelicula");

                con.Close();

                dataGVMostrador.DataSource = ds.Tables["Pelicula"];
            }

            if (chckBxFiltrarAño.Checked)
            {
                string sql = "SELECT * FROM Pelicula WHERE Año = '" + txtBarraBuscador.Text + "'";

                OleDbCommand cmd = new OleDbCommand(sql, con);

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(ds, "Pelicula");

                con.Close();

                dataGVMostrador.DataSource = ds.Tables["Pelicula"];
            }
        }
    }
}