using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoViagem.App.Models;
using ProjetoViagem.Domain.Base;
using ProjetoViagem.Domain.Entities;
using ProjetoViagem.Service.Validators;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace ProjetoViagem.App.Cadastros
{
    public partial class cadastroVoo : CrownForm
    {
        #region Declarações
        protected bool IsAlteracao = false;
        #endregion

        private readonly IBaseService<Voo> _vooService;
        private readonly IBaseService<Cidade> _cidadeService;
        private readonly VooModel _voo;

        private List<VooModel>? voos;

        public cadastroVoo(IBaseService<Voo> vooService, IBaseService<Cidade> cidadeService)
        {
            _vooService = vooService;
            _cidadeService = cidadeService;
           
            InitializeComponent();
            CarregarCombo();

            _voo = new VooModel();
        }

        public void PreencheObjeto(Voo voo)
        {
            string formato = "HH:mm";
            string formatoData = "dd/MM/yyyy";  // Formato de data: dia/mês/ano

            if (int.TryParse(cboOrigem.SelectedValue.ToString(), out var idOrigem))
            {
                var origemCidade = _cidadeService.GetById<Cidade>(idOrigem);
                voo.Origem = origemCidade;
            }

            if (int.TryParse(cboDestino.SelectedValue.ToString(), out var idDestino))
            {
                var destinoCidade = _cidadeService.GetById<Cidade>(idDestino);
                voo.Destino = destinoCidade;
            }

            voo.Empresa = txtEmpresa.Text;
            voo.NumVoo = int.TryParse(txtNumVoo.Text, out int numVoo) ? numVoo : 0;
            voo.ValorVoo = float.TryParse(txtValor.Text, out float valorVoo) ? valorVoo : 0;

            voo.Horario_saida = DateTime.TryParseExact(materialMaskedTextBoxHoraSaida.Text, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime horarioSaida)
                ? horarioSaida
                : DateTime.MinValue;

            voo.Horario_chegada = DateTime.TryParseExact(materialMaskedTextBoxHoraChegada.Text, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime horarioChegada)
                ? horarioChegada
                : DateTime.MinValue;

            voo.Data_voo = DateTime.TryParseExact(materialMaskedTextBoxData.Text, formatoData, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataVoo)
                ? dataVoo
                : DateTime.MinValue; // Ou outro valor padrão que faça sentido no seu contexto
        }
        private void CarregarCombo()
        {
            cboOrigem.ValueMember = "Id";
            cboOrigem.DisplayMember = "Nome";
            cboOrigem.DataSource = _cidadeService.Get<Cidade>().ToList();

            cboDestino.ValueMember = "Id";
            cboDestino.DisplayMember = "Nome";
            cboDestino.DataSource = _cidadeService.Get<Cidade>().ToList();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            float valorVoo;
            if (!float.TryParse(txtValor.Text, out valorVoo))
            {
                MessageBox.Show("Por favor, insira um valor numérico válido para o preço do voo.", "Erro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                        var voo = _vooService.GetById<Voo>(id);
                        PreencheObjeto(voo);
                        voo = _vooService.Update<Voo, Voo, VooValidator>(voo);
                    }
                }
                else
                {
                    var voo = new Voo();
                    PreencheObjeto(voo);
                    _vooService.Add<Voo, Voo, VooValidator>(voo);

                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Projeto Viagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cboOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
