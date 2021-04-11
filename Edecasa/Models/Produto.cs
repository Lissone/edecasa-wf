using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edecasa.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Tamanho { get; set; }
        public float VlPequeno { get; set; }
        public float VlGrande { get; set; }
        public ICollection<Item> Itens { get; set; }
    }
}
