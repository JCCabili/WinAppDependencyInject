using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreWinApp.Data.Interface
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        void Remove(T entity);
        void Update(T Entity);
        T GetbyId(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Func<T,bool> predicate);
        int Count(Func<T, bool> predicate);
    }
}
