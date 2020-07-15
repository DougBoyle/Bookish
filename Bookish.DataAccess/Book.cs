namespace Bookish.DataAccess {
    public class Book {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string ISBN { get; set; }
        public int copies { get; set; }

        public override string ToString()
        {
            return $"{BookId}, {Title}, {AuthorId}, {ISBN}, {copies}";
        }
    }
}