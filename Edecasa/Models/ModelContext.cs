using Edecasa.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edecasa
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("name=con") { }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
    }
}
