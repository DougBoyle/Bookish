using System.Collections.Generic;
using Bookish.DataAccess;

namespace Bookish.Web.Models
{
    public class BookStatus
    {
        public Book Book { get; set; }
        public List<Checkout> Checkouts { get; set; }
    }
}