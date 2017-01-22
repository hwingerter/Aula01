using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Dominio.DomainEntities;
using Projeto.Dominio.Contracts.Repositories;

namespace Projeto.Dominio.DomainServices
{
    public class DomainServiceEstoque
        : DomainServiceBase<Estoque>
    {
        private readonly IRepositoryEstoque repositorio;

        public DomainServiceEstoque(IRepositoryEstoque repositorio)
            : base (repositorio)
        {
            this.repositorio = repositorio;
        }

    }
}
