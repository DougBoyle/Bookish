using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace Bookish.DataAccess {
    public class DbQuery {
        public static List<Book> GetData() {
            IDbConnection db = new SqlConnection(
                ConfigurationManager.ConnectionStrings["BookConnection"].ConnectionString);
            string SqlString = "SELECT Title, Name, ISBN, Copies, BookId FROM Books JOIN Authors on Books.AuthorId = Authors.AuthorId";
            return (List<Book>)db.Query<Book>(SqlString);
        }
        
        public static List<Book> GetData(string searchFor) {
            var db = new SqlConnection(
                ConfigurationManager.ConnectionStrings["BookConnection"].ConnectionString);

            var parameters = new { desc = "%" + searchFor + "%" };
            var sql = "SELECT Title, Name, ISBN, Copies, BookId FROM Books JOIN Authors on Books.AuthorId = Authors.AuthorId " + 
                      "WHERE Title LIKE @desc OR Name LIKE @desc";

            return (List<Book>)db.Query<Book>(sql, parameters);
        }

        public static List<Checkout> GetHolders(int bookId)
        {
            var db = new SqlConnection(
                ConfigurationManager.ConnectionStrings["BookConnection"].ConnectionString);

            var parameters = new { id = bookId };
            var sql = "SELECT TxId, CheckedOut.UserId, Books.BookId, TakenOut, DueDate, Name, Title FROM CheckedOut JOIN Users on Users.UserId = CheckedOut.UserId JOIN Books on Books.BookId = CheckedOut.BookId WHERE Books.BookId = @id";
            return (List<Checkout>)db.Query<Checkout>(sql, parameters);
        }
    }
}