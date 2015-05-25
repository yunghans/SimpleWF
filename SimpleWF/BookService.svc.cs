using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SimpleWF.Models;

namespace SimpleWF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BookService.svc or BookService.svc.cs at the Solution Explorer and start debugging.
    public class BookService : IBookService
    {
        public Book GetBook(string bookId)
        {
            //* Uncomment this line if you change your model and run it once.
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<LibraryDbContext>()); 
            //*

            LibraryDbContext db = new LibraryDbContext();

            Book foundBook = db.Books.SingleOrDefault(b => b.BookId == bookId);

            return foundBook;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            LibraryDbContext db = new LibraryDbContext();

            return db.Books;
        }
    }

}
