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
using ProjetoViagem.App.Infra;
using Microsoft.Extensions.DependencyInjection;
using ProjetoViagem.Domain.Entities;

namespace ProjetoViagem.App.Viagens
{
    public partial class ListarPassagens : CrownForm
    {
        public List<VooModel> voosPesquisados;
        private VooModel passagemSelecionada;
        public List<VooModel> viagensCompradas = new List<VooModel>();


        public ListarPassagens(List<VooModel> voosPesquisados)
        {
            InitializeComponent();

            //Atribuindo a lista de voosPesquisados e viagensCompradas à variável de instância
            this.voosPesquisados = voosPesquisados;

            PreencherDataGridView(voosPesquisados);

        }

        private void PreencherDataGridView(List<VooModel> voosPesquisados)
        {
            // Limpe o DataGridView
            dataGridViewPassagens.Rows.Clear();
            dataGridViewPassagens.Columns.Clear();

            // Adicione as colunas desejadas
            dataGridViewPassagens.Columns.Add("NumVoo", "Número do Voo");
            dataGridViewPassagens.Columns.Add("Empresa", "Empresa");
            dataGridViewPassagens.Columns.Add("Origem", "Origem");
            dataGridViewPassagens.Columns.Add("Destino", "Destino");
            dataGridViewPassagens.Columns.Add("Data_voo", "Data do Voo");
            dataGridViewPassagens.Columns.Add("Horario_saida", "Horário de Saída");
            dataGridViewPassagens.Columns.Add("Horario_chegada", "Horário de Chegada");
            dataGridViewPassagens.Columns.Add("ValorVoo", "Valor do Voo");


            // Adicione as novas linhas com os resultados da pesquisa
            foreach (var voo in voosPesquisados)
            {
                dataGridViewPassagens.Rows.Add(
                    voo.NumVoo,
                    voo.Empresa,
                    voo.Origem?.Nome ?? "N/A",
                    voo.Destino?.Nome ?? "N/A",
                    voo.Data_voo.HasValue ? voo.Data_voo.Value.ToShortDateString() : "N/A",
                    voo.Horario_saida.HasValue ? voo.Horario_saida.Value.ToString("HH:mm") : "N/A",
                    voo.Horario_chegada.HasValue ? voo.Horario_chegada.Value.ToString("HH:mm") : "N/A",
                    voo.ValorVoo.ToString()
                );
            }
        }

        public interface IArgumentReceiver
        {
            void ReceiveArguments(params object[] args);
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Verifique se uma passagem foi selecionada
            if (passagemSelecionada != null)
            {
                MessageBox.Show("Compra confirmada com sucesso!", "Compra Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Adicione a passagem à lista de viagens compradas
                viagensCompradas.Add(passagemSelecionada);
                //Instanciando minhas viagens
                MinhasViagens ListarMinhasViagens = new MinhasViagens(viagensCompradas);
                //Atualizar
                ListarMinhasViagens.AtualizarListaViagensCompradas(viagensCompradas);

                ListarMinhasViagens.Show();

                Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma passagem antes de confirmar a compra.", "Selecione uma Passagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewPassagens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ao clicar em uma célula do DataGridView, obtenha a passagem selecionada
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewPassagens.Rows.Count)
            {
                passagemSelecionada = voosPesquisados[e.RowIndex];
            }
        }

        private void nightForm1_Enter(object sender, EventArgs e)
        {
            // PreencherDataGridView(voosPesquisados);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
