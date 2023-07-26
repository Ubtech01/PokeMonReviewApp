namespace PokeMonReviewApp.Models
{
    public class review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Reviewer Reviewer { get; set; }
        public PokeMon PokeMon { get; set; } 
      
    }
}
