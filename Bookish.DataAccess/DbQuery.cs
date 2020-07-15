using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace Bookish.DataAccess {
    public class DbQuery {
        public static void getData() {
            var str = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            IDbConnection db = new SqlConnection(
                ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            Console.WriteLine("Setup");
            string SqlString = "SELECT * FROM Books";
            var books = (List<Book>)db.Query<Book>(SqlString);
            Console.WriteLine("Didnt fail");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}