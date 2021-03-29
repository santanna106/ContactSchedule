using AgendaContato.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NerdStore.Core.Data
{
    public interface IRepository <T> : IDisposable where T : Entity
    {
        Task Add(T entity);
        Task<T> FindById(Guid id);
        Task<List<T>> getAll();
        Task Update(T entity);
        Task Delete(int id);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
        Task<int> SaveChanges();
    }
}