using ProjetoViagem.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoViagem.Domain.Entities
{
    public class Destino : BaseEntity<int>
    {
        public Destino()
        {
        }

        public Destino(int id, string? nome, string? descricao, Viagem? viagem) : base(id)
        {
            Nome = nome;
            Descricao = descricao;
            Viagem = viagem;

        }

        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public Viagem? Viagem { get; set; }
    }
}
