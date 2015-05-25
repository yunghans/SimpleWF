using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryApp.BookService;

namespace LibraryApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string myAction, string bookId)
        {
            LibraryService.ServiceClient lClient = new LibraryService.ServiceClient();
            string actionStatus = "";

            try
            {
                switch (myAction)
                {
                    case "Borrow":

                        actionStatus = lClient.Borrow(ref bookId);

                        break;

                    case "Return":

                        actionStatus = lClient.Return(ref bookId);

                        break;

                    case "Renew":

                        bool renewResult = false;

                        actionStatus = lClient.Renew(ref bookId, out renewResult);

                        break;
                }
            }
            catch (Exception ex)
            {
                actionStatus = ex.Message;
            }

            ViewBag.actionStatus = actionStatus;

            BookServiceClient bClient = new BookServiceClient();
            IEnumerable<Book> books = bClient.GetAllBooks();
            ViewBag.books = books;

            return View();
        }

    }
}