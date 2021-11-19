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
        public static string nomUser = "";

        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\db_TPBasesDeDatos.accdb;";
            con.Open();
        }

        private void btnIniciarSesión_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblUsuarios WHERE Usuario = '" + txtNomUsuario.Text + "' and Contraseña = '" + txtContraseña.Text + "'";
            cmd = new OleDbCommand(sql, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read() == true)
            {
                new frmAgregarPeliculas().Show();
                this.Hide();
                nomUser = txtNomUsuario.Text;
            }
        }

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
