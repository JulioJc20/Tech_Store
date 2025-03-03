﻿namespace TechStore.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; } 
        public string Nome{ get; set; } 
        public decimal Preco { get; set; } 
        public int Estoque { get; set; } 
        public string Categoria { get; set; } 
    }
}
