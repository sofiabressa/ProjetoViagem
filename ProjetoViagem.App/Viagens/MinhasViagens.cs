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
using ProjetoViagem.Domain.Base;
using ProjetoViagem.Domain.Entities;

namespace ProjetoViagem.App.Viagens
{
    public partial class MinhasViagens : CrownForm
    {
        private readonly IBaseService<Voo> _vooService;
        public List<VooModel> viagensCompradas;

        public MinhasViagens(IBaseService<Voo> vooService)
        {
            InitializeComponent();
            _vooService = vooService;
            viagensCompradas = _vooService.GetAll<VooModel>().ToList();

            AdicionarColunasAoDataGridView();
            PreencherDataGridView(viagensCompradas);

        }
        private void AdicionarColunasAoDataGridView()
        {
            // Adicione as colunas ao DataGridView se necessário
            if (dataGridViewViagens.Columns.Count == 0)
            {
                dataGridViewViagens.Columns.Add("NumVoo", "Número do Voo");
                dataGridViewViagens.Columns.Add("Origem", "Origem");
                dataGridViewViagens.Columns.Add("Destino", "Destino");
                dataGridViewViagens.Columns.Add("Data_voo", "Data do Voo");
            }
        }
        public void AtualizarListaViagensCompradas(List<VooModel> viagensCompradas)
        {
            if (dataGridViewViagens.Columns.Count == 0)
            {
                AdicionarColunasAoDataGridView();
            }
            //Atualiza o DataGridView ou qualquer controle que você esteja usando para exibir as viagens compradas
            PreencherDataGridView(viagensCompradas);
        }

        private void PreencherDataGridView(List<VooModel> viagensCompradas)
        {
            // Limpe o DataGridView
            dataGridViewViagens.Rows.Clear();

            // Adicione as viagens compradas ao DataGridView
            foreach (var viagem in viagensCompradas)
            {
                dataGridViewViagens.Rows.Add(viagem.NumVoo, viagem.Origem, viagem.Destino, viagem.Data_voo);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewViagens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nightForm1_Enter(object sender, EventArgs e)
        {
            PreencherDataGridView(viagensCompradas);
        }

        private void MinhasViagens_Enter(object sender, EventArgs e)
        {
            PreencherDataGridView(viagensCompradas);
        }
    }
}
