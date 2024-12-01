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
    public partial class formConta : Form
    {
        ClasseConexao con;
        ClasseUsuario user;
        DataTable dt;
        int idComercio;
        int qtd = 0;
        int pos = 0;
        public formConta()
        {
            InitializeComponent();
        }

        private void pegarId()
        {
            //Método no qual faz o registro do cadastro do comercio
            user = new ClasseUsuario();
            idComercio = user.getIdComercio();
        }
        private void consultarDados(String sql)
        {
            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executarSQL(sql);
            qtd = dt.Rows.Count;
            mostrarDados();
        }
        private void mostrarDados()
        {
            txtID.Text = dt.Rows[0]["idComercio"].ToString();
            txtComercio.Text = dt.Rows[0]["nomeComercio"].ToString();
            txtResponsavel.Text = dt.Rows[0]["nomeResponsavel"].ToString();
            txtCNPJ.Text = dt.Rows[0]["CNPJ"].ToString();
            txtEndereco.Text = dt.Rows[0]["endereco"].ToString();

            //Carrega imagem salva no BD!
            if (dt.Rows[0]["fotoComercio"] != DBNull.Value)
            {
                byte[] imgBytes = (byte[])dt.Rows[0]["fotoComercio"];
                using (MemoryStream ms = new MemoryStream(imgBytes))
                {
                    pbLogo.Image = Image.FromStream(ms);
                }
            }
        }

        private void formConta_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            pegarId();
            //Consulta exatamente o ID do comercio registrado!
            consultarDados($"SELECT * FROM comercio where idComercio = {idComercio}");
        }

        public byte[] ImageToByteArray(string imagePath)
        {
            return System.IO.File.ReadAllBytes(imagePath);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            String a1 = txtID.Text;
            String a2 = txtComercio.Text;
            String a3 = txtResponsavel.Text;
            String a4 = txtEndereco.Text;

            con = new ClasseConexao();
            con.executarSQL("UPDATE comercio SET nomeComercio='" + a2 + "', nomeResponsavel='" + a3 + "', endereco='" + a4 + "' WHERE idComercio='" + a1 + "'");
            MessageBox.Show("Atualizado com sucesso!");
        }

        private void btnEscolherLogo_Click(object sender, EventArgs e)
        {
            String LocalizacaoImagem = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files|*.jpg;*.png;*.bmp|All Files|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    LocalizacaoImagem = dialog.FileName;
                    pbLogo.ImageLocation = LocalizacaoImagem;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void btnSalvarLogo_Click(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                pbLogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();

                //Salva a imagem diretamente no banco
                string query = $"UPDATE comercio SET fotoComercio = 0x{BitConverter.ToString(imageBytes).Replace("-", "")} WHERE idComercio = {idComercio}";
                con.executarSQL(query);
                MessageBox.Show("Imagem incluída com sucesso!");
            }
        }
    }
}
