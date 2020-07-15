using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace Bookish.DataAccess {
    public class DbQuery {
        public static List<Book> getData() {
            IDbConnection db = new SqlConnection(
                ConfigurationManager.ConnectionStrings["BookConnection"].ConnectionString);
            string SqlString = "SELECT Title, Name, ISBN, Copies FROM Books JOIN Authors on Books.AuthorId = Authors.AuthorId";
            return (List<Book>)db.Query<Book>(SqlString);
        }
        
        public static List<Book> getData(string searchFor) {
            var db = new SqlConnection(
                ConfigurationManager.ConnectionStrings["BookConnection"].ConnectionString);

            var parameters = new { desc = "%" + searchFor + "%" };
            var sql = "SELECT Title, Name, ISBN, Copies FROM Books JOIN Authors on Books.AuthorId = Authors.AuthorId " + 
                      "WHERE Title LIKE @desc OR Name LIKE @desc";

            return (List<Book>)db.Query<Book>(sql, parameters);
        }
    }
}