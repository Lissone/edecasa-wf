using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Edecasa.Models
{
    [Table("FormasPagamento")]
    public class FormasPagamento
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
