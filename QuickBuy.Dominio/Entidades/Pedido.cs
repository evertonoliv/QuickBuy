using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidades
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }


        public int FormPagamento { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMesagensValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Critica - Pedido Nao pode ficar sem item de pedido");

            if(string.IsNullOrEmpty(CEP))
                AdicionarCritica("Critica - CEP deve estar preenchido");


        }
    }
}
