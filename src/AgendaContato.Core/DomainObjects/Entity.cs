using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContato.Core.DomainObjects
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
    }
}
