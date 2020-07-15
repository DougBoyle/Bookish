using System;

namespace Bookish.DataAccess
{
    public class Checkout
    {
        public int TxId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime TakenOut { get; set; }
        public DateTime DueDate { get; set; }
        
        public string Name { get; set; }
        
        public string Title { get; set; }

        public override string ToString()
        {
            return $"'{Title}' held by {Name} from {TakenOut.ToString("d")}, due {DueDate.ToString("d")}";
        }
    }
}