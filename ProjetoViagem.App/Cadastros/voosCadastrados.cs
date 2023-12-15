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
using ProjetoViagem.Domain.Base;
using ProjetoViagem.Domain.Entities;
using ProjetoViagem.App.Models;
using ProjetoViagem.App.Infra;
using Microsoft.Extensions.DependencyInjection;

namespace ProjetoViagem.App.Cadastros
{
    public partial class voosCadastrados : CrownForm
    {
        private readonly IBaseService<Voo> _vooService;
        private readonly IBaseService<Cidade> _cidadeService;
        private List<VooModel>? MeusVoos;

        public voosCadastrados(IBaseService<Voo> vooService)
        {
            InitializeComponent();
            _vooService = vooService;
 
            // Obtenha a lista de voos usando o serviço
            MeusVoos = _vooService.GetAll<VooModel>().ToList();

            PreencherDataGridView(MeusVoos);
        }
        private void PreencherDataGridView(List<VooModel>? MeusVoos)
        {
            // Limpe o DataGridView
            dataGridViewVoos.Rows.Clear();
            dataGridViewVoos.Columns.Clear();

            // Adicione uma coluna oculta para o ID do voo
            dataGridViewVoos.Columns.Add("Id", "ID");
            dataGridViewVoos.Columns["Id"].Visible = false; // Torna a coluna oculta

             // Adicione as colunas desejadas
            dataGridViewVoos.Columns.Add("NumVoo", "Número do Voo");
            dataGridViewVoos.Columns.Add("Empresa", "Empresa");
            dataGridViewVoos.Columns.Add("Origem", "Origem");
            dataGridViewVoos.Columns.Add("Destino", "Destino");
            dataGridViewVoos.Columns.Add("Data_voo", "Data do Voo");
            dataGridViewVoos.Columns.Add("Horario_saida", "Horário de Saída");
            dataGridViewVoos.Columns.Add("Horario_chegada", "Horário de Chegada");
            dataGridViewVoos.Columns.Add("ValorVoo", "Valor do Voo");


            // Adicione as novas linhas
            foreach (var voo in MeusVoos)
            {
                dataGridViewVoos.Rows.Add(
                    voo.Id,
                    voo.NumVoo ?? 0,
                    voo.Empresa ?? "N/A",
                    voo.Origem.Nome ?? "N/A",
                    voo.Destino.Nome ?? "N/A",
                    voo.Data_voo.HasValue ? voo.Data_voo.Value.ToShortDateString() : "N/A",
                    voo.Horario_saida.HasValue ? voo.Horario_saida.Value.ToString("HH:mm") : "N/A",
                    voo.Horario_chegada.HasValue ? voo.Horario_chegada.Value.ToString("HH:mm") : "N/A",
                    voo.ValorVoo.ToString()
                );
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridViewVoos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente deletar este Voo?", "Projeto Viagem", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = int.Parse(dataGridViewVoos.SelectedRows[0].Cells[0].Value.ToString());
                        _vooService.Delete(id);

                        // Recarrega a lista após a exclusão
                        MeusVoos = _vooService.GetAll<VooModel>().ToList();
                        PreencherDataGridView(MeusVoos);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Projeto Viagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para deletar.", "Projeto Viagem", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nightForm1_Enter(object sender, EventArgs e)
        {
            PreencherDataGridView(MeusVoos);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Exibeformulario<cadastroVoo>();
        }
    }
}
