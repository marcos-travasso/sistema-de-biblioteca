namespace SistemaBiblioteca
{
    public class Genero : Funcoes
    {
        public Genero() { }
        public Genero(string nome) {
            this.Nome = converterNome(nome);
        }
        public Genero(int id, string nome)
        {
            this.Nome = converterNome(nome);
            this.idGenero = id;
        }
        public string Nome { get; set; }
        public int idGenero { get; set; }
    }
}
