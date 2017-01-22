using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Dominio.DomainEntities;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Infra.Repositorio.Mappings
{
    public  class EstoqueMapping : EntityTypeConfiguration<Estoque>
    {
        public EstoqueMapping()
        {
            HasKey(e => e.IdEstoque);

            Property(e => e.Nome)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
