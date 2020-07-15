using System;

namespace Bookish.ConsoleApp {
    public class Program {
        public static void Main(string[] args) {
         /*   foreach (var book in DataAccess.DbQuery.GetData("book"))
            {
                Console.WriteLine(book);
            }*/
            foreach (var book in DataAccess.DbQuery.GetHolders(3))
            {
                Console.WriteLine(book);
            }
        }
    }
}