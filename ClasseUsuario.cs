using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelar
{
    public class ClasseUsuario
    {
        private static int idComercio;

        public int getIdComercio()
        {
            return idComercio;
        }

        public void setIdComercio(int novoCodigo)
        {
            idComercio = novoCodigo;
        }
    }
}
