﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edecasa.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TpPagamento { get; set; }
        public float Valor { get; set; }
        public float Taxa { get; set; }
        public DateTime Data { get; set; }
        public ICollection<Item> Itens { get; set; }

        public Cliente Cliente { get; set; }
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
    }
}