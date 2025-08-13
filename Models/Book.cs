namespace BookstoreApi.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public int PublishedYear { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; } = null!;
    }
}
