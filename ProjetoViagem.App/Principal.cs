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

namespace ProjetoViagem.App
{
    public partial class Principal : MaterialForm
    {
        public static Usuario? Usuario { get; set; }
        private ListarPassagens listarPassagensForm;


        public Principal()
        {
            InitializeComponent();
            CarregaLogin();
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
                // Crie uma instância de MinhasViagens e passe a lista de viagensCompradas
                MinhasViagens minhasViagensForm = new MinhasViagens(listarPassagensForm.viagensCompradas);

                // Exiba o formulário
                minhasViagensForm.Show();
            }
        }

        private void cadastroDeVoosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Exibeformulario<cadastroVoo>();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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
