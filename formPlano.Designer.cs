namespace Zelar
{
    partial class formPlano
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
            panel1 = new Panel();
            txtPlano = new TextBox();
            lbPlano = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
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
            flowLayoutPanel1.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kodchasan", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(63, 5, 145);
            label5.Location = new Point(28, 25);
            label5.Name = "label5";
            label5.Size = new Size(140, 72);
            label5.TabIndex = 0;
            label5.Text = "Plano";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtPlano);
            panel1.Controls.Add(lbPlano);
            panel1.Location = new Point(28, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 182);
            panel1.TabIndex = 19;
            // 
            // txtPlano
            // 
            txtPlano.BackColor = Color.FromArgb(63, 5, 145);
            txtPlano.BorderStyle = BorderStyle.FixedSingle;
            txtPlano.Font = new Font("Kodchasan", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlano.ForeColor = Color.White;
            txtPlano.Location = new Point(19, 101);
            txtPlano.Name = "txtPlano";
            txtPlano.ReadOnly = true;
            txtPlano.Size = new Size(899, 56);
            txtPlano.TabIndex = 21;
            txtPlano.TextAlign = HorizontalAlignment.Center;
            // 
            // lbPlano
            // 
            lbPlano.AutoSize = true;
            lbPlano.BackColor = Color.Transparent;
            lbPlano.Font = new Font("Kodchasan", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPlano.ForeColor = Color.FromArgb(63, 5, 145);
            lbPlano.Location = new Point(19, 25);
            lbPlano.Name = "lbPlano";
            lbPlano.Size = new Size(219, 50);
            lbPlano.TabIndex = 20;
            lbPlano.Text = "Tipo de plano:";
            // 
            // formPlano
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 5, 145);
            ClientSize = new Size(1140, 870);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formPlano";
            StartPosition = FormStartPosition.Manual;
            Text = "Plano";
            Load += formPlano_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label5;
        private Panel panel1;
        private Label lbPlano;
        private TextBox txtPlano;
    }
}