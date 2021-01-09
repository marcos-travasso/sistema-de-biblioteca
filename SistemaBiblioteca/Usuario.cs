using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBiblioteca
{
    public class Usuario : Pessoa
    {
        public Usuario() { }
        public Usuario(string Nome, string Genero, DateTime Nascimento)
        {
            this.Nome = Nome;
            this.Genero = Genero;
            this.Nascimento = Nascimento;
        }

        public string Celular { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime CriacaoDaConta { get; set; }
        public string CPF { get; set; }
        public Usuario Responsavel { get; set; }
        public int idUsuario { get; set; }
        public string Email { get; set; }
    }
}
