using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edecasa.Models
{
    public class Bebida
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Tamanho { get; set; }
        public float Valor { get; set; }
    }
}
