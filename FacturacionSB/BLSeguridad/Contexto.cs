using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLFacturacionSB;

namespace BLFacturacionSB
{
    public class Contexto: DbContext
    {
        public Contexto(): base("ClientesMayoreo")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());//Agrega datos de inicio

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<usuarios> Usuarios { get; set; }

        //public static implicit operator Contexto(BidingList<Departamento> v)
        //  {
        //     throw new NotImplementedException();
        //   }
    }
}
