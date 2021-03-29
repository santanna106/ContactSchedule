using AgendaContato.Domain.Entities;
using AgendaContato.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AgendaContato.Data.Repository
{
    public class ContactRepository : IContactRepository
    {
        public Task Add(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contact>> Find(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Contact>> getAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task Update(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}
