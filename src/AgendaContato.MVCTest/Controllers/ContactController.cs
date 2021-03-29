using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaContato.MVCTest.ViewsModel;
using Microsoft.AspNetCore.Mvc;

namespace AgendaContato.MVCTest.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            List<ContactViewModel> list = new List<ContactViewModel>();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactViewModel contact)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(contact);
        }


    }
}
