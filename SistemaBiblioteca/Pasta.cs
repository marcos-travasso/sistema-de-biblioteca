﻿namespace SistemaBiblioteca
{
    public class Pasta
    {
        public Pasta() { }
        public Pasta(string nome, string id)
        {
            this.Nome = nome;
            this.Id = id;
        }
        public string Nome { get; set; }
        public string Id { get; set; }
    }
}
