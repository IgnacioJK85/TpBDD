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
    public partial class frmRegistro : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\dbTPBdD.accdb;";
            con.Open();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtNomUsuario.Text == "" && txtContraseña.Text == "" && txtConfContraseña.Text == "")
            {
                MessageBox.Show("Campos de usuario y contraseña están incompletos", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtContraseña.Text == txtConfContraseña.Text)
            {
                try
                {
                    string sql = "INSERT INTO tblUsuarios (NomUsuario, Contraseña) VALUES ('" + txtNomUsuario.Text + "', '" + txtContraseña.Text + "');";
                    cmd = new OleDbCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tu cuenta ha sido creada exitosamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (OleDbException)
                {
                    MessageBox.Show("Este nombre de usuario ya existe, intente con otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales , Por favor, reescríbalas ", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Text = "";
                txtConfContraseña.Text = "";
                txtContraseña.Focus();
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void chckBxMC_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBxMC.Checked)
            {
                txtContraseña.PasswordChar = '\0';
                txtConfContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '•';
                txtConfContraseña.PasswordChar = '•';
            }
        }
    }
}
