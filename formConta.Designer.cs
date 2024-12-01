namespace Zelar
{
    partial class formConta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAtualizar = new Button();
            pnLogo = new Panel();
            pbLogo = new PictureBox();
            btnSalvarLogo = new Button();
            btnEscolherLogo = new Button();
            pnComercio = new FlowLayoutPanel();
            lbComercio = new Label();
            txtComercio = new TextBox();
            lbtxtComercio = new Label();
            txtResponsavel = new TextBox();
            lbtxtResponsavel = new Label();
            lbtxtCNPJ = new Label();
            txtEndereco = new TextBox();
            lbtxtEndereco = new Label();
            txtCNPJ = new MaskedTextBox();
            txtID = new TextBox();
            label1 = new Label();
            pnDados = new Panel();
            pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnComercio.SuspendLayout();
            pnDados.SuspendLayout();
            SuspendLayout();
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(63, 5, 145);
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Kodchasan", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(44, 639);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(482, 130);
            btnAtualizar.TabIndex = 14;
            btnAtualizar.Text = "Atualizar dados";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.White;
            pnLogo.Controls.Add(pbLogo);
            pnLogo.Location = new Point(532, 163);
            pnLogo.Name = "pnLogo";
            pnLogo.Padding = new Padding(2);
            pnLogo.Size = new Size(431, 470);
            pnLogo.TabIndex = 12;
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(21, 21);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(387, 427);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // btnSalvarLogo
            // 
            btnSalvarLogo.BackColor = Color.FromArgb(63, 5, 145);
            btnSalvarLogo.FlatStyle = FlatStyle.Flat;
            btnSalvarLogo.Font = new Font("Kodchasan", 10.8F);
            btnSalvarLogo.ForeColor = Color.White;
            btnSalvarLogo.Location = new Point(532, 707);
            btnSalvarLogo.Name = "btnSalvarLogo";
            btnSalvarLogo.Size = new Size(431, 62);
            btnSalvarLogo.TabIndex = 14;
            btnSalvarLogo.Text = "Salvar logo";
            btnSalvarLogo.UseVisualStyleBackColor = false;
            btnSalvarLogo.Click += btnSalvarLogo_Click;
            // 
            // btnEscolherLogo
            // 
            btnEscolherLogo.BackColor = Color.FromArgb(63, 5, 145);
            btnEscolherLogo.FlatStyle = FlatStyle.Flat;
            btnEscolherLogo.Font = new Font("Kodchasan", 10.8F);
            btnEscolherLogo.ForeColor = Color.White;
            btnEscolherLogo.Location = new Point(532, 639);
            btnEscolherLogo.Name = "btnEscolherLogo";
            btnEscolherLogo.Size = new Size(431, 62);
            btnEscolherLogo.TabIndex = 13;
            btnEscolherLogo.Text = "Escolher logo";
            btnEscolherLogo.UseVisualStyleBackColor = false;
            btnEscolherLogo.Click += btnEscolherLogo_Click;
            // 
            // pnComercio
            // 
            pnComercio.BackColor = Color.White;
            pnComercio.Controls.Add(lbComercio);
            pnComercio.Dock = DockStyle.Top;
            pnComercio.ForeColor = Color.Transparent;
            pnComercio.Location = new Point(0, 0);
            pnComercio.Margin = new Padding(0);
            pnComercio.Name = "pnComercio";
            pnComercio.Padding = new Padding(25);
            pnComercio.Size = new Size(1140, 114);
            pnComercio.TabIndex = 14;
            // 
            // lbComercio
            // 
            lbComercio.AutoSize = true;
            lbComercio.Font = new Font("Kodchasan", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbComercio.ForeColor = Color.FromArgb(63, 5, 145);
            lbComercio.Location = new Point(28, 25);
            lbComercio.Name = "lbComercio";
            lbComercio.Size = new Size(201, 66);
            lbComercio.TabIndex = 0;
            lbComercio.Text = "Comércio";
            lbComercio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtComercio
            // 
            txtComercio.BackColor = Color.FromArgb(63, 5, 145);
            txtComercio.BorderStyle = BorderStyle.FixedSingle;
            txtComercio.Font = new Font("Kodchasan", 16.2F);
            txtComercio.ForeColor = Color.White;
            txtComercio.Location = new Point(17, 152);
            txtComercio.Name = "txtComercio";
            txtComercio.Size = new Size(445, 43);
            txtComercio.TabIndex = 2;
            // 
            // lbtxtComercio
            // 
            lbtxtComercio.AutoSize = true;
            lbtxtComercio.BackColor = Color.Transparent;
            lbtxtComercio.Font = new Font("Kodchasan", 10.8F);
            lbtxtComercio.ForeColor = Color.FromArgb(63, 5, 145);
            lbtxtComercio.Location = new Point(17, 119);
            lbtxtComercio.Name = "lbtxtComercio";
            lbtxtComercio.Size = new Size(98, 32);
            lbtxtComercio.TabIndex = 4;
            lbtxtComercio.Text = "Comércio";
            // 
            // txtResponsavel
            // 
            txtResponsavel.BackColor = Color.FromArgb(63, 5, 145);
            txtResponsavel.BorderStyle = BorderStyle.FixedSingle;
            txtResponsavel.Font = new Font("Kodchasan", 16.2F);
            txtResponsavel.ForeColor = Color.White;
            txtResponsavel.Location = new Point(17, 229);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.Size = new Size(445, 43);
            txtResponsavel.TabIndex = 5;
            // 
            // lbtxtResponsavel
            // 
            lbtxtResponsavel.AutoSize = true;
            lbtxtResponsavel.BackColor = Color.Transparent;
            lbtxtResponsavel.Font = new Font("Kodchasan", 10.8F);
            lbtxtResponsavel.ForeColor = Color.FromArgb(63, 5, 145);
            lbtxtResponsavel.Location = new Point(17, 196);
            lbtxtResponsavel.Name = "lbtxtResponsavel";
            lbtxtResponsavel.Size = new Size(127, 32);
            lbtxtResponsavel.TabIndex = 6;
            lbtxtResponsavel.Text = "Responsável";
            // 
            // lbtxtCNPJ
            // 
            lbtxtCNPJ.AutoSize = true;
            lbtxtCNPJ.BackColor = Color.Transparent;
            lbtxtCNPJ.Font = new Font("Kodchasan", 10.8F);
            lbtxtCNPJ.ForeColor = Color.FromArgb(63, 5, 145);
            lbtxtCNPJ.Location = new Point(17, 273);
            lbtxtCNPJ.Name = "lbtxtCNPJ";
            lbtxtCNPJ.Size = new Size(61, 32);
            lbtxtCNPJ.TabIndex = 8;
            lbtxtCNPJ.Text = "CNPJ";
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = Color.FromArgb(63, 5, 145);
            txtEndereco.BorderStyle = BorderStyle.FixedSingle;
            txtEndereco.Font = new Font("Kodchasan", 16.2F);
            txtEndereco.ForeColor = Color.White;
            txtEndereco.Location = new Point(17, 377);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(445, 43);
            txtEndereco.TabIndex = 9;
            // 
            // lbtxtEndereco
            // 
            lbtxtEndereco.AutoSize = true;
            lbtxtEndereco.BackColor = Color.Transparent;
            lbtxtEndereco.Font = new Font("Kodchasan", 10.8F);
            lbtxtEndereco.ForeColor = Color.FromArgb(63, 5, 145);
            lbtxtEndereco.Location = new Point(17, 344);
            lbtxtEndereco.Name = "lbtxtEndereco";
            lbtxtEndereco.Size = new Size(99, 32);
            lbtxtEndereco.TabIndex = 10;
            lbtxtEndereco.Text = "Endereço";
            // 
            // txtCNPJ
            // 
            txtCNPJ.BackColor = Color.FromArgb(63, 5, 145);
            txtCNPJ.BorderStyle = BorderStyle.FixedSingle;
            txtCNPJ.Font = new Font("Kodchasan", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCNPJ.ForeColor = Color.White;
            txtCNPJ.Location = new Point(17, 306);
            txtCNPJ.Mask = "99,999,999/9999-99";
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.ReadOnly = true;
            txtCNPJ.Size = new Size(443, 37);
            txtCNPJ.TabIndex = 35;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(63, 5, 145);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Kodchasan", 16.2F);
            txtID.ForeColor = Color.White;
            txtID.Location = new Point(17, 75);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(445, 43);
            txtID.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Kodchasan", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(63, 5, 145);
            label1.Location = new Point(17, 42);
            label1.Name = "label1";
            label1.Size = new Size(32, 32);
            label1.TabIndex = 37;
            label1.Text = "ID";
            // 
            // pnDados
            // 
            pnDados.BackColor = Color.White;
            pnDados.Controls.Add(label1);
            pnDados.Controls.Add(txtID);
            pnDados.Controls.Add(txtCNPJ);
            pnDados.Controls.Add(lbtxtEndereco);
            pnDados.Controls.Add(txtEndereco);
            pnDados.Controls.Add(lbtxtCNPJ);
            pnDados.Controls.Add(lbtxtResponsavel);
            pnDados.Controls.Add(txtResponsavel);
            pnDados.Controls.Add(lbtxtComercio);
            pnDados.Controls.Add(txtComercio);
            pnDados.Location = new Point(44, 163);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(482, 470);
            pnDados.TabIndex = 1;
            // 
            // formConta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 5, 145);
            ClientSize = new Size(1140, 900);
            Controls.Add(btnSalvarLogo);
            Controls.Add(btnEscolherLogo);
            Controls.Add(pnComercio);
            Controls.Add(btnAtualizar);
            Controls.Add(pnLogo);
            Controls.Add(pnDados);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "formConta";
            StartPosition = FormStartPosition.Manual;
            Text = "Sua conta";
            Load += formConta_Load;
            pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnComercio.ResumeLayout(false);
            pnComercio.PerformLayout();
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnLogo;
        private FlowLayoutPanel pnComercio;
        private Label lbComercio;
        private Button btnEscolherLogo;
        private PictureBox pbLogo;
        private Button btnAtualizar;
        private Button btnSalvarLogo;
        private TextBox txtComercio;
        private Label lbtxtComercio;
        private TextBox txtResponsavel;
        private Label lbtxtResponsavel;
        private Label lbtxtCNPJ;
        private TextBox txtEndereco;
        private Label lbtxtEndereco;
        private MaskedTextBox txtCNPJ;
        private TextBox txtID;
        private Label label1;
        private Panel pnDados;
    }
}