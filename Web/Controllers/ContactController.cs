using System.Net;
using System.ComponentModel.DataAnnotations;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    
    public class ContactController : Controller
    {
        private readonly IUnitOfWork<Contact> _repo;

        public ContactController(IUnitOfWork<Contact> repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(string name, string email, string phone, string message)
        {
            var contact = new Contact
            {
                Name    = name,
                Email   = email,
                Phone   = phone,
                Message = message
            };
            
            if(string.IsNullOrEmpty(contact.Name) || string.IsNullOrEmpty(contact.Email) ||
               string.IsNullOrEmpty(contact.Phone) || string.IsNullOrEmpty(contact.Message))
            {
               return RedirectToAction("Index","Home");
            }
            else
            {
               _repo.Entity.Insert(contact);
               _repo.Save();
               return RedirectToAction("Index","Home");         
            }            
        }
    }
}