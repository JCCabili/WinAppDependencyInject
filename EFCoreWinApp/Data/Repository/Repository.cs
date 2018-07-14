using EFCoreWinApp.Custom;
using EFCoreWinApp.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace EFCoreWinApp.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected EmployeeContext _context;

        public Repository()
        {
            _context = Global.Container.Resolve<EmployeeContext>();
        }

        private void Save() => _context.SaveChanges();

        public int Count(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate).Count();
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity); ;
            Save();
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetbyId(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            Save();
        }

        public void Update(T Entity)
        {
            _context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
            Save();
        }
    }
}
