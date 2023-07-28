using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class ContactOtherController : Controller
    {
        private readonly IContactService contactService;

        public ContactOtherController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.SendDateMessage = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            contactService.TInsert(contact);
            return RedirectToAction("Index", "ContactOther");
        }
    }
}
