using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zelar
{
    public partial class formLogin : Form
    {
        ClasseConexao con;
        DataTable dt;
        public formLogin()
        {
            InitializeComponent();
        }
        private void consultarDados(String sql)
        {
            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executarSQL(sql);
        }
        private void btnLinkCadastro_Click(object sender, EventArgs e)
        {
            formCadastro cadastro = new formCadastro();
            cadastro.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtLoginUsuario.Text;
            string senha = txtLoginSenha.Text;

            con = new ClasseConexao();
            string login = $"SELECT * FROM comercio WHERE emailResponsavel = '{usuario}' AND senhaResponsavel = '{senha}'";

            DataTable dt = con.executarSQL(login);

            if(dt != null && dt.Rows.Count > 0)
            {
                ClasseUsuario user = new ClasseUsuario();
                user.setIdComercio(Convert.ToInt32(dt.Rows[0]["idComercio"]));
                formDash dash = new formDash();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!");
            }
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked == true) 
            { 
                txtLoginSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtLoginSenha.UseSystemPasswordChar= true;
            }
        }
    }
}
