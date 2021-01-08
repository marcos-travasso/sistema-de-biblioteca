using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace SistemaBiblioteca
{
    public class BancoDeDados
    {
        private SQLiteConnection sqliteConnection;
        public BancoDeDados()
        { }
        private SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=.\\BancoDeDados.db; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        public int AdicionarPessoa(Pessoa pessoa)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Pessoas(Nome, Genero, Nascimento) values (@nome, @genero, @nascimento)";
                    cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
                    cmd.Parameters.AddWithValue("@genero", pessoa.Genero);
                    cmd.Parameters.AddWithValue("@nascimento", pessoa.Nascimento);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT * FROM Pessoas WHERE nome = \"" + pessoa.Nome + "\" ORDER BY idPessoa DESC";
                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        return Convert.ToInt32(r["idPessoa"]);
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return 0;
        }

        public DataTable GetUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Pessoas";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AdicionarUsuario(Pessoa pessoa)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Pessoas(id, Nome) values (@id, @nome)";
                    cmd.Parameters.AddWithValue("@Id", pessoa.idPessoa);
                    cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
