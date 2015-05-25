using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Data.Entity.Migrations;
using SimpleWF.Models;

namespace SimpleWF
{

    public sealed class SetBookStatus : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> BookId { get; set; }
        public InArgument<BookStatus> Status { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {

            string bookId = context.GetValue(this.BookId);
            BookStatus status = context.GetValue(this.Status);

            LibraryDbContext db = new LibraryDbContext();
            Book book = db.Books.SingleOrDefault(b => b.BookId == bookId);

            if (book == null)
            {
                book = new Book();
                book.BookId = bookId;
                book.Status = status;

                db.Books.Add(book);
            }
            else
            {
                book.Status = status;
                db.Books.AddOrUpdate(book);
            }

            db.SaveChanges();

        }
    }
}
