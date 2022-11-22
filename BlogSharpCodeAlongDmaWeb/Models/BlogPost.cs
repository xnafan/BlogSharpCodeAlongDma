namespace BlogSharpCodeAlongDmaWeb.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        public string Title { get; set; } = "untitled";
        public string Content { get; set; } = "no content";
        public DateTime CreationDate { get; set; }
        public int AuthorId { get; set; }
    }
}
