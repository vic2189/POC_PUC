using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalvarComprasCliente.EF
{
    public class DropShippingContext : DbContext
    {
        public DropShippingContext() : base("name=DSContext")
        {
            //Database.SetInitializer<DropShippingContext>(new DropCreateDatabaseAlways<DropShippingContext>());
        }

        public DbSet<HistoricoCompras> HistoricoCompras { get; set; }
    }

}
