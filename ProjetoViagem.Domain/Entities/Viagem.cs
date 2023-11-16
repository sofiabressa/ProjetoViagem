using ProjetoViagem.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoViagem.Domain.Entities
{
    public class Viagem : BaseEntity<int>
    {
        public Viagem()
        {
        }

        public Viagem(int id, string? nome, DateTime data_inicio, DateTime data_fim, float valorViagem, Usuario? usuario, DateTime data_venda) : base(id)
        {
            Nome = nome;
            Data_inicio = data_inicio;
            Data_fim = data_fim;
            ValorViagem = valorViagem;
            Usuario = usuario;
            Data_venda = data_venda;
        }

        public string? Nome { get; set; }
        public DateTime? Data_inicio { get; set; }
        public DateTime? Data_fim{ get; set; }
        public float? ValorViagem { get; set; }
        public Usuario? Usuario { get; set; }
        public DateTime? Data_venda { get; set; }
    }
}
