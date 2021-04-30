using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Edecasa.Models
{
    [Table("Motoqueiro")]
    public class Motoqueiro
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double Valor { get; set; }
    }
}
