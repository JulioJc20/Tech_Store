namespace TechStore.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataPedido{ get; set; }
        public decimal Total{ get; set; }
        public List<ItemPedido> Itens{ get; set; }



    }
}
