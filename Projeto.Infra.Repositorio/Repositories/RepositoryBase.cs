using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.Dominio.Contracts.Repositories;
using Projeto.Infra.Repositorio.Context;

namespace Projeto.Infra.Repositorio.Repositories
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity>
        where TEntity : class
    {
        protected readonly DataContext Context;
        private DbContextTransaction transaction;

        public RepositoryBase()
        {
            Context = new DataContext();
        }


        public void Insert(TEntity obj)
        {
            Context.Entry(obj).State = EntityState.Added;
            Context.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Context.Entry(obj).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void Delete(TEntity obj)
        {
            Context.Entry(obj).State = EntityState.Deleted;
            Context.SaveChanges();
        }

        public List<TEntity> FindAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public TEntity FindById(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public void BeginTransaction()
        {
            transaction = Context.Database.BeginTransaction();
        }

        public void Commit()
        {
            if (transaction != null)
                transaction.Commit();
        }

        public void Rollback()
        {
            if (transaction != null)
                transaction.Rollback();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

    }
}
