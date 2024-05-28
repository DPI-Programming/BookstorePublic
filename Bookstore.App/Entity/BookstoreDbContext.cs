using Bookstore.App.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace Bookstore.App.Entity
{
    public class BookstoreDbContext : DbContext
    {
        // Your context has been configured to use a 'BookstoreDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Bookstore.App.Entity.BookstoreDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BookstoreDbContext' 
        // connection string in the application configuration file.
        public BookstoreDbContext()
            : base("name=BookstoreDbContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.


        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}