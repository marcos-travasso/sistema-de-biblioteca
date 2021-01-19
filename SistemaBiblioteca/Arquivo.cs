using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBiblioteca
{
    public class Arquivo
    {
        public Arquivo() { }
        public Arquivo(string nome, string id)
        {
            this.Nome = nome;
            this.Id = id;
        }
        public string Nome { get; set; }
        public string Id { get; set; }
    }
}
