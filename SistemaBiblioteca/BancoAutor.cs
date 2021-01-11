using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace SistemaBiblioteca
{
    public class BancoAutor : BancoDeDados
    {
        public BancoAutor() { }
        public void CriarAutor(Autor autor)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Pessoas(nome, genero, nascimento) values (@nome, @genero, @nascimento)";
                    cmd.Parameters.AddWithValue("@nome", autor.Nome);
                    cmd.Parameters.AddWithValue("@genero", autor.Genero);
                    cmd.Parameters.AddWithValue("@nascimento", autor.Nascimento.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT * FROM Pessoas WHERE nome = \"" + autor.Nome + "\" ORDER BY idPessoa DESC LIMIT 1";
                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        autor.idPessoa = Convert.ToInt32(r["idPessoa"]);
                        r.Close();
                        break;
                    }

                    cmd.CommandText = "INSERT INTO Autores(pessoa) values (@id)";
                    cmd.Parameters.AddWithValue("@id", autor.idPessoa);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT * FROM Autores WHERE pessoa = \"" + autor.idPessoa + "\" ORDER BY idAutor DESC LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        autor.idAutor = Convert.ToInt32(r["idAutor"]);
                        r.Close();
                        break;
                    }

                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Autor> GetAutores(List<Autor> lista)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "select idAutor, idPessoa, nome, genero, nascimento from autores inner join pessoas on pessoas.idPessoa = autores.pessoa;";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());

                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        Autor autor = new Autor(Convert.ToInt32(r["idPessoa"]), Convert.ToString(r["nome"]), Convert.ToString(r["nascimento"]), Convert.ToString(r["genero"]), Convert.ToInt32(r["idAutor"]));
                        lista.Add(autor);
                    }

                    r.Close();
                    cmd.Dispose();

                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Autor EditarAutor(Autor autor)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Pessoas SET nome=@nome, genero=@genero, nascimento=@nascimento WHERE idPessoa = @id";
                    cmd.Parameters.AddWithValue("@nome", autor.Nome);
                    cmd.Parameters.AddWithValue("@genero", autor.Genero);
                    cmd.Parameters.AddWithValue("@nascimento", autor.Nascimento.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@id", autor.idPessoa);
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();

                    return autor;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ExcluirAutor(Autor autor)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Livros WHERE autor = @id";
                    cmd.Parameters.AddWithValue("@id", autor.idAutor);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE FROM Autores WHERE idAutor = @id";
                    cmd.Parameters.AddWithValue("@id", autor.idAutor);
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
