using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBiblioteca
{
    public class Emprestimo
    {
        public Emprestimo() { }
        public int idEmprestimo { get; set; }
        public Livro livro { get; set; }
        public Usuario usuario { get; set; }
        public DateTime dataDoPedido { get; set; }
        public List<Devolucao> devolucoes { get; set; }
    }
}
