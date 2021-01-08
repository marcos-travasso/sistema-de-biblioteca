using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBiblioteca
{
    public class Pessoa
    {
        public Pessoa() { }
        public Pessoa(string Nome, string Genero, DateTime Nascimento)
        {
            this.Nome = Nome;
            this.Genero = Genero;
            this.Nascimento = Nascimento;
        }
        public string Nome { get; set; }

        public string Genero { get; set; }

        public DateTime Nascimento { get; set; }

        public int idPessoa { get; set; }
    }
}
