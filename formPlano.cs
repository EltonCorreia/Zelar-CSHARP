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
    public partial class formPlano : Form
    {
        ClasseConexao con;
        ClasseUsuario user;
        DataTable dt;
        int idComercio;
        public formPlano()
        {
            InitializeComponent();
        }
        private void pegarId()
        {
            user = new ClasseUsuario();
            idComercio = user.getIdComercio();
        }
        private void consultarDados(String sql)
        {
            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executarSQL(sql);
            mostrarDados();
        }
        private void mostrarDados()
        {
            txtPlano.Text = dt.Rows[0]["planoComercio"].ToString();
        }

        private void formPlano_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            pegarId();
            consultarDados($"SELECT * FROM comercio where idComercio = {idComercio}");
        }
    }
}
