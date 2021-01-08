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
    public partial class TelaCadastroLivro : Form
    {
        public TelaCadastroLivro()
        {
            InitializeComponent();
        }

        private void abrirCadastroAutor()
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaCadastroAutor")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaCadastroAutor janela = new TelaCadastroAutor();
                janela.Show();
            }
        }

        private void abrirCadastroGenero()
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaCadastroGenero")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaCadastroGenero janela = new TelaCadastroGenero();
                janela.Show();
            }
        }

        private void autorAdicionar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirCadastroAutor();
        }

        private void generoAdicionar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirCadastroGenero();
        }
    }
}
