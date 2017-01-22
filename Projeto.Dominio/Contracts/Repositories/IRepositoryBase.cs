using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Dominio.DomainEntities;

namespace Projeto.Dominio.Contracts.Repositories
{
    public  interface IRepositoryBase<TEntity>
        where TEntity : class
    {

        #region Manutenção de Dados

        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        List<TEntity> FindAll();
        TEntity FindById(int id);

        #endregion

        #region Controle de Transação

        void BeginTransaction();
        void Commit();
        void Rollback();
        void Dispose();

        #endregion

    }
}
