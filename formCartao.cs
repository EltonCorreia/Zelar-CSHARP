using System;
using System.Data;
using System.Windows.Forms;

namespace Zelar
{
    public partial class formCartao : Form
    {
        ClasseConexao con;
        ClasseUsuario user;
        DataTable dt;
        int idComercio;

        public formCartao()
        {
            InitializeComponent();
            pegarId();
            carregarDados();
        }

        private void pegarId()
        {
            user = new ClasseUsuario();
            idComercio = user.getIdComercio();
        }

        private void carregarDados()
        {
            string sql = $"SELECT numeroCartao FROM comercio WHERE idComercio = {idComercio}";
            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executarSQL(sql);
            if (dt.Rows.Count > 0)
            {
                txtCodigo.Text = dt.Rows[0]["numeroCartao"].ToString();
                ClasseClientes clientes = new ClasseClientes();
                clientes.setnumeroCartao(txtCodigo.Text);
            }
            else
            {
                txtCodigo.Text = string.Empty;
            }
        }

        private void btnSalvarCodigo_Click(object sender, EventArgs e)
        {
            int codigo = new Random().Next(4555,4555);
            txtCodigo.Text = codigo.ToString();

            con = new ClasseConexao();
            con.executarSQL($"UPDATE comercio SET numeroCartao = '{codigo}' WHERE idComercio = {idComercio}");

            ClasseClientes clientes = new ClasseClientes();
            clientes.setnumeroCartao(codigo.ToString());

            btnSalvarCodigo.Enabled = false;
            txtCodigo.Enabled = false;
        }
    }
}
