namespace CryptoBank.Models
{
    public class NewsModel
    {
        public string Title { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        public string Author { get; set; } = string.Empty;

        public string Text { get; set; } = string.Empty;
    }
}
