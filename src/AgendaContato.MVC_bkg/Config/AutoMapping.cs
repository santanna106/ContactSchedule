using AgendaContato.Domain.Entities;
using AgendaContato.MVC.ViewsModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaContato.MVC.Config
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Contact, ContactViewModel>(); // means you want to map from User to UserDTO
        }
    }
}
