namespace Zelar
{
    partial class formFuncoes
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
            pnFuncoes = new FlowLayoutPanel();
            lbFuncoes = new Label();
            btnSair = new Button();
            btnAtualizar = new Button();
            pnFuncoes.SuspendLayout();
            SuspendLayout();
            // 
            // pnFuncoes
            // 
            pnFuncoes.BackColor = Color.White;
            pnFuncoes.Controls.Add(lbFuncoes);
            pnFuncoes.Dock = DockStyle.Top;
            pnFuncoes.ForeColor = Color.Transparent;
            pnFuncoes.Location = new Point(0, 0);
            pnFuncoes.Margin = new Padding(0);
            pnFuncoes.Name = "pnFuncoes";
            pnFuncoes.Padding = new Padding(25);
            pnFuncoes.Size = new Size(1140, 114);
            pnFuncoes.TabIndex = 17;
            // 
            // lbFuncoes
            // 
            lbFuncoes.AutoSize = true;
            lbFuncoes.BackColor = Color.Transparent;
            lbFuncoes.Font = new Font("Kodchasan", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFuncoes.ForeColor = Color.FromArgb(63, 5, 145);
            lbFuncoes.Location = new Point(28, 25);
            lbFuncoes.Name = "lbFuncoes";
            lbFuncoes.Size = new Size(194, 72);
            lbFuncoes.TabIndex = 0;
            lbFuncoes.Text = "Funções";
            lbFuncoes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(63, 5, 145);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Kodchasan", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(28, 222);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(946, 59);
            btnSair.TabIndex = 18;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(63, 5, 145);
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Kodchasan", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(28, 146);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(946, 59);
            btnAtualizar.TabIndex = 19;
            btnAtualizar.Text = "Atualizar dados cadastrais";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // formFuncoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 5, 145);
            ClientSize = new Size(1140, 870);
            Controls.Add(btnAtualizar);
            Controls.Add(btnSair);
            Controls.Add(pnFuncoes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formFuncoes";
            StartPosition = FormStartPosition.Manual;
            Text = "Funções";
            pnFuncoes.ResumeLayout(false);
            pnFuncoes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnFuncoes;
        private Label lbFuncoes;
        private Button btnSair;
        private Button btnAtualizar;
    }
}