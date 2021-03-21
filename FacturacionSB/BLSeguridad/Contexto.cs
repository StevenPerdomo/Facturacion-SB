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
        public Contexto(): base("SBFacturacion")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());//Agrega datos de inicio

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
       
    }
}
