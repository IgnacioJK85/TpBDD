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
            lblNomUsuario.Text = frmLogin.nomUser;
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\db_TPBasesDeDatos.accdb;";
            con.Open();
        }

        private void btnAñadirCmbBx_Click(object sender, EventArgs e)
        {
            bool GeneroExistente = false;
            bool AñoExistente = false;

            foreach (string elem in cmbBxGeneroPelicula.Items)
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
                cmbBxGeneroPelicula.Items.Add(txtGeneroPelicula.Text);
            }

            foreach (string elem in cmbBxAñoPelicula.Items)
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
                cmbBxAñoPelicula.Items.Add(txtAñoPelicula.Text);
            }
        }

        private void btnAñadirPeliculas_Click(object sender, EventArgs e)
        {

            if (cmbBxAñoPelicula.SelectedIndex == -1 || cmbBxGeneroPelicula.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona año y/o genero de pelicula");
            }
            else
            {
                string sql = "INSERT INTO tblPeliculas VALUES ('" + txtNomPelicula.Text + "','" + Convert.ToString(cmbBxGeneroPelicula.SelectedItem) + "', '" + Convert.ToString(cmbBxAñoPelicula.SelectedItem) + "', '" + 8 + "');";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void lblBuscador_Click(object sender, EventArgs e)
        {
            new frmBuscador().Show();
            this.Hide();
        }
    }
}
