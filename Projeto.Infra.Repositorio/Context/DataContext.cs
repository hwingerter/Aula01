using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Projeto.Dominio.DomainEntities;
using Projeto.Infra.Repositorio.Mappings;
using System.Configuration;

namespace Projeto.Infra.Repositorio.Context
{
    public class DataContext : DbContext
    {

        public DataContext()
            : base (ConfigurationManager.ConnectionStrings["Projeto"].ConnectionString)
        {                
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configuração do Entity
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Classes de Mapeamento
            modelBuilder.Configurations.Add(new EstoqueMapping());
            modelBuilder.Configurations.Add(new ProdutoMapping());
        }

        public DbSet<Estoque> EstoqueDB { get; set; }
        public DbSet<Produto> ProdutoDB { get; set; }

    }
}
