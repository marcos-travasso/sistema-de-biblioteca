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
                using (var querry = DbConnection().CreateCommand())
                {
                    querry.CommandText = "INSERT INTO Pessoas(nome, genero, nascimento) values (@nome, @genero, @nascimento)";
                    querry.Parameters.AddWithValue("@nome", autor.Nome);
                    querry.Parameters.AddWithValue("@genero", autor.Genero);
                    querry.Parameters.AddWithValue("@nascimento", autor.Nascimento.ToString("yyyy-MM-dd"));
                    querry.ExecuteNonQuery();

                    querry.CommandText = "SELECT * FROM Pessoas WHERE nome = \"" + autor.Nome + "\" ORDER BY idPessoa DESC LIMIT 1";
                    SQLiteDataReader consulta = querry.ExecuteReader();
                    while (consulta.Read())
                    {
                        autor.idPessoa = Convert.ToInt32(consulta["idPessoa"]);
                        consulta.Close();
                        break;
                    }

                    querry.CommandText = "INSERT INTO Autores(pessoa) values (@id)";
                    querry.Parameters.AddWithValue("@id", autor.idPessoa);
                    querry.ExecuteNonQuery();

                    querry.CommandText = "SELECT * FROM Autores WHERE pessoa = \"" + autor.idPessoa + "\" ORDER BY idAutor DESC LIMIT 1";
                    consulta = querry.ExecuteReader();
                    while (consulta.Read())
                    {
                        autor.idAutor = Convert.ToInt32(consulta["idAutor"]);
                        consulta.Close();
                        break;
                    }

                    querry.Dispose();
                    DbDisconnection();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }
        public List<Autor> GetAutores(List<Autor> lista)
        {
            try
            {
                using (var querry = DbConnection().CreateCommand())
                {
                    querry.CommandText = "select idAutor, idPessoa, nome, genero, nascimento from autores inner join pessoas on pessoas.idPessoa = autores.pessoa;";
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(querry.CommandText, DbConnection());

                    SQLiteDataReader consulta = querry.ExecuteReader();
                    while (consulta.Read())
                    {
                        Autor autor = new Autor();

                        autor.idPessoa = Convert.ToInt32(consulta["idPessoa"]);
                        autor.Nome = Convert.ToString(consulta["nome"]);
                        autor.Genero = Convert.ToString(consulta["genero"]);
                        autor.Nascimento = Convert.ToDateTime(consulta["nascimento"]);
                        autor.idAutor = Convert.ToInt32(consulta["idAutor"]);

                        lista.Add(autor);
                    }

                    consulta.Close();
                    querry.Dispose();

                    DbDisconnection();
                    return lista;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }
        public Autor EditarAutor(Autor autor)
        {
            try
            {
                using (var querry = DbConnection().CreateCommand())
                {
                    querry.CommandText = "UPDATE Pessoas SET nome=@nome, genero=@genero, nascimento=@nascimento WHERE idPessoa = @id";
                    querry.Parameters.AddWithValue("@nome", autor.Nome);
                    querry.Parameters.AddWithValue("@genero", autor.Genero);
                    querry.Parameters.AddWithValue("@nascimento", autor.Nascimento.ToString("yyyy-MM-dd"));
                    querry.Parameters.AddWithValue("@id", autor.idPessoa);
                    querry.ExecuteNonQuery();

                    querry.Dispose();

                    DbDisconnection();
                    return autor;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }
        public void ExcluirAutor(Autor autor)
        {
            try
            {
                using (var querry = DbConnection().CreateCommand())
                {
                    querry.CommandText = "DELETE FROM Livros WHERE autor = @id";
                    querry.Parameters.AddWithValue("@id", autor.idAutor);
                    querry.ExecuteNonQuery();

                    querry.CommandText = "DELETE FROM Autores WHERE idAutor = @id";
                    querry.Parameters.AddWithValue("@id", autor.idAutor);
                    querry.ExecuteNonQuery();

                    querry.Dispose();

                    DbDisconnection();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }
        public Autor GetAutor(Autor autor)
        {
            try
            {
                using (var querry = DbConnection().CreateCommand())
                {
                    querry.CommandText = "select idAutor, idPessoa, genero, nascimento from autores inner join pessoas on pessoas.idPessoa = autores.pessoa WHERE nome = @nome ORDER BY idPessoa DESC limit 1";
                    querry.Parameters.AddWithValue("@nome", autor.Nome);
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(querry.CommandText, DbConnection());

                    SQLiteDataReader consulta = querry.ExecuteReader();
                    while (consulta.Read())
                    {
                        autor.idPessoa = Convert.ToInt32(consulta["idPessoa"]);
                        autor.Genero = Convert.ToString(consulta["genero"]);
                        autor.Nascimento = Convert.ToDateTime(consulta["nascimento"]);
                        autor.idAutor = Convert.ToInt32(consulta["idAutor"]);
                    }

                    consulta.Close();
                    querry.Dispose();

                    DbDisconnection();
                    return autor;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }
    }
}
