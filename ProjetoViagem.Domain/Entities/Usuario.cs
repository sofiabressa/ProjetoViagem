using ProjetoViagem.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoViagem.Domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        public Usuario()
        {
        }

        public Usuario(int id, string? nome, string? email, string? senha) : base(id)
        {
            Nome = nome;
            Email = email;
            Senha = senha;

        }

        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
    }
}