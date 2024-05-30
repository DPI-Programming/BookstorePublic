using Bookstore.App.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookstore.App.ViewModels
{
    public class CustomerFormViewModel
    {
        public string PageTitle { get; set; }

        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Status")]
        public bool IsActive { get; set; }

        public IEnumerable<BooleanDropDownListOption> SelectStatus { get; set; }
    }
}