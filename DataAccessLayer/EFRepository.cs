using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    /// <summary>
    /// Реализация репозитория с использованием Entity Framework Core.
    /// </summary>
    /// <typeparam name="T">Тип сущности, наследующийся от Student и реализующий IDomainObject.</typeparam>
    public class EFRepository<T> : IRepository<T> where T : Car, IDomainObject, new()
    {
        private readonly DbContext _context;

        public EFRepository(DbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
            }
        }
        public IEnumerable<T> ReadAll()
        {
            return _context.Set<T>().ToList();
        }
        public T ReadById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
