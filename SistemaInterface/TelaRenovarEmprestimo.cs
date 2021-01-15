using SistemaBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaRenovarEmprestimo : Form
    {
        public TelaRenovarEmprestimo()
        {
            InitializeComponent();
        }

        private void listaEmprestimosLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var form = new TelaListarEmprestimos(true))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Emprestimo emprestimo = form.selecionado;
                    idUsuarioTexto.Text = emprestimo.usuario.idUsuario.ToString();
                    idLivroTexto.Text = emprestimo.livro.idLivro.ToString();
                }
            }
        }

        private void TelaRenovarEmprestimo_Load(object sender, EventArgs e)
        {
            devolucaoData.Value = devolucaoData.Value.AddDays(7);
        }
        private void abrirConfirmarEmprestimo(Emprestimo emprestimo)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaConfirmarEmprestimo")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaConfirmarEmprestimo janela = new TelaConfirmarEmprestimo(emprestimo, true);
                janela.Show();
            }
        }

        private void renovarBotao_Click(object sender, EventArgs e)
        {
            if (idUsuarioTexto.Text != "" || idLivroTexto.Text != "")
            {
                var diferenca = Math.Ceiling((devolucaoData.Value - DateTime.Now).TotalDays);
                if (diferenca >= 1)
                {
                    try
                    {
                        Emprestimo emprestimo = new Emprestimo();


                        if (idUsuarioTexto.Text != "") { emprestimo.usuario = new Usuario(Convert.ToInt32(idUsuarioTexto.Text)); }
                        else if (idLivroTexto.Text != "") { emprestimo.livro = new Livro(Convert.ToInt32(idLivroTexto.Text)); }

                        BancoEmprestimo banco = new BancoEmprestimo();
                        emprestimo = banco.GetEmprestimo(emprestimo);

                        Devolucao devolucao = new Devolucao();
                        devolucao.dataDeDevolucao = devolucaoData.Value;
                        devolucao.emprestimo = emprestimo;
                        emprestimo.devolucoes.Add(devolucao);

                        abrirConfirmarEmprestimo(emprestimo);
                        idUsuarioTexto.Text = "";
                        idLivroTexto.Text = "";
                    }
                    catch
                    {
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Não foi possível emprestar o livro.", "Erro");
                    }
                }
                else
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("O empréstimo deve ser de no mínimo um dia.", "Erro");
                    devolucaoData.Focus();
                }
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }
    }
}
