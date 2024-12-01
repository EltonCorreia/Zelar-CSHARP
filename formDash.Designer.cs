namespace Zelar
{
    partial class formDash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDash));
            btnFuncoes = new Button();
            btnClientes = new Button();
            btnPlano = new Button();
            btnConta = new Button();
            btnCartao = new Button();
            btnBar = new Button();
            pnlSidebar = new FlowLayoutPanel();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // btnFuncoes
            // 
            btnFuncoes.FlatAppearance.BorderSize = 0;
            btnFuncoes.FlatStyle = FlatStyle.Flat;
            btnFuncoes.Font = new Font("Kodchasan", 10.8F);
            btnFuncoes.ForeColor = Color.FromArgb(63, 5, 145);
            btnFuncoes.Image = Properties.Resources.Gear;
            btnFuncoes.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncoes.Location = new Point(3, 684);
            btnFuncoes.Name = "btnFuncoes";
            btnFuncoes.Padding = new Padding(15);
            btnFuncoes.Size = new Size(222, 141);
            btnFuncoes.TabIndex = 6;
            btnFuncoes.Text = "              Funções";
            btnFuncoes.UseVisualStyleBackColor = true;
            btnFuncoes.Click += btnFuncoes_Click;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Kodchasan", 10.8F);
            btnClientes.ForeColor = Color.FromArgb(63, 5, 145);
            btnClientes.Image = Properties.Resources.Group;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(3, 537);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(15);
            btnClientes.Size = new Size(222, 141);
            btnClientes.TabIndex = 5;
            btnClientes.Text = "              Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnPlano
            // 
            btnPlano.FlatAppearance.BorderSize = 0;
            btnPlano.FlatStyle = FlatStyle.Flat;
            btnPlano.Font = new Font("Kodchasan", 10.8F);
            btnPlano.ForeColor = Color.FromArgb(63, 5, 145);
            btnPlano.Image = Properties.Resources.List;
            btnPlano.ImageAlign = ContentAlignment.MiddleLeft;
            btnPlano.Location = new Point(3, 390);
            btnPlano.Name = "btnPlano";
            btnPlano.Padding = new Padding(15);
            btnPlano.Size = new Size(222, 141);
            btnPlano.TabIndex = 4;
            btnPlano.Text = "              Plano";
            btnPlano.UseVisualStyleBackColor = true;
            btnPlano.Click += btnPlano_Click;
            // 
            // btnConta
            // 
            btnConta.FlatAppearance.BorderSize = 0;
            btnConta.FlatStyle = FlatStyle.Flat;
            btnConta.Font = new Font("Kodchasan", 10.8F);
            btnConta.ForeColor = Color.FromArgb(63, 5, 145);
            btnConta.Image = Properties.Resources.User;
            btnConta.ImageAlign = ContentAlignment.MiddleLeft;
            btnConta.Location = new Point(3, 96);
            btnConta.Name = "btnConta";
            btnConta.Padding = new Padding(15);
            btnConta.Size = new Size(222, 141);
            btnConta.TabIndex = 3;
            btnConta.Text = "              Conta";
            btnConta.UseVisualStyleBackColor = true;
            btnConta.Click += btnConta_Click;
            // 
            // btnCartao
            // 
            btnCartao.FlatAppearance.BorderSize = 0;
            btnCartao.FlatStyle = FlatStyle.Flat;
            btnCartao.Font = new Font("Kodchasan", 10.8F);
            btnCartao.ForeColor = Color.FromArgb(63, 5, 145);
            btnCartao.Image = Properties.Resources.Card;
            btnCartao.ImageAlign = ContentAlignment.MiddleLeft;
            btnCartao.Location = new Point(3, 243);
            btnCartao.Name = "btnCartao";
            btnCartao.Padding = new Padding(15);
            btnCartao.Size = new Size(222, 141);
            btnCartao.TabIndex = 2;
            btnCartao.Text = "              Cartão";
            btnCartao.UseVisualStyleBackColor = true;
            btnCartao.Click += btnCartao_Click;
            // 
            // btnBar
            // 
            btnBar.FlatAppearance.BorderSize = 0;
            btnBar.FlatStyle = FlatStyle.Flat;
            btnBar.Font = new Font("Kodchasan", 10.8F);
            btnBar.ForeColor = Color.FromArgb(63, 5, 145);
            btnBar.Image = Properties.Resources.Close;
            btnBar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBar.Location = new Point(3, 3);
            btnBar.Name = "btnBar";
            btnBar.Padding = new Padding(15);
            btnBar.Size = new Size(222, 87);
            btnBar.TabIndex = 4;
            btnBar.Text = "              Menu";
            btnBar.UseVisualStyleBackColor = true;
            btnBar.Click += btnBar_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(btnBar);
            pnlSidebar.Controls.Add(btnConta);
            pnlSidebar.Controls.Add(btnCartao);
            pnlSidebar.Controls.Add(btnPlano);
            pnlSidebar.Controls.Add(btnClientes);
            pnlSidebar.Controls.Add(btnFuncoes);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.MaximumSize = new Size(225, 0);
            pnlSidebar.MinimumSize = new Size(95, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(95, 823);
            pnlSidebar.TabIndex = 4;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // formDash
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(63, 5, 145);
            ClientSize = new Size(1122, 823);
            Controls.Add(pnlSidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "formDash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zelar";
            Load += formDash_Load;
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnCartao;
        private Button btnBar;
        private Button btnFuncoes;
        private Button btnClientes;
        private Button btnPlano;
        private Button btnConta;
        private FlowLayoutPanel pnlSidebar;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}
