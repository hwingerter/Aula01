using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Dominio.DomainEntities
{
    public class Estoque
    {
        public virtual int IdEstoque { get; set; }
        public virtual string Nome { get; set; }

        #region Relacionamentos

            public virtual ICollection<Produto> Produtos { get; set; }
        #endregion
    }

}
