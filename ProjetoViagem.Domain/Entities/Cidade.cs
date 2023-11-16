using ProjetoViagem.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoViagem.Domain.Entities
{
    public class Cidade : BaseEntity<int>
    {
        public Cidade()
        {
        }

        public Cidade(int id, string? nome, string? estado, Destino? detino) : base(id)
        {
            Nome = nome;
            Estado = estado;
            Destino = detino;
        }

        public string? Nome { get; set; }
        public string? Estado { get; set; }

        public Destino? Destino { get; set; }
    }
}
