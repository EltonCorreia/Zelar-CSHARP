namespace Zelar
{
    partial class formAtualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAtualizar));
            pnComercio = new FlowLayoutPanel();
            lbComercio = new Label();
            btnAtualizar = new Button();
            txtNovaSenha = new TextBox();
            lbtxtComercio = new Label();
            txtNovoEmail = new TextBox();
            label1 = new Label();
            pnComercio.SuspendLayout();
            SuspendLayout();
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
            pnComercio.TabIndex = 15;
            // 
            // lbComercio
            // 
            lbComercio.AutoSize = true;
            lbComercio.Font = new Font("Kodchasan", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbComercio.ForeColor = Color.FromArgb(63, 5, 145);
            lbComercio.Location = new Point(28, 25);
            lbComercio.Name = "lbComercio";
            lbComercio.Size = new Size(512, 66);
            lbComercio.TabIndex = 0;
            lbComercio.Text = "Atualizar dados cadastrais";
            lbComercio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(63, 5, 145);
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Kodchasan", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(28, 310);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(1083, 64);
            btnAtualizar.TabIndex = 17;
            btnAtualizar.Text = "Atualizar dados";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.BackColor = Color.White;
            txtNovaSenha.BorderStyle = BorderStyle.FixedSingle;
            txtNovaSenha.Font = new Font("Kodchasan", 16.2F);
            txtNovaSenha.ForeColor = Color.FromArgb(63, 5, 145);
            txtNovaSenha.Location = new Point(28, 250);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(1083, 43);
            txtNovaSenha.TabIndex = 2;
            // 
            // lbtxtComercio
            // 
            lbtxtComercio.AutoSize = true;
            lbtxtComercio.BackColor = Color.Transparent;
            lbtxtComercio.Font = new Font("Kodchasan", 10.8F);
            lbtxtComercio.ForeColor = Color.White;
            lbtxtComercio.Location = new Point(28, 217);
            lbtxtComercio.Name = "lbtxtComercio";
            lbtxtComercio.Size = new Size(69, 32);
            lbtxtComercio.TabIndex = 4;
            lbtxtComercio.Text = "Senha";
            // 
            // txtNovoEmail
            // 
            txtNovoEmail.BackColor = Color.White;
            txtNovoEmail.BorderStyle = BorderStyle.FixedSingle;
            txtNovoEmail.Font = new Font("Kodchasan", 16.2F);
            txtNovoEmail.ForeColor = Color.FromArgb(63, 5, 145);
            txtNovoEmail.Location = new Point(28, 165);
            txtNovoEmail.Name = "txtNovoEmail";
            txtNovoEmail.Size = new Size(1083, 43);
            txtNovoEmail.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Kodchasan", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 132);
            label1.Name = "label1";
            label1.Size = new Size(69, 32);
            label1.TabIndex = 37;
            label1.Text = "E-mail";
            // 
            // formAtualizar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 5, 145);
            ClientSize = new Size(1140, 900);
            Controls.Add(label1);
            Controls.Add(txtNovoEmail);
            Controls.Add(btnAtualizar);
            Controls.Add(lbtxtComercio);
            Controls.Add(pnComercio);
            Controls.Add(txtNovaSenha);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formAtualizar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar dados";
            pnComercio.ResumeLayout(false);
            pnComercio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel pnComercio;
        private Label lbComercio;
        private Button btnAtualizar;
        private TextBox txtNovaSenha;
        private Label lbtxtComercio;
        private TextBox txtNovoEmail;
        private Label label1;
    }
}