using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zelar
{
    public partial class formFuncoes : Form
    {
        public formFuncoes()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            formAtualizar atualizar = new formAtualizar();
            atualizar.Show();
        }
    }
}
