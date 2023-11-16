using ProjetoViagem.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoViagem.Domain.Entities
{
    public class Empresa : BaseEntity<int>
    {
        public Empresa()
        {
        }

        public Empresa(int id, string? nome, Viagem? viagem) : base(id)
        {
            Nome = nome;
            Viagem = viagem;
        }

        public string? Nome { get; set; }
        public Viagem? Viagem { get; set; }
    }
}
