using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoslovnaInformatika.Data
{
    public interface IRepository<TEntity, in TKey> where TEntity : BaseEntity<TKey>, new()
    {
        IEnumerable<TEntity> FindAll(Func<TEntity, bool> pred);
        TEntity FindById(Func<TEntity, bool> pred);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(TKey id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(TKey id);
        void DeleteAll();
    }
}
