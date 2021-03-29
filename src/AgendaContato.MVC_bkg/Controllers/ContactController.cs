using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaContato.MVC.ViewsModel;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgendaContato.MVC.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMapper _mapper;
        public ContactController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            List<ContactViewModel> list = new List<ContactViewModel>();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
       
    }
}
