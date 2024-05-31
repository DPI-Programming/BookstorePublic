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
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [RegularExpression(@"^[\s]*[a-z|A-Z|0-9|\.|_|-]+[@]{1}[a-z|A-Z|0-9|\.|_|-]+[\.]{1}[a-zA-z]{1,5}[\s]*$", 
            ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Date of Birth")]
        [Required]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Status")]
        public bool IsActive { get; set; }

        public IEnumerable<BooleanDropDownListOption> SelectStatus { get; set; }
    }
}