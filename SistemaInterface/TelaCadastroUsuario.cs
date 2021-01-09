using SistemaBiblioteca;
using System;
using System.Media;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaCadastroUsuario : Form
    {
        public TelaCadastroUsuario()
        {
            InitializeComponent();
        }

        public string converterNumero(string numero)
        {
            string retorno = "";
            foreach (char num in numero)
            {
                if (Char.IsNumber(num))
                {
                    retorno += num;
                }
            }

            return retorno;
        }

        private void cadastrarBotao_Click(object sender, EventArgs e)
        {
            if (generoTexto.Text != "" && nascimentoTexto.Text != "  /  /" && nomeTexto.Text != "")
            {
                Usuario novoUsuario = new Usuario();
                novoUsuario.Nome = nomeTexto.Text;

                if (generoTexto.Text == "Masculino") { novoUsuario.Genero = "M"; }
                else if (generoTexto.Text == "Feminino") { novoUsuario.Genero = "F"; }
                else { novoUsuario.Genero = "O"; }

                try { novoUsuario.Nascimento = Convert.ToDateTime(nascimentoTexto.Text); }
                catch { SystemSounds.Beep.Play(); MessageBox.Show("A data de nascimento está incorreta.", "Erro"); nascimentoTexto.Focus(); }

                Endereco novoEndereco = new Endereco();

                BancoDeDados banco = new BancoDeDados();

                try
                {
                    if (celularTexto.Text != "(  )      -") { novoUsuario.Celular = converterNumero(celularTexto.Text); } else { novoUsuario.Celular = ""; }
                    if (telefoneTexto.Text != "(  )     -") { novoUsuario.Telefone = converterNumero(telefoneTexto.Text); } else { novoUsuario.Telefone = ""; }
                    if (cpfTexto.Text != "   .   .   -") { novoUsuario.CPF = converterNumero(cpfTexto.Text); } else { novoUsuario.CPF = ""; }
                    if (emailTexto.Text != "") { novoUsuario.Email = emailTexto.Text; } else { novoUsuario.Email = ""; }
                }
                catch
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Algum dado pessoal está inválido.", "Erro");
                }

                try
                {
                    if (cepTexto.Text != "     -") { novoEndereco.CEP = converterNumero(cepTexto.Text); } else { novoEndereco.CEP = ""; }
                    if (cidadeTexto.Text != "") { novoEndereco.Cidade = cidadeTexto.Text; } else { novoEndereco.Cidade = ""; }
                    if (bairroTexto.Text != "") { novoEndereco.Bairro = bairroTexto.Text; } else { novoEndereco.Bairro = ""; }
                    if (ruaTexto.Text != "") { novoEndereco.Rua = ruaTexto.Text; } else { novoEndereco.Rua = ""; }
                    if (numeroTexto.Text != "") { novoEndereco.Numero = Convert.ToInt32(numeroTexto.Text); } else { novoEndereco.Numero = 0; }
                    if (complementoTexto.Text != "") { novoEndereco.Complemento = complementoTexto.Text; } else { novoEndereco.Complemento = ""; }
                }
                catch
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Algum dado do endereço está inválido.", "Erro");
                }

                try
                {
                    novoUsuario.Endereco = novoEndereco;

                    novoUsuario = banco.CriarUsuario(novoUsuario);

                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
                catch
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Não foi possível cadastrar o usuário.", "Erro");
                }
            }
            else
            {
                if (nomeTexto.Text == "") { SystemSounds.Beep.Play(); MessageBox.Show("É necessário um nome para criar usuário.", "Erro"); nomeTexto.Focus(); }
                else if (nascimentoTexto.Text == "  /  /") { SystemSounds.Beep.Play(); MessageBox.Show("É necessário uma data de nascimento para criar usuário.", "Erro"); nascimentoTexto.Focus(); }
                else if (generoTexto.Text == "") { SystemSounds.Beep.Play(); MessageBox.Show("É necessário um gênero para criar usuário.", "Erro"); generoTexto.Focus(); }
            }
        }

        private void TelaCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cadastrarBotao.PerformClick();
            }
        }
    }
}
