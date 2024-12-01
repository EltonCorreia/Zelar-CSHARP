namespace Zelar
{
    partial class formCliente
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label5 = new Label();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            dgvPesquisar = new DataGridView();
            btnPDF = new Button();
            saveFileDialog1 = new SaveFileDialog();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.ForeColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(25);
            flowLayoutPanel1.Size = new Size(1140, 114);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kodchasan", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(63, 5, 145);
            label5.Location = new Point(28, 25);
            label5.Name = "label5";
            label5.Size = new Size(193, 72);
            label5.TabIndex = 0;
            label5.Text = "Clientes";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPesquisar
            // 
            txtPesquisar.BorderStyle = BorderStyle.FixedSingle;
            txtPesquisar.Font = new Font("Kodchasan", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisar.ForeColor = Color.FromArgb(63, 5, 145);
            txtPesquisar.Location = new Point(28, 147);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(517, 37);
            txtPesquisar.TabIndex = 17;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(63, 5, 145);
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Kodchasan", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(755, 147);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(204, 37);
            btnPesquisar.TabIndex = 18;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dgvPesquisar
            // 
            dgvPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPesquisar.Location = new Point(28, 204);
            dgvPesquisar.Name = "dgvPesquisar";
            dgvPesquisar.RowHeadersWidth = 51;
            dgvPesquisar.Size = new Size(931, 562);
            dgvPesquisar.TabIndex = 19;
            dgvPesquisar.CellContentClick += dgvPesquisar_CellContentClick;
            // 
            // btnPDF
            // 
            btnPDF.BackColor = Color.FromArgb(63, 5, 145);
            btnPDF.FlatStyle = FlatStyle.Flat;
            btnPDF.Font = new Font("Kodchasan", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPDF.ForeColor = Color.White;
            btnPDF.Location = new Point(551, 147);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(198, 37);
            btnPDF.TabIndex = 20;
            btnPDF.Text = "Gerar PDF";
            btnPDF.UseVisualStyleBackColor = false;
            btnPDF.Click += btnPDF_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // formCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 5, 145);
            ClientSize = new Size(1140, 870);
            Controls.Add(btnPDF);
            Controls.Add(dgvPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formCliente";
            StartPosition = FormStartPosition.Manual;
            Text = "Clientes";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label5;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private DataGridView dgvPesquisar;
        private Button btnPDF;
        private SaveFileDialog saveFileDialog1;
    }
}