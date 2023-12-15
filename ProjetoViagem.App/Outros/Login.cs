using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using ProjetoViagem.App.Models;
using ProjetoViagem.Domain.Base;
using ProjetoViagem.Domain.Entities;
using ProjetoViagem.App.Base;
using ProjetoViagem.App.Infra;
using ProjetoViagem.Service.Validators;

namespace ProjetoViagem.App.Outros
{
    public partial class Login : CrownForm
    {
        private readonly IBaseService<Usuario> _usuarioService;

        public Login(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
#if DEBUG
            txtEmail.Text = @"sofia@hotmail.com";
            txtSenha.Text = @"12345";
#endif
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.ShowDialog();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroBase>();
        }
        private void ChecaExistenciaDeUsuariosCadastrados()
        {
            var usuarios = _usuarioService.Get<UsuarioModel>().ToList();
        }

        private Usuario? ObterUsuario(string login, string senha)
        {
            ChecaExistenciaDeUsuariosCadastrados();

            var usuario = _usuarioService.Get<Usuario>().Where(x => x.Email == login).FirstOrDefault();
            if (usuario == null)
            {
                return null;
            }
            return usuario.Senha != senha ? null : usuario;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var usuario = ObterUsuario(txtEmail.Text, txtSenha.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuário e/ou senha inválido(s)!", "Projeto Viagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
            else
            {
                usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                Principal.Usuario = usuario;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
