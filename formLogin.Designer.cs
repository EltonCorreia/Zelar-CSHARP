namespace Zelar
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            label1 = new Label();
            txtLoginUsuario = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtLoginSenha = new TextBox();
            btnLogin = new Button();
            btnLinkCadastro = new Button();
            cbMostrarSenha = new CheckBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Kodchasan Medium", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 222, 89);
            label1.Location = new Point(379, 47);
            label1.Name = "label1";
            label1.Size = new Size(212, 107);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLoginUsuario
            // 
            txtLoginUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtLoginUsuario.Font = new Font("Kodchasan", 13.8F);
            txtLoginUsuario.ForeColor = Color.FromArgb(63, 5, 145);
            txtLoginUsuario.Location = new Point(393, 186);
            txtLoginUsuario.Name = "txtLoginUsuario";
            txtLoginUsuario.Size = new Size(366, 37);
            txtLoginUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Kodchasan", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(393, 154);
            label2.Name = "label2";
            label2.Size = new Size(77, 30);
            label2.TabIndex = 2;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Kodchasan", 10.1999989F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(393, 225);
            label3.Name = "label3";
            label3.Size = new Size(66, 30);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            // 
            // txtLoginSenha
            // 
            txtLoginSenha.BorderStyle = BorderStyle.FixedSingle;
            txtLoginSenha.Font = new Font("Kodchasan", 13.8F);
            txtLoginSenha.ForeColor = Color.FromArgb(63, 5, 145);
            txtLoginSenha.Location = new Point(393, 257);
            txtLoginSenha.Name = "txtLoginSenha";
            txtLoginSenha.Size = new Size(366, 37);
            txtLoginSenha.TabIndex = 3;
            txtLoginSenha.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new Font("Kodchasan", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(63, 5, 145);
            btnLogin.Location = new Point(393, 332);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(366, 70);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnLinkCadastro
            // 
            btnLinkCadastro.BackColor = Color.FromArgb(63, 5, 145);
            btnLinkCadastro.FlatAppearance.BorderSize = 0;
            btnLinkCadastro.FlatStyle = FlatStyle.Flat;
            btnLinkCadastro.Font = new Font("Kodchasan", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLinkCadastro.ForeColor = Color.FromArgb(255, 222, 89);
            btnLinkCadastro.Location = new Point(393, 405);
            btnLinkCadastro.Margin = new Padding(0);
            btnLinkCadastro.Name = "btnLinkCadastro";
            btnLinkCadastro.Size = new Size(366, 32);
            btnLinkCadastro.TabIndex = 7;
            btnLinkCadastro.Text = "É novo por aqui? Cadastre-se";
            btnLinkCadastro.TextAlign = ContentAlignment.MiddleLeft;
            btnLinkCadastro.UseVisualStyleBackColor = false;
            btnLinkCadastro.Click += btnLinkCadastro_Click;
            // 
            // cbMostrarSenha
            // 
            cbMostrarSenha.AutoSize = true;
            cbMostrarSenha.Font = new Font("Kodchasan", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMostrarSenha.ForeColor = Color.White;
            cbMostrarSenha.Location = new Point(393, 296);
            cbMostrarSenha.Name = "cbMostrarSenha";
            cbMostrarSenha.Size = new Size(158, 34);
            cbMostrarSenha.TabIndex = 9;
            cbMostrarSenha.Text = "Mostrar senha";
            cbMostrarSenha.UseVisualStyleBackColor = true;
            cbMostrarSenha.CheckedChanged += cbMostrarSenha_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 186);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 122);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(321, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 366);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 5, 145);
            ClientSize = new Size(822, 502);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cbMostrarSenha);
            Controls.Add(btnLinkCadastro);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(txtLoginSenha);
            Controls.Add(label2);
            Controls.Add(txtLoginUsuario);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formLogin";
            Padding = new Padding(25);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLoginUsuario;
        private Label label2;
        private Label label3;
        private TextBox txtLoginSenha;
        private Button btnLogin;
        private Button btnLinkCadastro;
        private CheckBox cbMostrarSenha;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}