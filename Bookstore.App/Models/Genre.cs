using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookstore.App.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}