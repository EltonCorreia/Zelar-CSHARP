namespace Zelar
{
    public partial class formDash : Form
    {

        //Declaração de cada form e variável sidebar

        bool sidebarExp;
        formConta conta;
        formCartao cartao;
        formPlano plano;
        formCliente cliente;
        formFuncoes funcoes;
        public formDash()
        {
            InitializeComponent();
        }

        //Método do Timer para a sidebar

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExp)
            {
                pnlSidebar.Width -= 10;
                if (pnlSidebar.Width == pnlSidebar.MinimumSize.Width)
                {
                    sidebarExp = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                pnlSidebar.Width += 10;
                if (pnlSidebar.Width == pnlSidebar.MaximumSize.Width)
                {
                    sidebarExp = true;
                    sidebarTimer.Stop();
                }
            }
        }

        //Botão de colapso do menu

        private void btnBar_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        //Botões do menu | Multiplas páginas

        private void btnConta_Click(object sender, EventArgs e)
        {
            if (conta == null)
            {
                conta = new formConta();
                conta.FormClosed += Conta_FormClosed;
                conta.MdiParent = this;
                conta.Show();
            }
            else
            {
                conta.Activate();
            }
        }

        private void Conta_FormClosed(object? sender, FormClosedEventArgs e)
        {
        
        }

        private void btnCartao_Click(object sender, EventArgs e)
        {
            if (cartao == null)
            {
                cartao = new formCartao();
                cartao.FormClosed += Cartao_FormClosed;
                cartao.MdiParent = this;
                cartao.Show();
            }
            else
            {
                cartao.Activate();
            }
        }

        private void Cartao_FormClosed(object? sender, FormClosedEventArgs e)
        {
            
        }

        private void btnPlano_Click(object sender, EventArgs e)
        {
            if (plano == null)
            {
                plano = new formPlano();
                plano.FormClosed += Plano_FormClosed;
                plano.MdiParent = this;
                plano.Show();
            }
            else
            {
                plano.Activate();
            }
        }

        private void Plano_FormClosed(object? sender, FormClosedEventArgs e)
        {
           
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                cliente = new formCliente();
                cliente.FormClosed += Cliente_FormClosed;
                cliente.MdiParent = this;
                cliente.Show();
            }
            else
            {
                cliente.Activate();
            }
        }

        private void Cliente_FormClosed(object? sender, FormClosedEventArgs e)
        {
           
        }

        private void btnFuncoes_Click(object sender, EventArgs e)
        {
            if (funcoes == null)
            {
                funcoes = new formFuncoes();
                funcoes.FormClosed += Funcoes_FormClosed;
                funcoes.MdiParent = this;
                funcoes.Show();
            }
            else
            {
                funcoes.Activate();
            }
        }

        private void Funcoes_FormClosed(object? sender, FormClosedEventArgs e)
        {
            
        }

        private void formDash_Load(object sender, EventArgs e)
        {
            conta = new formConta();
            conta.FormClosed += Conta_FormClosed;
            conta.MdiParent = this;
            conta.Show();
        }
    }
}
