namespace TechStore.Models
{
    public class ItemPedido
    {

        public int ItemPedidoId{ get; set; }
        public int PedidoId{ get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal SubTotal { get; set; }


    }
}
