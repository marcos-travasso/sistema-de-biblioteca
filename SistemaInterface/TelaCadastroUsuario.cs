using SistemaBiblioteca;
using System;
using System.Media;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaCadastroUsuario : Form
    {
        public bool menorDeIdade = false;
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
                novoUsuario.Nome = novoUsuario.converterNome(nomeTexto.Text);

                //Inserir dados essenciais
                if (generoTexto.Text == "Masculino") { novoUsuario.Genero = "M"; }
                else if (generoTexto.Text == "Feminino") { novoUsuario.Genero = "F"; }
                else { novoUsuario.Genero = "O"; }

                try { novoUsuario.Nascimento = Convert.ToDateTime(nascimentoTexto.Text); }
                catch { SystemSounds.Beep.Play(); MessageBox.Show("A data de nascimento está incorreta.", "Erro"); nascimentoTexto.Focus(); }

                Endereco novoEndereco = new Endereco();

                BancoDeDados banco = new BancoDeDados();

                //Inserir dados pessoais
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

                //Inserir dados de endereco
                try
                {
                    if (cepTexto.Text != "     -") { novoEndereco.CEP = converterNumero(cepTexto.Text); } else { novoEndereco.CEP = ""; }
                    if (cidadeTexto.Text != "") { novoEndereco.Cidade = novoEndereco.converterNome(cidadeTexto.Text); } else { novoEndereco.Cidade = ""; }
                    if (bairroTexto.Text != "") { novoEndereco.Bairro = novoEndereco.converterNome(bairroTexto.Text); } else { novoEndereco.Bairro = ""; }
                    if (ruaTexto.Text != "") { novoEndereco.Rua = novoEndereco.converterNome(ruaTexto.Text); } else { novoEndereco.Rua = ""; }
                    if (numeroTexto.Text != "") { novoEndereco.Numero = Convert.ToInt32(numeroTexto.Text); } else { novoEndereco.Numero = 0; }
                    if (complementoTexto.Text != "") { novoEndereco.Complemento = complementoTexto.Text; } else { novoEndereco.Complemento = ""; }
                }
                catch
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Algum dado do endereço está inválido.", "Erro");
                }

                //Inserir dados do responsavel caso exista necessidade
                if (menorDeIdade == true && nomeResponsavelTexto.Text != ""){
                    try
                    {
                        Pessoa responsavel = new Pessoa();
                        responsavel.Nome = responsavel.converterNome(nomeResponsavelTexto.Text);

                        if (generoResponsavelTexto.Text != "")
                        {
                            if (generoResponsavelTexto.Text == "Masculino") { responsavel.Genero = "M"; }
                            else if (generoResponsavelTexto.Text == "Feminino") { responsavel.Genero = "F"; }
                            else { responsavel.Genero = "O"; }
                        }

                        if (nascimentoResponsavelTexto.Text != "  /  /")
                        {
                            try { responsavel.Nascimento = Convert.ToDateTime(nascimentoResponsavelTexto.Text); }
                            catch { SystemSounds.Beep.Play(); MessageBox.Show("A data de nascimento do responsável está incorreta.", "Erro"); nascimentoResponsavelTexto.Focus(); }
                        }

                        novoUsuario.Responsavel = responsavel;
                    }
                    catch
                    {
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Algum dado do responsável está inválido.", "Erro");
                    }
                }

                try
                {
                    novoUsuario.Endereco = novoEndereco;

                    if (novoUsuario.Responsavel == null && menorDeIdade)
                    {
                        DialogResult continuar = MessageBox.Show("Deseja cadastrar usuário menor de idade sem um responsável?", "Confirmação", MessageBoxButtons.YesNo);
                        if (continuar == DialogResult.Yes)
                        {
                            novoUsuario = banco.CriarUsuario(novoUsuario);

                            concluirCadastro();
                        } else
                        {
                            nomeResponsavelTexto.Focus();
                        }
                    }
                    else
                    {
                        novoUsuario = banco.CriarUsuario(novoUsuario);

                        concluirCadastro();
                    }
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

        private void nascimentoTexto_Leave(object sender, EventArgs e)
        {
            try
            {
               menorDeIdade = EMenorDeIdade(nascimentoTexto.Text);

                if (menorDeIdade) { nomeResponsavelTexto.Text = ""; generoResponsavelTexto.Text = ""; nascimentoResponsavelTexto.Text = ""; responsavelPanel.Visible = true; menorDeIdade = true; tabOrdemMenor(); }
                else { responsavelPanel.Visible = false; menorDeIdade = false; tabOrdemMaior(); }
                
            }
            catch { SystemSounds.Beep.Play();}
        }

        public bool EMenorDeIdade(string ano)
        {
            DateTime zero = new DateTime(1, 1, 1);

            System.TimeSpan diferenca = Convert.ToDateTime(ano) - DateTime.Now;

            int idade = 0;
            idade = DateTime.Now.Year - Convert.ToDateTime(ano).Year;
            if (DateTime.Now.DayOfYear < Convert.ToDateTime(ano).DayOfYear) { idade = idade - 1; }

            if (idade < 0) { throw new Exception(); }
            else if (idade < 14) { return true; }
            else { return false; }
        }

        private void nascimentoResponsavelTexto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (nascimentoResponsavelTexto.Text != "  /  /")
                {
                    bool menorDeIdadeResponsavel = EMenorDeIdade(nascimentoResponsavelTexto.Text);

                    if (menorDeIdadeResponsavel) { throw new Exception(); }
                }
            }
            catch { nascimentoResponsavelTexto.Text = ""; SystemSounds.Beep.Play(); MessageBox.Show("O responsável não pode ser menor de 14 anos.", "Erro"); nascimentoResponsavelTexto.Focus(); }
        }

        private void tabOrdemMaior()
        {
            cepTexto.TabIndex = 8;
            cidadeTexto.TabIndex = 9;
            bairroTexto.TabIndex = 10;
            ruaTexto.TabIndex = 11;
            numeroTexto.TabIndex = 12;
            complementoTexto.TabIndex = 13;
            cadastrarBotao.TabIndex = 14;

            nomeResponsavelTexto.TabIndex = 16;
            nascimentoResponsavelTexto.TabIndex = 16;
            generoResponsavelTexto.TabIndex = 16;
            responsavelPanel.TabIndex = 16;
        }

        private void tabOrdemMenor()
        {
            responsavelPanel.TabIndex = 8;
            nomeResponsavelTexto.TabIndex = 9;
            nascimentoResponsavelTexto.TabIndex = 10;
            generoResponsavelTexto.TabIndex = 11;

            cepTexto.TabIndex = 12;
            cidadeTexto.TabIndex = 13;
            bairroTexto.TabIndex = 14;
            ruaTexto.TabIndex = 15;
            numeroTexto.TabIndex = 16;
            complementoTexto.TabIndex = 17;
            cadastrarBotao.TabIndex = 18;
        }

        private void concluirCadastro()
        {
            nomeTexto.Text = "";
            nascimentoTexto.Text = "";
            generoTexto.Text = "";
            celularTexto.Text = "";
            telefoneTexto.Text = "";
            cpfTexto.Text = "";
            emailTexto.Text = "";

            cepTexto.Text = "";
            cidadeTexto.Text = "";
            bairroTexto.Text = "";
            ruaTexto.Text = "";
            numeroTexto.Text = "";
            complementoTexto.Text = "";

            nomeResponsavelTexto.Text = "";
            generoResponsavelTexto.Text = "";
            nascimentoResponsavelTexto.Text = "";

            MessageBox.Show("Cadastro concluído com sucesso", "Sucesso");
        }
    }
}
