using System;

namespace Bookish.ConsoleApp {
    public class Program {
        public static void Main(string[] args) {
            foreach (var book in DataAccess.DbQuery.getData("book"))
            {
                Console.WriteLine(book);
            }
        }
    }
}