namespace Bookish.DataAccess {
    public class Book {
        public string Title { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public int copies { get; set; }

        public override string ToString()
        {
            return $"'{Title}' by {Name}, ISBN: {ISBN}, Copies: {copies}";
        }
    }
}