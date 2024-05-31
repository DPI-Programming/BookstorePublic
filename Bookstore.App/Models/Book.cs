using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookstore.App.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Author { get; set; }

        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string LastUpdatedBy { get; set;}
        public DateTime ModificationDate { get; set; }
    }
}