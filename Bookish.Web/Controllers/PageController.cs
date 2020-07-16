using System;
using System.Runtime.ConstrainedExecution;
using System.Web.Mvc;
using Bookish.DataAccess;
using Bookish.Web.Models;

namespace Bookish.Web.Controllers
{
    public class PageController : Controller
    {
        public ActionResult Browse(string searchFor)
        {
            var data = Bookish.DataAccess.DbQuery.GetData(searchFor);
            return View("~/Views/Pages/Browse.cshtml", new BookList() {books = data, searchFor = ""});
        }

        public ActionResult SingleBook(Book book)
        {
            Console.WriteLine(book);
            var data = Bookish.DataAccess.DbQuery.GetHolders(book.BookId);
            return View("~/Views/Pages/SingleBook.cshtml", new BookStatus() {Book = book, Checkouts = data});
        }
    }
}