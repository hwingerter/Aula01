using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Dominio.DomainEntities;
using Projeto.Dominio.Contracts.Repositories;

namespace Projeto.Infra.Repositorio.Repositories
{
    public class RepositoryProduto
        : RepositoryBase<Produto>, IRepositoryProduto
    {
    }
}
