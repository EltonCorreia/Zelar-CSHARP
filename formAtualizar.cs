using System;
using System.Data;
using System.Windows.Forms;

namespace Zelar
{
    public partial class formAtualizar : Form
    {
        ClasseConexao con;
        ClasseUsuario user;
        DataTable dt;
        int idComercio;

        public formAtualizar()
        {
            InitializeComponent();
            pegarId(); // Chama o método para pegar o id do comércio
        }

        private void pegarId()
        {
            // Método para obter o ID do comércio
            user = new ClasseUsuario();
            idComercio = user.getIdComercio();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string novoEmail = txtNovoEmail.Text;
            string novaSenha = txtNovaSenha.Text;
            pegarId();

            try
            {
                con = new ClasseConexao();
                con.executarSQL($"UPDATE comercio SET emailResponsavel='{novoEmail}', senhaResponsavel='{novaSenha}' WHERE idComercio = {idComercio}");

                MessageBox.Show("Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar: {ex.Message}");
            }
            finally
            {
                Application.Exit();
            }
        }
    }
}
