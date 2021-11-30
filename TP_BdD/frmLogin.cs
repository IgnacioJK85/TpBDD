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
            string sql = "SELECT * FROM tblUsuarios WHERE NomUsuario= '" + txtNomUsuario.Text + "' AND Contraseña = '" + txtContraseña.Text + "'";
            cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            OleDbDataReader dr = cmd.ExecuteReader();

            try
            {
                if (dr.Read() == true)
                {
                    nomUser = txtNomUsuario.Text;
                    new Form1().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Campo de usuario o contraseña inválido, Intente nuevamente", "Login fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNomUsuario.Text = "";
                    txtContraseña.Text = "";
                    txtNomUsuario.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Este nombre de usuario no existe"); 
            }
            finally
            {
                con.Close();
                dr.Close();
            }
        }

        private void lblCambairRegistro_Click(object sender, EventArgs e)
        {
            new frmRegistro().Show();
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
