using System;

namespace SistemaBiblioteca
{
    public class Autor : Pessoa
    {
        public Autor() { }
        public Autor(string nome)
        {
            this.Nome = nome;
            this.Genero = "O";
            this.Nascimento = Convert.ToDateTime("01/01/0001");
        }
        public Autor(int idAutor)
        {
            this.idAutor = idAutor;
        }
        public int idAutor { get; set; }
    }
}
