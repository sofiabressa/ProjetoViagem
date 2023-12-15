using ProjetoViagem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoViagem.App.Models
{
    public class VooModel
    {
        public int Id { get; set; }
        public DateTime? Data_voo { get; set; }
        public DateTime? Horario_saida { get; set; }
        public DateTime? Horario_chegada { get; set; }
        public int? NumVoo { get; set; }
        public float? ValorVoo { get; set; }
        public CidadeModel? Origem { get; set; }
        public CidadeModel? Destino { get; set; }
        public string? Empresa { get; set; }
    }
}
