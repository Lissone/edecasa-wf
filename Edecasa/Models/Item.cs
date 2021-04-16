using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edecasa.Models
{
    [Table("Item")]
    public class Item
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public string Tamanho { get; set; }

        public Produto Produto { get; set; }
        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }

        public Pedido Pedido { get; set; }
        [ForeignKey("Pedido")]
        public int PedidoId { get; set; }
    }
}
