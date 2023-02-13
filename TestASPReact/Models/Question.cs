namespace TestASPReact.Models
{
    public class Question
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public Variant[] Variants { get; set; }
    }
}
