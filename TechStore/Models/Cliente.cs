﻿namespace TechStore.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome{ get; set; }
        public string Email{ get; set; }
        public string Telefone{ get; set; }
        public DateTime DataCadastro{ get; set; }
    }
}
