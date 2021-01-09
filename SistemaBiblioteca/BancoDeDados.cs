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

        public Usuario CriarUsuario(Usuario usuario)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    //Sim, eu sei como tudo está extremamente ridículo, porém eu não estava conseguindo fechar a conexão com o banco de dados, então levei me consideração executar tudo de uma vez. Peço perdão.
                    cmd.CommandText = "INSERT INTO Pessoas(Nome, Genero, Nascimento) values (@nome, @genero, @nascimento)";
                    cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@genero", usuario.Genero);
                    cmd.Parameters.AddWithValue("@nascimento", usuario.Nascimento.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT * FROM Pessoas WHERE nome = \"" + usuario.Nome + "\" ORDER BY idPessoa DESC";
                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        usuario.idPessoa = Convert.ToInt32(r["idPessoa"]);
                        r.Close();
                        break;
                    }

                    cmd.CommandText = "INSERT INTO Enderecos(CEP, cidade, bairro, rua, numero, complemento) values (@CEP, @cidade, @bairro, @rua, @numero, @complemento)";
                    cmd.Parameters.AddWithValue("@CEP", usuario.Endereco.CEP);
                    cmd.Parameters.AddWithValue("@cidade", usuario.Endereco.Cidade);
                    cmd.Parameters.AddWithValue("@bairro", usuario.Endereco.Bairro);
                    cmd.Parameters.AddWithValue("@rua", usuario.Endereco.Rua);
                    cmd.Parameters.AddWithValue("@numero", usuario.Endereco.Numero);
                    cmd.Parameters.AddWithValue("@complemento", usuario.Endereco.Complemento);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT * FROM Enderecos WHERE CEP = \"" + usuario.Endereco.CEP + "\" ORDER BY idEndereco DESC";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        usuario.Endereco.idEndereco = Convert.ToInt32(r["idEndereco"]);
                        r.Close();
                        break;
                    }

                    cmd.CommandText = "INSERT INTO Usuarios(pessoa, celular, telefone, endereco, cpf, email, criacao) values (@pessoa, @celular, @telefone, @endereco, @cpf, @email, @criacao)";
                    cmd.Parameters.AddWithValue("@pessoa", usuario.idPessoa);
                    cmd.Parameters.AddWithValue("@celular", usuario.Celular);
                    cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
                    cmd.Parameters.AddWithValue("@endereco", usuario.Endereco.idEndereco);
                    cmd.Parameters.AddWithValue("@cpf", usuario.CPF);
                    cmd.Parameters.AddWithValue("@email", usuario.Email);
                    cmd.Parameters.AddWithValue("@criacao", DateTime.Now);
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();

                    return usuario;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    sqliteConnection.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
