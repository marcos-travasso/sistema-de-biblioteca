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

        public Usuario(int idUsuario, string celular, string telefone, string CPF, string email, string criacao, string nome, string genero, string nascimento, Endereco endereco)
        {
            this.Nome = converterNome(nome.Trim());
            this.CPF = CPF;
            this.Genero = genero;
            this.CriacaoDaConta = Convert.ToDateTime(criacao);
            this.Nascimento = Convert.ToDateTime(nascimento);
            this.Celular = celular;
            this.Telefone = telefone;
            this.Endereco = endereco;
            this.idUsuario = idUsuario;
            this.Email = email;
        }

        public string Celular { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime CriacaoDaConta { get; set; }
        public string CPF { get; set; }
        public Usuario Responsavel { get; set; }
        public int idUsuario { get; set; }
        public string Email { get; set; }

        public string getTelefone()
        {
            if (this.Telefone == "") { return ""; }
            string telefone = "(" + this.Telefone.Substring(0, 2) + ") " + this.Telefone.Substring(2, 4) + "-" + this.Telefone.Substring(6, 4);
            return telefone;
        }

        public string getCelular()
        {
            if (this.Celular == "") { return ""; }
            string celular = "(" + this.Celular.Substring(0, 2) + ") " + this.Celular.Substring(2, 5) + "-" + this.Celular.Substring(7, 4);
            return celular;
        }

        public string getCPF()
        {
            if (this.CPF == "") { return ""; }
            string cpf = this.CPF.Substring(0, 3) + "." + this.CPF.Substring(3, 3) + "." + this.CPF.Substring(6, 3) + "-" + this.CPF.Substring(9, 2);
            return cpf;
        }
    }
}
