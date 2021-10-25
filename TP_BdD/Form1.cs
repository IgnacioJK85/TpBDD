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
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\db_TPBdD.accdb;";
            con.Open();
        }

        private void btnAñadirAlosCmbbx_Click(object sender, EventArgs e)
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

        private void btnAgregarInfoFinal_Click(object sender, EventArgs e)
        {
            if (cmbBxAñoPelicula.SelectedIndex == -1 || cmbBxGeneroPelicula.SelectedIndex == -1)
            { 
                MessageBox.Show("Selecciona año y/o genero de pelicula");
            }
            else
            {
                string sql = "INSERT INTO Tabla1 VALUES ('" + txtNomPelicula.Text + "','" + cmbBxGeneroPelicula.SelectedItem + "', '" + cmbBxAñoPelicula.SelectedItem + "')";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Close();
            }
        }

        private void lblCambiarForm_Click(object sender, EventArgs e)
        {
            new frmBuscador().Show();
            this.Hide();
        }
    }
}
