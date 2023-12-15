using ProjetoViagem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoViagem.App.Models
{
    public class ViagemModel
    {
        public DateTime? Data_inicio { get; set; }
        //public DateTime? Data_fim { get; set; }
        public Usuario? Usuario { get; set; }
        public Cidade? Destino { get; set; }
        public Cidade? Origem { get; set; }
        public Voo? Voo { get; set; }
    }
}
