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
    public partial class frmAgregarPeliculas : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        public frmAgregarPeliculas()
        {
            InitializeComponent();
        }

        private void frmAgregarPeliculas_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\dbTPBdD.accdb;";
            con.Open();
        }

        private void btnAgregarALosCmb_Click(object sender, EventArgs e)
        {
            bool GeneroExistente = false;
            bool AñoExistente = false;

            foreach (string elem in cmbGeneroPelicula.Items)
            {
                if (elem == txtGeneroPelicula.Text)
                {
                    GeneroExistente = true;
                }
            }

            if (GeneroExistente)
            {
                MessageBox.Show("Este género ya se encuentra en el listado de géneros");
            }
            else
            {
                cmbGeneroPelicula.Items.Add(txtGeneroPelicula.Text);
            }

            foreach (string elem in cmbAñoPelicula.Items)
            {
                if (elem == txtAñoPelicula.Text)
                {
                    AñoExistente = true;
                }
            }

            if (AñoExistente)
            {
                MessageBox.Show("Este año ya se encuentra en el listado de años");
            }
            else
            {
                cmbAñoPelicula.Items.Add(txtAñoPelicula.Text);
            }
        }

        private void btnAgregarPelicula_Click(object sender, EventArgs e)
        {

            if (cmbAñoPelicula.SelectedIndex == -1 || cmbGeneroPelicula.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona año y/o genero de pelicula");
            }
            else
            {
                string sql1 = "SELECT Id FROM tblUsuarios WHERE NomUsario = '" + frmLogin.nomUser + "'";
                OleDbCommand cmd1 = new OleDbCommand(sql1, con);
                cmd1.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd1);
                da.Fill(ds, "tblPeliculas");

                lblPrueba.Text = ds.Tables["tblPeliculas"].Rows[0]["Id"].ToString();


                string sql2 = "INSERT INTO tblPeliculas (NomPelicula, GeneroPelicula, AñoPelicula, IDUsuario) VALUES ('" + txtNomPelicula.Text + "','" + Convert.ToString(cmbBxGeneroPelicula.SelectedItem) + "', '" + Convert.ToString(cmbBxAñoPelicula.SelectedItem) + "', " + 1 + ");";
                OleDbCommand cmd = new OleDbCommand(sql2, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
