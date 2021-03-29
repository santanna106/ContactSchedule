using AgendaContato.Domain.Entities;
using NerdStore.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContato.Domain.Interfaces
{
    public interface IContactRepository :  IRepository<Contact>{}
}
