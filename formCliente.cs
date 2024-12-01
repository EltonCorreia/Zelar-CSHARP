using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
namespace Zelar
{
    public partial class formCliente : Form
    {
        ClasseConexao con;
        ClasseClientes clientes;
        DataTable dt;
        string numerocartao;
        String caminho_escolhido = "";

        public formCliente()
        {
            InitializeComponent();
            clientes = new ClasseClientes();
            pesquisaporNumero();
        }

        private static void AddCellToHeader(PdfPTable tableLayout, string cellText)
        {
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Padding = 10,
                BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255)
            });
        }

        protected PdfPTable corpo_documento(PdfPTable tableLayout)
        {
            float[] headers = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            tableLayout.SetWidths(headers); 
            tableLayout.WidthPercentage = 100;
            tableLayout.HeaderRows = 1;
            //Add header 
            AddCellToHeader(tableLayout, "ID");
            AddCellToHeader(tableLayout, "NOME");
            AddCellToHeader(tableLayout, "ENDEREÇO");
            AddCellToHeader(tableLayout, "TELEFONE");
            AddCellToHeader(tableLayout, "ID CARTÃO");
            AddCellToHeader(tableLayout, "E-MAIL");
            AddCellToHeader(tableLayout, "SENHA");
            AddCellToHeader(tableLayout, "PONTUAÇÃO");
            AddCellToHeader(tableLayout, "DATA DE COMPRA");
            AddCellToHeader(tableLayout, "VALOR");
            AddCellToHeader(tableLayout, "CUPOM");
            DataTable dt = new DataTable();
            dt = con.executarSQL($"SELECT * FROM CadastroCliente WHERE Nome LIKE '%{txtPesquisar.Text}%' AND IdCartao = {numerocartao}");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                AddCellToBody(tableLayout, dt.Rows[i]["CodigoCliente"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["Nome"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["Endereco"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["Telefone"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["IdCartao"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["Email"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["Senha"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["Pontos"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["Datadacompra"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["ValorCompra"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["CodCupom"].ToString(), i);
            }
            return tableLayout;
        }

        private static void AddCellToBody(PdfPTable tableLayout, string cellText, int count)
        {
            if (count % 2 == 0)
            {
                tableLayout.AddCell(new PdfPCell(new Phrase(cellText, FontFactory.GetFont(FontFactory.HELVETICA, 8, 1, iTextSharp.text.BaseColor.BLACK)))
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    Padding = 8,
                    BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255)
                });
            }
            else
            {
                tableLayout.AddCell(new PdfPCell(new Phrase(cellText, FontFactory.GetFont(FontFactory.HELVETICA, 8, 1, iTextSharp.text.BaseColor.BLACK)))
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    Padding = 8,
                    BackgroundColor = new iTextSharp.text.BaseColor(230, 230, 230)
                });
            }
        }

        private void pesquisaporNumero()
        {
            numerocartao = clientes.getnumeroCartao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM CadastroCliente WHERE Nome LIKE '%{txtPesquisar.Text}%' AND IdCartao = {numerocartao}";
            con = new ClasseConexao();
            dt = con.executarSQL(sql);
            dgvPesquisar.DataSource = dt;
        }

        private void dgvPesquisar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string idCliente = dgvPesquisar.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar PDF como";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            caminho_escolhido = saveFileDialog1.FileName;
            MessageBox.Show("Salvo em: " + caminho_escolhido);
            Document doc = null;
            try
            {
                doc = new Document(PageSize.A4);
                doc.SetMargins(10, 10, 10, 10);
                doc.AddCreationDate();
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho_escolhido, FileMode.Create));
                doc.Open();

                PdfPTable tableLayout = new PdfPTable(11);
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font fontInvoice = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.NORMAL);
                Paragraph paragraph = new Paragraph("Dados - Clientes", fontInvoice);
                paragraph.Alignment = Element.ALIGN_CENTER;
                doc.Add(paragraph);
                Paragraph p3 = new Paragraph();
                p3.SpacingAfter = 6;
                doc.Add(p3);
                doc.Add(corpo_documento(tableLayout));
                doc.Close();
            }
            catch (Exception erro)
            {
                if (doc != null)
                    doc.Close();
                MessageBox.Show("Erro Arquivo PDF --> " + erro);
            }
        }
    }
}
