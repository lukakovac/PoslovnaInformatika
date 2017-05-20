using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoslovnaInformatika.Data
{
    public class Repository<T, K> where T : BaseEntity<K>
    {
        private readonly ApplicationContext _context;
        private DbSet<T> _entities;

        public Repository(ApplicationContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public IEnumerable<T> FindAll(Func<T, bool> predicate)
        {
            return _entities.Where(predicate);
        }

        public T FindById(Func<T, bool> predicate)
        {
            return _entities.SingleOrDefault(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public T GetById(K id)
        {
            return _entities.SingleOrDefault(m => m.Id.Equals(id));
        }

        public void Insert(T entity)
        {
            IsEntityNull(entity);

            _entities.Add(entity);
            Save();
        }

        public void Update(T entity)
        {
            IsEntityNull(entity);

            _entities.Update(entity);
            Save();
        }

        public void Delete(T entity)
        {
            IsEntityNull(entity);

            _entities.Remove(entity);
            Save();
        }

        public void Delete(K id)
        {
            T entity = _entities.FirstOrDefault(m => m.Id.Equals(id));

            IsEntityNull(entity);

            _entities.Remove(entity);
            Save();
        }

        public void DeleteAll()
        {
            IEnumerable<T> entities = _entities.ToList();
            _entities.RemoveRange(entities);
            Save();
        }

        private bool IsEntityNull(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(entity.GetType().ToString());
            }

            return false;
        }

        private void Save()
        {
            _context.SaveChanges();
        }
    }
}
