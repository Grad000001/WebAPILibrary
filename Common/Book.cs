namespace WebAPILibrary.Common
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name {  get; set; } = string.Empty;
        public List<Page> Pages { get; set; } = new List<Page>();
        public int CountPage { get; set; }

        public Book(Guid id, string name, List<Page> pages)
        {
            Id = id;
            Name = name;
            Pages = pages;
            CountPage = pages.Count;            
        }
    }
}
