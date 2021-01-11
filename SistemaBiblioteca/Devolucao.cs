using System;

namespace SistemaBiblioteca
{
    public class Devolucao
    {
        public Devolucao() { }
        public int idDevolucao { get; set; }
        public Emprestimo emprestimo { get; set; }
        public DateTime dataDeDevolucao { get; set; }
    }
}
