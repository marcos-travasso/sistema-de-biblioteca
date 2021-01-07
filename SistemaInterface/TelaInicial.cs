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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void abrirCadastroUsuario()
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaCadastroUsuario")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaCadastroUsuario janela = new TelaCadastroUsuario();
                janela.Show();
            }
        }

        private void usuariosCadastrarBotao1_Click(object sender, EventArgs e)
        {
            abrirCadastroUsuario();
        }

        private void usuariosCadastrarBotao2_Click(object sender, EventArgs e)
        {
            abrirCadastroUsuario();
        }
    }
}
