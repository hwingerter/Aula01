using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Dominio.DomainEntities;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Infra.Repositorio.Mappings
{
    public class ProdutoMapping : EntityTypeConfiguration<Produto>
    {
        public ProdutoMapping()
        {
            HasKey(p => p.IdProduto);

            Property(p => p.Nome)
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Preco)
                .HasPrecision(18, 2)
                .IsRequired();

            Property(p => p.Quantidade)
                .IsRequired();

            Property(p => p.DataCompra)
                .IsRequired();

            #region Relacionamentos

            HasRequired(p => p.Estoque)
                .WithMany(e => e.Produtos)
                .HasForeignKey(p => p.IdEstoque);

            #endregion


        }        
    }
}
