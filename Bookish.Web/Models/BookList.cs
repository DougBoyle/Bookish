using System.Collections.Generic;
using Bookish.DataAccess;

namespace Bookish.Web.Models
{
    public class BookList
    {
        public List<Book> books { get; set; }
        public string searchFor { get; set; }
    }
}