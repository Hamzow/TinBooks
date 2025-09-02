namespace TinBooks.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public object Book { get; }
    }
}