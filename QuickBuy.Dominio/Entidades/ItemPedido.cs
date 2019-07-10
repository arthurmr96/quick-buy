using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public virtual Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public virtual Pedido Pedido { get; set; }

        public override void Validar()
        {
            if(ProdutoId == 0)
            {
                MensagemValidacao.Add("Qual o produto a ser adicionado?");
            }
        }
    }
}
