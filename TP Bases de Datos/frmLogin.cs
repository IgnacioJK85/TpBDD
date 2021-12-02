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
    public partial class frmLogin : Form
    {
        public static string nomUser;
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\dbTPBdD.accdb;";
            con.Open();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblUsuarios WHERE Usuario = '" + txtNomUsuario.Text + "' AND Contraseña = '" + txtContraseña.Text + "'";
            cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                nomUser = txtNomUsuario.Text;
                con.Close();
                dr.Close();
                new frmMenu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña o Usuario Incorrecto, intente nuevamente", "Error en Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomUsuario.Text = "";
                txtContraseña.Text = "";
                txtNomUsuario.Focus();
            } 
            
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void chckBxMC_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBxMC.Checked)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '•';
            }
        }
    }
}
