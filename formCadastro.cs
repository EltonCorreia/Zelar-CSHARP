using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Zelar
{
    public partial class formCadastro : Form
    {
        ClasseConexao con;
        DataTable dt;
        public formCadastro()
        {
            InitializeComponent();
        }

        private void consultarDados(String sql)
        {
            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executarSQL(sql);
        }

        private void btnLinkLogin_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            String nome = txtCadastroNome.Text;
            String email = txtCadastroEmail.Text;
            String senha = txtCadastroSenha.Text;
            String plano = txtTipoPlano.Text;

            String nomecomercio = txtNomeComercio.Text;
            String emailcomercio = txtEmailComercio.Text;
            String cnpj = txtCadastroCNPJ.Text;
            String endereco = txtCadastroEndereco.Text;

            con = new ClasseConexao();
            bool x = con.manutencaoDB("INSERT INTO comercio (nomeResponsavel, emailResponsavel, senhaResponsavel, nomeComercio, emailComercio, CNPJ, endereco, planoComercio) VALUES ('" +nome+"','"+email+"','"+senha+"','"+nomecomercio+"','"+emailcomercio+"','"+cnpj+"','"+endereco+"','"+plano+"')");
            consultarDados("SELECT * FROM comercio");

            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }
    }
}

