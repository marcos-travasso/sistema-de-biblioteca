﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace SistemaBiblioteca
{
    public class BancoUsuario : BancoDeDados
    {
        public BancoUsuario() { }
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

                    cmd.CommandText = "SELECT * FROM Pessoas WHERE nome = \"" + usuario.Nome + "\" ORDER BY idPessoa DESC LIMIT 1";
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

                    cmd.CommandText = "SELECT * FROM Enderecos WHERE CEP = \"" + usuario.Endereco.CEP + "\" ORDER BY idEndereco DESC LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        usuario.Endereco.idEndereco = Convert.ToInt32(r["idEndereco"]);
                        r.Close();
                        break;
                    }

                    if (usuario.Responsavel != null)
                    {
                        cmd.CommandText = "INSERT INTO Pessoas(Nome, Genero, Nascimento) values (@nome, @genero, @nascimento)";
                        cmd.Parameters.AddWithValue("@nome", usuario.Responsavel.Nome);
                        if (usuario.Responsavel.Genero != null) { cmd.Parameters.AddWithValue("@genero", usuario.Responsavel.Genero); } else { cmd.Parameters.AddWithValue("@genero", "N"); }
                        cmd.Parameters.AddWithValue("@nascimento", usuario.Responsavel.Nascimento.ToString("yyyy-MM-dd"));
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "SELECT * FROM Pessoas WHERE nome = \"" + usuario.Responsavel.Nome + "\" ORDER BY idPessoa DESC LIMIT 1";
                        r = cmd.ExecuteReader();
                        while (r.Read())
                        {
                            usuario.Responsavel.idPessoa = Convert.ToInt32(r["idPessoa"]);
                            r.Close();
                            break;
                        }
                        cmd.CommandText = "INSERT INTO Usuarios(pessoa, celular, telefone, endereco, cpf, email, criacao, responsavel) values (@pessoa, @celular, @telefone, @endereco, @cpf, @email, @criacao, @responsavel)";
                        cmd.Parameters.AddWithValue("@responsavel", usuario.Responsavel.idPessoa);
                    }

                    if (usuario.Responsavel == null)
                    {
                        cmd.CommandText = "INSERT INTO Usuarios(pessoa, celular, telefone, endereco, cpf, email, criacao) values (@pessoa, @celular, @telefone, @endereco, @cpf, @email, @criacao)";
                    }
                    cmd.Parameters.AddWithValue("@pessoa", usuario.idPessoa);
                    cmd.Parameters.AddWithValue("@celular", usuario.Celular);
                    cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
                    cmd.Parameters.AddWithValue("@endereco", usuario.Endereco.idEndereco);
                    cmd.Parameters.AddWithValue("@cpf", usuario.CPF);
                    cmd.Parameters.AddWithValue("@email", usuario.Email);
                    cmd.Parameters.AddWithValue("@criacao", DateTime.Now);
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();

                    DbDisconnection();
                    return usuario;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Usuario EditarUsuario(Usuario usuario)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Pessoas SET nome=@nome, genero=@genero, nascimento=@nascimento WHERE idPessoa = @id";
                    cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@genero", usuario.Genero);
                    cmd.Parameters.AddWithValue("@nascimento", usuario.Nascimento.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@id", usuario.idPessoa);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "UPDATE Enderecos SET CEP=@CEP, cidade=@cidade, bairro=@bairro, rua=@rua, numero=@numero, complemento=@complemento WHERE idEndereco = @id";
                    cmd.Parameters.AddWithValue("@CEP", usuario.Endereco.CEP);
                    cmd.Parameters.AddWithValue("@cidade", usuario.Endereco.Cidade);
                    cmd.Parameters.AddWithValue("@bairro", usuario.Endereco.Bairro);
                    cmd.Parameters.AddWithValue("@rua", usuario.Endereco.Rua);
                    cmd.Parameters.AddWithValue("@numero", usuario.Endereco.Numero);
                    cmd.Parameters.AddWithValue("@complemento", usuario.Endereco.Complemento);
                    cmd.Parameters.AddWithValue("@id", usuario.Endereco.idEndereco);
                    cmd.ExecuteNonQuery();

                    if (usuario.Responsavel != null)
                    {
                        cmd.CommandText = "UPDATE Pessoas SET nome=@nome, genero=@genero, nascimento=@nascimento WHERE idPessoa = @id";
                        cmd.Parameters.AddWithValue("@nome", usuario.Responsavel.Nome);
                        if (usuario.Responsavel.Genero != null) { cmd.Parameters.AddWithValue("@genero", usuario.Responsavel.Genero); } else { cmd.Parameters.AddWithValue("@genero", "N"); }
                        cmd.Parameters.AddWithValue("@nascimento", usuario.Responsavel.Nascimento.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@id", usuario.Responsavel.idPessoa);
                        cmd.ExecuteNonQuery();
                    }

                    cmd.CommandText = "UPDATE Usuarios SET pessoa=@pessoa, celular=@celular, telefone=@telefone, endereco=@endereco, cpf=@cpf, email=@email WHERE idUsuario = @id";
                    cmd.Parameters.AddWithValue("@pessoa", usuario.idPessoa);
                    cmd.Parameters.AddWithValue("@celular", usuario.Celular);
                    cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
                    cmd.Parameters.AddWithValue("@endereco", usuario.Endereco.idEndereco);
                    cmd.Parameters.AddWithValue("@cpf", usuario.CPF);
                    cmd.Parameters.AddWithValue("@email", usuario.Email);
                    cmd.Parameters.AddWithValue("@id", usuario.idUsuario);
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    DbDisconnection();
                    return usuario;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Usuario> GetUsuarios(List<Usuario> lista)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "select * from ((Usuarios inner join Pessoas on Pessoas.idPessoa = Usuarios.pessoa) inner join Enderecos on Usuarios.endereco = Enderecos.idEndereco);";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());

                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        Endereco endereco = new Endereco(Convert.ToInt32(r["idEndereco"]), Convert.ToString(r["cep"]), Convert.ToString(r["cidade"]), Convert.ToString(r["bairro"]), Convert.ToString(r["rua"]), Convert.ToInt32(r["numero"]), Convert.ToString(r["complemento"]));
                        Usuario usuario = new Usuario(Convert.ToInt32(r["pessoa"]), Convert.ToInt32(r["idUsuario"]), Convert.ToString(r["celular"]), Convert.ToString(r["telefone"]), Convert.ToString(r["cpf"]), Convert.ToString(r["email"]), Convert.ToString(r["criacao"]), Convert.ToString(r["nome"]), Convert.ToString(r["genero"]), Convert.ToString(r["nascimento"]), endereco);

                        lista.Add(usuario);
                    }

                    r.Close();

                    foreach (Usuario pessoa in lista)
                    {
                        cmd.CommandText = "select idPessoa, nome, genero, nascimento from usuarios inner join pessoas on usuarios.responsavel = Pessoas.idPessoa where idUsuario = @id";
                        cmd.Parameters.AddWithValue("@id", pessoa.idUsuario);
                        da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());

                        r = cmd.ExecuteReader();
                        while (r.Read())
                        {
                            pessoa.Responsavel = new Pessoa(Convert.ToString(r["nome"]), Convert.ToString(r["genero"]), Convert.ToString(r["nascimento"]));
                            pessoa.Responsavel.idPessoa = Convert.ToInt32(r["idPessoa"]);
                            break;
                        }
                        r.Close();

                    }
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
        public void ExcluirUsuario(Usuario usuario)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Enderecos WHERE idEndereco = @id";
                    cmd.Parameters.AddWithValue("@id", usuario.Endereco.idEndereco);
                    cmd.ExecuteNonQuery();

                    if (usuario.Responsavel != null)
                    {
                        cmd.CommandText = "DELETE FROM Pessoas WHERE idPessoa = @id";
                        cmd.Parameters.AddWithValue("@id", usuario.Responsavel.idPessoa);
                        cmd.ExecuteNonQuery();
                    }

                    cmd.CommandText = "DELETE FROM Usuarios WHERE idUsuario = @id";
                    cmd.Parameters.AddWithValue("@id", usuario.idUsuario);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE FROM Pessoas WHERE idPessoa = @id";
                    cmd.Parameters.AddWithValue("@id", usuario.idPessoa);
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
        public Usuario GetUsuario(Usuario usuario)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "select * from ((Usuarios inner join Pessoas on Pessoas.idPessoa = Usuarios.pessoa) inner join Enderecos on Usuarios.endereco = Enderecos.idEndereco) WHERE idUsuario = @id;";
                    cmd.Parameters.AddWithValue("@id", usuario.idUsuario);
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());

                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        Endereco endereco = new Endereco(Convert.ToInt32(r["idEndereco"]), Convert.ToString(r["cep"]), Convert.ToString(r["cidade"]), Convert.ToString(r["bairro"]), Convert.ToString(r["rua"]), Convert.ToInt32(r["numero"]), Convert.ToString(r["complemento"]));
                        usuario = new Usuario(Convert.ToInt32(r["pessoa"]), Convert.ToInt32(r["idUsuario"]), Convert.ToString(r["celular"]), Convert.ToString(r["telefone"]), Convert.ToString(r["cpf"]), Convert.ToString(r["email"]), Convert.ToString(r["criacao"]), Convert.ToString(r["nome"]), Convert.ToString(r["genero"]), Convert.ToString(r["nascimento"]), endereco);
                    }

                    r.Close();

                    cmd.CommandText = "select idPessoa, nome, genero, nascimento from usuarios inner join pessoas on usuarios.responsavel = Pessoas.idPessoa where idUsuario = @id";
                    cmd.Parameters.AddWithValue("@id", usuario.idUsuario);
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());

                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        usuario.Responsavel = new Pessoa(Convert.ToString(r["nome"]), Convert.ToString(r["genero"]), Convert.ToString(r["nascimento"]));
                        usuario.Responsavel.idPessoa = Convert.ToInt32(r["idPessoa"]);
                        break;
                    }
                    r.Close();

                    cmd.Dispose();
                    DbDisconnection();

                    return usuario;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
