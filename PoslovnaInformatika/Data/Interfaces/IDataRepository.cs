using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoslovnaInformatika.Data.Interfaces
{
    public interface IDataRepository<TEntity> : IDisposable
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity data);
        void Update(TEntity data);
        void Delete(int id);
        void Save();
    }
}
