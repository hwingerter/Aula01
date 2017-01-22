using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Dominio.DomainEntities
{
    public class Produto
    {
        public virtual int IdProduto { get; set; }
        public virtual string Nome { get; set; }
        public virtual decimal Preco { get; set; }
        public virtual int Quantidade { get; set; }
        public virtual DateTime DataCompra { get; set; }
        public virtual int IdEstoque { get; set; }

        #region Relacionamento

        public virtual Estoque Estoque { get; set; }

        #endregion

    }
}
