using Bookstore.App.Entity;
using Bookstore.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookstore.App.Controllers
{
    public class CustomerController : Controller
    {
        private BookstoreDbContext _context = new BookstoreDbContext();

        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> list = new List<Customer>();   
            list = _context.Customers.Where(c => c.IsActive).ToList();

            return View(list);
        }

        public ActionResult Details(int id)
        {
            Customer customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            
            return View(customer);
        }

        [HttpGet]
        public ActionResult Create() 
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            
            
            customer.CreationDate = DateTime.Now;
            customer.CreatedBy = User.Identity.Name;
            customer.LastName = customer.LastName;
            customer.ModificationDate = DateTime.Now;   

            _context.Customers.Add(customer);    
            _context.SaveChanges();
            
            
            return View();
        }
    }
}