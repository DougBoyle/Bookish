using System.Web.Mvc;
using Bookish.Web.Models;

namespace Bookish.Web.Controllers
{
    public class PageController : Controller
    {
        public ActionResult Browse(string searchFor)
        {
            var data = Bookish.DataAccess.DbQuery.getData(searchFor);
            return View("~/Views/Pages/Browse.cshtml", new BookList() {books = data, searchFor = ""});
        }
    }
}