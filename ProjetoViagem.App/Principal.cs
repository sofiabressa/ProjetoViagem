using Microsoft.Extensions.DependencyInjection;
using ProjetoViagem.App.Infra;
using ProjetoViagem.Domain.Entities;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ProjetoViagem.App.Outros;
using ProjetoViagem.App.Cadastros;
using ProjetoViagem.App.Base;
using ProjetoViagem.App.Viagens;
using ProjetoViagem.Domain.Base;
using System.Windows.Forms;
using ProjetoViagem.App.Models;

namespace ProjetoViagem.App
{
    public partial class Principal : MaterialForm
    {
        public static Usuario? Usuario { get; set; }

        private ListarPassagens listarPassagensForm;

        bool logado = false;

        public Principal()
        {
            InitializeComponent();
            CarregaLogin();

            logado = true;
        }

        private void CarregaLogin()
        {
            var login = ConfigureDI.ServicesProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }
        }

        private void criarViagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<NovaViagem>();
        }

        private void minhasViagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listarPassagensForm != null && !listarPassagensForm.IsDisposed)
            {
                Exibeformulario<MinhasViagens>();
            }
        }

        private void cadastroDeVoosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Usuario != null && Usuario.Nome == "sofia")
            {
                // Exibe o formulário apenas se o usuário for um administrador
                Exibeformulario<cadastroVoo>();

            }
            else
            {
                MessageBox.Show("Você não tem permissão para acessar esta funcionalidade.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void voosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Usuario != null && Usuario.Nome == "sofia")
            {
                // Exibe o formulário apenas se o usuário for um administrador
                Exibeformulario<voosCadastrados>();

            }
            else
            {
                MessageBox.Show("Você não tem permissão para acessar esta funcionalidade.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }


    }
}
