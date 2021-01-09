using System;

namespace SistemaBiblioteca
{
    public class Pessoa : Funcoes
    {
        public Pessoa() { }
        public Pessoa(string Nome, string Genero, DateTime Nascimento)
        {
            this.Nome = Nome;
            this.Genero = Genero;
            this.Nascimento = Nascimento;
        }
        public Pessoa(string Nome, string Genero, string Nascimento)
        {
            this.Nome = Nome;
            this.Genero = Genero;
            this.Nascimento = Convert.ToDateTime(Nascimento);
        }
        public string Nome { get; set; }

        public string Genero { get; set; }

        public DateTime Nascimento { get; set; }

        public int idPessoa { get; set; }
        public string getGenero()
        {
            if (this.Genero == "M") { return "Masculino"; }
            else if (this.Genero == "F") { return "Feminino"; }
            else { return "Outro"; }
        }
    }
}
