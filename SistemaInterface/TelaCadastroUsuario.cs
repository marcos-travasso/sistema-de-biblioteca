using SistemaBiblioteca;
using System;
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
                try
                {
                    string genero;
                    DateTime nascimento = Convert.ToDateTime(nascimentoTexto.Text);

                    if (generoTexto.Text == "Masculino") { genero = "M"; }
                    else if (generoTexto.Text == "Feminino") { genero = "F"; }
                    else { genero = "O"; }

                    Usuario novoUsuario = new Usuario(nomeTexto.Text, genero, nascimento);
                    Endereco novoEndereco = new Endereco();

                    BancoDeDados banco = new BancoDeDados();


                    if (celularTexto.Text != "(  )      -") { novoUsuario.Celular = converterNumero(celularTexto.Text); } else { novoUsuario.Celular = ""; }
                    if (telefoneTexto.Text != "(  )     -") { novoUsuario.Telefone = converterNumero(telefoneTexto.Text); } else { novoUsuario.Telefone = ""; }
                    if (cpfTexto.Text != "   .   .   -") { novoUsuario.CPF = converterNumero(cpfTexto.Text); } else { novoUsuario.CPF = ""; }
                    if (emailTexto.Text != "") { novoUsuario.Email = emailTexto.Text; } else { novoUsuario.Email = ""; }

                    if (cepTexto.Text != "     -") { novoEndereco.CEP = converterNumero(cepTexto.Text); } else { novoEndereco.CEP = ""; }
                    if (cidadeTexto.Text != "") { novoEndereco.Cidade = cidadeTexto.Text; } else { novoEndereco.Cidade = ""; }
                    if (bairroTexto.Text != "") { novoEndereco.Bairro = bairroTexto.Text; } else { novoEndereco.Bairro = ""; }
                    if (ruaTexto.Text != "") { novoEndereco.Rua = ruaTexto.Text; } else { novoEndereco.Rua = ""; }
                    if (numeroTexto.Text != "") { novoEndereco.Numero = Convert.ToInt32(numeroTexto.Text); } else { novoEndereco.Numero = 0; }
                    if (complementoTexto.Text != "") { novoEndereco.Complemento = complementoTexto.Text; } else { novoEndereco.Complemento = ""; }

                    novoUsuario.Endereco = novoEndereco;

                    novoUsuario = banco.CriarUsuario(novoUsuario);

                    MessageBox.Show("Usuário cadastrado com sucesso!");

                }
                catch
                {
                    MessageBox.Show("Algum dado está inválido.");
                }
            }
            else
            {
                //TODO dar focus no que falta
                MessageBox.Show("Dados incorretos");
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
