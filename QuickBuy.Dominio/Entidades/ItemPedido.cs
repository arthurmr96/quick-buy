namespace QuickBuy.Dominio.Entidades
{
    class ItemPedido : Entidade
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        public override void Validar()
        {
            throw new System.NotImplementedException();
        }
    }
}
