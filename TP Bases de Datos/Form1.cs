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
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\db_TPBasesDeDatos.accdb;";
            con.Open();
        }

        private void btnCrearNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                string sql = "INSERT INTO tblUsuarios VALUES ('" + txtNomUsuario.Text + "','" + txtContraseña.Text + "');";
                cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales");
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();    
        }
    }
}
