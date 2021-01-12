using System;

namespace SistemaBiblioteca
{
    public class Devolucao
    {
        public Devolucao() { }
        public Devolucao(DateTime data)
        {
            this.dataDeDevolucao = data;
        }
        public int idDevolucao { get; set; }
        public Emprestimo emprestimo { get; set; }
        public DateTime dataDeDevolucao { get; set; }
    }
}
