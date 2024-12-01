namespace Zelar
{
    partial class formCartao
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
            pnCartao = new FlowLayoutPanel();
            lbCartao = new Label();
            pnCodigo = new Panel();
            lbCodigo = new Label();
            txtCodigo = new TextBox();
            btnSalvarCodigo = new Button();
            pnCartao.SuspendLayout();
            pnCodigo.SuspendLayout();
            SuspendLayout();
            // 
            // pnCartao
            // 
            pnCartao.BackColor = Color.White;
            pnCartao.Controls.Add(lbCartao);
            pnCartao.Dock = DockStyle.Top;
            pnCartao.ForeColor = Color.Transparent;
            pnCartao.Location = new Point(0, 0);
            pnCartao.Margin = new Padding(0);
            pnCartao.Name = "pnCartao";
            pnCartao.Padding = new Padding(25);
            pnCartao.Size = new Size(1140, 114);
            pnCartao.TabIndex = 15;
            // 
            // lbCartao
            // 
            lbCartao.AutoSize = true;
            lbCartao.BackColor = Color.Transparent;
            lbCartao.Font = new Font("Kodchasan", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCartao.ForeColor = Color.FromArgb(63, 5, 145);
            lbCartao.Location = new Point(28, 25);
            lbCartao.Name = "lbCartao";
            lbCartao.Size = new Size(154, 66);
            lbCartao.TabIndex = 0;
            lbCartao.Text = "Cartão";
            lbCartao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnCodigo
            // 
            pnCodigo.BackColor = Color.White;
            pnCodigo.Controls.Add(lbCodigo);
            pnCodigo.Controls.Add(txtCodigo);
            pnCodigo.Location = new Point(28, 154);
            pnCodigo.Margin = new Padding(0);
            pnCodigo.Name = "pnCodigo";
            pnCodigo.Size = new Size(933, 186);
            pnCodigo.TabIndex = 2;
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.BackColor = Color.Transparent;
            lbCodigo.Font = new Font("Kodchasan", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCodigo.ForeColor = Color.FromArgb(63, 5, 145);
            lbCodigo.Location = new Point(16, 22);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(329, 50);
            lbCodigo.TabIndex = 4;
            lbCodigo.Text = "Código do seu cartão:";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(63, 5, 145);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Kodchasan", 25.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.ForeColor = Color.White;
            txtCodigo.Location = new Point(16, 97);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(899, 63);
            txtCodigo.TabIndex = 2;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSalvarCodigo
            // 
            btnSalvarCodigo.BackColor = Color.FromArgb(63, 5, 145);
            btnSalvarCodigo.FlatStyle = FlatStyle.Flat;
            btnSalvarCodigo.Font = new Font("Kodchasan", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvarCodigo.ForeColor = Color.White;
            btnSalvarCodigo.Location = new Point(28, 357);
            btnSalvarCodigo.Name = "btnSalvarCodigo";
            btnSalvarCodigo.Size = new Size(933, 78);
            btnSalvarCodigo.TabIndex = 13;
            btnSalvarCodigo.Text = "Gerar e salvar código";
            btnSalvarCodigo.UseVisualStyleBackColor = false;
            btnSalvarCodigo.Click += btnSalvarCodigo_Click;
            // 
            // formCartao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 5, 145);
            ClientSize = new Size(1140, 870);
            Controls.Add(btnSalvarCodigo);
            Controls.Add(pnCartao);
            Controls.Add(pnCodigo);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "formCartao";
            StartPosition = FormStartPosition.Manual;
            Text = "Cartão";
            pnCartao.ResumeLayout(false);
            pnCartao.PerformLayout();
            pnCodigo.ResumeLayout(false);
            pnCodigo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnCartao;
        private Label lbCartao;
        private Panel pnCodigo;
        private Label lbCodigo;
        private TextBox txtCodigo;
        private Button btnSalvarCodigo;
    }
}