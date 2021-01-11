using System;

namespace SistemaBiblioteca
{
    public class Autor : Pessoa
    {
        public Autor() { }
        public Autor(int idPessoa, string nome, string nascimento, string genero, int idAutor)
        {
            this.idPessoa = idPessoa;
            this.Nome = nome;
            this.Genero = genero;
            this.Nascimento = Convert.ToDateTime(nascimento);
            this.idAutor = idAutor;
        }
        public Autor(string nome, string genero, string nascimento)
        {
            this.Nome = nome;
            this.Genero = genero;
            this.Nascimento = Convert.ToDateTime(nascimento);
        }
        public int idAutor { get; set; }
    }
}
