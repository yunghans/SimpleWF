using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleWF.Models
{
    public class LibraryDbContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}