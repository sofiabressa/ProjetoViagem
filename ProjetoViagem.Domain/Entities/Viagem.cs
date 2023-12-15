using ProjetoViagem.Domain.Base;

namespace ProjetoViagem.Domain.Entities
{
    public class Viagem : BaseEntity<int>
    {
        public Viagem()
        {
        }

        public Viagem(int id, DateTime data_inicio, DateTime data_fim, Usuario? usuario, Cidade? origem, Cidade? destino, Voo? voo) : base(id)
        {
            Data_inicio = data_inicio;
            Data_fim = data_fim;
            Usuario = usuario;
            Origem = origem;
            Destino = destino;
            Voo = voo;
        }
        public DateTime? Data_inicio { get; set; }
        public DateTime? Data_fim{ get; set; }
        public Usuario? Usuario { get; set; }
        public Cidade? Origem { get; set; }
        public Cidade? Destino { get; set; }
        public Voo? Voo { get; set; }
    }
}
