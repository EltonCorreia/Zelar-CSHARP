using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelar
{
    internal class ClasseClientes
    {
        private static string numerocartao;

        public void setnumeroCartao(string c)
        {
            numerocartao = c;
        }

        public string getnumeroCartao()
        {
            return numerocartao;
        }
    }
}
