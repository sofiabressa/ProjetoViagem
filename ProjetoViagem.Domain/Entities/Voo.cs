using ProjetoViagem.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoViagem.Domain.Entities
{
    public class Voo : BaseEntity<int>
    {
        public Voo()
        {
        }

        public Voo(int id, DateTime data_voo, DateTime horario_saida, DateTime horario_chegada, int numVoo, float valorVoo, Cidade? origem, Cidade? destino, string? empresa) : base(id)
        {
            Data_voo = data_voo;
            Horario_saida = horario_saida;
            Horario_chegada = horario_chegada;
            NumVoo = numVoo;
            ValorVoo = valorVoo;
            Origem = origem;
            Destino = destino;
            Empresa = empresa;
        }
        public DateTime? Data_voo { get; set; }
        public DateTime? Horario_saida { get; set; }
        public DateTime? Horario_chegada { get; set; }
        public int? NumVoo { get; set; }
        public float? ValorVoo { get; set; }
        public Cidade? Origem { get; set; }
        public Cidade? Destino { get; set; }
        public string? Empresa { get; set; }
    }
}
