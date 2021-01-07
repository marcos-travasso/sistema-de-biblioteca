using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBiblioteca
{
    class Usuario : Pessoa
    {
        public string celular { get; set; }
        public string telefone { get; set; }
        public Endereco endereco { get; set; }
        public DateTime criacaoDaConta { get; set; }
        public string CPF { get; set; }
        public Usuario Responsavel { get; set; }
    }
}
