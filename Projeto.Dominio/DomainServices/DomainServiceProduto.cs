﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Dominio.DomainEntities;
using Projeto.Dominio.Contracts.Repositories;

namespace Projeto.Dominio.DomainServices
{
    public class DomainServiceProduto
        : DomainServiceBase<Produto>
    {

        private readonly IRepositoryProduto repositorio;

        public DomainServiceProduto(IRepositoryProduto repositorio)
            : base (repositorio)
        {
            this.repositorio = repositorio;
        }

    }
}
