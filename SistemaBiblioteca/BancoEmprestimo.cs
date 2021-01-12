using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

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

                    return emprestimo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> EstaEmprestado(Emprestimo emprestimo)
        {
            List<string> lista = new List<string>();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    Emprestimo emprestado = new Emprestimo();
                    cmd.CommandText = "SELECT devolvido, idEmprestimo FROM Emprestimos WHERE livro = \"" + emprestimo.livro.idLivro.ToString() + "\" ORDER BY datadopedido DESC LIMIT 1";
                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        if (Convert.ToInt32(r["devolvido"]) == 1){
                            return lista;
                        }
                        else
                        {
                            emprestado.idEmprestimo = Convert.ToInt32(r["idEmprestimo"]);
                            break;
                        }
                    }
                    r.Close();

                    cmd.CommandText = "SELECT dataDeDevolucao FROM devolucoes WHERE emprestimo = \"" + emprestado.idEmprestimo.ToString() + "\" ORDER BY datadedevolucao DESC LIMIT 1";
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
                    cmd.CommandText = "SELECT devolvido FROM Emprestimos WHERE usuario = \"" + emprestimo.usuario.idUsuario.ToString() + "\" ORDER BY datadopedido DESC LIMIT 1";
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
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
