using System;
using System.Collections.Generic;

namespace SistemaBiblioteca
{
    public class Emprestimo
    {
        public Emprestimo() {
            this.devolucoes = new List<Devolucao>();
        }
        public int idEmprestimo { get; set; }
        public Livro livro { get; set; }
        public Usuario usuario { get; set; }
        public DateTime dataDoPedido { get; set; }
        public List<Devolucao> devolucoes { get; set; }
        public int getDiferenca()
        {
            return Convert.ToInt32(Math.Ceiling((this.devolucoes[0].dataDeDevolucao - DateTime.Now).TotalDays));
        }
    }
}
