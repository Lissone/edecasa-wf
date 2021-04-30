using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Edecasa.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public float Valor { get; set; }
        public float Taxa { get; set; }
        public float VlMotoqueiro { get; set; }
        public DateTime Data { get; set; }

        public Cliente Cliente { get; set; }
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }

        public FormasPagamento TpPagamento { get; set; }
        [ForeignKey("TpPagamento")]
        public int TpPagamentoId { get; set; }

        public ICollection<Item> Itens { get; set; }
    }
}
