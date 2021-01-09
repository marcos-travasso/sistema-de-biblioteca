using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBiblioteca
{
    public class Endereco : Funcoes
    {
        public Endereco() { }
        public Endereco(int idEndereco, string CEP, string cidade, string bairro, string rua, int numero, string complemento)
        {
            this.CEP = CEP;
            this.Rua = converterNome(rua.Trim());
            this.Numero = numero;
            this.Bairro = bairro.Trim();
            this.Cidade = cidade.Trim();
            this.idEndereco = idEndereco;
            this.Complemento = complemento;
        }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public int idEndereco { get; set; }
    }
}
