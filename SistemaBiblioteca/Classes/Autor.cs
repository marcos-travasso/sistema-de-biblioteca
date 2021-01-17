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
        public Autor(int idAutor)
        {
            this.idAutor = idAutor;
        }
        public int idAutor { get; set; }
        public void setDados(int idPessoa, string nascimento, string genero, int idAutor)
        {
            this.idPessoa = idPessoa;
            this.Genero = genero;
            this.Nascimento = Convert.ToDateTime(nascimento);
            this.idAutor = idAutor;
        }
    }
}
