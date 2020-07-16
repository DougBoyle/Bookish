namespace Bookish.DataAccess {
    public class Book {
        public string Title { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public int Copies { get; set; }
        
        public int BookId { get; set; }

        public override string ToString()
        {
            return $"'{Title}' by {Name}, ISBN: {ISBN}, Copies: {Copies}";
        }
    }
}