namespace PokeMonReviewApp.Models
{
    public class PokeMonCategory
    {
        public int PokeMonId { get; set; }
        public int CategoryId { get; set; }
        public PokeMon PokeMon { get; set; }    
        public Category Category { get; set; }
    }
}
