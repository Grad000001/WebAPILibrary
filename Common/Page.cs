namespace WebAPILibrary.Common
{
    public class Page
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;        
        public Page(int id, string text)
        {
            Id = id;
            Text = text;
        }

    }
}
