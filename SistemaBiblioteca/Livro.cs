using System.Collections.Generic;

namespace SistemaBiblioteca
{
    public class Livro
    {
        public Livro()
        {
            this.Generos = new List<Genero>();
        }
        public Livro(int idLivro, string titulo, int ano, int paginas, int idAutor)
        {
            this.idLivro = idLivro;
            this.Titulo = titulo;
            this.Ano = ano;
            this.Paginas = paginas;
            if (idAutor != 0) { this.Autor = new Autor(idAutor); }
            this.Generos = new List<Genero>();
        }
        public Livro(int idLivro)
        {
            this.idLivro = idLivro;
        }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public Autor Autor { get; set; }
        public List<Genero> Generos { get; set; }
        public int idLivro { get; set; }
        public int Paginas { get; set; }
        public string getAutor()
        {
            if (this.Autor == null)
            {
                return "Desconhecido";
            }
            else
            {
                return this.Autor.Nome;
            }
        }
        public void setDados(string titulo, int ano, int paginas, int idAutor)
        {
            this.Titulo = titulo;
            this.Ano = ano;
            this.Paginas = paginas;
            if (idAutor != 0) { this.Autor = new Autor(idAutor); }
            this.Generos = new List<Genero>();
        }
    }
}
