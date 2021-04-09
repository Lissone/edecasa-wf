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
        public ModelContext() : base("name=con")
        {

        }

        public DbSet<Bebida> BebidaList { get; set; }
    }
}
