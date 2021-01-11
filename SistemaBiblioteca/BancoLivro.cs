using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace SistemaBiblioteca
{
    public class BancoLivro : BancoDeDados
    {
        public void CriarLivro(Livro livro)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Livros(titulo, ano, autor, paginas) values (@titulo, @ano, @autor, @paginas)";
                    cmd.Parameters.AddWithValue("@titulo", livro.Titulo);
                    cmd.Parameters.AddWithValue("@ano", livro.Ano);
                    if (livro.Autor != null) { cmd.Parameters.AddWithValue("@autor", livro.Autor.idAutor); } else { cmd.Parameters.AddWithValue("@autor", "0"); }
                    cmd.Parameters.AddWithValue("@paginas", livro.Paginas);

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT * FROM Livros WHERE titulo = \"" + livro.Titulo + "\" ORDER BY idLivro DESC LIMIT 1";
                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        livro.idLivro = Convert.ToInt32(r["idLivro"]);
                        r.Close();
                        break;
                    }

                    foreach (Genero genero in livro.Generos)
                    {
                        cmd.CommandText = "INSERT INTO generos_dos_livros(livro, genero) values (@livro, @genero)";
                        cmd.Parameters.AddWithValue("@livro", livro.idLivro);
                        cmd.Parameters.AddWithValue("@genero", genero.idGenero);

                        cmd.ExecuteNonQuery();
                    }

                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Livro> GetLivros(List<Livro> lista)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "select * from livros";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());

                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        Livro livro = new Livro(Convert.ToInt32(r["idLivro"]), Convert.ToString(r["titulo"]), Convert.ToInt32(r["ano"]), Convert.ToInt32(r["paginas"]), Convert.ToInt32(r["autor"]));
                        lista.Add(livro);
                    }

                    r.Close();

                    foreach (Livro livro in lista)
                    {
                        if (livro.Autor != null)
                        {
                            cmd.CommandText = "select idPessoa, nome, genero, nascimento from autores inner join pessoas on pessoas.idPessoa = autores.pessoa where idAutor = @id";
                            cmd.Parameters.AddWithValue("@id", livro.Autor.idAutor);
                            da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());

                            r = cmd.ExecuteReader();
                            while (r.Read())
                            {
                                livro.Autor.Nome = Convert.ToString(r["nome"]);
                                livro.Autor.Genero = Convert.ToString(r["genero"]);
                                livro.Autor.setNascimento(Convert.ToString(r["nascimento"]));
                                livro.Autor.idPessoa = Convert.ToInt32(r["idPessoa"]);

                                break;
                            }
                            r.Close();
                        }

                        cmd.CommandText = "select idGenero, nome from generos_dos_livros inner join livros on livros.idLivro = generos_dos_livros.livro inner join Generos on generos_dos_livros.genero = generos.idGenero where idLivro = @id";
                        cmd.Parameters.AddWithValue("@id", livro.idLivro);
                        da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());

                        r = cmd.ExecuteReader();
                        while (r.Read())
                        {
                            livro.Generos.Add(new Genero(Convert.ToInt32(r["idGenero"]), Convert.ToString(r["nome"])));
                        }
                        r.Close();
                    }

                    cmd.Dispose();

                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Livro EditarLivro(Livro livro)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Livros SET titulo=@titulo, ano=@ano, autor=@idAutor, paginas=@paginas WHERE idLivro = @idLivro";
                    cmd.Parameters.AddWithValue("@titulo", livro.Titulo);
                    cmd.Parameters.AddWithValue("@ano", livro.Ano);
                    if (livro.Autor == null)
                    {
                        cmd.Parameters.AddWithValue("@idAutor", "0");
                    }
                    else { cmd.Parameters.AddWithValue("@idAutor", livro.Autor.idAutor); }
                    cmd.Parameters.AddWithValue("@paginas", livro.Paginas);
                    cmd.Parameters.AddWithValue("@idLivro", livro.idLivro);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE FROM generos_dos_livros WHERE livro = @idLivro";
                    cmd.Parameters.AddWithValue("@idLivro", livro.idLivro);
                    cmd.ExecuteNonQuery();

                    foreach (Genero genero in livro.Generos)
                    {
                        cmd.CommandText = "INSERT INTO generos_dos_livros(livro, genero) values (@livro, @genero)";
                        cmd.Parameters.AddWithValue("@livro", livro.idLivro);
                        cmd.Parameters.AddWithValue("@genero", genero.idGenero);

                        cmd.ExecuteNonQuery();
                    }

                    cmd.Dispose();

                    return livro;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ExcluirLivro(Livro livro)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM generos_dos_livros WHERE livro = @id";
                    cmd.Parameters.AddWithValue("@id", livro.idLivro);
                    cmd.ExecuteNonQuery();
                    //remover registros de devolucoes e emprestimos aqui

                    cmd.CommandText = "DELETE FROM Livros WHERE idLivro = @id";
                    cmd.Parameters.AddWithValue("@id", livro.idLivro);
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
