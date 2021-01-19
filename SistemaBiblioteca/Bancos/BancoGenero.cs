using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace SistemaBiblioteca
{
    public class BancoGenero : BancoDeDados
    {
        public BancoGenero() { }
        public void CriarGenero(Genero genero)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Generos(nome) values (@nome)";
                    cmd.Parameters.AddWithValue("@nome", genero.Nome);
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    DbDisconnection();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Genero> GetGeneros(List<Genero> lista)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "select * from Generos";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());

                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        Genero genero = new Genero(Convert.ToInt32(r["idGenero"]), Convert.ToString(r["nome"]));
                        lista.Add(genero);
                    }

                    r.Close();
                    cmd.Dispose();

                    DbDisconnection();
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Genero EditarGenero(Genero genero)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Generos SET nome=@nome WHERE idGenero = @id";
                    cmd.Parameters.AddWithValue("@nome", genero.Nome);
                    cmd.Parameters.AddWithValue("@id", genero.idGenero);
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();

                    DbDisconnection();
                    return genero;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ExcluirGenero(Genero genero)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM generos_dos_livros WHERE genero = @id";
                    cmd.Parameters.AddWithValue("@id", genero.idGenero);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE FROM Generos WHERE idGenero = @id";
                    cmd.Parameters.AddWithValue("@id", genero.idGenero);
                    cmd.ExecuteNonQuery();

                    DbDisconnection();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Livro> ProcurarGeneros(List<Genero> listaGeneros)
        {
            List<Livro> listaLivros = new List<Livro>();

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = $"select * from livros inner join generos_dos_livros on idLivro = livro inner join generos on genero = idgenero where nome = \"{listaGeneros[0].Nome}\"";
                    if (listaGeneros.Count > 1)
                    {
                        listaGeneros.RemoveAt(0);
                        foreach (Genero genero in listaGeneros)
                        {
                            cmd.CommandText += $"or nome = \"{genero.Nome}\"";
                        }
                    }

                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());

                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        Livro livro = new Livro(Convert.ToInt32(r["idLivro"]));
                        listaLivros.Add(livro);
                    }

                    r.Close();
                    cmd.Dispose();

                    DbDisconnection();
                    return listaLivros;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
