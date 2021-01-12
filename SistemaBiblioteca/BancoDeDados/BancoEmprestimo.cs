using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SistemaBiblioteca
{
    public class BancoEmprestimo : BancoDeDados
    {
        public BancoEmprestimo() { }
        public Emprestimo CriarEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO emprestimos(livro, usuario, datadopedido) values (@idLivro, @idUsuario, @datadopedido)";
                    cmd.Parameters.AddWithValue("@idLivro", emprestimo.livro.idLivro);
                    cmd.Parameters.AddWithValue("@idUsuario", emprestimo.usuario.idUsuario);
                    cmd.Parameters.AddWithValue("@datadopedido", emprestimo.dataDoPedido.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT * FROM Emprestimos WHERE livro = \"" + emprestimo.livro.idLivro.ToString() + "\" ORDER BY datadopedido DESC LIMIT 1";
                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        emprestimo.idEmprestimo = Convert.ToInt32(r["idEmprestimo"]);
                        r.Close();
                        break;
                    }

                    cmd.CommandText = "INSERT INTO devolucoes(emprestimo, datadedevolucao) values (@emprestimo, @datadedevolucao)";
                    cmd.Parameters.AddWithValue("@emprestimo", emprestimo.idEmprestimo);
                    cmd.Parameters.AddWithValue("@datadedevolucao", emprestimo.devolucoes[0].dataDeDevolucao.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT * FROM devolucoes WHERE emprestimo = \"" + emprestimo.idEmprestimo.ToString() + "\" ORDER BY iddevolucao DESC LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        emprestimo.devolucoes[0].idDevolucao = Convert.ToInt32(r["idDevolucao"]);
                        r.Close();
                        break;
                    }
                    cmd.Dispose();

                    DbDisconnection();
                    return emprestimo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> EstaEmprestado(Emprestimo emprestimo, bool devolucaoBool = false)
        {
            List<string> lista = new List<string>();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    Emprestimo emprestado = new Emprestimo();
                    cmd.CommandText = "SELECT devolvido, idEmprestimo FROM Emprestimos WHERE livro = \"" + emprestimo.livro.idLivro.ToString() + "\" ORDER BY idemprestimo DESC LIMIT 1";
                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        if (Convert.ToInt32(r["devolvido"]) == 1)
                        {
                            DbDisconnection();
                            return lista;
                        }
                        else
                        {
                            emprestado.idEmprestimo = Convert.ToInt32(r["idEmprestimo"]);
                            break;
                        }
                    }
                    r.Close();
                    if (devolucaoBool) { cmd.Dispose(); DbDisconnection(); lista.Add(emprestado.idEmprestimo.ToString()); return lista; }


                    cmd.CommandText = "SELECT dataDeDevolucao FROM devolucoes WHERE emprestimo = \"" + emprestado.idEmprestimo.ToString() + "\" ORDER BY emprestimo DESC LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        Devolucao devolucao = new Devolucao(Convert.ToDateTime(r["dataDeDevolucao"]));
                        emprestado.devolucoes.Add(devolucao);

                        lista.Add(emprestado.getDiferenca().ToString());
                        lista.Add(Convert.ToDateTime(r["dataDeDevolucao"]).ToString("dd/MM/yyyy"));
                    }

                    r.Close();
                    cmd.Dispose();
                }
                DbDisconnection();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool TemEmprestado(Emprestimo emprestimo)
        {
            bool resultado = false;
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT devolvido FROM Emprestimos WHERE usuario = \"" + emprestimo.usuario.idUsuario.ToString() + "\" ORDER BY idemprestimo DESC LIMIT 1";
                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        if (Convert.ToInt32(r["devolvido"]) == 0)
                        {
                            resultado = true;
                        }
                    }
                    r.Close();
                    cmd.Dispose();
                    DbDisconnection();

                    return resultado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Emprestimo GetEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    string request = "";
                    if (emprestimo.usuario != null) { request = "idusuario = " + emprestimo.usuario.idUsuario; }
                    if (emprestimo.livro != null) { request = "idlivro = " + emprestimo.livro.idLivro; }

                    cmd.CommandText = "select idEmprestimo, idLivro, titulo, idUsuario, nome from emprestimos inner join usuarios on usuario = idUsuario inner join pessoas on pessoa = idpessoa inner join livros on livro = idlivro where " + request + " order by idemprestimo desc limit 1";
                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        emprestimo.setDados(Convert.ToInt32(r["idEmprestimo"]), Convert.ToInt32(r["idLivro"]), Convert.ToString(r["titulo"]), Convert.ToInt32(r["idUsuario"]), Convert.ToString(r["nome"]));
                    }

                    r.Close();
                    cmd.Dispose();

                    DbDisconnection();
                    return emprestimo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DevolverEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE emprestimos SET devolvido = 1 WHERE idemprestimo = @id";
                    cmd.Parameters.AddWithValue("@id", emprestimo.idEmprestimo);
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
    }
}
