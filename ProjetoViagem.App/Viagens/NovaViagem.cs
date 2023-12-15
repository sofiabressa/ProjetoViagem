using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Controls;
using ProjetoViagem.App.Models;
using ProjetoViagem.Domain.Entities;
using ProjetoViagem.Domain.Base;
using MySqlConnector;
using System.Globalization;
using ProjetoViagem.App.Infra;
using Microsoft.Extensions.DependencyInjection;

namespace ProjetoViagem.App.Viagens
{
    public partial class NovaViagem : CrownForm
    {
        private readonly IBaseService<Voo> _vooService;
        private readonly IBaseService<Cidade> _cidadeService;


        public NovaViagem(IBaseService<Voo> vooService, IBaseService<Cidade> cidadeService)
        {
            _vooService = vooService;
            InitializeComponent();
            _cidadeService = cidadeService;
            CarregarCombo();
        }

        private void Exibeformulario(List<VooModel> voosPesquisados)
        {
            //ListarPassagens cad = ConfigureDI.ServicesProvider!.GetService<ListarPassagens>();

            ListarPassagens cad = new ListarPassagens(voosPesquisados);

            if (cad != null && !cad.IsDisposed)
            {
                //cad.MdiParent = this;
                cad.voosPesquisados = voosPesquisados;
                cad.Show();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            // Obter critérios de pesquisa
            //string origem = cboOrigem.SelectedValue?.ToString() ?? string.Empty;
            //string destino = cboDestino.SelectedValue?.ToString() ?? string.Empty;

            string origem = txtOrigem.Text;
            string destino = txtDestino.Text;

            // Converter as datas de string para DateTime
            DateTime dataIda = DateTime.ParseExact(materialMaskedTextBoxIda.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //DateTime dataVolta = DateTime.ParseExact(materialMaskedTextBoxVolta.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            // Realizar a pesquisa de voos com base nos critérios
            List<VooModel> voosPesquisados = PesquisarVoos(origem, destino, dataIda);

            // Exibir informações para depuração
            MessageBox.Show($"Origem: {origem}\nDestino: {destino}\nData Ida: {dataIda.ToShortDateString()}",
            "Critérios de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Verificar se há resultados antes de exibir o formulário
            if (voosPesquisados.Any())
            {
                // Exibe o formulário ListarPassagens passando os resultados da pesquisa
                Exibeformulario(voosPesquisados);
            }
            else
            {
                MessageBox.Show("Nenhum voo encontrado com os critérios de pesquisa.", "Sem Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private List<VooModel> PesquisarVoos(string origem, string destino, DateTime dataIda)
        {
            try
            {
                // Obter todos os voos e cidades do serviço (ou fonte de dados)
                var todosVoos = _vooService.GetAll<VooModel>().ToList();

                MessageBox.Show($"Número de voos retornados: {todosVoos.Count}");

                // Exibir informações sobre os filtros
                MessageBox.Show($"Origem: {origem}, Destino: {destino}, Data Ida: {dataIda}",
                    "Informações dos Filtros", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Filtros de pesquisa
                var voosPesquisados = todosVoos
                /*.Where(v =>
                    (string.IsNullOrEmpty(origem) && (v.Origem != null && v.Origem.Nome.Equals(origem, StringComparison.OrdinalIgnoreCase))) &&
                    (string.IsNullOrEmpty(destino) && (v.Destino != null && v.Destino.Nome.Equals(destino, StringComparison.OrdinalIgnoreCase))) &&
                    (v.Data_voo >= dataIda.Date)
                )
                .ToList();*/

                     .Where(v =>
                     {
                         bool origemMatch = string.IsNullOrEmpty(origem) || (v.Origem != null && v.Origem.Nome.Equals(origem, StringComparison.OrdinalIgnoreCase));
                         bool destinoMatch = string.IsNullOrEmpty(destino) || (v.Destino != null && v.Destino.Nome.Equals(destino, StringComparison.OrdinalIgnoreCase));
                         bool dataMatch = v.Data_voo >= dataIda.Date;

                         MessageBox.Show($"Voo {v.NumVoo} - Origem: {v.Origem?.Nome}, Destino: {v.Destino?.Nome}, Origem Match: {origemMatch}, Destino Match: {destinoMatch}, Data Match: {dataMatch}",
                             "Correspondência de Voo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                         return origemMatch && destinoMatch && dataMatch;
                     })
                    .ToList();

                // Exibir informações para depuração
                MessageBox.Show($"Número de voos após aplicar filtros: {voosPesquisados.Count}",
                "Informação de Voos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return voosPesquisados;
            }
            catch (Exception ex)
            {
                // Lidar com exceções, como exibir uma mensagem de erro
                MessageBox.Show(ex.Message, @"Erro ao pesquisar voos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<VooModel>(); // Ou outra estratégia para lidar com o erro
            }
        }

        private void CarregarCombo()
        {
            // Origem
            cboOrigem.ValueMember = "Id";
            cboOrigem.DisplayMember = "Nome";
            List<Cidade> origens = _cidadeService.Get<Cidade>().ToList();
            cboOrigem.DataSource = origens;

            // Destino
            cboDestino.ValueMember = "Id";
            cboDestino.DisplayMember = "Nome";
            List<Cidade> destinos = _cidadeService.Get<Cidade>().ToList();
            cboDestino.DataSource = destinos;
        }

        private void txtDataInicio_Click(object sender, EventArgs e)
        {

        }

        private void crownLabel1_Click(object sender, EventArgs e)
        {
        }
    }
}
