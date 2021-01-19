using SistemaBiblioteca;
using System;
using System.Media;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaInformacoesUsuario : Form
    {
        bool admin = false;
        bool menorDeIdade = false;
        Usuario usuario;
        public TelaInformacoesUsuario()
        {
            this.admin = false;
            InitializeComponent();
        }

        public TelaInformacoesUsuario(bool editar, Usuario usuario)
        {
            this.admin = editar;
            this.usuario = usuario;
            InitializeComponent();
        }

        private void TelaInformacoesUsuario_Load(object sender, EventArgs e)
        {
            alterarCaixas();
            setarDados();
        }

        private void alterarCaixas()
        {
            nomeTexto.ReadOnly = !this.admin;
            nascimentoTexto.ReadOnly = !this.admin;
            generoTexto.Enabled = this.admin;
            celularTexto.ReadOnly = !this.admin;
            telefoneTexto.ReadOnly = !this.admin;
            cpfTexto.ReadOnly = !this.admin;
            emailTexto.ReadOnly = !this.admin;

            cepTexto.ReadOnly = !this.admin;
            cidadeTexto.ReadOnly = !this.admin;
            bairroTexto.ReadOnly = !this.admin;
            ruaTexto.ReadOnly = !this.admin;
            numeroTexto.ReadOnly = !this.admin;
            complementoTexto.ReadOnly = !this.admin;

            nomeResponsavelTexto.ReadOnly = !this.admin;
            generoResponsavelTexto.Enabled = this.admin;
            nascimentoResponsavelTexto.ReadOnly = !this.admin;

            editarBotao.Enabled = this.admin;
            excluirBotao.Enabled = this.admin;
        }

        private void setarDados()
        {
            idLabel.Text = "Usuário número: " + Convert.ToString(usuario.idUsuario);
            this.Text = "Informações do usuário " + Convert.ToString(usuario.idUsuario);

            nomeTexto.Text = usuario.Nome;
            nascimentoTexto.Text = usuario.Nascimento.ToString().Substring(0, 10);
            generoTexto.Text = usuario.getGenero();
            celularTexto.Text = usuario.Celular;
            telefoneTexto.Text = usuario.Telefone;
            cpfTexto.Text = usuario.CPF;
            emailTexto.Text = usuario.Email;

            cepTexto.Text = usuario.Endereco.CEP;
            cidadeTexto.Text = usuario.Endereco.Cidade;
            bairroTexto.Text = usuario.Endereco.Bairro;
            ruaTexto.Text = usuario.Endereco.Rua;
            numeroTexto.Text = usuario.Endereco.Numero.ToString();
            complementoTexto.Text = usuario.Endereco.Complemento;

            if (usuario.Responsavel != null)
            {
                responsavelPanel.Visible = true;
                nomeResponsavelTexto.Text = usuario.Responsavel.Nome;
                generoResponsavelTexto.Text = usuario.Responsavel.getGenero();
                nascimentoResponsavelTexto.Text = usuario.Responsavel.Nascimento.ToString().Substring(0, 10);
            }
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

        private void editarBotao_Click(object sender, EventArgs e)
        {
            if (generoTexto.Text != "" && nascimentoTexto.Text != "  /  /" && nomeTexto.Text != "")
            {
                usuario.Nome = usuario.converterNome(nomeTexto.Text);

                //Inserir dados essenciais
                if (generoTexto.Text == "Masculino") { usuario.Genero = "M"; }
                else if (generoTexto.Text == "Feminino") { usuario.Genero = "F"; }
                else { usuario.Genero = "O"; }

                try { usuario.Nascimento = Convert.ToDateTime(nascimentoTexto.Text); }
                catch { SystemSounds.Beep.Play(); MessageBox.Show("A data de nascimento está incorreta.", "Erro"); nascimentoTexto.Focus(); }

                Endereco novoEndereco = new Endereco();

                BancoUsuario banco = new BancoUsuario();

                //Inserir dados pessoais
                try
                {
                    if (celularTexto.Text != "(  )      -") { usuario.Celular = converterNumero(celularTexto.Text); } else { usuario.Celular = ""; }
                    if (telefoneTexto.Text != "(  )     -") { usuario.Telefone = converterNumero(telefoneTexto.Text); } else { usuario.Telefone = ""; }
                    if (cpfTexto.Text != "   .   .   -") { usuario.CPF = converterNumero(cpfTexto.Text); } else { usuario.CPF = ""; }
                    if (emailTexto.Text != "") { usuario.Email = emailTexto.Text; } else { usuario.Email = ""; }
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
                if (menorDeIdade == true && nomeResponsavelTexto.Text != "")
                {
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

                        usuario.Responsavel = responsavel;
                    }
                    catch
                    {
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Algum dado do responsável está inválido.", "Erro");
                    }
                }

                try
                {
                    usuario.Endereco = novoEndereco;

                    if (usuario.Responsavel == null && menorDeIdade)
                    {
                        DialogResult continuar = MessageBox.Show("Deseja editar usuário menor de idade sem um responsável?", "Confirmação", MessageBoxButtons.YesNo);
                        if (continuar == DialogResult.Yes)
                        {
                            usuario = banco.EditarUsuario(usuario);

                            concluirEdicao();
                        }
                        else
                        {
                            nomeResponsavelTexto.Focus();
                        }
                    }
                    else
                    {
                        usuario = banco.EditarUsuario(usuario);

                        concluirEdicao();
                    }
                }
                catch
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Não foi possível editar o usuário.", "Erro");
                }
            }
            else
            {
                if (nomeTexto.Text == "") { SystemSounds.Beep.Play(); MessageBox.Show("É necessário um nome para editar usuário.", "Erro"); nomeTexto.Focus(); }
                else if (nascimentoTexto.Text == "  /  /") { SystemSounds.Beep.Play(); MessageBox.Show("É necessário uma data de nascimento para editar usuário.", "Erro"); nascimentoTexto.Focus(); }
                else if (generoTexto.Text == "") { SystemSounds.Beep.Play(); MessageBox.Show("É necessário um gênero para editar usuário.", "Erro"); generoTexto.Focus(); }
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
            catch { SystemSounds.Beep.Play(); }
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
            editarBotao.TabIndex = 14;


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
            editarBotao.TabIndex = 18;
        }

        private void concluirEdicao()
        {
            MessageBox.Show("Cadastro editado com sucesso", "Sucesso");
            this.Close();
        }

        private void excluirBotao_Click(object sender, EventArgs e)
        {
            if (confirmarSenha())
            {
                BancoUsuario banco = new BancoUsuario();
                try
                {
                    banco.ExcluirUsuario(usuario);

                    MessageBox.Show("Usuário excluído com sucesso.", "Sucesso");

                    this.Close();
                }
                catch
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Não foi possível excluir o usuário.", "Erro");
                }
            }
        }
        private bool confirmarSenha()
        {
            using (var form = new TelaConfirmarSenha())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (form.confirmacao)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private void historicoBotao_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaListarEmprestimos")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaListarEmprestimos janela = new TelaListarEmprestimos(usuario);
                janela.Show();
            }
        }
    }
}
