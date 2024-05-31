using Bookstore.App.Entity;
using Bookstore.App.Misc;
using Bookstore.App.Models;
using Bookstore.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookstore.App.Controllers
{
    public class CustomerController : Controller
    {
        private BookstoreDbContext _context = new BookstoreDbContext();

        // GET: Customer
        [HttpGet]
        public ActionResult Index()
        {
            List<Customer> list = new List<Customer>();   
            list = _context.Customers.Where(c => c.IsActive).ToList();

            return View(list);
        }

        [HttpGet]
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
            
            
            customer.IsActive = true;
            customer.CreationDate = DateTime.Now;
            customer.CreatedBy = User.Identity.Name;
            customer.LastName = customer.LastName;
            customer.ModificationDate = DateTime.Now;   

            _context.Customers.Add(customer);    
            _context.SaveChanges();
            
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {

            Customer customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            CustomerFormViewModel viewModel = new CustomerFormViewModel()
            {
                PageTitle = "Edit the customer "+customer.FirstName + " "+customer.LastName,
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                DateOfBirth = customer.DateOfBirth,
                IsActive = customer.IsActive
            };

            viewModel.SelectStatus = new List<BooleanDropDownListOption>()
            {
                new BooleanDropDownListOption(true, "Active Customer"),
                new BooleanDropDownListOption(true, "Really Active Customer"),                
                new BooleanDropDownListOption(false, "Inactive Customer")
            };



            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(CustomerFormViewModel viewModel)
        {
            Customer customer = _context.Customers.FirstOrDefault(c => c.Id == viewModel.Id);

            customer.FirstName = viewModel.FirstName;
            customer.LastName = viewModel.LastName;
            customer.Email = viewModel.Email;
            customer.DateOfBirth = viewModel.DateOfBirth;
            customer.IsActive = viewModel.IsActive;

            _context.Customers.Attach(customer);
            _context.Entry(customer).State = EntityState.Modified;

            _context.SaveChanges();

            return RedirectToAction("Details", new { id = customer.Id });
        }
    }
}