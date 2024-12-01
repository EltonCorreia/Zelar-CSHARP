using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelar
{
    public class ClassUsuario
    {
        private static int idComercio;

		//Classe universal: GET e SET na tela de login, recupera o id do comercio e aparece as infos daquele usuario especifico!
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
