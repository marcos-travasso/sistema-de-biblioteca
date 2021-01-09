using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBiblioteca
{
    public class Funcoes
    {
        public string converterNome(string nome)
        {
            string retorno = "";

            for (int i = 0; i < nome.Length; i++)
            {
                if (i == 0) { retorno += Convert.ToString(nome[i]).ToUpper(); }
                else if (nome[i - 1] != ' ') { retorno += Convert.ToString(nome[i]).ToLower(); }
                else { retorno += Convert.ToString(nome[i]).ToUpper(); }
            }

            return retorno;
        }
    }
}
