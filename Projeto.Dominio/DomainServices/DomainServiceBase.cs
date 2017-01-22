using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Dominio.Contracts.Repositories;

namespace Projeto.Dominio.DomainServices
{
    public abstract class DomainServiceBase<TEntity>
        where TEntity : class
    {

        private readonly IRepositoryBase<TEntity> repositorio;

        public DomainServiceBase(IRepositoryBase<TEntity> repositorio)
        {
            this.repositorio = repositorio;
        }

        public virtual void Cadastrar (TEntity obj)
        {
            try
            {
                repositorio.BeginTransaction();
                repositorio.Insert(obj);
                repositorio.Commit();
            }
            catch
            {
                repositorio.Rollback();
                throw new Exception();
            }
        }
        public virtual void Atualizar(TEntity obj)
        {
            try
            {
                repositorio.BeginTransaction();
                repositorio.Update(obj);
                repositorio.Commit();
            }
            catch   
            {
                repositorio.Rollback();
                throw new Exception();
            }
        }

        public virtual void Excluir(TEntity obj)
        {
            try
            {
                repositorio.BeginTransaction();
                repositorio.Delete(obj);
                repositorio.Commit();
            }
            catch
            {
                repositorio.Rollback();
                throw new Exception();
            }
        }
        public virtual List<TEntity> Obtertodos()
        {
            return repositorio.FindAll();
        }
        public virtual TEntity ObterPorId (int id)
        {
            return repositorio.FindById(id);
        }
    }
}
