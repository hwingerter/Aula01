using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Dominio.DomainEntities;

namespace Projeto.Dominio.Contracts.Repositories
{
    public  interface IRepositoryProduto
        : IRepositoryBase<Produto>
    {
    }
}
