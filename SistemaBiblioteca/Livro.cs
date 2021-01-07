using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBiblioteca
{
    class Livro
    {
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public Autor Autor { get; set; }
        public List<Genero> Generos { get; set; }
    }
}
