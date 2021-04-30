using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edecasa.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public double VlPequeno { get; set; }
        public double VlGrande { get; set; }
        public ICollection<Item> Itens { get; set; }
    }
}
