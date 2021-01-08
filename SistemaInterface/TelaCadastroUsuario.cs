using SistemaBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaCadastroUsuario : Form
    {
        public TelaCadastroUsuario()
        {
            InitializeComponent();
        }

        private void cadastrarBotao_Click(object sender, EventArgs e)
        {
            string genero;
            DateTime nascimento = Convert.ToDateTime(nascimentoTexto.Text);

            if (generoTexto.Text == "Masculino") { genero = "M";  }
            else if (generoTexto.Text == "Feminino") { genero = "F";  }
            else { genero = "O"; }


            Pessoa novaPessoa = new Pessoa(nomeTexto.Text, genero, nascimento);

            BancoDeDados banco = new BancoDeDados();
            novaPessoa.idPessoa = banco.AdicionarPessoa(novaPessoa);
        }
    }
}
