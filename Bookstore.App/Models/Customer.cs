using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookstore.App.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}