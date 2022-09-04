using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_Modelo.DomainModel
{
   public abstract class EntityBase
    {
        public int Id { get; set; }
    }

    public interface IRepositoryBase<T> where T : EntityBase
    {
        void Salvar(T entity);
        void Excluir(T entity);
        T ObterPor(int id);
        List<T> ObterTodos();
    }
}
