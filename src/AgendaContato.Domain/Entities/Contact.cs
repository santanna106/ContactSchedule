using AgendaContato.Core.DomainObjects;

namespace AgendaContato.Domain.Entities
{
    public class Contact: Entity
    {
        public string Name { get; set; }
        public string Doc { get; set; }
        public string Phone { get; set; }
        public string Logradouro { get; set; }
        public string Address { get; set; }
    }
}
