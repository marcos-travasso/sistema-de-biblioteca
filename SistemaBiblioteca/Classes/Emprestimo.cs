﻿using System;
using System.Collections.Generic;

namespace SistemaBiblioteca
{
    public class Emprestimo
    {
        public Emprestimo()
        {
            this.devolucoes = new List<Devolucao>();
        }
        public Emprestimo(int idEmprestimo, string data = "0001/01/01")
        {
            this.devolucoes = new List<Devolucao>();
            this.idEmprestimo = idEmprestimo;
            this.dataDoPedido = Convert.ToDateTime(data);
        }
        public int idEmprestimo { get; set; }
        public Livro livro { get; set; }
        public Usuario usuario { get; set; }
        public DateTime dataDoPedido { get; set; }
        public List<Devolucao> devolucoes { get; set; }
        public int devolvido { get; set; }
        public int getDiferenca()
        {
            return Convert.ToInt32(Math.Ceiling((this.devolucoes[0].dataDeDevolucao - DateTime.Now).TotalDays));
        }
        public void setDados(int idEmprestimo, int idLivro, string titulo, int idUsuario, string nome, int devolvido = 0)
        {
            this.idEmprestimo = idEmprestimo;

            if (this.livro == null) { this.livro = new Livro(idLivro); }
            if (this.usuario == null) { this.usuario = new Usuario(idUsuario); }

            this.livro.Titulo = titulo;
            this.usuario.Nome = nome;
            this.devolvido = devolvido;
        }
    }
}
