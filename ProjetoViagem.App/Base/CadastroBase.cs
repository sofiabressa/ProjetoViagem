using ProjetoViagem.App.Base;
using ProjetoViagem.App.Models;
using ProjetoViagem.Domain.Base;
using ProjetoViagem.Domain.Entities;
using ProjetoViagem.Service.Validators;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Controls;

namespace ProjetoViagem.App.Base
{
    public partial class CadastroBase : CrownForm
    {
        #region Declarações
        protected bool IsAlteracao = false;
        #endregion

        private readonly IBaseService<Usuario> _usuarioService;

        private List<UsuarioModel>? usuarios;

        public CadastroBase(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }

        private void PreencheObjeto(Usuario usuario)
        {
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;

        }

        private void nightHeaderLabel1_Click(object sender, EventArgs e)
        {

        }

        private void nightForm1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var usuario = _usuarioService.GetById<Usuario>(id);
                        PreencheObjeto(usuario);
                        usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                    }
                }
                else
                {
                    var usuario = new Usuario();
                    PreencheObjeto(usuario);
                    _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);

                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Projeto Viagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
